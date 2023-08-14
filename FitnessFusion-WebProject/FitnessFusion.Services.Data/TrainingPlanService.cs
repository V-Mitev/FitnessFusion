namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TrainingPlanService : ITrainingPlanService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainingPlanService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddExerciseToExistingPlanAsync(AddExerciseModel model, string trainingPlanId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == trainingPlanId);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doesn't exists");
            }

            var exercise = new Exercise()
            {
                Name = model.Name,
                Description = model.Description,
                ImagePath = model.Image,
                VideoLink = model.VideoLink,
                MuscleGroup = (MuscleGroups)model.MuscleGroup!,
                Difficulty = (ExerciseLevelOfDificulty)model.Dificulty!
            };

            await dbContext.Exercises.AddAsync(exercise);

            trainingPlan.Exercises.Add(exercise);

            await dbContext.SaveChangesAsync();
        }

        public void AddExerciseToPlan(AddExerciseModel model, TrainingPlanModel trainingPlan)
        {
            trainingPlan.AddedExercises.Add(model);
        }

        public async Task AddExerciseWhenEditPlan(string trainingPlanId, string exerciseId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .FindAsync(Guid.Parse(trainingPlanId));

            var exercise = await dbContext.Exercises
                .FindAsync(Guid.Parse(exerciseId));

            if (trainingPlan != null && exercise != null)
            {
                trainingPlan.Exercises.Add(exercise);

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task AddTrainingPlanAsync(TrainingPlanModel model, string userId)
        {
            var trainer = await dbContext.Trainers
                .FirstOrDefaultAsync(u => u.IsTrainer && u.Id.ToString() == userId);

            if (trainer == null)
            {
                throw new NullReferenceException("Trainer doesnt exists");
            }

            var alreadyCreatedExercise = await dbContext.Exercises
                .Select(e => new AddExerciseModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Dificulty = e.Difficulty,
                    MuscleGroup = e.MuscleGroup,
                    Image = e.ImagePath,
                    VideoLink = e.VideoLink
                })
                .ToListAsync();

            foreach (var exercise in alreadyCreatedExercise.DistinctBy(e => e.Id))
            {
                if (model.AddedExercises
                    .Where(e => e.Id != null)
                    .Any(e => e.Id!.ToString() == exercise.Id && e.Name == exercise.Name))
                {
                    model.AddedExercises.Remove(exercise);
                }
            }

            var exercises = model.AddedExercises
            .Select(e => new Exercise()
            {
                Name = e.Name,
                Description = e.Description,
                ImagePath = e.Image,
                VideoLink = e.VideoLink,
                MuscleGroup = (MuscleGroups)e.MuscleGroup!,
                Difficulty = (ExerciseLevelOfDificulty)e.Dificulty!
            })
            .ToList();

            var trainingPlan = new TrainingPlan()
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

            dbContext.TrainingPlans.Remove(trainingPlan);

            await dbContext.SaveChangesAsync();
        }

        public async Task<DetailsTrainingPlanModel> DetailsAsync(string id)
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
               .Select(e => new AddExerciseModel()
               {
                   Id = e.Id.ToString(),
                   Name = e.Name,
                   Description = e.Description,
                   Image = e.ImagePath,
                   VideoLink = e.VideoLink,
                   MuscleGroup = e.MuscleGroup,
                   Dificulty = e.Difficulty
               }).ToList();

            var detailsTP = new DetailsTrainingPlanModel()
            {
                Name = trainingPlan.Name,
                Trainer = $"{trainer.FirstName} {trainer.LastName}",
                Exercises = exercises
            };

            return detailsTP;
        }

        public async Task EditTrainingPlanAsync(TrainingPlanModel model, string trainingPlanId, string userId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .FindAsync(Guid.Parse(trainingPlanId));

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doesn't exists");
            }

            if (trainingPlan.TrainerId.ToString() != userId)
            {
                throw new InvalidOperationException("You can't edit training plan when you are not creator!");
            }

            var exercises = model.AddedExercises
                .Select(e => new Exercise()
                {
                    Name = e.Name,
                    Description = e.Description,
                    ImagePath = e.Image,
                    VideoLink = e.VideoLink,
                    MuscleGroup = (MuscleGroups)e.MuscleGroup!
                }).ToList();

            trainingPlan.Name = model.Name;
            trainingPlan.Image = model.Image;

            await dbContext.SaveChangesAsync();
        }

        public async Task<TrainingPlanModel> FindTrainingPlanByIdAsync(string id)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == id);

            if (trainingPlan == null)
            {
                throw new NullReferenceException("Training plan doen't exists");
            }

            var exercises = trainingPlan.Exercises
                .Select(e => new AddExerciseModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Image = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup,
                    Dificulty = e.Difficulty
                }).ToList();

            TrainingPlanModel model = new TrainingPlanModel()
            {
                Id = trainingPlan.Id.ToString(),
                Name = trainingPlan.Name,
                Image = trainingPlan.Image,
                AddedExercises = exercises
            };

            return model;
        }

        public async Task<ICollection<AllTrainingPlansModel>> GetAllTrainingPlansAsync()
        {
            var trainingPlans = await dbContext.TrainingPlans
                .Select(tp => new AllTrainingPlansModel()
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

        public async Task<bool> IsTrainingPlanExistByIdAsync(string id)
        {
            var result = await dbContext.TrainingPlans
                .AnyAsync(tp => tp.Id.ToString() == id);

            return result;
        }

        public async Task RemoveExerciseFromPlan(string trainingPlanId, string exerciseId)
        {
            var trainingPlan = await dbContext.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefaultAsync(tp => tp.Id.ToString() == trainingPlanId);

            var exercise = await dbContext.Exercises
                .FirstOrDefaultAsync(e => e.Id.ToString() == exerciseId);

            trainingPlan!.Exercises.Remove(exercise!);

            await dbContext.SaveChangesAsync();
        }
    }
}
