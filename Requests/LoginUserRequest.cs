using System.ComponentModel.DataAnnotations;

namespace DotNet.Docker.Requests
{
    public record LoginUserRequest(
        [Required] string Email,
        [Required] string Password);
}
