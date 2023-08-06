namespace FitnessFusion.Common
{
    public static class EntityValidationConstants
    {
        public static class Meal
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 2048;

            public const double CaloriesMinValue = 0;
            public const double CaloriesMaxValue = 5000;
        }

        public static class CaloriesCalculator
        {
            public const double MinHeightValue = 1;
            public const double MaxHeightValue = 300;

            public const double MinWeightValue = 1;
            public const double MaxWeightValue = 500;

            public const int MinAgeValue = 1;
            public const int MaxAgeValue = 100;
        }

        public static class ApplicationUser
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 5;
            public const int LastNameMaxLength = 50;
        }

        public static class Exercise
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 5000;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 2048;

            public const int VideoUrlMinLength = 3;
            public const int VideoUrlMaxLength = 2048;
        }

        public static class TrainingPlan
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 50;
        }
    }
}
