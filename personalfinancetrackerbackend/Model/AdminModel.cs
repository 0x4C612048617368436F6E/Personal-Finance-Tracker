using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    [Table("admin")]
    public class AdminModel
    {
        [Required]
        [Column("admin_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Column("first_name")]
        [Required]
        public string firstName;

        [Column("last_name")]
        [Required]
        public string lastName;

        [Column("user_name")]
        [Required]
        public string userName;

        [Column("email")]
        [Required]
        public string email;

        [Column("hashed_password")]
        [Required]
        public string hashedPassword;

        [Column("created_at")]
        [Required]
        public DateTime createdAt;

        [Column("updated_at")]
        [Required]
        public DateTime updatedAt;

        public AdminModel()
        {
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public String FirstName
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

        public String LastName
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

        public String UserName
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

        public String Email
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

        public String HashedPassword
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
