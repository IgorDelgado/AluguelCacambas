using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Migrations
{
    public partial class alteracaoClasseAluga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Alugueis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Alugueis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
