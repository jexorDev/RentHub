using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentHub.Server.Migrations
{
    public partial class AddExpenseToRoommate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Roommates_BuyerId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_BuyerId",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "RoommateId",
                table: "Expenses",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_RoommateId",
                table: "Expenses",
                column: "RoommateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Roommates_RoommateId",
                table: "Expenses",
                column: "RoommateId",
                principalTable: "Roommates",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Roommates_RoommateId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_RoommateId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "RoommateId",
                table: "Expenses");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_BuyerId",
                table: "Expenses",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Roommates_BuyerId",
                table: "Expenses",
                column: "BuyerId",
                principalTable: "Roommates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
