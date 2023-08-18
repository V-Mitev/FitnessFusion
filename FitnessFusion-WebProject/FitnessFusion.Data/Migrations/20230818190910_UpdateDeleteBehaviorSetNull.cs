#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDeleteBehaviorSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03264bd6-4757-4e80-b622-4d2d9aa5d6ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("917a7e5d-1c30-4f19-98b8-564f2083bd2e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dce1f387-16cf-4ee7-a7c5-e892a7f8c8b6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1bb8f410-11d8-4509-ba3e-193739d7e021"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("314c1c48-9c70-42ef-acfe-dfb3dec5fd3e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("943e1c9a-16ab-4885-a9f4-c1e9e36acb19"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("ab083c04-34ed-4d74-a242-f50ee6c4c5e2"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8dad6605-a144-4968-848f-e5da521bf984", "AQAAAAEAACcQAAAAEJPymepscb9cHeufo8HOhsxiDYPi1c1AEwpvdSWsi+Aqtcmi/PF/eXcr2zO0eogoJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "272bc7eb-5594-4fa5-985f-3a8395f9def5", "AQAAAAEAACcQAAAAEGPjhvdiW+27boAHetj5dw521CvtLh2W/F67HfrLzlIlLZh+kacJ1VKopjwWijwDIw==" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("03264bd6-4757-4e80-b622-4d2d9aa5d6ed"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("917a7e5d-1c30-4f19-98b8-564f2083bd2e"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", 1, "Pull Up", "https://youtu.be/poyr8KenUfc" },
                    { new Guid("dce1f387-16cf-4ee7-a7c5-e892a7f8c8b6"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", 2, "Squat", "https://youtu.be/MVMNk0HiTMg" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("1bb8f410-11d8-4509-ba3e-193739d7e021"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("314c1c48-9c70-42ef-acfe-dfb3dec5fd3e"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("943e1c9a-16ab-4885-a9f4-c1e9e36acb19"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("ab083c04-34ed-4d74-a242-f50ee6c4c5e2"), 300.0, "Egg.png", 3, "TestDinner" }
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
