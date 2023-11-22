using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> entity)
        {
            entity.Property(e => e.PessoaJuridicaId);
            entity.Property(e => e.PessoaId);
            entity.Property(e => e.EnderecoId);
            entity.Property(e => e.Cnpj).HasMaxLength(14).IsRequired();

            entity.HasData(
                new PessoaJuridica
                {
                  PessoaJuridicaId = 1,
                  PessoaId = 2,
                  EnderecoId = 2,
                  Cnpj = "13014953000150",
                },
                new PessoaJuridica
                {
                    PessoaJuridicaId = 2,
                    PessoaId = 4,
                    EnderecoId = 4,
                    Cnpj = "79333947000174",
                },
                new PessoaJuridica
                {
                    PessoaJuridicaId = 3,
                    PessoaId = 6,
                    EnderecoId = 6,
                    Cnpj = "56743188000112",
                }
                );
        }
    }
}
