using DotNet.Docker.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet.Docker.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) 
            : base(options) 
        {
            Database.EnsureCreated();  
        }

        DbSet<UserEntity> Users { get; set; }
        DbSet<RoleEntity> Roles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
