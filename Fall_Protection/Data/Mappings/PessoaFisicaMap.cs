using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> entity)
        {
            entity.Property(e => e.PessoaFisicaId);
            entity.Property(e => e.PessoaId);
            entity.Property(e => e.EnderecoId);
            entity.Property(e => e.Cpf).HasMaxLength(11).IsRequired();
            entity.Property(e => e.Rg).HasMaxLength(9).IsRequired();
            entity.Property(e => e.DataNascimento).HasDefaultValueSql("getdate()").IsRequired();
            entity.Property(e => e.Genero).IsRequired();

            entity.HasData(
                new PessoaFisica
                {
                    PessoaFisicaId = 1,
                    PessoaId = 1,
                    Cpf = "71273092058",
                    Rg = "162068414",
                    DataNascimento = new DateTime(1990,04,09),
                    EnderecoId = 1,
                    Genero = GeneroEnum.Feminino
                },
                new PessoaFisica
                {
                    PessoaFisicaId = 2,
                    PessoaId = 3,
                    Cpf = "64341166085",
                    Rg = "315423699",
                    DataNascimento = new DateTime(2000, 07, 12),
                    EnderecoId = 3,
                    Genero = GeneroEnum.Masculino
                },
                new PessoaFisica
                {
                    PessoaFisicaId = 3,
                    PessoaId = 5,
                    Cpf = "14233317027",
                    Rg = "332345117",
                    DataNascimento = new DateTime(1998, 10, 03),
                    EnderecoId = 5,
                    Genero = GeneroEnum.Masculino
                }
                );
        }
    }
}
