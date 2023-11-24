﻿// <auto-generated />
using System;
using Fall_Protection.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fall_Protection.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fall_Protection.Data.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("NumeroContrato")
                        .HasMaxLength(9999999)
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("StatusCliente")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3628),
                            NumeroContrato = 178657,
                            PessoaId = 1,
                            StatusCliente = 0
                        },
                        new
                        {
                            ClienteId = 2,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3636),
                            NumeroContrato = 189078,
                            PessoaId = 2,
                            StatusCliente = 0
                        },
                        new
                        {
                            ClienteId = 3,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3637),
                            NumeroContrato = 345674,
                            PessoaId = 3,
                            StatusCliente = 0
                        },
                        new
                        {
                            ClienteId = 4,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3638),
                            NumeroContrato = 564342,
                            PessoaId = 4,
                            StatusCliente = 0
                        },
                        new
                        {
                            ClienteId = 5,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3639),
                            NumeroContrato = 221452,
                            PessoaId = 5,
                            StatusCliente = 0
                        },
                        new
                        {
                            ClienteId = 6,
                            DataCadastro = new DateTime(2023, 11, 24, 18, 8, 44, 393, DateTimeKind.Local).AddTicks(3640),
                            NumeroContrato = 979563,
                            PessoaId = 6,
                            StatusCliente = 0
                        });
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            EnderecoId = 1,
                            Bairro = "Chácara Gaivotas",
                            Cep = "04849341",
                            Cidade = "São Paulo",
                            Estado = "São Paulo",
                            Logradouro = "Travessa Mirandela",
                            Numero = "446",
                            Pais = "Brasil",
                            PessoaId = 1
                        },
                        new
                        {
                            EnderecoId = 2,
                            Bairro = "Taguatinga Sul",
                            Cep = "72020053",
                            Cidade = "Brasília",
                            Estado = "Distrito Federal",
                            Logradouro = "Rua Especial",
                            Numero = "10",
                            Pais = "Brasil",
                            PessoaId = 2
                        },
                        new
                        {
                            EnderecoId = 3,
                            Bairro = "Jardim Três Lagoas",
                            Cep = "71880694",
                            Cidade = "Maringá",
                            Estado = "Paraná",
                            Logradouro = "Rua Henri Jean Viana Júnior",
                            Numero = "465",
                            Pais = "Brasil",
                            PessoaId = 3
                        },
                        new
                        {
                            EnderecoId = 4,
                            Bairro = "Fazendinha",
                            Cep = "81320082",
                            Cidade = "Curitiba",
                            Estado = "Paraná",
                            Logradouro = "Rua Nicolau Hornung",
                            Numero = "446",
                            Pais = "Brasil",
                            PessoaId = 4
                        },
                        new
                        {
                            EnderecoId = 5,
                            Bairro = "Grã-Duquesa",
                            Cep = "35057370",
                            Cidade = "Governador Valadares",
                            Estado = "Minas Gerais",
                            Logradouro = "Rua Irlanda",
                            Numero = "843",
                            Pais = "Brasil",
                            PessoaId = 5
                        },
                        new
                        {
                            EnderecoId = 6,
                            Bairro = "Valparaiso",
                            Cep = "89023785",
                            Cidade = "Blumenau",
                            Estado = "Santa Catarina",
                            Logradouro = "Rua Oscar Burger",
                            Numero = "665",
                            Pais = "Brasil",
                            PessoaId = 6
                        });
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.LeituraSensor", b =>
                {
                    b.Property<int>("LeituraSensorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeituraSensorId"));

                    b.Property<DateTime>("DataLeitura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("TipoDado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorLeitura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeituraSensorId");

                    b.ToTable("LeiturasSensor");
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PessoaId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            PessoaId = 1,
                            Email = "alana_aparicio@gmail.com",
                            Nome = "Alana Stella",
                            Telefone = "11 99531-0146",
                            TipoPessoa = "Pessoa Física"
                        },
                        new
                        {
                            PessoaId = 2,
                            Email = "Rihappy@gmail.com",
                            Nome = "Rihappy",
                            Telefone = "41 98689-4359",
                            TipoPessoa = "Pessoa Jurídica"
                        },
                        new
                        {
                            PessoaId = 3,
                            Email = "paulo88@gmail.com",
                            Nome = "Paulo Antonio",
                            Telefone = "41 98807-9819",
                            TipoPessoa = "Pessoa Física"
                        },
                        new
                        {
                            PessoaId = 4,
                            Email = "tblanches@gmail.com",
                            Nome = "Taubaté Lanches",
                            Telefone = "11 97765-9190",
                            TipoPessoa = "Pessoa Jurídica"
                        },
                        new
                        {
                            PessoaId = 5,
                            Email = "pereira2012@gmail.com",
                            Nome = "Marcelo Pereira",
                            Telefone = "11 98788-6120",
                            TipoPessoa = "Pessoa Física"
                        },
                        new
                        {
                            PessoaId = 6,
                            Email = "saudeclinica@gmail.com",
                            Nome = "Clínica Saúde",
                            Telefone = "11 92345-6120",
                            TipoPessoa = "Pessoa Jurídica"
                        });
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.PessoaFisica", b =>
                {
                    b.Property<int>("PessoaFisicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PessoaFisicaId"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("DataNascimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PessoaFisicaId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoasFisica");

                    b.HasData(
                        new
                        {
                            PessoaFisicaId = 1,
                            Cpf = "71273092058",
                            DataNascimento = new DateTime(1990, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnderecoId = 1,
                            Genero = 0,
                            PessoaId = 1,
                            Rg = "162068414"
                        },
                        new
                        {
                            PessoaFisicaId = 2,
                            Cpf = "64341166085",
                            DataNascimento = new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnderecoId = 3,
                            Genero = 1,
                            PessoaId = 3,
                            Rg = "315423699"
                        },
                        new
                        {
                            PessoaFisicaId = 3,
                            Cpf = "14233317027",
                            DataNascimento = new DateTime(1998, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnderecoId = 5,
                            Genero = 1,
                            PessoaId = 5,
                            Rg = "332345117"
                        });
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.PessoaJuridica", b =>
                {
                    b.Property<int>("PessoaJuridicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PessoaJuridicaId"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("PessoaJuridicaId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoasJuridica");

                    b.HasData(
                        new
                        {
                            PessoaJuridicaId = 1,
                            Cnpj = "13014953000150",
                            EnderecoId = 2,
                            PessoaId = 2
                        },
                        new
                        {
                            PessoaJuridicaId = 2,
                            Cnpj = "79333947000174",
                            EnderecoId = 4,
                            PessoaId = 4
                        },
                        new
                        {
                            PessoaJuridicaId = 3,
                            Cnpj = "56743188000112",
                            EnderecoId = 6,
                            PessoaId = 6
                        });
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SensorId"));

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("DispositivoModelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DispositivoNumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoAparelho")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("StatusSensor")
                        .HasColumnType("int");

                    b.HasKey("SensorId");

                    b.ToTable("Sensores");
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<bool?>("Ativo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varbinary(64)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.Cliente", b =>
                {
                    b.HasOne("Fall_Protection.Data.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.PessoaFisica", b =>
                {
                    b.HasOne("Fall_Protection.Data.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fall_Protection.Data.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("Fall_Protection.Data.Entities.PessoaJuridica", b =>
                {
                    b.HasOne("Fall_Protection.Data.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fall_Protection.Data.Entities.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
