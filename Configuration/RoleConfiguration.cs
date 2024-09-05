using DotNet.Docker.Entities;
using DotNet.Docker.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNet.Docker.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasMany(r => r.Permissions)
                .WithMany(r => r.Roles)
                .UsingEntity<PermissionRoleEntity>(
                   j => j
                   .HasOne(r => r.Permission)
                   .WithMany()
                   .HasForeignKey(rp => rp.PermissionId),
                   j => j
                   .HasOne(r => r.Role)
                   .WithMany()
                   .HasForeignKey(rp => rp.RoleId),

                   j =>
                   {
                       j.HasKey(rp => new { rp.RoleId, rp.PermissionId });
                   });

            var roles = Enum
                .GetValues<Role>()
                .Select(r => new RoleEntity
                {
                    Id = (int)r,
                    Name = r.ToString()
                });

            builder.HasData(roles);
        }
    }
}
