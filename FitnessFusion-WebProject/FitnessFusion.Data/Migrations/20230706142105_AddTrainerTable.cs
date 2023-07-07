using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class AddTrainerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("0db99003-7075-4a6d-ae4b-245160b9bd66"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3e4394f2-3cd7-4fc6-a3f1-e97aba173f10"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("86d2bd17-4c0c-44ce-a927-66cf96ea83ac"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("b4bad234-8d12-4bdd-88c3-9cd0db12f54a"));

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsExpririence = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealName", "MealPlanId", "MealType" },
                values: new object[,]
                {
                    { new Guid("225ae336-1288-4767-9a98-e4f613dca986"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("2ac32f4d-8752-4e5c-a3d9-9b1f055dd62a"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("7545f772-9d30-4308-bcb5-3e39d816269d"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("802fd1bf-2d56-4c66-b410-546a72021746"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_TrainerId",
                table: "MealPlans",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlans_Trainers_TrainerId",
                table: "MealPlans",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_Trainers_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_Trainers_TrainerId",
                table: "MealPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_Trainers_TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_MealPlans_TrainerId",
                table: "MealPlans");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("225ae336-1288-4767-9a98-e4f613dca986"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("2ac32f4d-8752-4e5c-a3d9-9b1f055dd62a"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("7545f772-9d30-4308-bcb5-3e39d816269d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("802fd1bf-2d56-4c66-b410-546a72021746"));

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealName", "MealPlanId", "MealType" },
                values: new object[,]
                {
                    { new Guid("0db99003-7075-4a6d-ae4b-245160b9bd66"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("3e4394f2-3cd7-4fc6-a3f1-e97aba173f10"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("86d2bd17-4c0c-44ce-a927-66cf96ea83ac"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 },
                    { new Guid("b4bad234-8d12-4bdd-88c3-9cd0db12f54a"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 }
                });
        }
    }
}
