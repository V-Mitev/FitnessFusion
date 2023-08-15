#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class SeedAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("48c369ed-9b17-4d78-90c7-fbb99ba6c15b"), 0, "bd9b4601-9e14-434c-82bc-ec3ac6ff150b", null, "ApplicationUser", "admin@fitnessfusion.bg", false, null, "Admin", false, false, "Admin", false, null, "admin@fitnessfusion.bg", "admin@fitnessfusion.bg", "AQAAAAEAACcQAAAAEGMCKQrI1BfGPAIOBU0gj5C4ynGxhJ21LqEgwlAqxMz+fHUnqGacVFZXRk3q6kE8tQ==", null, false, null, null, false, "admin@fitnessfusion.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("02d5b442-6d8f-4227-b642-679d4400dbf7"), 0, "377ac06d-a17d-417a-b275-37789891ac26", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEGjT2rcgOeSehxgzlhRRoDnqPq9D2tNVfx+1r4AIR6pY80E8dzZ8tBQzc9jmKKTtGQ==", null, false, "e14ee784-a8ae-43e1-8cf2-9d3a7498f96f", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("37a8e064-fef7-438a-ae3d-1e804b315b9a"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("4de661cd-e0c0-4a5d-9d5f-302f27402df7"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("ed5831d1-e52f-42e8-857a-3c17d124979e"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("03e482c0-f1a7-4801-b90e-d9c59e954a16"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("0a878ceb-9df8-45d8-96fd-bc086f80fe4d"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("a8d5386f-9c28-48b8-8575-7c55a814ed70"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("ae5be678-db07-442e-9f2e-d9772ac79e13"), 300.0, "Egg.png", 3, "TestDinner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("48c369ed-9b17-4d78-90c7-fbb99ba6c15b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("02d5b442-6d8f-4227-b642-679d4400dbf7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("37a8e064-fef7-438a-ae3d-1e804b315b9a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4de661cd-e0c0-4a5d-9d5f-302f27402df7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed5831d1-e52f-42e8-857a-3c17d124979e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("03e482c0-f1a7-4801-b90e-d9c59e954a16"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("0a878ceb-9df8-45d8-96fd-bc086f80fe4d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a8d5386f-9c28-48b8-8575-7c55a814ed70"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ae5be678-db07-442e-9f2e-d9772ac79e13"));

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
    }
}
