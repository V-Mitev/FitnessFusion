#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddToApplicationUserStartAndEndDateOfSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c22cd981-e871-4be1-93bd-b83c50ed9cc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("51b1a4aa-2785-4f44-b8df-d6d46726b924"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9f21fbc-9810-4fba-a9d5-694e34046bb1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e25000d6-a2b3-4bc2-8eeb-9349164a59ed"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("25b99704-a285-4b58-8c48-9db6d3b43ba0"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5425f1c8-bd0c-4ccb-a5a7-f4642d724950"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("bfc6e29d-f05a-4813-8e83-d896415a4b2c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("efe64846-ab16-45cb-b99e-2121dac9ac33"));

            migrationBuilder.DropColumn(
                name: "EndSubscription",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "StartSubscription",
                table: "Subscriptions");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSubscription",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSubscription",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "EndSubscription", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartSubscription", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f1236a0f-4308-4909-b397-5bd26b65dc34"), 0, "d948cd48-361b-42c2-974b-e80ee510e6b8", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEL95hbXxIA1ijZYrgSsFU+u1mrZ5V1zM6P17CKcBrypk2D3uhTM9Y4sq65YlBb9Gew==", null, false, "4a3a7144-1725-4f72-acdc-3add9156b06c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("5ef42aad-a7bb-447e-b55e-37a21ce191e6"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("6fc4e44a-c186-478e-8db2-67b5331b5edd"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("c7dcc0d3-dcc4-4bea-b168-3265420a0bba"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("20b6c7d7-7fb4-4a48-9be2-b29d38a28abe"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("43029a30-f1a1-4276-8ec1-b50a04f1245f"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("6f49aad0-fa8e-4190-8de5-cb601ea3bc6e"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("dcbf45c6-3eb9-4e5d-af50-09c56ecf1d9f"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1236a0f-4308-4909-b397-5bd26b65dc34"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ef42aad-a7bb-447e-b55e-37a21ce191e6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6fc4e44a-c186-478e-8db2-67b5331b5edd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c7dcc0d3-dcc4-4bea-b168-3265420a0bba"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("20b6c7d7-7fb4-4a48-9be2-b29d38a28abe"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("43029a30-f1a1-4276-8ec1-b50a04f1245f"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("6f49aad0-fa8e-4190-8de5-cb601ea3bc6e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("dcbf45c6-3eb9-4e5d-af50-09c56ecf1d9f"));

            migrationBuilder.DropColumn(
                name: "EndSubscription",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StartSubscription",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSubscription",
                table: "Subscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSubscription",
                table: "Subscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CurrentCaloriesGoal", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscribeValid", "IsTrainer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c22cd981-e871-4be1-93bd-b83c50ed9cc1"), 0, "1957c691-602b-4431-9fe6-5b961c62820b", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.", "Trainer", "trainer@abv.bg", true, "Test", true, true, "Trainer", true, null, "TRAINER@ABV.BG", "TRAINER@ABV.BG", "AQAAAAEAACcQAAAAEL+GSWTqgxuh/F+FA0IfOf4vXxKNeNynmTngYEGxGt2kz8gKmVnA8brPd7hNNuprTQ==", null, false, "b1758ef8-d9fc-4ebe-a149-678bbcbcea0c", false, "trainer@abv.bg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImagePath", "IsInPlan", "MuscleGroup", "Name", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("51b1a4aa-2785-4f44-b8df-d6d46726b924"), "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.", 1, "BenchPress.jfif", false, 0, "Bench press", "https://youtu.be/gRVjAtPip0Y" },
                    { new Guid("b9f21fbc-9810-4fba-a9d5-694e34046bb1"), "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.", 1, "Squat.jfif", false, 2, "Squat", "https://youtu.be/MVMNk0HiTMg" },
                    { new Guid("e25000d6-a2b3-4bc2-8eeb-9349164a59ed"), "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.", 1, "PullUp.jfif", false, 1, "Pull Up", "https://youtu.be/poyr8KenUfc" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("25b99704-a285-4b58-8c48-9db6d3b43ba0"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("5425f1c8-bd0c-4ccb-a5a7-f4642d724950"), 300.0, "Egg.png", 3, "TestDinner" },
                    { new Guid("bfc6e29d-f05a-4813-8e83-d896415a4b2c"), 300.0, "Egg.png", 2, "TestSnack" },
                    { new Guid("efe64846-ab16-45cb-b99e-2121dac9ac33"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
