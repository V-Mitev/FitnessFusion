#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddRangeAttributeForPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("315049a5-17a6-475a-93ad-ad03f478a7de"), 0, "b834c6c7-2ce9-46d8-a212-ee36b935b555", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEKLwMalHURYjNueFxhsRMs8F9AacIfjIl5TdMjF2QPDhTfE69PmKTrV7ZPaysaP6VA==", null, false, "c61c5bbd-d662-4856-b742-3ef373d52f2d", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("40f5c4c8-bc3d-4d35-832c-b83c5030acfd"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("61b9b845-e9fa-4af1-abd1-fb32fcbe3142"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("996fdfbb-6914-4b20-b7ac-a33538a44b99"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("046f3f12-68d3-41bb-8a92-56cb3ef78760"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("17eadaf8-7bb4-4e99-980c-ca2cb304d1ac"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("d6665c3c-7766-4b0c-9e1f-8612fdd054b8"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("e86c01fd-b809-4083-b7f9-be76fa0bf2b9"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("315049a5-17a6-475a-93ad-ad03f478a7de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40f5c4c8-bc3d-4d35-832c-b83c5030acfd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61b9b845-e9fa-4af1-abd1-fb32fcbe3142"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("996fdfbb-6914-4b20-b7ac-a33538a44b99"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("046f3f12-68d3-41bb-8a92-56cb3ef78760"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("17eadaf8-7bb4-4e99-980c-ca2cb304d1ac"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d6665c3c-7766-4b0c-9e1f-8612fdd054b8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e86c01fd-b809-4083-b7f9-be76fa0bf2b9"));

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
    }
}
