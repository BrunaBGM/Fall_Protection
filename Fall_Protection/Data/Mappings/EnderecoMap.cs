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
                    
                },
                new Endereco
                {
                    EnderecoId = 2,
                    Cep = "72020053",
                    Logradouro = "Rua Especial",
                    Numero = "10",
                    Bairro = "Taguatinga Sul",
                    Cidade = "Brasília",
                    Estado = "Distrito Federal",
                    Pais = "Brasil"

                },
                new Endereco
                {
                    EnderecoId = 3,
                    Cep = "71880694",
                    Logradouro = "Rua Henri Jean Viana Júnior",
                    Numero = "465",
                    Bairro = "Jardim Três Lagoas",
                    Cidade = "Maringá",
                    Estado = "Paraná",
                    Pais = "Brasil"

                },
                new Endereco
                {
                    EnderecoId = 4,
                    Cep = "81320082",
                    Logradouro = "Rua Nicolau Hornung",
                    Numero = "446",
                    Bairro = "Fazendinha",
                    Cidade = "Curitiba",
                    Estado = "Paraná",
                    Pais = "Brasil"

                },
                new Endereco
                {
                    EnderecoId = 5,
                    Cep = "35057370",
                    Logradouro = "Rua Irlanda",
                    Numero = "843",
                    Bairro = "Grã-Duquesa",
                    Cidade = "Governador Valadares",
                    Estado = "Minas Gerais",
                    Pais = "Brasil"

                },
                new Endereco
                {
                    EnderecoId = 6,
                    Cep = "89023785",
                    Logradouro = "Rua Oscar Burger",
                    Numero = "665",
                    Bairro = "Valparaiso",
                    Cidade = "Blumenau",
                    Estado = "Santa Catarina",
                    Pais = "Brasil"

                }

                );
        }
    }
}
