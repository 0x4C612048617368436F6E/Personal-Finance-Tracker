using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    [Table("account")]
    public class AccountModel
    {
        [Column("account_id")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;

        [Column("user_id")]
        [Required]
        public int userId;

        [Column("balance")]
        [Required]
        public int balance;

        [ForeignKey("user_id")]
        public UserModel user;

        public List<TransactionModel> userTransactions;

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

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
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
