using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMultiContext.Migrations
{
    public partial class correcaoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "TelefoneIid",
                table: "Pessoas");

            migrationBuilder.AlterColumn<Guid>(
                name: "TelefoneId",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId",
                principalTable: "Telefones",
                principalColumn: "TelefoneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas");

            migrationBuilder.AlterColumn<Guid>(
                name: "TelefoneId",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "TelefoneIid",
                table: "Pessoas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId",
                principalTable: "Telefones",
                principalColumn: "TelefoneId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
