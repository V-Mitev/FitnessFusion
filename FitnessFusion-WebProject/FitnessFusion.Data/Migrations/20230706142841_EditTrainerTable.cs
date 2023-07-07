#nullable disable

namespace FitnessFusion.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class EditTrainerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_Trainers_TrainerId",
                table: "MealPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_Trainers_TrainerId",
                table: "TrainingPlans");

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
                    { new Guid("0c54464c-9db8-47ce-be1d-597ff868227e"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("2fbf3a4c-8a5d-4c0f-8257-f58b73c47897"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("33ce4ce4-944b-4d34-8390-9430a7af4744"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("3f244625-3b94-486c-804b-4a7fd741e753"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlans_Trainers_TrainerId",
                table: "MealPlans",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_Trainers_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_Trainers_TrainerId",
                table: "MealPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_Trainers_TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("0c54464c-9db8-47ce-be1d-597ff868227e"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("2fbf3a4c-8a5d-4c0f-8257-f58b73c47897"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("33ce4ce4-944b-4d34-8390-9430a7af4744"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("3f244625-3b94-486c-804b-4a7fd741e753"));

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
    }
}
