using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    [Table("user_role")]
    public class UserRoleModel
    {
        [Required]
        [Column("user_role_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Column("user_id")]
        [Required]
        public int userId;

        [Column("role_id")]
        [Required]
        public int roleId;

        [ForeignKey("roleId")]
        public RoleModel userRole;

        [ForeignKey("user_id")]
        public UserModel user;


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

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        public int RoleId
        {
            get
            {
                return roleId;
            }
            set
            {
                roleId = value;
            }
        }

        public RoleModel UserRole
        {
            get
            {
                return userRole;
            }
            set
            {
                userRole = value;
            }
        }

        public UserModel User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
    }
}
