using Microsoft.EntityFrameworkCore;
using RentHub.Shared;
using RentHub.Shared.Expenses;

namespace RentHub.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IConfiguration _config;

        public ApplicationDBContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_config["DatabasePath"]};");
        }

        public DbSet<Roommate> Roommates { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}
