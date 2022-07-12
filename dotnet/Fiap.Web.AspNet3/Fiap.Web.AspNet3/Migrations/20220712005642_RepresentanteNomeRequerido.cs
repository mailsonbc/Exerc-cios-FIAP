﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.AspNet3.Migrations
{
    public partial class RepresentanteNomeRequerido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Representante");

            migrationBuilder.AlterColumn<string>(
                name: "NomeRepresentante",
                table: "Representante",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeRepresentante",
                table: "Representante",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Representante",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
