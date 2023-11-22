using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
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

            entity.HasData(
                new Cliente
                {
                    ClienteId = 1,
                    PessoaId = 1,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 178657,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                },
                new Cliente
                {
                    ClienteId = 2,
                    PessoaId = 2,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 189078,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                },
                new Cliente
                {
                    ClienteId = 3,
                    PessoaId = 3,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 345674,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                },
                new Cliente
                {
                    ClienteId = 4,
                    PessoaId = 4,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 564342,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                },
                new Cliente
                {
                    ClienteId = 5,
                    PessoaId = 5,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 221452,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                },
                new Cliente
                {
                    ClienteId = 6,
                    PessoaId = 6,
                    StatusCliente = StatusEnum.Ativo,
                    NumeroContrato = 979563,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                }
                );
        }

    }
}
