#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7f1fa49b-712d-4a7d-a022-4cdafd197ec5"), 0, "26ba411d-a417-42df-9fdd-6eec3aa8b1f8", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", false, null, null, null, "AQAAAAEAACcQAAAAEBh3wD3IOUDvxCbD4p/mn60DbWNoVsGKtJBBvNpoGQrKbEIXsFvlIAS3SqsaKzYsqw==", null, false, "f9847ba1-799a-4372-9cd4-06e057c91db6", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("b13c0472-9284-4ae4-9a9c-8377557ccf18"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("d7419043-f9ae-42e4-8889-3dd934f0e428"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("e7c629f1-db6f-4524-9eba-1b4db3f1befb"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("39e36425-920c-4e87-98b0-932eeb7cb380"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("7788d4a0-a159-4b87-b704-32f1f7c9bb96"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("a02af202-21a7-40cb-966f-7cfa95beb6d7"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("aa00d72d-e86c-46a8-954e-002c59004737"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7f1fa49b-712d-4a7d-a022-4cdafd197ec5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b13c0472-9284-4ae4-9a9c-8377557ccf18"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d7419043-f9ae-42e4-8889-3dd934f0e428"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7c629f1-db6f-4524-9eba-1b4db3f1befb"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("39e36425-920c-4e87-98b0-932eeb7cb380"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7788d4a0-a159-4b87-b704-32f1f7c9bb96"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a02af202-21a7-40cb-966f-7cfa95beb6d7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("aa00d72d-e86c-46a8-954e-002c59004737"));

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
    }
}
