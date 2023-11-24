using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fall_Protection.Data.Migrations
{
    /// <inheritdoc />
    public partial class UltimaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "PessoasJuridica",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "PessoasFisica",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "PessoasFisica",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3640));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "PessoasJuridica",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "PessoasFisica",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "PessoasFisica",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 19, 20, 20, 663, DateTimeKind.Local).AddTicks(4250));
        }
    }
}
