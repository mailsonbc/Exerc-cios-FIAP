using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.AspNet3.Migrations
{
    public partial class ClienteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepresentanteId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RepresentanteId",
                table: "Clientes",
                column: "RepresentanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Representante_RepresentanteId",
                table: "Clientes",
                column: "RepresentanteId",
                principalTable: "Representante",
                principalColumn: "RepresentanteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Representante_RepresentanteId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_RepresentanteId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RepresentanteId",
                table: "Clientes");
        }
    }
}
