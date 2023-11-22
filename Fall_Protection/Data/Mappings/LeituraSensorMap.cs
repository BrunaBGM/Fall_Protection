using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class LeituraSensorMap : IEntityTypeConfiguration<LeituraSensor>
    {
        public void Configure(EntityTypeBuilder<LeituraSensor> entity)
        {
            entity.Property(e => e.LeituraSensorId);
            entity.Property(e => e.DataLeitura).HasDefaultValueSql("getdate()").IsRequired();
            entity.Property(e => e.TipoDado).IsRequired();
            entity.Property(e => e.ValorLeitura).IsRequired();
      
        }
    }
}
