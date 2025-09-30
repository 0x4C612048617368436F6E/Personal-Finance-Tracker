using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    internal class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        [Required]
        private string firstName;
        [Required]
        private string lastName;
        [Required]
        private string userName;
        [Required]
        [EmailAddress]
        private string email;
        [Required]
        private string hashedPassword;
        [Required]
        private DateTime createdAt;
        [Required]
        private DateTime updatedAt;

        internal UserModel() { 
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }

        internal int Id
        {
            get
            {
                return id;
            }
        }

        internal String FirstName
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

        internal String LastName
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

        internal String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        internal String Email
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

        internal String HashedPassword
        {
            get
            {
                return hashedPassword;
            }
            set
            {
                hashedPassword = value;
            }
        }


    }
}
