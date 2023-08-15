#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddDescriptionInTrainingPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10013d2e-84af-4de8-98b0-f8419e13fd1d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7953856b-a65c-4d98-a03e-77c231c72435"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2035af54-2b61-450a-b6cf-372c003fb988"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a1adf18-9749-4247-899d-ed662e6abe9e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("809780f0-cac2-40c5-a888-1fd47655d902"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("316d6125-b5a1-47c5-a92f-0f89e4c95c17"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a1155cbb-3af0-4847-8b21-cfb528394732"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("bf598483-c98c-4cd2-9337-fab4719c7fd2"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f2163d13-ae55-4fd5-9c25-cfb378d8d103"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TrainingPlans",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7fcd63eb-90e2-4745-9ca5-9ca4273cb353"), 0, "475eb7dd-073d-42db-bfcc-6631d538d5ec", null, "ApplicationUser", "admin@fitnessfusion.bg", false, null, "Admin", false, false, "Admin", false, null, "admin@fitnessfusion.bg", "admin@fitnessfusion.bg", "AQAAAAEAACcQAAAAEG1r5BM5zZ3LM22TS2lQ6rDCtrb2fvwW8tpa7mzGlmVHazmptZnveIuEXSmceVztXQ==", null, false, "71e43299-6a94-478d-b74b-020e7a86e68d", null, false, "admin@fitnessfusion.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d96a80dc-7496-4293-97ac-fe71cbe8478b"), 0, "f0182732-e195-49e6-80f5-0b35b6785154", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEHqgI+Cpy7JkdaJhugFlIkOhu2A9NKJOP5+JKssR/ea9M5WSXXEUCblOQebRWqQ2PA==", null, false, "2ef0c278-d1e0-4669-ba75-f4c3d3e65397", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("bdf83ef7-628b-48d3-928d-5a8c01f8dfa6"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("bf7f83cd-7c0e-46d8-8376-70ea1524a9a6"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("e8f0e517-0bb7-49c0-abe2-9643880847cc"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("9f9b26b8-e3c5-4516-af2f-46e8d1eff65c"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("ac796058-275b-498e-b4a4-ad4c14f5677d"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("d4c6ecdc-b3de-4e8b-a795-ccb8dbb4da1d"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("f372ffa7-5fdb-4763-97f1-50a837a20874"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7fcd63eb-90e2-4745-9ca5-9ca4273cb353"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d96a80dc-7496-4293-97ac-fe71cbe8478b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bdf83ef7-628b-48d3-928d-5a8c01f8dfa6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bf7f83cd-7c0e-46d8-8376-70ea1524a9a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8f0e517-0bb7-49c0-abe2-9643880847cc"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9f9b26b8-e3c5-4516-af2f-46e8d1eff65c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ac796058-275b-498e-b4a4-ad4c14f5677d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d4c6ecdc-b3de-4e8b-a795-ccb8dbb4da1d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f372ffa7-5fdb-4763-97f1-50a837a20874"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TrainingPlans");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("10013d2e-84af-4de8-98b0-f8419e13fd1d"), 0, "a2253044-0cd5-408f-8361-dca97151c440", null, "ApplicationUser", "admin@fitnessfusion.bg", false, null, "Admin", false, false, "Admin", false, null, "admin@fitnessfusion.bg", "admin@fitnessfusion.bg", "AQAAAAEAACcQAAAAECGFvOy54KFGPldkziHxbrx5xWOKI1F2qGYVxSQ9vi21tiSA5LlA5m7+sPJu8NRTYA==", null, false, "6b22a816-a08f-4716-a25c-d83c6b9cff75", null, false, "admin@fitnessfusion.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7953856b-a65c-4d98-a03e-77c231c72435"), 0, "4b650ebd-2d37-46fa-8b55-adf5fa7f6d86", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEBWwi/7IMWDdsIumWziz7WcCIPTo3B4lyEpmSbvsIN2eB0EPX6h6NN+A+XfvOQOvbA==", null, false, "ad14c658-6e68-495e-95e5-774f14192d64", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("2035af54-2b61-450a-b6cf-372c003fb988"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("6a1adf18-9749-4247-899d-ed662e6abe9e"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("809780f0-cac2-40c5-a888-1fd47655d902"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("316d6125-b5a1-47c5-a92f-0f89e4c95c17"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("a1155cbb-3af0-4847-8b21-cfb528394732"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("bf598483-c98c-4cd2-9337-fab4719c7fd2"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("f2163d13-ae55-4fd5-9c25-cfb378d8d103"), 300.0, "Egg.png", 3, "TestDinner" }
                });
        }
    }
}
