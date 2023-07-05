using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class EditMealTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Meals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Meals",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 100.0);
        }
    }
}
