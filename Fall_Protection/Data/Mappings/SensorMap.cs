using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class SensorMap : IEntityTypeConfiguration<Sensor>
    {
        public void Configure(EntityTypeBuilder<Sensor> entity)
        {
            entity.Property(e => e.SensorId);
            entity.Property(e => e.DispositivoModelo).IsRequired();
            entity.Property(e => e.DispositivoNumeroSerie).IsRequired();
            entity.Property(e => e.LocalizacaoSensor).IsRequired();
            entity.Property(e => e.StatusSensor).IsRequired();
            entity.Property(e => e.PrecoAparelho).HasPrecision(10,2).IsRequired();
            entity.Property(e => e.DataAlteracao);
            entity.Property(e => e.DataCadastro).HasDefaultValueSql("getdate()").IsRequired();
        }
    }
}
