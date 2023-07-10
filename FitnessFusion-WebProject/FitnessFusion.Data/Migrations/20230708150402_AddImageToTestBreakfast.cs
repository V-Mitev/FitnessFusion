using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class AddImageToTestBreakfast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00c68ca5-6dbc-4b7d-b86a-b56b82226e92"), 300.0, "/img/musli.png", "TestBreakfast", null, 0 },
                    { new Guid("1b6162cd-a57e-4000-8367-4af8fb43cbba"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("29894ca3-dc80-48bb-8d27-2038a75ca73d"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("fbb9d55d-be8c-4770-9a0a-890b3d7f09fc"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("00c68ca5-6dbc-4b7d-b86a-b56b82226e92"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("1b6162cd-a57e-4000-8367-4af8fb43cbba"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("29894ca3-dc80-48bb-8d27-2038a75ca73d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("fbb9d55d-be8c-4770-9a0a-890b3d7f09fc"));

            migrationBuilder.AlterColumn<double>(
                name: "CaloriesIntake",
                table: "CaloriesCalculators",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
    }
}
