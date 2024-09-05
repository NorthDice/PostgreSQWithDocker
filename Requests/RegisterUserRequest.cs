using System.ComponentModel.DataAnnotations;

namespace DotNet.Docker.Requests
{
    public record RegisterUserRequest(
       [Required] string UserName,
       [Required] string Password,
       [Required] string Email);
}
