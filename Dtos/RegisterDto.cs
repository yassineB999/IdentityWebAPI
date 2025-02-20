using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public record RegisterDto(


        [Required]
         string UserName,

        [Required]
        [EmailAddress]
         string Email,

        [Required]
         string Password,

        [Required]
        string PhoneNumber
    );
}
