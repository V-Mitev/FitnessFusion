namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    public class AllTrainingPlansViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Trainer { get; set; } = null!;

        public string? Image { get; set; }
    }
}
