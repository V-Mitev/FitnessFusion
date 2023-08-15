#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditExerciseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9101fa5-4c2c-49a2-9c86-36497d0bb4e8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("143f9732-2315-4130-a403-b904ea2d75d9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("801ad93a-7e60-4669-bae6-80a5842e4e51"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ab0b83eb-add9-42bb-a578-9fed56011775"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("18de705c-a385-4fc3-8c4f-e1dc8d4503b1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("30dfcce0-6546-4eec-a2da-12181abfbf21"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("38e7a5c7-7490-439e-add4-cb4d885653b8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b2a8fa3e-ff05-4270-a9de-56867e847619"));

            migrationBuilder.DropColumn(
                name: "IsInPlan",
                table: "Exercises");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("394673e4-96bf-422c-8bb6-e02f61eda88c"), 0, "eb02d530-64c2-49ff-afce-d59f934435a9", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAENN8kBABr1nkOX37pKPhMkTwyvxGMxWnGq0bgxV2ECAE1SedrvXRwhfyxqOv4WzDSQ==", null, false, "40dd01e6-f4e3-4c24-81c9-b261def15898", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("4dd5bc3b-b40e-46df-947a-c9e2ea77e70e"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("60a56019-91f2-40a4-9d54-549619b4075c"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("d5c8f848-63df-4e06-a4b3-c2a05e04cbf2"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("8dd4c18e-b048-4b37-aa7e-15b3e9f8f6b4"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("901a7a24-eee7-4291-b316-8886fb95765d"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("9af516c6-7657-4bd7-a218-78a9498d6c47"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("beccc0e1-4d4a-4e73-b74e-84d46fa3e5d7"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("394673e4-96bf-422c-8bb6-e02f61eda88c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4dd5bc3b-b40e-46df-947a-c9e2ea77e70e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("60a56019-91f2-40a4-9d54-549619b4075c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d5c8f848-63df-4e06-a4b3-c2a05e04cbf2"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8dd4c18e-b048-4b37-aa7e-15b3e9f8f6b4"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("901a7a24-eee7-4291-b316-8886fb95765d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9af516c6-7657-4bd7-a218-78a9498d6c47"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("beccc0e1-4d4a-4e73-b74e-84d46fa3e5d7"));

            migrationBuilder.AddColumn<bool>(
                name: "IsInPlan",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d9101fa5-4c2c-49a2-9c86-36497d0bb4e8"), 0, "26032ee8-0b7c-467f-88f4-f49ea03369a0", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEDf8lVpkXG4KAji+YG9gE83OgbDgKzH4/0GXulmrfV4uNIf60XPdKJEK1CDhoBwPfQ==", null, false, "f356ba49-1281-481d-9835-7592ad69bfe2", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("143f9732-2315-4130-a403-b904ea2d75d9"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("801ad93a-7e60-4669-bae6-80a5842e4e51"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("ab0b83eb-add9-42bb-a578-9fed56011775"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("18de705c-a385-4fc3-8c4f-e1dc8d4503b1"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("30dfcce0-6546-4eec-a2da-12181abfbf21"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("38e7a5c7-7490-439e-add4-cb4d885653b8"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("b2a8fa3e-ff05-4270-a9de-56867e847619"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }
    }
}
