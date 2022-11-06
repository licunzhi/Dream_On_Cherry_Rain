using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    public partial class AddSexColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sex",
                table: "Customers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sex",
                table: "Customers");
        }
    }
}
