using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class SomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("17af74a8-ca50-4af8-bac7-46481b2350b8"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1c0943e3-3c81-45cf-84c9-3d2f5abbc388"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b01c6424-73ca-4f59-8232-f29e1954ab96"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e5bf0c41-a559-46d7-9824-7657987dded1"));

            migrationBuilder.AlterColumn<double>(
                name: "CaloriesIntake",
                table: "CaloriesCalculators",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Calories",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealName", "MealPlanId", "MealType" },
                values: new object[,]
                {
                    { new Guid("834cbf48-1d94-496a-90d1-8558be2c94a7"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("a348a117-9e20-4699-8ff2-c7d3c0b71662"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("cc4046f0-d530-4f68-8662-de4a354d724d"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 },
                    { new Guid("d52a3777-e165-4793-8d01-d84dddf684d7"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("834cbf48-1d94-496a-90d1-8558be2c94a7"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("a348a117-9e20-4699-8ff2-c7d3c0b71662"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("cc4046f0-d530-4f68-8662-de4a354d724d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("d52a3777-e165-4793-8d01-d84dddf684d7"));

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<double>(
                name: "CaloriesIntake",
                table: "CaloriesCalculators",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealName", "MealPlanId", "MealType" },
                values: new object[,]
                {
                    { new Guid("17af74a8-ca50-4af8-bac7-46481b2350b8"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("1c0943e3-3c81-45cf-84c9-3d2f5abbc388"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 },
                    { new Guid("b01c6424-73ca-4f59-8232-f29e1954ab96"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("e5bf0c41-a559-46d7-9824-7657987dded1"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 }
                });
        }
    }
}
