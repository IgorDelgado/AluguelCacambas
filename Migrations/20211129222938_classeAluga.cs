using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Migrations
{
    public partial class classeAluga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cacamba",
                table: "Alugueis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cacamba",
                table: "Alugueis");
        }
    }
}
