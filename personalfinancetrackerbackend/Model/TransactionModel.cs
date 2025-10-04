using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    [Table("transaction")]
    public class TransactionModel
    {
        [Required]
        [Column("transaction_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;

        [Column("account_id")]
        [Required]
        private int accountId;

        [Column("amount")]
        [Required]
        private float amount;

        [Column("transaction_date")]
        [Required]
        private DateTime transactionDate;

        [Column("transaction_description")]
        [Required]
        private string transactionDescription="";

        [ForeignKey("account_id")]
        public AccountModel userAccount;

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

        public int AccountId
        {
            get
            {
                return accountId;
            }
            set
            {
                accountId = value;
            }
        }

        public float Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return transactionDate;
            }
            set
            {
                transactionDate = value;
            }
        }

        public string TransactionDescription
        {
            get
            {
                return transactionDescription;
            }
            set
            {
                transactionDescription = value;
            }
        }

        public AccountModel UserAccount
        {
            get
            {
                return userAccount;
            }
            set
            {
                userAccount = value;
            }
        }

    }
}
