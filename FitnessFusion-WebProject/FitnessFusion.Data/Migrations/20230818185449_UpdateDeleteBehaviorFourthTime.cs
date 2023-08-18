#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDeleteBehaviorFourthTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6a559dfd-09a8-4558-882b-ddcca367f73a", "AQAAAAEAACcQAAAAEGTSW85PsTwLcx6xK9yMeYxeoHlGYhzIrLjXxhNzGTQsvzlnZ0KkcU9fxgvhv9b/gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "155369a4-16f6-4be6-b2bb-deeafadddf62", "AQAAAAEAACcQAAAAEJnNeGxgqk2am9E4UGPstY9RNrq/H4ilblbWi1qpf4KCiuq9XXrugVyK/ziZM9BGPg==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("1ec984cc-c656-409b-ac1f-37d4e85bd2a7"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("6fd6c813-c94d-4035-adf9-8142ab232869"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("ed2fa94d-9bd5-44ee-834f-3f40fa2375fd"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("1867a828-0742-4cc8-a2a3-77eafeeca7a9"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("4e90ab19-b673-418e-8e58-31d825256baf"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("57b27f2e-e298-4c09-b2b9-25aa38feec3f"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("efe596fb-9cec-4450-8b64-39cc39c88039"), 300.0, "Egg.png", 2, "TestSnack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ec984cc-c656-409b-ac1f-37d4e85bd2a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6fd6c813-c94d-4035-adf9-8142ab232869"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed2fa94d-9bd5-44ee-834f-3f40fa2375fd"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1867a828-0742-4cc8-a2a3-77eafeeca7a9"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("4e90ab19-b673-418e-8e58-31d825256baf"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("57b27f2e-e298-4c09-b2b9-25aa38feec3f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("efe596fb-9cec-4450-8b64-39cc39c88039"));

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
    }
}
