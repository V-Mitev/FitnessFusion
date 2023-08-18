using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("338a6eb6-d927-475d-bef9-be1f7303a4e0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("70ebfef9-0c36-436a-b7fd-b2bd663bee8d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b402a0f2-fdb7-4c1e-903c-9b7341f55ff6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("6a8de4b7-1bec-4456-9b00-be98d7cedc75"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("8b653e0f-ea03-46d5-a0bb-9204adc5a375"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b70bf830-7e88-4c51-b7cd-fae5e27f999f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f4c74ced-41d0-4694-bc87-e0eb39ac1419"));

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
                values: new object[] { "0933f7a5-3e13-49c5-b666-d985944d7ebb", "AQAAAAEAACcQAAAAEBXPA63zyklhcISzivHOplzjBycF0b2ypUpAQEvINzIWynUiQz1WUE0jb59ATdKAVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57688613-27dd-415b-a0db-3f8aab38f2d8", "AQAAAAEAACcQAAAAEL2NumtXShMt3/yrSHmbFuPj4jsXq0Kb03n2CFvJTaKrt8vsf3wJHPB4ve8/3bOjLQ==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("338a6eb6-d927-475d-bef9-be1f7303a4e0"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("70ebfef9-0c36-436a-b7fd-b2bd663bee8d"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("b402a0f2-fdb7-4c1e-903c-9b7341f55ff6"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("6a8de4b7-1bec-4456-9b00-be98d7cedc75"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("8b653e0f-ea03-46d5-a0bb-9204adc5a375"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("b70bf830-7e88-4c51-b7cd-fae5e27f999f"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("f4c74ced-41d0-4694-bc87-e0eb39ac1419"), 300.0, "Egg.png", 3, "TestDinner" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
