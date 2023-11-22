using Fall_Protection.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fall_Protection.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> entity)
        {
            entity.Property(e => e.PessoaId);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.TipoPessoa).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Telefone).IsRequired();

            entity.HasData(
                new Pessoa
                {
                    PessoaId = 1,
                    Nome = "Bruna",
                    Email = "bruna@gmail.com",
                    Telefone = "9918889",
                    TipoPessoa = "PessoaFisica"
                },
                 new Pessoa
                 {
                     PessoaId = 2,
                     Nome = "Jubileu",
                     Email = "jubileu@gmail.com",
                     Telefone = "9918889",
                     TipoPessoa = "PessoaFisica"
                 }

                );
        }
    }
}
