using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.AspNet3.Migrations
{
    public partial class PropCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "CategoriaId", "DataLancamento" },
                values: new object[] { 2, new DateTime(2022, 8, 20, 10, 5, 50, 171, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "CategoriaId", "DataLancamento" },
                values: new object[] { 2, new DateTime(2022, 8, 20, 10, 5, 50, 171, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "CategoriaId", "DataLancamento" },
                values: new object[] { 2, new DateTime(2022, 8, 20, 10, 5, 50, 171, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "CategoriaId", "DataLancamento" },
                values: new object[] { 2, new DateTime(2022, 8, 20, 10, 5, 50, 171, DateTimeKind.Local).AddTicks(2785) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataLancamento",
                value: new DateTime(2022, 8, 11, 21, 28, 35, 789, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                column: "DataLancamento",
                value: new DateTime(2022, 8, 11, 21, 28, 35, 789, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "DataLancamento",
                value: new DateTime(2022, 8, 11, 21, 28, 35, 789, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                column: "DataLancamento",
                value: new DateTime(2022, 8, 11, 21, 28, 35, 789, DateTimeKind.Local).AddTicks(8911));
        }
    }
}
