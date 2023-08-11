#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddValidationsForSubscriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Subscriptions",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f34e9aa2-d8b0-40d2-bb4b-6b1df9b3ecaf"), 0, "d5527fd9-a68b-402b-91bc-863b7130d126", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAELwSmQQM7bEBy4KM5M+5aNPnRi/sCbLWNdsQCphTegNpAHNsm376At4shNBYtTBGKw==", null, false, "23b2176e-ba9e-4bc2-b01d-8c29e9739d50", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0f0de187-df2a-4530-a810-3516e3024ef2"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("12da1e21-ca27-4a9d-bf54-fdaa4ccef51f"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("c9c2e517-5585-4ae5-a2f6-fd852e3f0f03"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("73cb20f6-d377-4181-accc-c6c881cd07e8"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("773ecf45-c1a9-4ad4-aa15-12a2c4438ea3"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("aabccb7d-2728-486d-83ad-7319004406d7"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("e8b584fa-2210-4b54-9df4-a97aab88b430"), 300.0, "Egg.png", 3, "TestDinner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f34e9aa2-d8b0-40d2-bb4b-6b1df9b3ecaf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f0de187-df2a-4530-a810-3516e3024ef2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("12da1e21-ca27-4a9d-bf54-fdaa4ccef51f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c9c2e517-5585-4ae5-a2f6-fd852e3f0f03"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("73cb20f6-d377-4181-accc-c6c881cd07e8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("773ecf45-c1a9-4ad4-aa15-12a2c4438ea3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("aabccb7d-2728-486d-83ad-7319004406d7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e8b584fa-2210-4b54-9df4-a97aab88b430"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048);

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
    }
}
