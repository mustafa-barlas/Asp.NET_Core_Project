using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Server=localhost;Port=5432;Database=CoreProjectDB;Integrated Security=true;Pooling=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
