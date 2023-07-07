using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    public partial class UpdateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("17af74a8-ca50-4af8-bac7-46481b2350b8"), 300.0, "aaaaaaaaa", "TestDinner", null, 3 },
                    { new Guid("1c0943e3-3c81-45cf-84c9-3d2f5abbc388"), 300.0, "aaaaaaaaa", "TestSnack", null, 2 },
                    { new Guid("b01c6424-73ca-4f59-8232-f29e1954ab96"), 300.0, "aaaaaaaaa", "TestBreakfast", null, 0 },
                    { new Guid("e5bf0c41-a559-46d7-9824-7657987dded1"), 300.0, "aaaaaaaaa", "TestLunch", null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_ClientId",
                table: "MealPlans",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlans_AspNetUsers_ClientId",
                table: "MealPlans",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_ClientId",
                table: "TrainingPlans",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_AspNetUsers_ClientId",
                table: "MealPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_AspNetUsers_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_MealPlans_ClientId",
                table: "MealPlans");

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
    }
}
