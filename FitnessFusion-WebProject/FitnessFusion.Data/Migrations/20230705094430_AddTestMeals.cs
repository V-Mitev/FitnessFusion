#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddTestMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "ImageUrl", "MealType", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, 300.0, "aaaaaaaaa", 1, "TestBreakfast", 100.0 },
                    { 2, 300.0, "aaaaaaaaa", 2, "TestLunch", 100.0 },
                    { 3, 300.0, "aaaaaaaaa", 4, "TestDinner", 100.0 },
                    { 4, 300.0, "aaaaaaaaa", 3, "TestSnack", 100.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
