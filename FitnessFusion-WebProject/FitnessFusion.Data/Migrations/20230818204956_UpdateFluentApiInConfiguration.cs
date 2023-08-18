#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateFluentApiInConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "92ac8ee4-aae8-4a92-8f4e-e2d8b6a4d650", "AQAAAAEAACcQAAAAENPcuNTQ4Av+SzTCxISA07gu1vGfNjO39wXujU90lBmmt0aJtNsdnBZkEaRNKOIKlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9450513-e900-4e04-8fa3-3063beb964c2", "AQAAAAEAACcQAAAAEMEW3fyE2kbwxUYft47G/9TqxRdIYRJ+UV0cRhWK2tp4ANRYm4/IJJ384r9VO6/47w==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("463b9139-a26f-48fb-92fa-f2ce27432872"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("8522731d-a98f-4994-9e9a-3b559c8aeabb"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("99e2c926-4d90-4612-8a67-def74eed6f87"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("096d0355-4392-4b7d-b2ef-4bafd94d54f8"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("31874f87-1e26-4280-8d4b-02e0867aab97"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("5d4dee4c-b5d2-4107-8426-178fe23410f7"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("f05156b7-a45c-4c0d-9777-8f53c34c38f6"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("463b9139-a26f-48fb-92fa-f2ce27432872"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8522731d-a98f-4994-9e9a-3b559c8aeabb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99e2c926-4d90-4612-8a67-def74eed6f87"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("096d0355-4392-4b7d-b2ef-4bafd94d54f8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("31874f87-1e26-4280-8d4b-02e0867aab97"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5d4dee4c-b5d2-4107-8426-178fe23410f7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f05156b7-a45c-4c0d-9777-8f53c34c38f6"));

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
    }
}
