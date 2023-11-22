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
                    PessoaId = 2,
                    Cpf = "71273092058",
                    Rg = "162068414",
                    DataNascimento = new DateTime(1990,04,09),
                    EnderecoId = 1,
                    Genero = GeneroEnum.Masculino
                });
        }
    }
}
