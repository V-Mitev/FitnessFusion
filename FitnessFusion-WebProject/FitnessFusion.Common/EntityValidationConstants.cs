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

        public static class User
        {
            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;

            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 1;
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

            public const int DescriptionMinLength = 30;
            public const int DescriptionMaxLength = 5000;
        }

        public static class Subscription
        {
            public const int SubscriptionTypeMinValue = 0;
            public const int SubscriptionTypeMaxValue = 2;

            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int ImageUrlMinLength = 1;
            public const int ImageUrlMaxLength = 2048;

            public const string PriceMinValue = "1";
            public const string PriceMaxValue = "250";

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 100;

            public const string CvvPatern = "^[0-9]{3}$";

            public const int CardNumberLength = 16;

            public const string ExpirationDatePatern = "^(0[1-9]|1[0-2])\\/?([0-9]{2})$";
        }

        public static class Trainer
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;
            
            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
        }
    }
}
