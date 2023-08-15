#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditTrainerAndAdministratorProblemWithId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"), 0, "c3d7284e-9a00-45e0-97e4-1c851b83bec7", null, "ApplicationUser", "admin@fitnessfusion.bg", false, null, "Admin", false, false, "Admin", false, null, "admin@fitnessfusion.bg", "admin@fitnessfusion.bg", "AQAAAAEAACcQAAAAEIv1J3GPfMTviGzJQPCIgeyGEBZ5YriV1S5Z/EycL8yZC5Ez9hcu90kw6/Ja/SILOQ==", null, false, "4086a2a8-4ccc-430e-916b-ceda5be3ab94", null, false, "admin@fitnessfusion.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"), 0, "3753c1d5-4924-4509-a32a-c916102ff37f", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, null, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEJkpbKWzytj/E18qB+1nLNTTL76p8d/WvXF7Tj0bRBvxupy2ofYLRspecNQ4a39jjA==", null, false, "f321b542-d4d0-4eb0-afa7-38e09e666a92", null, false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("7910e48c-2a98-444b-97a7-1bf4c751e7ec"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("93aa2d45-f745-4c6a-9438-9096a9e0bd9c"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("b56870f8-6e59-4a50-a7d8-7c6b1f82af44"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("036f080e-ac5a-4908-a984-dcf942b10b11"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("3999e051-9305-42fe-a9f8-087e4b6112ab"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("44ce375c-e3a9-420d-aa16-b23f6e9b34ac"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("c85d7c08-e1aa-42d5-b923-a7235f582966"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7910e48c-2a98-444b-97a7-1bf4c751e7ec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93aa2d45-f745-4c6a-9438-9096a9e0bd9c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b56870f8-6e59-4a50-a7d8-7c6b1f82af44"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("036f080e-ac5a-4908-a984-dcf942b10b11"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3999e051-9305-42fe-a9f8-087e4b6112ab"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("44ce375c-e3a9-420d-aa16-b23f6e9b34ac"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c85d7c08-e1aa-42d5-b923-a7235f582966"));

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
    }
}
