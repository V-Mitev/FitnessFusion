namespace FitnessFusion.Data
{
    using FitnessFusion.Data.Configuration;
    using FitnessFusion.Data.Models;    
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class FitnessFusionDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FitnessFusionDbContext(DbContextOptions<FitnessFusionDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

        public DbSet<Exercise> Exercises { get; set; } = null!;

        public DbSet<Meal> Meals { get; set; } = null!;

        public DbSet<Subscription> Subscriptions { get; set; } = null!;

        public DbSet<TrainingPlan> TrainingPlans { get; set; } = null!;

        public DbSet<Trainer> Trainers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Meal>(new MealEntityConfiguration());

            builder.ApplyConfiguration<Exercise>(new ExerciseConfiguration());

            builder.Entity<Subscription>()
                .Property(t => t.Price)
                .HasPrecision(5, 2);

            base.OnModelCreating(builder);
        }
    }
}