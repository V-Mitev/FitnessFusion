namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;

    public class Subscription
    {
        public Subscription()
        {
            Id = Guid.NewGuid();
            Users = new HashSet<ApplicationUser>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public TypeOfSubscription TypeOfSubscription { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
