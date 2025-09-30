using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    public class AdminRoleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        [Required]
        private int adminId;
        [Required] 
        private int roleId;

        internal int Id
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

        internal int AdminId
        {
            get
            {
                return adminId;
            }
            set
            {
                adminId = value;
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
