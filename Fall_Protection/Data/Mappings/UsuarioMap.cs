using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.Property(e => e.UsuarioId);
            entity.Property(e => e.Nome).HasMaxLength(128).IsRequired();
            entity.Property(e => e.Email).HasMaxLength(128).IsRequired();
            entity.Property(e => e.SenhaHash).HasMaxLength(64).IsRequired();
            entity.Property(e => e.DataNascimento).IsRequired();
            entity.Property(e => e.Ativo).HasDefaultValue(true).IsRequired();
            entity.Property(e => e.DataAlteracao);
            entity.Property(e => e.DataCadastro).HasDefaultValueSql("getdate()").IsRequired();
        }
    }
}
