namespace FitnessFusion.Web.ViewModels.Subscription
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Subscription;

    public class SubscribeViewModel
    {
        [Required]
        [StringLength(CardNumberLength, MinimumLength = CardNumberLength)]
        public string CardNumber { get; set; } = null!;

        [Required]
        [RegularExpression(ExpirationDatePatern, 
            ErrorMessage = "Please enter card expiry date correctly like example")]
        public string ExpirationDate { get; set; } = null!;

        [Required]
        [RegularExpression(CvvPatern, ErrorMessage = "Please enter three numbers")]
        public string Cvv { get; set; } = null!;
    }
}
