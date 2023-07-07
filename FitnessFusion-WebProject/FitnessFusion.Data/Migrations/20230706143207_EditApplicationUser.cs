using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class EditApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "TrainingPlans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "MealPlans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesPer100g", "ImageUrl", "MealName", "MealPlanId", "MealType" },
                values: new object[,]
                {
                    { new Guid("420fbd13-4158-4933-ad38-ab722644e12d"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("5303ec7f-0a32-4202-bc3b-4de9b7583081"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("70006d43-4fbc-4e8e-a015-d35f50bd437c"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 },
                    { new Guid("78b5d3fc-fcf0-4d17-b2e2-37216d1116f2"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ApplicationUserId",
                table: "TrainingPlans",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_ApplicationUserId",
                table: "MealPlans",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlans_AspNetUsers_ApplicationUserId",
                table: "MealPlans",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_ApplicationUserId",
                table: "TrainingPlans",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_AspNetUsers_ApplicationUserId",
                table: "MealPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_ApplicationUserId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ApplicationUserId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_MealPlans_ApplicationUserId",
                table: "MealPlans");

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("420fbd13-4158-4933-ad38-ab722644e12d"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("5303ec7f-0a32-4202-bc3b-4de9b7583081"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("70006d43-4fbc-4e8e-a015-d35f50bd437c"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("78b5d3fc-fcf0-4d17-b2e2-37216d1116f2"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "TrainingPlans");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "MealPlans");

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
        }
    }
}
