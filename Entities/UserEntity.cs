using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet.Docker.Entities
{
    public class UserEntity
    {
        [Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public IEnumerable<RoleEntity> Roles { get; set; }

    }
}
