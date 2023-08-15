#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddSecurityStampToAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
