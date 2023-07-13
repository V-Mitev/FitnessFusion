using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class AddImageToExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("716a53d7-7e2e-4603-9b30-6c5ee56ce684"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d17a5cc1-4797-4e15-9d19-64103ccd713d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb59fb01-2db8-499a-9e6f-f6a10c3730f8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("012bc7a1-c8ca-4364-9f7a-1f89589069ac"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3b873eda-cb1f-4e19-954c-41985141a148"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4c95dc2a-bf64-47c4-8f5c-67bfa4214473"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f39a30d2-91cf-4d03-9dfb-45110d7e40bb"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Exercises");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("716a53d7-7e2e-4603-9b30-6c5ee56ce684"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("d17a5cc1-4797-4e15-9d19-64103ccd713d"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("eb59fb01-2db8-499a-9e6f-f6a10c3730f8"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("012bc7a1-c8ca-4364-9f7a-1f89589069ac"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("3b873eda-cb1f-4e19-954c-41985141a148"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("4c95dc2a-bf64-47c4-8f5c-67bfa4214473"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("f39a30d2-91cf-4d03-9dfb-45110d7e40bb"), 300.0, "aaaaaaaaa", 3, "TestDinner" }
                });
        }
    }
}
