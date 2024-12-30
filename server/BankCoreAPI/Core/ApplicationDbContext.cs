using BankCoreAPI.Core.Models;
using BankCoreAPI.Core.Models.Accounts;
using BankCoreAPI.Core.Models.Cards;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BankCoreAPI.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountTransactionType> AccountTransactionTypes { get; set; }

        public DbSet<AccountTransaction> AccountTransactions { get; set; }

        public DbSet<CardType> CardTypes { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<CardTransactionType> CardTransactionTypes { get; set; }

        public DbSet<CardTransaction> CardTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasOne(user => user.Role).WithMany(role => role.Users)
                .HasForeignKey(user => user.RoleId);

            modelBuilder.Entity<Account>().HasOne(account => account.User).WithMany(user => user.Accounts)
                .HasForeignKey(account => account.UserId);

            modelBuilder.Entity<Account>().HasOne(account => account.AccountType)
                .WithMany(accountType => accountType.Accounts)
                .HasForeignKey(account => account.AccountTypeId);

            modelBuilder.Entity<Account>().HasOne(account => account.Currency)
                .WithMany(currency => currency.Accounts)
                .HasForeignKey(account => account.CurrencyId);

            modelBuilder.Entity<Card>().HasOne(card => card.User).WithMany(user => user.Cards)
                .HasForeignKey(card => card.UserId);

            modelBuilder.Entity<Card>().HasOne(card => card.CardType)
                .WithMany(cardType => cardType.Cards)
                .HasForeignKey(card => card.CardTypeId);

            modelBuilder.Entity<Card>().HasOne(card => card.Currency)
                .WithMany(currency => currency.Cards)
                .HasForeignKey(card => card.CurrencyId);

            modelBuilder.Entity<AccountTransaction>().HasOne(accountTransaction => accountTransaction.AccountFrom)
                .WithMany(accountFrom => accountFrom.AccountFromTransactions)
                .HasForeignKey(accountTransaction => accountTransaction.AccountFromId);

            modelBuilder.Entity<AccountTransaction>().HasOne(accountTransaction => accountTransaction.AccountTo)
                .WithMany(accountTo => accountTo.AccountToTransactions)
                .HasForeignKey(accountTransaction => accountTransaction.AccountToId);

            modelBuilder.Entity<AccountTransaction>().HasOne(accountTransaction => accountTransaction.AccountTransactionType)
                .WithMany(accountTransactionType => accountTransactionType.AccountTransactions)
                .HasForeignKey(accountTransaction => accountTransaction.AccountTransactionTypeId);

            modelBuilder.Entity<CardTransaction>().HasOne(cardTransaction => cardTransaction.CardTransactionType)
                .WithMany(cardTransactionType => cardTransactionType.CardTransactions)
                .HasForeignKey(cardTransaction => cardTransaction.CardTransactionTypeId);

            modelBuilder.Entity<CardTransaction>().HasOne(cardTransaction => cardTransaction.CardFrom)
                .WithMany(cardFrom => cardFrom.CardFromTransactions)
                .HasForeignKey(cardTransaction => cardTransaction.CardFromId);

            modelBuilder.Entity<CardTransaction>().HasOne(cardTransaction => cardTransaction.CardTo)
                .WithMany(cardTo => cardTo.CardToTransactions)
                .HasForeignKey(cardTransaction => cardTransaction.CardToId);
        }


    }
}
