using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalfinancetrackerbackend.Model
{
    public class RoleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Required]
        [DefaultValue("user")]
        public string roleType;

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

        public string RoleType
        {
            get
            {
                return roleType;
            }
            set
            {
                roleType = value;
            }
        }
    }
}
