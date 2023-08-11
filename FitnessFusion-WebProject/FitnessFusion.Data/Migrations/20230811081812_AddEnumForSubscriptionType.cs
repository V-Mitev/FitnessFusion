#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddEnumForSubscriptionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba89b212-8801-4a7a-a6f1-47265eb3d39c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38666953-a60d-4f20-a333-dbaf4ed3c0d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4cd080fb-f745-4aac-a30c-d7adffea0196"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71a41bad-f057-48d1-845a-1d9ce7111580"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("21e8f14a-9120-443d-af00-aea223755af6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("48336999-36a4-46f9-af9c-5571008a112f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("81a55fe0-7809-41c4-905f-67b07d62b26b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b5a9e945-8680-4bdf-816a-f81fe3c3990e"));

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfSubscription",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("65cf8762-0334-4344-b9ab-27278f13d724"), 0, "fb69fb2b-8ca2-41ee-b27d-c2009ef30fb3", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAENDyLfjslxxRmlly1UpWF7bPgigbPORc1p9JRJYifqn0SpWzL116R0uOrjFJmVlNKg==", null, false, "ed107c5d-d4e5-4c81-ab59-b10d12eb940e", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("6d93bc97-4b32-4808-82a2-7bcb7001c0ce"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("86478ae3-0a5b-473c-a4a9-7ad685cc6781"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("ef5a75c1-806f-469e-b7c7-b27aaaaabd3d"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("4bc30dfa-306b-463f-9f4c-f16eea0520c0"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("80e2137b-7249-49dd-9083-9e252c4c7b5c"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("9ab21929-7152-4fa0-a867-979b7b6b5039"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("ea8c2ba2-2be3-495a-92f8-666509a83494"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65cf8762-0334-4344-b9ab-27278f13d724"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d93bc97-4b32-4808-82a2-7bcb7001c0ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86478ae3-0a5b-473c-a4a9-7ad685cc6781"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ef5a75c1-806f-469e-b7c7-b27aaaaabd3d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4bc30dfa-306b-463f-9f4c-f16eea0520c0"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("80e2137b-7249-49dd-9083-9e252c4c7b5c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9ab21929-7152-4fa0-a867-979b7b6b5039"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ea8c2ba2-2be3-495a-92f8-666509a83494"));

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfSubscription",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ba89b212-8801-4a7a-a6f1-47265eb3d39c"), 0, "53442b23-cc61-452f-944c-c5e9a92e6b83", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEHF6ZdqMPphEwdTv+oR9JX+J+h/s6ZA0153ILhhCUH7sB98vDR9AFW9SZhXRAi8Gmw==", null, false, "5b43efdd-4715-4283-871b-5b7f6ec69b58", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("38666953-a60d-4f20-a333-dbaf4ed3c0d2"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("4cd080fb-f745-4aac-a30c-d7adffea0196"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("71a41bad-f057-48d1-845a-1d9ce7111580"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("21e8f14a-9120-443d-af00-aea223755af6"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("48336999-36a4-46f9-af9c-5571008a112f"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("81a55fe0-7809-41c4-905f-67b07d62b26b"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("b5a9e945-8680-4bdf-816a-f81fe3c3990e"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }
    }
}
