#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDeleteBehaviorSecondTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ecdca66-642e-4dcc-9f4f-4e540fea940c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e9da4c76-0eb0-4041-b3f2-0eca43562350"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f8c36076-981e-4b27-bf6e-6108374c398e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("00f9b6cd-61e7-4925-a2a2-54d5a86a0e78"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("2f7db931-5db4-4ffc-bddf-b9e86a7cc34f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("55d7d5fa-8621-40ea-b2b9-03a47eb423eb"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d48fe873-78b0-406e-b7c0-0a3f3c7990a9"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8aeff07d-dc62-4d1a-94d9-8eaee13ed92f", "AQAAAAEAACcQAAAAEDPYNvKjhK7rE0BWgjaCt919n1HydAexDRUUC/DzlvADLxQjTJtgzQYEF/2OO21BjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c65d0441-2ad2-47b2-9de9-ad418aeb8cf4", "AQAAAAEAACcQAAAAEGwXfNRj+gulD4cQOhorFnAc5fbZExfFprSxHdDI+y2MEWqogmW+JN0z401tHBOW5Q==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("6ecdca66-642e-4dcc-9f4f-4e540fea940c"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("e9da4c76-0eb0-4041-b3f2-0eca43562350"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("f8c36076-981e-4b27-bf6e-6108374c398e"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("00f9b6cd-61e7-4925-a2a2-54d5a86a0e78"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("2f7db931-5db4-4ffc-bddf-b9e86a7cc34f"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("55d7d5fa-8621-40ea-b2b9-03a47eb423eb"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("d48fe873-78b0-406e-b7c0-0a3f3c7990a9"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }
    }
}
