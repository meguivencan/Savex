using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Savex.Migrations
{
    public partial class ChangeDateToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Expense",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Expense",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
