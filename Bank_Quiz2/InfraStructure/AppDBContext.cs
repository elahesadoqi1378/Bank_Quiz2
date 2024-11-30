

using Bank_Quiz2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank_Quiz2.InfraStructure
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source =ELAMIR\\SQLEXPRESS; Database = Bank_Quiz2; Integrated Security=True; User ID = sa; Password =123456 ; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
             .HasOne(t => t.SourceCard)
             .WithMany(c => c.SourceTransactions)
             .HasForeignKey(t => t.SourceCardNumber).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Transaction>()
             .HasOne(t => t.DestinationCard)
             .WithMany(c => c.DestinationTransactions)
             .HasForeignKey(t => t.DestinationCardNumber).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Transaction>()
                .HasKey(t => t.TransactionId);

            modelBuilder.Entity<Card>()
               .HasKey(c => c.CardNumber);



        }

    }
}
