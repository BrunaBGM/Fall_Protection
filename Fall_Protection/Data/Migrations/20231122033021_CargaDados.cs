using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fall_Protection.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Complemento", "Estado", "Logradouro", "Numero", "Pais" },
                values: new object[] { 1, "Chácara Gaivotas", "04849341", "São Paulo", null, "São Paulo", "Travessa Mirandela", "446", "Brasil" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PessoaId", "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[,]
                {
                    { 1, "bruna@gmail.com", "Bruna", "9918889", "PessoaFisica" },
                    { 2, "jubileu@gmail.com", "Jubileu", "9918889", "PessoaFisica" }
                });

            migrationBuilder.InsertData(
                table: "PessoasFisica",
                columns: new[] { "PessoaFisicaId", "Cpf", "DataNascimento", "EnderecoId", "Genero", "PessoaId", "Rg" },
                values: new object[] { 1, "71273092058", new DateTime(1990, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2, "162068414" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PessoasFisica",
                keyColumn: "PessoaFisicaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 2);
        }
    }
}
