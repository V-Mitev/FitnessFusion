#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

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
                values: new object[] { "f9899fdc-3727-420a-9537-51d09f5d9b09", "AQAAAAEAACcQAAAAEJV0VfbPfal+C+gOqySlmoCnddE6kxIXuCYJVu5TWSEwAXonAM2qYM70ZV5iVK3l0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adf875c4-7e48-4ac1-850d-85735a81ef7f", "AQAAAAEAACcQAAAAEGXxBCRRdnE+QnW+JI8zaaUvMrZ0I0JTOCECt8FSKco2gvcQ+YOlrwlHO03ij+4HfA==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("05dedb58-0fca-480a-9a27-ced130aaf85d"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("893cf870-d243-49c2-9ee4-491f5fcffc5a"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("c655c316-1fc5-4687-80ff-5333bcbb5aa1"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("3035ab13-9f6a-49bb-8652-3cda29df512d"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("8ea6c2b1-ca97-47c8-9f22-fd616e7a31ce"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("97d2029a-d397-4f7b-9d77-a44922bc98b5"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("aad09e22-eab2-421e-85c2-1a98d55ef164"), 300.0, "Egg.png", 2, "TestSnack" }
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
                keyValue: new Guid("05dedb58-0fca-480a-9a27-ced130aaf85d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("893cf870-d243-49c2-9ee4-491f5fcffc5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c655c316-1fc5-4687-80ff-5333bcbb5aa1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3035ab13-9f6a-49bb-8652-3cda29df512d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8ea6c2b1-ca97-47c8-9f22-fd616e7a31ce"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("97d2029a-d397-4f7b-9d77-a44922bc98b5"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("aad09e22-eab2-421e-85c2-1a98d55ef164"));

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
