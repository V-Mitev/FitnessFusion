#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditTrainingPlanAndSeedTestTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("06bc952c-75a0-4fa2-a004-123c6b98000f"), 0, "9f5e1b24-3434-40e8-9c39-7e2e131b5727", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", false, null, null, null, "AQAAAAEAACcQAAAAEPhh0pr831mLCefuSmLpO1vo18sVbiOgLcYVO9MZA/tO5tJDSf7TjXu1WfRX55DdQQ==", null, false, null, false, null });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("2385a59d-524b-478e-a26d-041052107d91"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("26151384-8d77-4197-8841-744957dfb758"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("96db6580-9bb1-4da1-9719-b05fa8b3a901"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("42a01ea8-4f3c-4e84-8b7c-1834c0450f8f"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("4c4d9f1a-e7c0-4630-8ee5-e5d1da1008ef"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("c991d8c8-382b-4f1b-9694-6ab9122affc2"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("e8b8609c-5f56-4004-a556-26ec18c0d2f5"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06bc952c-75a0-4fa2-a004-123c6b98000f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2385a59d-524b-478e-a26d-041052107d91"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26151384-8d77-4197-8841-744957dfb758"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("96db6580-9bb1-4da1-9719-b05fa8b3a901"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("42a01ea8-4f3c-4e84-8b7c-1834c0450f8f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4c4d9f1a-e7c0-4630-8ee5-e5d1da1008ef"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c991d8c8-382b-4f1b-9694-6ab9122affc2"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e8b8609c-5f56-4004-a556-26ec18c0d2f5"));

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
    }
}
