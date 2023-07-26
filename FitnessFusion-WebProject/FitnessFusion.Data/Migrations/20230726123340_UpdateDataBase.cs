using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0805a02-9106-4577-934b-0648491589c3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1fb1d071-4975-479e-a952-e568fa6fdb07"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5cd2a1d8-13c6-4d8d-83b2-8bc70d14e898"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df46c6b2-7a10-41d5-9a14-6f3d5070594a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("384d61e1-8af2-4107-9700-51266d6831b1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("59c1d805-95c1-4bbe-bd2e-c9970a83170a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ea66020d-4f97-4e8d-8f68-37011399fdc1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("eddc30ab-e581-457c-867b-280f0eb1ddc6"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e267ed0d-45a1-41a4-811e-02f1dc93530a"), 0, "3254011a-a6e1-49b9-8869-ed69f9f6e5cb", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEFQiSGfRW5CZ2Vwkr1pVftg4wiJG0pmAyb74G8FejteReXmB+17UlEPBppv4v55l/A==", null, false, "b2fb3c65-6dc8-4907-9534-d82b7eaa266e", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("2835dd54-b15d-4398-92b5-67e80bc5360d"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("74e7f49e-dbfa-421d-ae81-0987d5a293aa"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("a487badf-1059-4199-bdaa-7f4c980fb301"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("53f96bbd-c3c2-49b3-9bb3-7e6cc4faf2ff"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("7fca4ebb-e581-44bc-9c70-5953b252aea3"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("86ac2d8b-8ccc-46e7-ba2d-508b7f005886"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("d4095fbc-ea4d-4011-b536-5cd1fe454791"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e267ed0d-45a1-41a4-811e-02f1dc93530a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2835dd54-b15d-4398-92b5-67e80bc5360d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74e7f49e-dbfa-421d-ae81-0987d5a293aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a487badf-1059-4199-bdaa-7f4c980fb301"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("53f96bbd-c3c2-49b3-9bb3-7e6cc4faf2ff"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7fca4ebb-e581-44bc-9c70-5953b252aea3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("86ac2d8b-8ccc-46e7-ba2d-508b7f005886"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d4095fbc-ea4d-4011-b536-5cd1fe454791"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d0805a02-9106-4577-934b-0648491589c3"), 0, "2c678da5-0966-4dfc-9a51-70b749906f48", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAELYMpFa6bQWirzgZInmMJqAmv5XoaDTUp1uaWGeQn7PGHbdiA6H9JEQfUyX/b0N6SA==", null, false, "04f56de6-f75c-4055-9bab-02f23933a341", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("1fb1d071-4975-479e-a952-e568fa6fdb07"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("5cd2a1d8-13c6-4d8d-83b2-8bc70d14e898"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("df46c6b2-7a10-41d5-9a14-6f3d5070594a"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("384d61e1-8af2-4107-9700-51266d6831b1"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("59c1d805-95c1-4bbe-bd2e-c9970a83170a"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("ea66020d-4f97-4e8d-8f68-37011399fdc1"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("eddc30ab-e581-457c-867b-280f0eb1ddc6"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
