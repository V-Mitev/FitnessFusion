namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Subscription;

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
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(SubscriptionTypeMinValue, SubscriptionTypeMaxValue)]
        public TypeOfSubscription TypeOfSubscription { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string Image { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
