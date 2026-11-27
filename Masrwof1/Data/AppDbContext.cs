using Masrwof1.Models;
using Microsoft.EntityFrameworkCore;

namespace Masrwof1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
