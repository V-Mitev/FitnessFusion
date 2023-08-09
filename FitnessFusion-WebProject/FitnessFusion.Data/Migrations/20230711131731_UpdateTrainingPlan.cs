#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateTrainingPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1de8a76c-e511-43af-929b-a6107034f56a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("622e0b4b-3bc5-4890-bb83-95052332c93b"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("85b7f899-4a9a-47d1-98d0-c1b18385abd1"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b00d0ec6-f254-478f-b042-fa48445bdba6"));

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("24cea67e-808e-400c-b4b6-8067e8ce74e3"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("29795b00-e3b4-4ab0-b1dd-dffec166acb7"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("549c8185-01c4-4f43-9f63-ed7b1da9d5b3"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("c44b0117-5166-4796-a893-b296fc39b4e9"), 300.0, "Musli.png", 0, "TestBreakfast" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("24cea67e-808e-400c-b4b6-8067e8ce74e3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("29795b00-e3b4-4ab0-b1dd-dffec166acb7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("549c8185-01c4-4f43-9f63-ed7b1da9d5b3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c44b0117-5166-4796-a893-b296fc39b4e9"));

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("1de8a76c-e511-43af-929b-a6107034f56a"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("622e0b4b-3bc5-4890-bb83-95052332c93b"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("85b7f899-4a9a-47d1-98d0-c1b18385abd1"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("b00d0ec6-f254-478f-b042-fa48445bdba6"), 300.0, "Egg.png", 1, "TestLunch" }
                });
        }
    }
}
