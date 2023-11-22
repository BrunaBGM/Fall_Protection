using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>

    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.Property(e => e.ClienteId);
            entity.Property(e => e.PessoaId);
            entity.Property(e => e.StatusCliente).IsRequired();
            entity.Property(e => e.NumeroContrato).HasMaxLength(9999999).IsRequired();
            entity.Property(e => e.DataCadastro).HasDefaultValueSql("getdate()").IsRequired();
            entity.Property(e => e.DataAlteracao);
        }

    }
}
