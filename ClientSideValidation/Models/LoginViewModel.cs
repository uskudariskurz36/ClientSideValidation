using System.ComponentModel.DataAnnotations;

namespace ClientSideValidation.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(40)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        [MaxLength(16)]
        public string Password { get; set; }
    }
}
