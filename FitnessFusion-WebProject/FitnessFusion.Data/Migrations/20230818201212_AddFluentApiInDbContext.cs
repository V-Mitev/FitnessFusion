#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddFluentApiInDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88457738-8356-4f3c-a0a6-6cea8fcb599f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c78091eb-9716-4619-9528-a44fcb0418f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c83d4fba-c557-4fc6-a664-331a39594a34"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5b742346-df07-481d-809b-14ee5e59717e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("6f4d6f56-58f4-417e-a63c-3016efbe2046"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8fd64c5d-b6f1-44ff-b1ff-560118a42890"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("942b26f8-df84-448b-9f87-2479b2a37b9c"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ff03014-f1a0-42bd-821b-0d078aa03182", "AQAAAAEAACcQAAAAEEsZM6Qa4xvjtg41vxeiyRsbKYBRN7A/uWHF4dqDu5yydveCKSfaYp7PnBgEqgUsiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "010f8163-a358-431c-9791-74e8d14958f6", "AQAAAAEAACcQAAAAEBX+S5TSOEew+CJ56jKUm6Z3DyWBYc3LB5y5drwv/eyBv+cSNAVSLAikPFZTK094YQ==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("498cd104-c54b-4992-af32-ee68f29c1d29"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("a2f3fe73-5cc2-4878-bed7-7957882c9621"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("f130b05a-8745-4f73-9987-937aa5d6cb92"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("872acd9b-f430-4519-bbf9-6c10e3238428"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("cec7cbe1-64d0-479d-9df4-199ff6e0c628"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("de568054-a3ed-474d-906f-e7b253d926e7"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("e87b56eb-cc5a-4bdd-8f48-251a2edbee3a"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("498cd104-c54b-4992-af32-ee68f29c1d29"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2f3fe73-5cc2-4878-bed7-7957882c9621"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f130b05a-8745-4f73-9987-937aa5d6cb92"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("872acd9b-f430-4519-bbf9-6c10e3238428"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("cec7cbe1-64d0-479d-9df4-199ff6e0c628"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("de568054-a3ed-474d-906f-e7b253d926e7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e87b56eb-cc5a-4bdd-8f48-251a2edbee3a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3971b230-98ba-424d-9ce9-0ceda7992073", "AQAAAAEAACcQAAAAEBwvi0aRnxqEDUgj9lyIpCrTosG/1DNLU1oWjBjOLpswiVICPE0dopr4PIKjK/xejw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88ced886-56d7-4970-a7fc-7662d09ae5f4", "AQAAAAEAACcQAAAAEJGuR46V0LV1i/Xw0ZdLvoTeFX7Us7rR/Lc+HrgM1hEqshx8dkdcJDuFyHOnYBmn+Q==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("88457738-8356-4f3c-a0a6-6cea8fcb599f"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("c78091eb-9716-4619-9528-a44fcb0418f9"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("c83d4fba-c557-4fc6-a664-331a39594a34"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("5b742346-df07-481d-809b-14ee5e59717e"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("6f4d6f56-58f4-417e-a63c-3016efbe2046"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("8fd64c5d-b6f1-44ff-b1ff-560118a42890"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("942b26f8-df84-448b-9f87-2479b2a37b9c"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }
    }
}
