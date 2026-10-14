using Microsoft.EntityFrameworkCore;
namespace NutriVie.Data
{
    public class NutriVieDbContext : DbContext
    {
        public NutriVieDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
