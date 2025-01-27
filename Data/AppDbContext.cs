using Microsoft.EntityFrameworkCore;
using Mvc_train.Models;

namespace Mvc_train.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options):base(options)
        {

        }
        public DbSet<Item> Items { get; set; }

    }
}
