using System.ComponentModel.DataAnnotations;

namespace personalfinancetrackerbackend.Model.ModelDTO
{
    internal class UserModelDTO
    {
        [Required]
        [MaxLength(255)]
        private string FirstName;
        [Required]
        [MaxLength(255)]
        private string LastName;
        [Required]
        [EmailAddress]
        private string Email;
        [Required]
        private string Password;
        [Required]
        private string confirmPassword;
    }
}
