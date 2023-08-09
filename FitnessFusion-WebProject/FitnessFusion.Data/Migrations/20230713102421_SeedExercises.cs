#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class SeedExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4d82ef6c-5cf0-4b6e-957f-4d2975f11be9"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4db1a414-afba-4372-bf91-a1c324d6eb41"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8fb73b6f-5220-49b8-829e-8001247fc1e9"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c910033f-8034-4bbd-8b35-86a0d6d2c760"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("4d82ef6c-5cf0-4b6e-957f-4d2975f11be9"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("4db1a414-afba-4372-bf91-a1c324d6eb41"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("8fb73b6f-5220-49b8-829e-8001247fc1e9"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("c910033f-8034-4bbd-8b35-86a0d6d2c760"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
