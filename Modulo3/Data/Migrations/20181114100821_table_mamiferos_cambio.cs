using Microsoft.EntityFrameworkCore.Migrations;

namespace Modulo3.Data.Migrations
{
    public partial class table_mamiferos_cambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EcoLocalizacion",
                table: "Mamiferos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EcoLocalizacion",
                table: "Mamiferos",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
