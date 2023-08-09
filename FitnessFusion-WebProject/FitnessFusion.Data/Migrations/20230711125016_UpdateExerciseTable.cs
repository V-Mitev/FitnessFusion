#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateExerciseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Exercises_ExerciseId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_TrainingPlans_TrainingPlanId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ExerciseId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_TrainingPlanId",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("52977bd2-2bb5-41f1-b738-102b397f7d59"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5d4de28f-261f-4eb7-b228-2c2c97a3e8a3"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("85be5c0d-1068-4c7f-b58d-a29a6604d807"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("96e47207-c3bc-41fb-9888-5d023b017ff0"));

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TrainingPlanId",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "ExerciseTrainingPlan",
                columns: table => new
                {
                    ExercisesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainingPlansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTrainingPlan", x => new { x.ExercisesId, x.TrainingPlansId });
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingPlan_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingPlan_TrainingPlans_TrainingPlansId",
                        column: x => x.TrainingPlansId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainingPlan_TrainingPlansId",
                table: "ExerciseTrainingPlan",
                column: "TrainingPlansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseTrainingPlan");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseId",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingPlanId",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealType", "Name" },
                values: new object[,]
                {
                    { new Guid("52977bd2-2bb5-41f1-b738-102b397f7d59"), 300.0, "Musli.png", 0, "TestBreakfast" },
                    { new Guid("5d4de28f-261f-4eb7-b228-2c2c97a3e8a3"), 300.0, "aaaaaaaaa", 3, "TestDinner" },
                    { new Guid("85be5c0d-1068-4c7f-b58d-a29a6604d807"), 300.0, "aaaaaaaaa", 2, "TestSnack" },
                    { new Guid("96e47207-c3bc-41fb-9888-5d023b017ff0"), 300.0, "Egg.png", 1, "TestLunch" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseId",
                table: "Exercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingPlanId",
                table: "Exercises",
                column: "TrainingPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Exercises_ExerciseId",
                table: "Exercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_TrainingPlans_TrainingPlanId",
                table: "Exercises",
                column: "TrainingPlanId",
                principalTable: "TrainingPlans",
                principalColumn: "Id");
        }
    }
}
