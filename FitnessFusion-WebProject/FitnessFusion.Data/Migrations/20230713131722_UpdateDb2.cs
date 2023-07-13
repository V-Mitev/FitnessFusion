using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19bd0bb5-647f-43de-864e-783d3540fb35"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2512190a-3aa0-4950-8b5e-24d822737cfe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("757c75c2-572a-453e-b9b6-b029255c3d62"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("30deba33-9165-41e0-8c37-ce30c83488a3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3eb25831-7737-431a-a070-80a34dd89a16"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ae696663-6361-4ed2-8128-592a5b88a250"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f6d1007c-90a1-46de-a281-6c4bf310811b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("19bd0bb5-647f-43de-864e-783d3540fb35"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("2512190a-3aa0-4950-8b5e-24d822737cfe"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("757c75c2-572a-453e-b9b6-b029255c3d62"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("30deba33-9165-41e0-8c37-ce30c83488a3"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("3eb25831-7737-431a-a070-80a34dd89a16"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("ae696663-6361-4ed2-8128-592a5b88a250"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("f6d1007c-90a1-46de-a281-6c4bf310811b"), 300.0, "aaaaaaaaa", 2, "TestSnack" }
                });
        }
    }
}
