using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    public class UserRoleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        [Required]
        private int userId;
        [Required]
        private int roleId;

        internal int Id
        {
            get
            {
                return id;
            }
        }

        internal int UserId
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

        internal int RoleId
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
    }
}
