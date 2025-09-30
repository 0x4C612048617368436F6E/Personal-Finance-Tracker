using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalfinancetrackerbackend.Model
{
    internal class BudgetModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        [Required]
        private float amount;
        [Required]
        private int userId;
        [Required]
        private int categoryId;

        internal int Id
        {
            get
            {
                return id;
            }
        }

        internal float Amount
        {
            get
            {
                return amount;
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

        internal int CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                categoryId = value;
            }
        }
    }
}
