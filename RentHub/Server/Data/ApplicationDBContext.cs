using Microsoft.EntityFrameworkCore;
using RentHub.Shared;
using RentHub.Shared.Expenses;

namespace RentHub.Server.Data
{
    public class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\AppDatabases\\RentHub.db;");
        }

        public DbSet<Roommate> Roommates { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}
