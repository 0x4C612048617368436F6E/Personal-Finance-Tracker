using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace personalfinancetrackerbackend.Model
{
    internal class TransactionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        [Required]
        private int accountId;
        [Required]
        private float amount;
        [Required]
        private DateTime transactionDate;
        [Required]
        private string transactionDescription;

        internal int Id
        {
            get
            {
                return id;
            }
        }

        internal int AccountId
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

        internal float Amount
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

        internal DateTime TransactionDate
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

        internal string TransactionDescription
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

    }
}
