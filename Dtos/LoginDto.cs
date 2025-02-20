using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public record LoginDto
        (
    
        [Required]
        string Username,
        [Required]
        string Password
         );
}
