
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Bank_Quiz2.Entities
{
    public class Card
    {
        [Key]
        public string CardNumber { get; set; }
        public string HolderName { get; set; }
        public float Balance { get; set; }
        public bool IsActive { get; set; } = true;
        public string Password { get; set; }
        public List<Transaction> SourceTransactions { get; set; }
        public List<Transaction> DestinationTransactions { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
    }
}
