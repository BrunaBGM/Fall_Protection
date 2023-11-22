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
                    Nome = "Alana Stella",
                    Email = "alana_aparicio@gmail.com",
                    Telefone = "11 99531-0146",
                    TipoPessoa = "Pessoa Física"
                },
                new Pessoa
                {
                    PessoaId = 2,
                    Nome = "Rihappy",
                    Email = "Rihappy@gmail.com",
                    Telefone = "41 98689-4359",
                    TipoPessoa = "Pessoa Jurídica"
                },
                new Pessoa
                {
                    PessoaId = 3,
                    Nome = "Paulo Antonio",
                    Email = "paulo88@gmail.com",
                    Telefone = "41 98807-9819",
                    TipoPessoa = "Pessoa Física"
                },
                new Pessoa
                {
                    PessoaId = 4,
                    Nome = "Taubaté Lanches",
                    Email = "tblanches@gmail.com",
                    Telefone = "11 97765-9190",
                    TipoPessoa = "Pessoa Jurídica"
                },
                new Pessoa
                {
                    PessoaId = 5,
                    Nome = "Marcelo Pereira",
                    Email = "pereira2012@gmail.com",
                    Telefone = "11 98788-6120",
                    TipoPessoa = "Pessoa Física"
                },
                new Pessoa
                {
                    PessoaId = 6,
                    Nome = "Clínica Saúde",
                    Email = "saudeclinica@gmail.com",
                    Telefone = "11 92345-6120",
                    TipoPessoa = "Pessoa Jurídica"
                }

                );
        }
    }
}
