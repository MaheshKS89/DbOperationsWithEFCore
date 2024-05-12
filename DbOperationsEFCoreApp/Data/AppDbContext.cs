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

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "Hindi", Description = "Indian Hindi" },
                new Language() { Id = 2, Title = "Kannada", Description = "Indian Kannada" },
                new Language() { Id = 3, Title = "English", Description = "Indian English" },
                new Language() { Id = 4, Title = "Urdu", Description = "Indian Urdu" }
                );

    }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; } 
    }
}

