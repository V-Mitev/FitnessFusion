#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDeleteBehaviorForUsersAndSubscriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
