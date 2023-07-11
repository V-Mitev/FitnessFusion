namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.CaloriesCalculator;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class CaloriesCalculatorService : ICaloriesCalculatorService
    {
        private readonly FitnessFusionDbContext dbContext;

        public CaloriesCalculatorService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CalculateAsync(string userId, CaloriesCalculatorViewModel cc)
        {
            var genderParse = (GenderType)Enum.Parse(typeof(GenderType), cc.Gender);

            var activityLevelParse =
                (ActivityLevelType)Enum.Parse(typeof(ActivityLevelType), cc.ActivityLevel);

            var goalParse = (GoalType)Enum.Parse(typeof(GoalType), cc.Goal);

            CaloriesCalculator caloriesCalculator = new CaloriesCalculator()
            {
                Id = cc.Id,
                UserId = userId,
                Age = cc.Age,
                Height = cc.Height,
                Weight = cc.Weight,
                Gender = genderParse,
                ActivityLevel = activityLevelParse,
                Goal = goalParse,
                CaloriesIntake = CalculateCalories(genderParse, cc.Age, cc.Height, cc.Weight, activityLevelParse, goalParse)
            };

            cc.CaloriesIntake = caloriesCalculator.CaloriesIntake.ToString();

            var user = 
                await dbContext.ApplicationUsers.FirstAsync(a => a.Id == Guid.Parse(userId));

                user.CurrentCaloriesGoal = string.Format("{0:f2}", cc.CaloriesIntake);

                await dbContext.SaveChangesAsync();
        }

        // UnitTests

        public double CalculateCalories(GenderType gender, int age, double height, double weight, ActivityLevelType activityLevel, GoalType goal)
        {
            double bmr = 0;
            double calories = 0;

            // Calculate Basal Metabolic Rate (BMR) based on gender, age, height, and weight
            if (gender == GenderType.Male)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else if (gender == GenderType.Female)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
            }

            // Adjust BMR based on activity level
            switch (activityLevel)
            {
                case ActivityLevelType.Sedentary:
                    bmr *= 1.2;
                    break;
                case ActivityLevelType.LightlyActive:
                    bmr *= 1.375;
                    break;
                case ActivityLevelType.ModeratelyActive:
                    bmr *= 1.55;
                    break;
                case ActivityLevelType.VeryActive:
                    bmr *= 1.725;
                    break;
                case ActivityLevelType.SuperActive:
                    bmr *= 1.9;
                    break;
            }

            // Adjust calories based on goal
            switch (goal)
            {
                case GoalType.LoseWeight:
                    calories = bmr * 0.8;
                    break;
                case GoalType.MaintainWeight:
                    calories = bmr;
                    break;
                case GoalType.GainWeight:
                    calories = bmr * 1.2;
                    break;
            }

            return calories;
        }
    }
}
