using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fall_Protection.Data.Migrations
{
    /// <inheritdoc />
    public partial class newRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalizacaoSensor",
                table: "Sensores");

            migrationBuilder.AlterColumn<int>(
                name: "StatusSensor",
                table: "Sensores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 1,
                column: "PessoaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 2,
                column: "PessoaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 3,
                column: "PessoaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 4,
                column: "PessoaId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 5,
                column: "PessoaId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 6,
                column: "PessoaId",
                value: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Enderecos");

            migrationBuilder.AlterColumn<string>(
                name: "StatusSensor",
                table: "Sensores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LocalizacaoSensor",
                table: "Sensores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6684));
        }
    }
}
