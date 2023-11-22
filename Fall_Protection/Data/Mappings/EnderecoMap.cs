using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> entity)
        {
            entity.Property(e => e.EnderecoId);
            entity.Property(e => e.Cep).IsRequired();
            entity.Property(e => e.Logradouro).IsRequired();
            entity.Property(e => e.Numero).IsRequired();
            entity.Property(e => e.Complemento);
            entity.Property(e => e.Bairro).IsRequired();
            entity.Property(e => e.Cidade).IsRequired();
            entity.Property(e => e.Estado).IsRequired();
            entity.Property(e => e.Pais).IsRequired();

            entity.HasData(
                new Endereco
                {
                    EnderecoId = 1,
                    Cep = "04849341",
                    Logradouro = "Travessa Mirandela",
                    Numero = "446",
                    Bairro = "Chácara Gaivotas",
                    Cidade = "São Paulo",
                    Estado = "São Paulo",
                    Pais = "Brasil"
                    
                });
        }
    }
}
