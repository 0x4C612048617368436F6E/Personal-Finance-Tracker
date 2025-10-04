using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalfinancetrackerbackend.Model
{
    [Table("budget")]
    public class BudgetModel
    {
        [Column("budget_id")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Column("amount")]
        [Required]
        public float amount;

        [Column("user_id")]
        [Required]
        public int userId;

        [Column("category_id")]
        [Required]
        public int categoryId;

        [ForeignKey("categoryId")]
        public CategoryModel category;

        [ForeignKey("userId")]
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

        public float Amount
        {
            get
            {
                return amount;
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

        public int CategoryId
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

        public CategoryModel Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
    }
}
