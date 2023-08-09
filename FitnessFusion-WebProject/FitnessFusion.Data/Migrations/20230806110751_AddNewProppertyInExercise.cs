#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddNewProppertyInExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsInPlan",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b1f7ad8d-1c95-4587-9a3e-3cddf93416f0"), 0, "ca385429-2650-45a4-a081-19417b188f63", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEAPs8+1CyK9nyu354O2Xekdrj12+sk28EjT7uH7jUayr2MFGTnI1jFiO55kj3zIuGg==", null, false, "1ad5bde4-271b-407a-b019-d7aa0109d29d", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("2b4ecd91-c71a-40ba-92e9-b5715f86abc8"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("e92aa024-9760-4f1b-a177-22d9599ce847"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("f9dbdaa7-9651-453b-bee6-b3418b73187d"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("00803aff-4d54-4b1a-b49c-59ceaac29c1a"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("570eec53-4026-4897-bec0-340e47eacad8"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("68f49beb-4e34-41bf-9814-da2d23e88735"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("ad246842-9c89-408c-a495-feb4567dcd0d"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1f7ad8d-1c95-4587-9a3e-3cddf93416f0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b4ecd91-c71a-40ba-92e9-b5715f86abc8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e92aa024-9760-4f1b-a177-22d9599ce847"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9dbdaa7-9651-453b-bee6-b3418b73187d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("00803aff-4d54-4b1a-b49c-59ceaac29c1a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("570eec53-4026-4897-bec0-340e47eacad8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("68f49beb-4e34-41bf-9814-da2d23e88735"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ad246842-9c89-408c-a495-feb4567dcd0d"));

            migrationBuilder.DropColumn(
                name: "IsInPlan",
                table: "Exercises");

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
    }
}
