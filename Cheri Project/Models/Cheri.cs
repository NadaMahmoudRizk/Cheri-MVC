using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cheri_Project.Models
{
    public class Cheri : IdentityDbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Product_Order> Product_Orders { get; set; }

        public Cheri(DbContextOptions options) : base(options)
        {

        }
        public Cheri()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Cheri;Integrated Security=True");
        }
    }
}
