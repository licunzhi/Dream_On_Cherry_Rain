using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleConfigApp.Migrations
{
    public partial class EFCoreAddHomeTown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hometown",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hometown",
                table: "Person");
        }
    }
}
