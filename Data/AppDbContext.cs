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
        public DbSet<mvcCategory> MvcCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //QUERY
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mvcCategory>().HasData(
                new mvcCategory() { Id = 1, Name = "Select Category" },
                new mvcCategory() { Id = 2, Name = "Computers" },
                new mvcCategory() { Id = 3, Name = "Mobiles" },
                new mvcCategory() { Id = 4, Name = "Electric machines" }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
