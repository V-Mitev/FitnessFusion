using FitnessFusion.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessFusion.Data
{
    public class FitnessFusionDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FitnessFusionDbContext(DbContextOptions<FitnessFusionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Meal> Meals { get; set; } = null!;

        public DbSet<CaloriesCalculator> CaloriesCalculators { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }
    }
}