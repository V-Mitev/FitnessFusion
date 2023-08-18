using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateFluentApiInConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

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
                values: new object[] { "63c785cf-d2f0-45d2-a611-769b0a94013e", "AQAAAAEAACcQAAAAEC4xlYewDk9dRmAI0AS3JpdCi7knjROQ6ECv72JoIkWRh6s0qHQj2iURzgDcm2h3tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6216ba67-67b3-47c0-909d-a8c357319af7", "AQAAAAEAACcQAAAAEJcWsDSRhViY20iPCU+kTb9M8GUQ9jFSaDOPizzxs6grHtiSQrWZHUrIS8/dEcFdLw==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("2087ead7-95a9-45ce-a47e-d903c39093d9"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("2a46fb7c-2d5a-4a9b-97ad-f0e2225558d2"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("ea4aff8b-a728-4441-af50-58d0302557c0"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("0a3f06f9-f43c-414f-a8bb-f6e56d99527a"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("8608e1d2-5731-4ee9-ba08-2d71c7dc8c5b"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("9dd98d61-a3e6-4cfb-8b77-902a662e6cc0"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("c86b772e-798d-48a7-a451-9486b4dee150"), 300.0, "Egg.png", 2, "TestSnack" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2087ead7-95a9-45ce-a47e-d903c39093d9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a46fb7c-2d5a-4a9b-97ad-f0e2225558d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea4aff8b-a728-4441-af50-58d0302557c0"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("0a3f06f9-f43c-414f-a8bb-f6e56d99527a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8608e1d2-5731-4ee9-ba08-2d71c7dc8c5b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9dd98d61-a3e6-4cfb-8b77-902a662e6cc0"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c86b772e-798d-48a7-a451-9486b4dee150"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }
    }
}
