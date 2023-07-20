namespace FitnessFusion.Web.ViewModels.Exercise
{
    using System.ComponentModel.DataAnnotations;

    public class ExerciseViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;
    }
}
