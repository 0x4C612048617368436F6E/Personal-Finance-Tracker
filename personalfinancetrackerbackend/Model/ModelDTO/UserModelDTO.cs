using System.ComponentModel.DataAnnotations;

namespace personalfinancetrackerbackend.Model.ModelDTO
{
    public class UserModelDTO
    {
        [Required]
        private string firstName;
        [Required]
        private string lastName;
        [Required]
        private string username;
        [Required]
        private string email;
        [Required]
        private string password;
        [Required]
        private string confirmPassword;
        
        internal string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        internal string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        internal string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        internal string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        internal string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        internal string ConfirmPassword
        {
            get
            {
                return ConfirmPassword;
            }
            set
            {
                ConfirmPassword = value;
            }
        }

    }
}
