using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateTrainingPlans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("440b0161-ab08-46e8-81a8-4ab2eb5cb78b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35edb32e-eaee-4cd2-8897-a2922651a85c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5fc7a99c-189e-4fa0-b82d-318d920dc42d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("62dbe262-b304-4e8a-89b7-c555c5bfafe6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("009c900d-7e07-44e1-b2ce-33785925ea9b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5ee13ecc-7b1b-4ace-8d59-de4633d4e53f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8659d195-2059-4e6d-abdf-9c1df4bb573e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8848407f-e9c1-4392-90a7-0de82232c08e"));

            migrationBuilder.RenameColumn(
                name: "DescriptionОfЕxercises",
                table: "TrainingPlans",
                newName: "SetsAndReps");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "TrainingPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("700f34ac-4a8a-4e79-9d5a-222d79b43e23"), 0, "c382a6b2-69b5-4ff7-8e36-fa8d36a48b51", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEK52fOrSU2OqQR0SV8bOTQwaKlcAYEFRc1Dp2f2GI1lLtSlZLVMrCTKupk2EWMbFWA==", null, false, "2b24e073-82a3-49ef-b828-9e0924f4c0d0", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("b02a84df-0639-447a-bf3c-443cb1d61069"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("bf5d1dbf-2d64-4f6a-949e-ae574689d201"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("e05746a9-cf3c-4da7-9854-dd03eaf3c071"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("1051245a-fed1-41c2-9afe-80e4829eaba7"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("1a8ff083-bc34-4fd7-b3cb-7331797866a6"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("27602b6c-dcc0-4c96-8dba-31f45d3fa3d1"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("e092dd15-80f7-466a-b4cf-1ade0b715b7e"), 300.0, "Egg.png", 3, "TestDinner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("700f34ac-4a8a-4e79-9d5a-222d79b43e23"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b02a84df-0639-447a-bf3c-443cb1d61069"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bf5d1dbf-2d64-4f6a-949e-ae574689d201"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e05746a9-cf3c-4da7-9854-dd03eaf3c071"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1051245a-fed1-41c2-9afe-80e4829eaba7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1a8ff083-bc34-4fd7-b3cb-7331797866a6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("27602b6c-dcc0-4c96-8dba-31f45d3fa3d1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e092dd15-80f7-466a-b4cf-1ade0b715b7e"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "TrainingPlans");

            migrationBuilder.RenameColumn(
                name: "SetsAndReps",
                table: "TrainingPlans",
                newName: "DescriptionОfЕxercises");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImgUrl", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("440b0161-ab08-46e8-81a8-4ab2eb5cb78b"), 0, "830c4441-d0d9-4391-bafd-ba3f03957400", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", null, true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEO3P3v6O1sBgzgDDfsuMqwtnvHdL6j5XsRgPjpmavs/vfGnlrSOrsygy2exKvTcSlA==", null, false, "76430fef-5cef-47b6-94ae-89788c41f654", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("35edb32e-eaee-4cd2-8897-a2922651a85c"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("5fc7a99c-189e-4fa0-b82d-318d920dc42d"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("62dbe262-b304-4e8a-89b7-c555c5bfafe6"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("009c900d-7e07-44e1-b2ce-33785925ea9b"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("5ee13ecc-7b1b-4ace-8d59-de4633d4e53f"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("8659d195-2059-4e6d-abdf-9c1df4bb573e"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("8848407f-e9c1-4392-90a7-0de82232c08e"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
