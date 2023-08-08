namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TrainingPlanService : ITrainingPlanService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainingPlanService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddExerciseToExistingPlanAsync(TrainingPlanExercises model, string trainingPlanId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == trainingPlanId);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doesn't exists");
            }

            Exercise exercise = new Exercise()
            {
                Name = model.Name,
                Description = model.Description,
                ImagePath = model.Image,
                VideoLink = model.VideoLink,
                MuscleGroup = model.MuscleGroup,
                IsInPlan = true
            };

            await dbContext.Exercises.AddAsync(exercise);

            trainingPlan.Exercises.Add(exercise);

            await dbContext.SaveChangesAsync();
        }

        public void AddExerciseToPlan(TrainingPlanExercises model, TrainingPlanViewModel trainingPlan)
        {
            trainingPlan.AddedExercises.Add(model);
        }

        public async Task AddTrainingPlanAsync(TrainingPlanViewModel model, string userId)
        {
            var trainer = await dbContext.Trainers
                .FindAsync(Guid.Parse(userId));

            if (trainer == null)
            {
                throw new NullReferenceException("Trainer doesnt exists");
            }

            var exercises = model.AddedExercises!
            .Select(e => new Exercise()
            {
                Name = e.Name,
                Description = e.Description,
                ImagePath = e.Image,
                VideoLink = e.VideoLink,
                MuscleGroup = e.MuscleGroup,
                IsInPlan = true
            })
            .ToList();

            TrainingPlan trainingPlan = new TrainingPlan()
            {
                Name = model.Name,
                TrainerId = trainer.Id,
                Exercises = exercises,
                Image = model.Image
            };

            await dbContext.TrainingPlans.AddAsync(trainingPlan);

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteExerciseInTrainingPlanAsync(string id)
        {
            var exerciseToDelete = await dbContext.Exercises
                .FindAsync(Guid.Parse(id));

            if (exerciseToDelete == null)
            {
                throw new ArgumentNullException(nameof(exerciseToDelete));
            }

            dbContext.Exercises.Remove(exerciseToDelete);

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteTrainingPlanAsync(string id)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == id);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doens't exists");
            }

            dbContext.Exercises.RemoveRange(trainingPlan.Exercises);

            dbContext.TrainingPlans.Remove(trainingPlan);

            await dbContext.SaveChangesAsync();
        }

        public async Task<DetailsTrainingPlanViewModel> DetailsAsync(string id)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == id);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doesn't exists");
            }

            var trainer = await dbContext.Trainers
                .FindAsync(trainingPlan.TrainerId);

            if (trainer == null)
            {
                throw new NullReferenceException("Trainer doesn't exists");
            }

            var exercises = trainingPlan.Exercises
               .Select(e => new TrainingPlanExercises()
               {
                   Id = e.Id.ToString(),
                   Name = e.Name,
                   Description = e.Description,
                   Image = e.ImagePath,
                   VideoLink = e.VideoLink,
                   MuscleGroup = e.MuscleGroup
               }).ToList();

            var detailsTP = new DetailsTrainingPlanViewModel()
            {
                Name = trainingPlan.Name,
                Trainer = $"{trainer.FirstName} {trainer.LastName}",
                Exercises = exercises
            };

            return detailsTP;
        }

        public async Task EditTrainingPlanAsync(TrainingPlanViewModel model, string trainingPlanId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .FindAsync(Guid.Parse(trainingPlanId));

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doesn't exists");
            }

            var exercises = model.AddedExercises
                .Select(e => new Exercise()
                {
                    Name = e.Name,
                    Description = e.Description,
                    ImagePath = e.Image,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup
                }).ToList();

            trainingPlan.Name = model.Name;
            trainingPlan.Image = model.Image;

            await dbContext.SaveChangesAsync();
        }

        public async Task EditTrainingPlanExerciseAsync(string id, TrainingPlanExercises model)
        {
            var exercise = await dbContext.Exercises.FindAsync(Guid.Parse(id));

            if (exercise == null)
            {
                throw new ArgumentNullException("Exercise doesn't exists");
            }

            exercise.Name = model.Name;
            exercise.Description = model.Description;
            exercise.ImagePath = model.Image;
            exercise.VideoLink = model.VideoLink;
            exercise.MuscleGroup = model.MuscleGroup;

            await dbContext.SaveChangesAsync();
        }

        public async Task<TrainingPlanViewModel> FindTrainingPlanByIdAsync(string id)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == id);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doen't exists");
            }

            var exercises = trainingPlan.Exercises
                .Select(e => new TrainingPlanExercises()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Image = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup
                }).ToList();

            TrainingPlanViewModel model = new TrainingPlanViewModel()
            {
                Id = trainingPlan.Id.ToString(),
                Name = trainingPlan.Name,
                Image = trainingPlan.Image,
                AddedExercises = exercises
            };

            return model;
        }

        public async Task<TrainingPlanExercises> FindTrainingPlanExerciseAsync(string id)
        {
            var exerciseDb =
                await dbContext.Exercises.FindAsync(Guid.Parse(id));

            if (exerciseDb == null)
            {
                throw new ArgumentNullException(nameof(exerciseDb));
            }

            TrainingPlanExercises exerciseTp = new TrainingPlanExercises()
            {
                Id = exerciseDb.Id.ToString(),
                Name = exerciseDb.Name,
                Description = exerciseDb.Description,
                Image = exerciseDb.ImagePath,
                VideoLink = exerciseDb.VideoLink,
                MuscleGroup = exerciseDb.MuscleGroup
            };

            return exerciseTp;
        }

        public async Task<ICollection<AllTrainingPlansViewModel>> GetAllTrainingPlansAsync()
        {
            var trainingPlans = await dbContext.TrainingPlans
                .Select(tp => new AllTrainingPlansViewModel()
                {
                    Id = tp.Id.ToString(),
                    Name = tp.Name,
                    TrainerId = tp.TrainerId.ToString(),
                    Trainer = $"{tp.Trainer.FirstName} {tp.Trainer.LastName}",
                    Image = tp.Image
                })
                .ToListAsync();

            return trainingPlans;
        }

        public async Task<bool> IsExercisesAlreadyCreated(string trainingPlanId, string exerciseName)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == trainingPlanId);

            var exercise = await dbContext.Exercises
                .Where(e => e.TrainingPlans.Contains(trainingPlan!) && e.Name == exerciseName)
                .FirstOrDefaultAsync();

            return trainingPlan!.Exercises.Any(e => e.Name == exerciseName && e.IsInPlan);
        }
    }
}
