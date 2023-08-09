namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ExerciseService : IExerciseService
    {
        private readonly FitnessFusionDbContext dbContext;

        public ExerciseService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddExerciseAsync(AddExerciseModel model)
        {
            Exercise exercise = new Exercise()
            {
                Name = model.Name,
                Description = model.Description,
                ImagePath = model.ImagePath,
                VideoLink = model.VideoLink,
                MuscleGroup = (MuscleGroups)model.MuscleGroup!,
                Difficulty = (ExerciseLevelOfDificulty)model.Dificulty!,
                IsInPlan = false
            };

            await dbContext.Exercises.AddAsync(exercise);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteExerciseAsync(string id)
        {
            var exercise = await dbContext.Exercises
                .FindAsync(Guid.Parse(id));

            if (exercise == null)
            {
                throw new ArgumentNullException("Exercise doesn't exists");
            }

            dbContext.Exercises.Remove(exercise);

            await dbContext.SaveChangesAsync();
        }

        public async Task<ExerciseDetailsModel> DetailsAsync(string id)
        {
            var exercise = await dbContext.Exercises
                .FindAsync(Guid.Parse(id));

            if (exercise == null)
            {
                throw new NullReferenceException("Exercise doesn't exists");
            }

            var exerciseViewModel = new ExerciseDetailsModel()
            {
                Id = exercise.Id.ToString(),
                Name = exercise.Name,
                Description = exercise.Description,
                ImagePath = exercise.ImagePath,
                MuscleGroup = exercise.MuscleGroup.ToString(),
                VideoLink = exercise.VideoLink,
                Difficulty = exercise.Difficulty.ToString()
            };

            return exerciseViewModel;
        }

        public async Task EditExerciseAsync(string id, AddExerciseModel model)
        {
            var exerciseToEdit = await dbContext.Exercises
                .FindAsync(Guid.Parse(id));

            if (exerciseToEdit == null)
            {
                throw new ArgumentNullException("This exercise doesn't exists");
            }

            exerciseToEdit.Id = Guid.Parse(id);
            exerciseToEdit.Name = model.Name;
            exerciseToEdit.Description = model.Description;
            exerciseToEdit.Difficulty = (ExerciseLevelOfDificulty)model.Dificulty!;
            exerciseToEdit.VideoLink = model.VideoLink;
            exerciseToEdit.ImagePath = model.ImagePath;
            exerciseToEdit.MuscleGroup = (MuscleGroups)model.MuscleGroup!;

            await dbContext.SaveChangesAsync();
        }

        public async Task<AddExerciseModel> FindExerciseAsync(string exerciseId)
        {
            var exercise = await dbContext.Exercises
                .FindAsync(Guid.Parse(exerciseId));

            if (exercise == null)
            {
                throw new ArgumentNullException("This exercise doesn't exists");
            }

            var exerciseModel = new AddExerciseModel()
            {
                Name = exercise.Name,
                Description = exercise.Description,
                ImagePath = exercise.ImagePath,
                VideoLink = exercise.VideoLink,
                Dificulty = exercise.Difficulty,
                MuscleGroup = exercise.MuscleGroup
            };

            return exerciseModel;
        }

        public async Task<ICollection<AllExercisesModel>> GetAllExercisesAsync()
        {
            var exercises = await dbContext.Exercises
                .Where(e => !e.IsInPlan)
                .Select(e => new AllExercisesModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    ImagePath = e.ImagePath,
                    MuscleGroup = e.MuscleGroup.ToString()
                })
                .ToListAsync();

            return exercises;
        }
    }
}
