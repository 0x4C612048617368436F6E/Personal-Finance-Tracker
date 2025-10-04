using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    [Table("admin_role")]
    public class AdminRoleModel
    {
        [Required]
        [Column("admin_role_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Column("admin_id")]
        [Required]
        public int adminId;

        [Column("role_id")]
        [Required] 
        public int roleId;

        [ForeignKey("admin_id")]
        public AdminModel admin;

        [ForeignKey("role_id")]
        public List<RoleModel> adminRole;

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

        public int AdminId
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
        public List<RoleModel> AdminRole
        {
            get
            {
                return adminRole;
            }
            set
            {
                adminRole = value;
            }
        }

        public AdminModel Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

    }

}
