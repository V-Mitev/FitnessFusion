#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("00f62bb7-61ab-4344-869f-bc639e16b936"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("50d9fcbd-96b5-403f-8dd5-09a519c07c74"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90c158be-f3ab-41c4-a48b-2142f19d794a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("2cf9c96d-6b44-4982-ab45-b5b8eb1e3d9e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3fb68d90-f501-4f6e-acf5-19dac494543b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9e5593ca-67c9-445f-a1c1-46f62a9f0372"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c9e33729-6e61-4fcb-9d26-6ab62eaf8169"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("00f62bb7-61ab-4344-869f-bc639e16b936"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("50d9fcbd-96b5-403f-8dd5-09a519c07c74"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("90c158be-f3ab-41c4-a48b-2142f19d794a"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("2cf9c96d-6b44-4982-ab45-b5b8eb1e3d9e"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("3fb68d90-f501-4f6e-acf5-19dac494543b"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("9e5593ca-67c9-445f-a1c1-46f62a9f0372"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("c9e33729-6e61-4fcb-9d26-6ab62eaf8169"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }
    }
}
