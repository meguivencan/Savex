using Microsoft.EntityFrameworkCore.Migrations;

namespace Savex.Migrations
{
    public partial class AddedTypeOfExpensesId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfExpense",
                table: "Expense");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfExpenseId",
                table: "Expense",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_TypeOfExpenseId",
                table: "Expense",
                column: "TypeOfExpenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_TypeOfExpense_TypeOfExpenseId",
                table: "Expense",
                column: "TypeOfExpenseId",
                principalTable: "TypeOfExpense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_TypeOfExpense_TypeOfExpenseId",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_TypeOfExpenseId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "TypeOfExpenseId",
                table: "Expense");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfExpense",
                table: "Expense",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
