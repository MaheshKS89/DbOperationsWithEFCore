using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id=1, Title="INR", Description="Indian Rupees"},
                new Currency() { Id=2, Title="Dollar", Description="US Dollar"},
                new Currency() { Id=3, Title="Euro", Description="European Euro"},
                new Currency() { Id=4, Title="Dinar", Description="UAE Dinar"}
                );


        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; } 
    }
}

