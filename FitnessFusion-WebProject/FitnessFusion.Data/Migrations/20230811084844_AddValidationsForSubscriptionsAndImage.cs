#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddValidationsForSubscriptionsAndImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "Subscriptions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("92558e8b-29eb-4924-870a-45dc7e907195"), 0, "9eca46cb-a12e-4f16-add9-da18d5fd161e", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEI0eudn64vguwBARX8wiQHIuPyj17btZh/GIpC5bGoRp74F2Vnqn/SCvLSEQ97lOcA==", null, false, "028a9dfc-0558-45ad-a446-acc05d9a1edc", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("95abff3d-4d84-43ad-ae33-ca0fce0c14ea"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("cd2e709a-9207-469d-8c3f-4ab08bc2e18b"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("db2004c2-e0f9-41bc-a8a3-b30e288f1847"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("88f9527f-c5f3-43af-9a05-f13ed94a93b4"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("a0039640-c069-4613-bf41-f6625b2cb130"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("a6b899e9-7290-47a0-9ff0-e4766fd3c327"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("fb23286d-8249-4eaa-abfa-5d3c5f45d2d9"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("92558e8b-29eb-4924-870a-45dc7e907195"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95abff3d-4d84-43ad-ae33-ca0fce0c14ea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd2e709a-9207-469d-8c3f-4ab08bc2e18b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("db2004c2-e0f9-41bc-a8a3-b30e288f1847"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("88f9527f-c5f3-43af-9a05-f13ed94a93b4"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a0039640-c069-4613-bf41-f6625b2cb130"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a6b899e9-7290-47a0-9ff0-e4766fd3c327"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("fb23286d-8249-4eaa-abfa-5d3c5f45d2d9"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
