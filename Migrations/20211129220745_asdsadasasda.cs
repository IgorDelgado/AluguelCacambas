using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Migrations
{
    public partial class asdsadasasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtdAluga",
                table: "AlugaGrup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdAluga",
                table: "AlugaGrup",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
