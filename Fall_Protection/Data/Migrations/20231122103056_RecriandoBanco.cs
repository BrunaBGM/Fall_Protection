using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fall_Protection.Data.Migrations
{
    /// <inheritdoc />
    public partial class RecriandoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "DataAlteracao", "DataCadastro", "NumeroContrato", "PessoaId", "StatusCliente" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6670), 178657, 1, 0 },
                    { 2, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6678), 189078, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Complemento", "Estado", "Logradouro", "Numero", "Pais" },
                values: new object[,]
                {
                    { 2, "Taguatinga Sul", "72020053", "Brasília", null, "Distrito Federal", "Rua Especial", "10", "Brasil" },
                    { 3, "Jardim Três Lagoas", "71880694", "Maringá", null, "Paraná", "Rua Henri Jean Viana Júnior", "465", "Brasil" },
                    { 4, "Fazendinha", "81320082", "Curitiba", null, "Paraná", "Rua Nicolau Hornung", "446", "Brasil" },
                    { 5, "Grã-Duquesa", "35057370", "Governador Valadares", null, "Minas Gerais", "Rua Irlanda", "843", "Brasil" },
                    { 6, "Valparaiso", "89023785", "Blumenau", null, "Santa Catarina", "Rua Oscar Burger", "665", "Brasil" }
                });

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 1,
                columns: new[] { "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[] { "alana_aparicio@gmail.com", "Alana Stella", "11 99531-0146", "Pessoa Física" });

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 2,
                columns: new[] { "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[] { "Rihappy@gmail.com", "Rihappy", "41 98689-4359", "Pessoa Jurídica" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PessoaId", "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[,]
                {
                    { 3, "paulo88@gmail.com", "Paulo Antonio", "41 98807-9819", "Pessoa Física" },
                    { 4, "tblanches@gmail.com", "Taubaté Lanches", "11 97765-9190", "Pessoa Jurídica" },
                    { 5, "pereira2012@gmail.com", "Marcelo Pereira", "11 98788-6120", "Pessoa Física" },
                    { 6, "saudeclinica@gmail.com", "Clínica Saúde", "11 92345-6120", "Pessoa Jurídica" }
                });

            migrationBuilder.UpdateData(
                table: "PessoasFisica",
                keyColumn: "PessoaFisicaId",
                keyValue: 1,
                columns: new[] { "Genero", "PessoaId" },
                values: new object[] { 0, 1 });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "DataAlteracao", "DataCadastro", "NumeroContrato", "PessoaId", "StatusCliente" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6680), 345674, 3, 0 },
                    { 4, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6681), 564342, 4, 0 },
                    { 5, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6682), 221452, 5, 0 },
                    { 6, null, new DateTime(2023, 11, 22, 7, 30, 56, 140, DateTimeKind.Local).AddTicks(6684), 979563, 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "PessoasFisica",
                columns: new[] { "PessoaFisicaId", "Cpf", "DataNascimento", "EnderecoId", "Genero", "PessoaId", "Rg" },
                values: new object[,]
                {
                    { 2, "64341166085", new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3, "315423699" },
                    { 3, "14233317027", new DateTime(1998, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 5, "332345117" }
                });

            migrationBuilder.InsertData(
                table: "PessoasJuridica",
                columns: new[] { "PessoaJuridicaId", "Cnpj", "EnderecoId", "PessoaId" },
                values: new object[,]
                {
                    { 1, "13014953000150", 2, 2 },
                    { 2, "79333947000174", 4, 4 },
                    { 3, "56743188000112", 6, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PessoasFisica",
                keyColumn: "PessoaFisicaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PessoasFisica",
                keyColumn: "PessoaFisicaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PessoasJuridica",
                keyColumn: "PessoaJuridicaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PessoasJuridica",
                keyColumn: "PessoaJuridicaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PessoasJuridica",
                keyColumn: "PessoaJuridicaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "EnderecoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 1,
                columns: new[] { "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[] { "bruna@gmail.com", "Bruna", "9918889", "PessoaFisica" });

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 2,
                columns: new[] { "Email", "Nome", "Telefone", "TipoPessoa" },
                values: new object[] { "jubileu@gmail.com", "Jubileu", "9918889", "PessoaFisica" });

            migrationBuilder.UpdateData(
                table: "PessoasFisica",
                keyColumn: "PessoaFisicaId",
                keyValue: 1,
                columns: new[] { "Genero", "PessoaId" },
                values: new object[] { 1, 2 });
        }
    }
}
