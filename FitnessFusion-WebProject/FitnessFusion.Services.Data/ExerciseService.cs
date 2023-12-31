﻿namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Services.Data.Models.Exercise;
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
                ImagePath = model.Image,
                VideoLink = model.VideoLink,
                MuscleGroup = (MuscleGroups)model.MuscleGroup!,
                Difficulty = (ExerciseLevelOfDificulty)model.Dificulty!
            };

            await dbContext.Exercises.AddAsync(exercise);
            await dbContext.SaveChangesAsync();
        }

        public async Task<AddExerciseModel?> AddExistingExerciseAsync(string id)
        {
            var exercise = await dbContext.Exercises
                .Where(e => e.Id.ToString() == id)
                .Select(e => new AddExerciseModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Image = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup,
                    Dificulty = e.Difficulty
                })
                .FirstOrDefaultAsync();

            if (exercise == null)
            {
                return null;
            }

            return exercise;
        }

        public async Task<AllExercisesFilteredAndPagedServiceModel> AllAsync(AllExercisesQueryModel queryModel)
        {
            IQueryable<Exercise> exercisesQuery = dbContext.Exercises
                .AsQueryable();

            if (queryModel.MuscleGroup.HasValue)
            {
                exercisesQuery = exercisesQuery
                    .Where(m => m.MuscleGroup == queryModel.MuscleGroup);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                exercisesQuery = exercisesQuery
                    .Where(e => EF.Functions.Like(e.Name, wildCard));
            }

            ICollection<AllExercisesModel> allExercises = await exercisesQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ExercisesPerPage)
                .Take(queryModel.ExercisesPerPage)
                .Select(e => new AllExercisesModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    ImagePath = e.ImagePath,
                    MuscleGroup = e.MuscleGroup.ToString()
                })
                .ToListAsync();

            int totalExercises = exercisesQuery.Count();

            return new AllExercisesFilteredAndPagedServiceModel()
            {
                Exercises = allExercises,
                TotalExerciseCount = totalExercises
            };
        }

        public async Task<ICollection<AllExercisesModel>> AlreadyCreatedAsync()
        {
            var result = await dbContext.Exercises
                .Select(e => new AllExercisesModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    ImagePath = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup.ToString(),
                    Difficulty = e.Difficulty.ToString(),
                })
                .ToListAsync();

            return result;
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

        public async Task<AllExercisesModel> DetailsAsync(string id)
        {
            var exercise = await dbContext.Exercises
                .FindAsync(Guid.Parse(id));

            if (exercise == null)
            {
                throw new NullReferenceException("Exercise doesn't exists");
            }

            var exerciseViewModel = new AllExercisesModel()
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
            exerciseToEdit.ImagePath = model.Image;
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
                Image = exercise.ImagePath,
                VideoLink = exercise.VideoLink,
                Dificulty = exercise.Difficulty,
                MuscleGroup = exercise.MuscleGroup
            };

            return exerciseModel;
        }

        public async Task<bool> IsExerciseExistByIdAsync(string id)
        {
            var result = await dbContext.Exercises
                .AnyAsync(e => e.Id.ToString() == id.ToLower());

            return result;
        }
    }
}
