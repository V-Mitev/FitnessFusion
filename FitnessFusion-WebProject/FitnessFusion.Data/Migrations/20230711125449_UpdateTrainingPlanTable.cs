using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateTrainingPlanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_TrainerForeignKey",
                table: "TrainingPlans");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("0ae3adc4-51dc-49e1-978e-8b19039858b6"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5add70bf-ffe5-4814-bd0a-08e84f307391"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("9adbd11a-9f67-4a68-8d88-1801f24e67ae"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("f003e227-4bed-420a-aaa8-32bea0d741a5"));

            migrationBuilder.RenameColumn(
                name: "TrainerForeignKey",
                table: "TrainingPlans",
                newName: "TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingPlans_TrainerForeignKey",
                table: "TrainingPlans",
                newName: "IX_TrainingPlans_TrainerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_TrainerId",
                table: "TrainingPlans");

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

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "TrainingPlans",
                newName: "TrainerForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans",
                newName: "IX_TrainingPlans_TrainerForeignKey");

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("0ae3adc4-51dc-49e1-978e-8b19039858b6"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("5add70bf-ffe5-4814-bd0a-08e84f307391"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("9adbd11a-9f67-4a68-8d88-1801f24e67ae"), 300.0, "Egg.png", 1, "TestLunch" },
                    { new Guid("f003e227-4bed-420a-aaa8-32bea0d741a5"), 300.0, "aaaaaaaaa", 3, "TestDinner" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_TrainerForeignKey",
                table: "TrainingPlans",
                column: "TrainerForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
