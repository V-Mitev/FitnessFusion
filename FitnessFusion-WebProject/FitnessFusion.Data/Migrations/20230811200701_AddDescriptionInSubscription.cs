#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;

    public partial class AddDescriptionInSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e590c02-508d-458e-9e9f-f98f30343531"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("350b56a8-4d6b-471d-8d96-c7b6640ea79a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d12dec1-64df-4857-8a3a-c8de70b80c87"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d72982d4-1415-4f2b-a3a3-f4177277cc4a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("230a610a-81ca-4842-9c1a-7355cf063ffd"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("46a52474-0a59-4da8-843d-72cdc5321ebd"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b5398bc9-dd00-4be2-b218-2d3918de1489"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d725f539-acff-4b79-864b-454b3c0c40e3"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subscriptions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c22cd981-e871-4be1-93bd-b83c50ed9cc1"), 0, "1957c691-602b-4431-9fe6-5b961c62820b", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEL+GSWTqgxuh/F+FA0IfOf4vXxKNeNynmTngYEGxGt2kz8gKmVnA8brPd7hNNuprTQ==", null, false, "b1758ef8-d9fc-4ebe-a149-678bbcbcea0c", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("51b1a4aa-2785-4f44-b8df-d6d46726b924"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("b9f21fbc-9810-4fba-a9d5-694e34046bb1"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("e25000d6-a2b3-4bc2-8eeb-9349164a59ed"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("25b99704-a285-4b58-8c48-9db6d3b43ba0"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("5425f1c8-bd0c-4ccb-a5a7-f4642d724950"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("bfc6e29d-f05a-4813-8e83-d896415a4b2c"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("efe64846-ab16-45cb-b99e-2121dac9ac33"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c22cd981-e871-4be1-93bd-b83c50ed9cc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("51b1a4aa-2785-4f44-b8df-d6d46726b924"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9f21fbc-9810-4fba-a9d5-694e34046bb1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e25000d6-a2b3-4bc2-8eeb-9349164a59ed"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("25b99704-a285-4b58-8c48-9db6d3b43ba0"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5425f1c8-bd0c-4ccb-a5a7-f4642d724950"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("bfc6e29d-f05a-4813-8e83-d896415a4b2c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("efe64846-ab16-45cb-b99e-2121dac9ac33"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subscriptions");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6e590c02-508d-458e-9e9f-f98f30343531"), 0, "7acd849a-8555-4737-81dd-3f5ae3186e8e", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEJ5VPhI1CmqZCSVFpMP8tgZboYUgGmjPU+0Ftb8Z+YoDBq62m/cAI18u52eS7j33HQ==", null, false, "a1db93a4-f54a-4356-b1eb-fade59e9c394", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("350b56a8-4d6b-471d-8d96-c7b6640ea79a"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("5d12dec1-64df-4857-8a3a-c8de70b80c87"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("d72982d4-1415-4f2b-a3a3-f4177277cc4a"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("230a610a-81ca-4842-9c1a-7355cf063ffd"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("46a52474-0a59-4da8-843d-72cdc5321ebd"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("b5398bc9-dd00-4be2-b218-2d3918de1489"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("d725f539-acff-4b79-864b-454b3c0c40e3"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
