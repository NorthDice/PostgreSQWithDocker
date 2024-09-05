using System.Security.Permissions;

namespace DotNet.Docker.Entities
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<UserEntity> Users { get; set; }

        public IEnumerable<PermissionEntity> Permissions { get; set; }

    }
}
