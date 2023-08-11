#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class RemovePeriodOfSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("103515da-dcc7-4f2b-9fe2-69f389305f73"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0c84e783-8782-4d02-b342-c5372f5113fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e041195-decd-4321-935a-48a9ad8bd03e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d25466f2-9431-4815-ac59-59ae7cbb8c66"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1ec8d8ad-c51d-4e42-abe9-6f0910eedc9a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5a2b6585-6870-44df-9fdc-b58c2b94b1bb"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("74454d6b-7959-40a2-b7fd-0c02e12adca5"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f5c8d54c-1018-4259-ac7e-39fdf87d59cc"));

            migrationBuilder.DropColumn(
                name: "PeriodOfSubscription",
                table: "Subscriptions");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PeriodOfSubscription",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("103515da-dcc7-4f2b-9fe2-69f389305f73"), 0, "8768176e-293c-49ad-bb3f-6f21f6e6b24a", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEHSw9goVdKYrfsGYl+7oQ1Q+Ih6dbgcAbCZDRMdTsd7uZ4G+gqihUh7zKvr3QND6+Q==", null, false, "3f80238e-3b1a-4ae7-880e-85f7d099ea80", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0c84e783-8782-4d02-b342-c5372f5113fc"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("0e041195-decd-4321-935a-48a9ad8bd03e"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("d25466f2-9431-4815-ac59-59ae7cbb8c66"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("1ec8d8ad-c51d-4e42-abe9-6f0910eedc9a"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("5a2b6585-6870-44df-9fdc-b58c2b94b1bb"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("74454d6b-7959-40a2-b7fd-0c02e12adca5"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("f5c8d54c-1018-4259-ac7e-39fdf87d59cc"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
