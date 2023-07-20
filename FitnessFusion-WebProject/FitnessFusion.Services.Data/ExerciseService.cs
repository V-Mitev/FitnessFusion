namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
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

        public async Task AddExerciseAsync(AddExerciseViewModel model)
        {
            Exercise exercise = new Exercise()
            {
                Name = model.Name,
                Description = model.Description,
                ImagePath = model.Image,
                VideoLink = model.VideoUrl,
                MuscleGroup = model.MuscleGroup,
                Difficulty = model.Dificulty
            };

            await dbContext.Exercises.AddAsync(exercise);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteExerciseAsync(string id)
        {
            var exercise = await dbContext.Exercises.FirstOrDefaultAsync(e => e.Id.ToString() == id);

            if (exercise == null)
            {
                throw new InvalidOperationException("Exercise doesn't exists");
            }

            dbContext.Exercises.Remove(exercise);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditExerciseAsync(string id, AddExerciseViewModel model)
        {
            var exerciseToEdit = await dbContext.Exercises.FirstOrDefaultAsync(e => e.Id.ToString() == id);

            if (exerciseToEdit == null)
            {
                throw new InvalidOperationException("This exercise doesn't exists");
            }

            exerciseToEdit.Id = Guid.Parse(id);
            exerciseToEdit.Name = model.Name;
            exerciseToEdit.Description = model.Description;
            exerciseToEdit.Difficulty = model.Dificulty;
            exerciseToEdit.VideoLink = model.VideoUrl;
            exerciseToEdit.ImagePath = model.Image;
            exerciseToEdit.MuscleGroup = model.MuscleGroup;

            await dbContext.SaveChangesAsync();
        }

        public async Task<AddExerciseViewModel> FindExerciseAsync(string exerciseId)
        {
            var exercise = 
                await dbContext.Exercises.FirstOrDefaultAsync(e => e.Id.ToString() == exerciseId);

            if (exercise == null)
            {
                throw new InvalidOperationException("This exercise doesn't exists");
            }

            AddExerciseViewModel exerciseModel = new AddExerciseViewModel()
            {
                Name = exercise.Name,
                Description = exercise.Description,
                Image = exercise.ImagePath,
                VideoUrl = exercise.VideoLink,
                Dificulty = exercise.Difficulty,
                MuscleGroup = exercise.MuscleGroup
            };

            return exerciseModel;
        }

        public async Task<ICollection<AllExercisesViewModel>> GetAllExercisesAsync()
        {
            var exercises = await dbContext.Exercises
                .Select(e => new AllExercisesViewModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Image = e.ImagePath,
                    Description = e.Description,
                    VideoUrl = e.VideoLink,
                    MuscleGroup = e.MuscleGroup.ToString()
                })
                .ToListAsync();

            return exercises;
        }

        public async Task<ICollection<ExerciseViewModel>> GetAllExercisesAsyncForTrainingPlan()
        {
            var exercises = await dbContext.Exercises
                .Select(e => new ExerciseViewModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name
                })
                .ToListAsync();

            return exercises;
        }
    }
}
