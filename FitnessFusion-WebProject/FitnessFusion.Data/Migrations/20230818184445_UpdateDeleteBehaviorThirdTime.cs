#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDeleteBehaviorThirdTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("01f20cf1-db18-4546-8e16-6a0352f78130"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26043c5f-1716-4a9b-a156-fc6c2d66c88d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("78173962-582d-4ded-b174-26f543ddf991"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3ad1f9a0-3574-495b-a9f2-11cbae780709"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4f4171e3-cf55-4fdd-ba0a-2efa3f006eeb"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("621ca9cc-306e-4516-bae0-80cef0b1f7a2"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("79e74578-a7e0-4746-9831-741a46c159a1"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e0c5993-f23c-4d13-8ba8-89ec16336baf", "AQAAAAEAACcQAAAAEBb9UWgfHS8UTbvpE/ygF03TSsMsOfZyjSaXWu2TZttrR6xAY9+oVvteVVsHTPK84g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3d52024-e761-4173-88a4-fbbbf78dbf5e", "AQAAAAEAACcQAAAAEEt0MVSvbBpmkS0Sp4tChuwGs4oGt69Q8iZmBR6bIpIyOUvexJlNp1UMSEzKxmWFNA==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0dcccf0c-ddb1-4ff8-b779-e3179bc657f4"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("19edd99f-1bca-4548-866e-451ed5ce9a34"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("a68b623f-1502-41fc-9186-45024b6af8f8"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("219835ec-956e-42b6-b086-3b193e8aff19"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("8eb897e4-59e0-4e69-8360-25f51e12e687"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("98c0cff9-b03e-4d57-8f41-b801859a8d6e"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("ac5d159e-b279-46cb-bc3c-07b4c455f31b"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0dcccf0c-ddb1-4ff8-b779-e3179bc657f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19edd99f-1bca-4548-866e-451ed5ce9a34"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a68b623f-1502-41fc-9186-45024b6af8f8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("219835ec-956e-42b6-b086-3b193e8aff19"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8eb897e4-59e0-4e69-8360-25f51e12e687"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("98c0cff9-b03e-4d57-8f41-b801859a8d6e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ac5d159e-b279-46cb-bc3c-07b4c455f31b"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "828e4cf1-6e87-42f0-99e2-da5ceea702d8", "AQAAAAEAACcQAAAAEIDIZDl0F3k+cXlr2YWcfLzGM3sVDBa1u5cyq18pyPqP7jS/2WQfCZs017ICHQYm4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f2383a1-1acf-4b91-8dc0-e864660a2472", "AQAAAAEAACcQAAAAELFdPBesdO3ag82VByDY2+RjFnhLMjQpCVLpor0ZiYVzVpKL9JaI1Q4FEW2raqZU6w==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("01f20cf1-db18-4546-8e16-6a0352f78130"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("26043c5f-1716-4a9b-a156-fc6c2d66c88d"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("78173962-582d-4ded-b174-26f543ddf991"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("3ad1f9a0-3574-495b-a9f2-11cbae780709"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("4f4171e3-cf55-4fdd-ba0a-2efa3f006eeb"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("621ca9cc-306e-4516-bae0-80cef0b1f7a2"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("79e74578-a7e0-4746-9831-741a46c159a1"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }
    }
}
