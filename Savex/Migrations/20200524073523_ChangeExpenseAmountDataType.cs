using Microsoft.EntityFrameworkCore.Migrations;

namespace Savex.Migrations
{
    public partial class ChangeExpenseAmountDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Expense",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Expense",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
