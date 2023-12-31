﻿namespace FitnessFusion.Services.Tests.TestData
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using System.Threading.Tasks;

    public static class DataSeeder
    {
        public static async Task SeedExerciseAsync(FitnessFusionDbContext dbContext)
        {
            ICollection<Exercise> exercises = new List<Exercise>();

            Exercise exercise;

            exercise = new Exercise()
            {
                Id = Guid.Parse("57fb1075-0c17-41f6-82e1-499c7b18dbf2"),
                Name = "Pull Up",
                Description = "Test description for exercise",
                ImagePath = "PullUp",
                Difficulty = ExerciseLevelOfDificulty.Intermediate,
                MuscleGroup = MuscleGroups.Back,
                VideoLink = "ExerciseLink"
            };
            exercises.Add(exercise);

            exercise = new Exercise()
            {
                Id = Guid.Parse("4297b564-6913-4538-b4e9-ab6f24c3d5ec"),
                Name = "Test",
                Description = "Test description for exercise",
                ImagePath = "Test",
                Difficulty = ExerciseLevelOfDificulty.Beginner,
                MuscleGroup = MuscleGroups.Chest,
                VideoLink = "ExerciseLink"
            };
            exercises.Add(exercise);

            await dbContext.AddRangeAsync(exercises);

            await dbContext.SaveChangesAsync();
        }

        public static async Task SeedMealAsync(FitnessFusionDbContext dbContext)
        {
            ICollection<Meal> meals = new List<Meal>();

            Meal meal;

            meal = new Meal()
            {
                Id = Guid.Parse("35ea94c3-ed8c-4aba-acc6-f7caaf07560a"),
                Name = "Ham",
                CaloriesPer100g = 100,
                MealType = MealType.Breakfast,
                ImageUrl = "Ham.png"
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Id = Guid.Parse("9d61e7df-20b6-42af-9137-085b84d507ac"),
                Name = "Bacon",
                CaloriesPer100g = 100,
                MealType = MealType.Breakfast,
                ImageUrl = "Bacon"
            };
            meals.Add(meal);

            await dbContext.Meals.AddRangeAsync(meals);

            await dbContext.SaveChangesAsync();
        }

        public static async Task SeedUsersAsync(FitnessFusionDbContext dbContext)
        {
            ApplicationUser user;

            user = new ApplicationUser()
            {
                Id = Guid.Parse("b7dc9a5e-80d2-49e0-9047-5c42a7a2a2a6"),
                FirstName = "Gosho",
                LastName = "Goshov",
                UserName = "Gosho",
                NormalizedUserName = "GOSHO",
                Email = "gosho@abv.bg",
                NormalizedEmail = "GOSHO@ABV.BG",
                EmailConfirmed = true,
                IsSubscribeValid = true,
                ConcurrencyStamp = "2a8f0ee6-76ba-4f5c-a443-75c87e6c6e0b",
                SecurityStamp = "58f0a7be-7297-418b-b195-29834b3366fd",
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                TwoFactorEnabled = false,
                SubscriptionId = Guid.Parse("aa9ba662-a330-43a4-a4fa-5dc0233ac34b"),
                StartSubscription = DateTime.UtcNow,
                EndSubscription = DateTime.UtcNow.AddDays(30)
            };

            dbContext.ApplicationUsers.Add(user);

            user = new ApplicationUser()
            {
                Id = Guid.Parse("9f11de4f-ca0b-4405-8daf-6e01e4647042"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                UserName = "Ivan",
                NormalizedUserName = "Ivan",
                Email = "ivan@abv.bg",
                NormalizedEmail = "IVAN@ABV.BG",
                EmailConfirmed = true,
                IsSubscribeValid = false,
                ConcurrencyStamp = "2a8f0ee6-76ba-4f5c-a443-75c87e6c6e0b",
                SecurityStamp = "58f0a7be-7297-418b-b195-29834b3366fd",
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                TwoFactorEnabled = false,
                StartSubscription = DateTime.UtcNow,
                EndSubscription = DateTime.UtcNow
            };

            dbContext.ApplicationUsers.Add(user);

            await dbContext.SaveChangesAsync();
        }

        public static async Task SeedTrainersAsync(FitnessFusionDbContext dbContext)
        {
            Trainer trainer;

            trainer = new Trainer()
            {
                Id = Guid.Parse("a19a795b-b45f-4c53-9958-d8fd71e1212a"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                Description = "Test description for trainer",
                UserName = "Ivan",
                NormalizedUserName = "IVAN",
                Email = "ivan@abv.bg",
                NormalizedEmail = "IVAN@ABV.BG",
                EmailConfirmed = true,
                ConcurrencyStamp = "844ea471-856a-405c-b019-35cfdc53d5e0",
                SecurityStamp = "359ecadb-93ab-444d-91b2-7183c16f9c0f",
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                TwoFactorEnabled = false,
                IsTrainer = true
            };

            dbContext.Trainers.Add(trainer);

            trainer = new Trainer()
            {
                Id = Guid.Parse("f2ab1a33-7228-4667-9267-b9c5568a31d5"),
                FirstName = "Petar",
                LastName = "Tomov",
                Description = "Test description for second trainer",
                UserName = "Petar",
                NormalizedUserName = "PETAR",
                Email = "petar@abv.bg",
                NormalizedEmail = "PETAR@ABV.BG",
                EmailConfirmed = true,
                ConcurrencyStamp = "e3a2d1de-bf3c-46ba-9d2f-993f512aa894",
                SecurityStamp = "2cfa045f-9925-4aa6-8aca-2a9aa7c8f85b",
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                TwoFactorEnabled = false,
                IsTrainer = true
            };

            dbContext.Trainers.Add(trainer);

            await dbContext.SaveChangesAsync();
        }

        public static async Task SeedSubscriptions(FitnessFusionDbContext dbContext)
        {
            Subscription subscription;

            subscription = new Subscription()
            {
                Id = Guid.Parse("aa9ba662-a330-43a4-a4fa-5dc0233ac34b"),
                Name = "Test subscription",
                Description = "Test description for subscription",
                Price = 30M,
                TypeOfSubscription = TypeOfSubscription.Standard,
                Image = "SubscriptionImage"
            };

            dbContext.Subscriptions.Add(subscription);

            subscription = new Subscription()
            {
                Id = Guid.Parse("d28d8986-4b44-4a0c-958f-13b21e7775ab"),
                Name = "Test subscription",
                Description = "Test description for subscription",
                Price = 30M,
                TypeOfSubscription = TypeOfSubscription.Premium,
                Image = "SubscriptionImage"
            };

            dbContext.Subscriptions.Add(subscription);

            await dbContext.SaveChangesAsync();
        }

        public static async Task SeedTrainingPlanAsync(FitnessFusionDbContext dbContext)
        {
            TrainingPlan trainingPlan;

            trainingPlan = new TrainingPlan()
            {
                Id = Guid.Parse("d6c89f41-9ea4-4ed3-a585-7b3650c04d8f"),
                Name = "Test training plan",
                Description = "Test training plan description",
                Image = "Test image",
                TrainerId = Guid.Parse("a19a795b-b45f-4c53-9958-d8fd71e1212a")
            };

            var firstExercise = new Exercise()
            {
                Id = Guid.Parse("57fb1075-0c17-41f6-82e1-499c7b18dbf2"),
                Name = "Pull Up",
                Description = "Test description for exercise",
                ImagePath = "PullUp",
                Difficulty = ExerciseLevelOfDificulty.Intermediate,
                MuscleGroup = MuscleGroups.Back,
                VideoLink = "ExerciseLink"
            };

            var secondExercise = new Exercise()
            {
                Id = Guid.Parse("4297b564-6913-4538-b4e9-ab6f24c3d5ec"),
                Name = "Test",
                Description = "Test description for exercise",
                ImagePath = "Test",
                Difficulty = ExerciseLevelOfDificulty.Beginner,
                MuscleGroup = MuscleGroups.Chest,
                VideoLink = "ExerciseLink"
            };

            trainingPlan.TrainerId = Guid.Parse("a19a795b-b45f-4c53-9958-d8fd71e1212a");

            trainingPlan.Exercises.Add(firstExercise);
            trainingPlan.Exercises.Add(secondExercise);

            await dbContext.TrainingPlans.AddAsync(trainingPlan);

            trainingPlan = new TrainingPlan()
            {
                Id = Guid.Parse("89996373-6df1-4d81-a982-b78c8b188ae8"),
                Name = "Training plan for delete",
                Description = "Test training plan for delete description",
                Image = "Test image",
                TrainerId = Guid.Parse("a19a795b-b45f-4c53-9958-d8fd71e1212a")
            };

            dbContext.TrainingPlans.Add(trainingPlan);

            await dbContext.SaveChangesAsync();
        }
    }
}