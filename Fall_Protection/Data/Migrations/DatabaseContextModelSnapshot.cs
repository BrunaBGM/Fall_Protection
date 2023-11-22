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
                            Pais = "Brasil"
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
                            Email = "bruna@gmail.com",
                            Nome = "Bruna",
                            Telefone = "9918889",
                            TipoPessoa = "PessoaFisica"
                        },
                        new
                        {
                            PessoaId = 2,
                            Email = "jubileu@gmail.com",
                            Nome = "Jubileu",
                            Telefone = "9918889",
                            TipoPessoa = "PessoaFisica"
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
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

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
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

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
                            Genero = 1,
                            PessoaId = 2,
                            Rg = "162068414"
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
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("PessoaJuridicaId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoasJuridica");
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

                    b.Property<int>("LocalizacaoSensor")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoAparelho")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("StatusSensor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
