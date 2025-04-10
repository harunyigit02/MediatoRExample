using Microsoft.EntityFrameworkCore;

namespace MediatoRTestApi.Database.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
