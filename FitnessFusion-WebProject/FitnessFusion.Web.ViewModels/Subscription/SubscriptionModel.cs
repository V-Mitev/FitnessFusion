namespace FitnessFusion.Web.ViewModels.Subscription
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Subscription;

    public class SubscriptionModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Range(SubscriptionMinValue, SubscriptionMaxValue)]
        public int TypeOfSubscription { get; set; }

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string Image { get; set; } = null!;

        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }
    }
}
