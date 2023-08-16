#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditRelationBetweenUserAndSubOnDeleteBehaviourNoAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3fe4514f-f772-4491-af1e-02165b7af9a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6eb428f7-d7e3-4a7f-ad50-05004e49611b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dea182ff-973f-4b78-902a-70414f4f997b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("6c392ee1-b651-470a-a5f4-f9a98ad319a1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7a38068d-8cb6-458b-9906-5a09fded0cf5"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7e906067-ca50-4f97-9df6-f1ae07c8070c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("947cf4a1-11e8-400a-98ad-a3f2dac6ed6e"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "021ccbeb-556f-4aea-8c7b-67e65cce338e", "AQAAAAEAACcQAAAAELhNx6lmdehB+gG7UbM9cfVS5CggS4yHlKncL1frfjVCr0AhqyRHg1meGZeXQvpOlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df5a2cef-4998-4e75-8441-4a1cbe42f0fa", "AQAAAAEAACcQAAAAEDMUNze8+cFg9AmTw733GvjFrcx8wxqa9xujMA9oCiVELoveskkCtW+c5kjH6GD5gg==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0129419c-cf94-4665-abeb-6bc760113764"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("091fe7ba-40ea-4b85-9f86-d9d93fdb50a1"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("a91942e6-2c67-483f-ad9b-d5663f23a88a"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("45a2fbc5-624e-47b7-bbb3-0132951dd302"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("c1f0f031-b8c3-4b74-b450-830da5b016bf"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("e0a37db6-dca7-4ef6-8b6c-5f611c017571"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("f4096306-7819-4b25-8705-c3a5669aecc1"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0129419c-cf94-4665-abeb-6bc760113764"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("091fe7ba-40ea-4b85-9f86-d9d93fdb50a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a91942e6-2c67-483f-ad9b-d5663f23a88a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("45a2fbc5-624e-47b7-bbb3-0132951dd302"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c1f0f031-b8c3-4b74-b450-830da5b016bf"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e0a37db6-dca7-4ef6-8b6c-5f611c017571"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f4096306-7819-4b25-8705-c3a5669aecc1"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a261c776-c934-4545-aba5-a6fcd77104bc", "AQAAAAEAACcQAAAAEOPoeseqZBKeJz+kHcdfeqms2Ybvpr0NIAP394j3GDdQasf+JDrjvR80dRGW4fG4Rg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c2a0753-2f08-4d0a-a96f-0b1ea3fbba29", "AQAAAAEAACcQAAAAEMKvKYNVdzbd/uQxiqJJz5usn8bMk/vjmAPrTmiF/ac58B2I7AMfRm5ectLNCcuQOQ==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("3fe4514f-f772-4491-af1e-02165b7af9a7"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("6eb428f7-d7e3-4a7f-ad50-05004e49611b"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("dea182ff-973f-4b78-902a-70414f4f997b"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("6c392ee1-b651-470a-a5f4-f9a98ad319a1"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("7a38068d-8cb6-458b-9906-5a09fded0cf5"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("7e906067-ca50-4f97-9df6-f1ae07c8070c"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("947cf4a1-11e8-400a-98ad-a3f2dac6ed6e"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }
    }
}
