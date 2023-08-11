#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddStartAndEndDateSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("315049a5-17a6-475a-93ad-ad03f478a7de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40f5c4c8-bc3d-4d35-832c-b83c5030acfd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61b9b845-e9fa-4af1-abd1-fb32fcbe3142"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("996fdfbb-6914-4b20-b7ac-a33538a44b99"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("046f3f12-68d3-41bb-8a92-56cb3ef78760"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("17eadaf8-7bb4-4e99-980c-ca2cb304d1ac"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d6665c3c-7766-4b0c-9e1f-8612fdd054b8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e86c01fd-b809-4083-b7f9-be76fa0bf2b9"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSubscription",
                table: "Subscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSubscription",
                table: "Subscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EndSubscription",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "StartSubscription",
                table: "Subscriptions");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("315049a5-17a6-475a-93ad-ad03f478a7de"), 0, "b834c6c7-2ce9-46d8-a212-ee36b935b555", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEKLwMalHURYjNueFxhsRMs8F9AacIfjIl5TdMjF2QPDhTfE69PmKTrV7ZPaysaP6VA==", null, false, "c61c5bbd-d662-4856-b742-3ef373d52f2d", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("40f5c4c8-bc3d-4d35-832c-b83c5030acfd"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("61b9b845-e9fa-4af1-abd1-fb32fcbe3142"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("996fdfbb-6914-4b20-b7ac-a33538a44b99"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("046f3f12-68d3-41bb-8a92-56cb3ef78760"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("17eadaf8-7bb4-4e99-980c-ca2cb304d1ac"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("d6665c3c-7766-4b0c-9e1f-8612fdd054b8"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("e86c01fd-b809-4083-b7f9-be76fa0bf2b9"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }
    }
}
