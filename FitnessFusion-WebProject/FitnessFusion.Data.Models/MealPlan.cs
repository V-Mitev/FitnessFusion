namespace FitnessFusion.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class MealPlan
    {
        public MealPlan()
        {
            Id = Guid.NewGuid();
            Meals = new List<Meal>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public Guid ClientId { get; set; }

        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }

        public Trainer Trainer { get; set; } = null!;

        public ICollection<Meal> Meals { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsValid { get; set; }

        public double TotalCalories { get; set; }
    }
}
