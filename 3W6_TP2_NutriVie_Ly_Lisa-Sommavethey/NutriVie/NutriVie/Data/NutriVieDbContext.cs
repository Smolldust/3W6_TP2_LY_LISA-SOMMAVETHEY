using Microsoft.EntityFrameworkCore;
using NutriVie.Models;

namespace NutriVie.Data
{
    public class NutriVieDbContext : DbContext
    {
        public NutriVieDbContext(DbContextOptions<NutriVieDbContext> options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    ServiceId = 1,
                    Nom = "Recettes Saines",
                    Description = "Des recettes équilibrées et faciles à préparer pour toute la famille.",
                },
                new Service
                {
                    ServiceId = 2,
                    Nom = "Plans Nutritionnels",
                    Description = "Des plans alimentaires personnalisés par nos nutritionnistes.",
                },
                new Service
                {
                    ServiceId = 3,
                    Nom = "Conseils d'Experts",
                    Description = "Des articles et guides sur la nutrition et le bien-être.",
                }

            );
        }
    }
}
