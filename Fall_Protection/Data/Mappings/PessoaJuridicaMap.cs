using Fall_Protection.Data.Entities;
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
        }
    }
}
