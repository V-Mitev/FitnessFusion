#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateTrainingPlanEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "SetsAndReps",
                table: "TrainingPlans");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingPlans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingPlans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "SetsAndReps",
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
    }
}
