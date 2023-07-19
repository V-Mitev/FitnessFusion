using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class EditTrainingPlanAndSeedTestTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03b5b9b6-646b-4d57-a0c1-36c571a78a81"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("885f4b9b-9446-4acd-ac01-a68fa7cea0df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc1f9b01-8476-40a8-b1d2-da11713f6af3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("2c375dbd-6850-4a03-bfdf-742889f7f851"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4a7b7f0d-9abb-40ae-9637-df9abd995069"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7b78ce84-3d9a-491a-9b1b-33a29314810d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("bcb3f812-b561-4d72-84e5-8b9543ae1001"));

            migrationBuilder.AddColumn<string>(
                name: "DescriptionОfЕxercises",
                table: "TrainingPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("188cf1df-8c94-402f-a1fa-fbabae0c326a"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("39b3f4bf-2eed-41bd-8a98-f0b0b94e2881"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("ce7d818c-2179-4518-8a21-c1656d85df3c"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("5ef4f5d5-beb0-43d1-b1a8-68281b019a05"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("ace45836-0627-4c4c-b6e7-28a234ea98dc"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("e1d101c7-1de5-4d7e-a9e0-d25820287a33"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("fb5685ca-4c13-46f5-90a9-f0c843be0ee4"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("188cf1df-8c94-402f-a1fa-fbabae0c326a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("39b3f4bf-2eed-41bd-8a98-f0b0b94e2881"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce7d818c-2179-4518-8a21-c1656d85df3c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5ef4f5d5-beb0-43d1-b1a8-68281b019a05"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ace45836-0627-4c4c-b6e7-28a234ea98dc"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e1d101c7-1de5-4d7e-a9e0-d25820287a33"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("fb5685ca-4c13-46f5-90a9-f0c843be0ee4"));

            migrationBuilder.DropColumn(
                name: "DescriptionОfЕxercises",
                table: "TrainingPlans");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("03b5b9b6-646b-4d57-a0c1-36c571a78a81"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("885f4b9b-9446-4acd-ac01-a68fa7cea0df"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("dc1f9b01-8476-40a8-b1d2-da11713f6af3"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("2c375dbd-6850-4a03-bfdf-742889f7f851"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("4a7b7f0d-9abb-40ae-9637-df9abd995069"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("7b78ce84-3d9a-491a-9b1b-33a29314810d"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("bcb3f812-b561-4d72-84e5-8b9543ae1001"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }
    }
}
