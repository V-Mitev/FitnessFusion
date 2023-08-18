using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class AddFluentApiInConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0f820049-0aa0-41bd-90e6-283b870af2d3", "AQAAAAEAACcQAAAAEM+8WZHuJvEg1J65g3yyLYml/yVppH2yA4yNu3u1xNGozM0YE4rii2WmwTrm3I6MQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "368ec2a0-f001-4ac8-ba09-2857966aad22", "AQAAAAEAACcQAAAAEDUvAdk1DyMzE2kNbLmGBkIuKu+PTM583XSIYUxUZhDlsvpxxkShjNS/T3O//a6Q2A==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("421616a9-2c4b-4a9b-b532-9ff4d243f985"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("b747f922-ad90-459a-a10a-e4c39912a519"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("d2e590aa-f9c8-4532-8fdc-80de65261010"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("23fa4d36-5893-4408-b086-9ee61bce70a9"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("3f1ba6fc-98da-4b3e-acd3-7fd217f4b506"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("ca5809a1-cbca-4ed8-8d96-4ab49de3b2c2"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("e495cca8-d4e1-4df1-a303-857d55105bdb"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("421616a9-2c4b-4a9b-b532-9ff4d243f985"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b747f922-ad90-459a-a10a-e4c39912a519"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d2e590aa-f9c8-4532-8fdc-80de65261010"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("23fa4d36-5893-4408-b086-9ee61bce70a9"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3f1ba6fc-98da-4b3e-acd3-7fd217f4b506"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ca5809a1-cbca-4ed8-8d96-4ab49de3b2c2"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e495cca8-d4e1-4df1-a303-857d55105bdb"));

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
    }
}
