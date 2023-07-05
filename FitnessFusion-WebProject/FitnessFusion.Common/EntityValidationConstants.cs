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
    }
}
