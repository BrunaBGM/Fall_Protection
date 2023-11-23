using Fall_Protection.Data.Entities;
using Fall_Protection.Data.Mappings;
using Fall_Protection.Models;
using Microsoft.EntityFrameworkCore;

namespace Fall_Protection.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DatabaseContext()
        {

        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<PessoaFisica> PessoasFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoasJuridica { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Sensor> Sensores { get; set; }
        public virtual DbSet<LeituraSensor> LeiturasSensor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new LeituraSensorMap());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new SensorMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());


            modelBuilder.Entity<PessoaFisica>()
              .HasOne(pf => pf.Pessoa)
              .WithMany()
              .HasForeignKey(pf => pf.PessoaId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PessoaFisica>()
               .HasOne(pf => pf.Endereco)
               .WithMany()
               .HasForeignKey(pf => pf.EnderecoId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PessoaJuridica>()
                .HasOne(pj => pj.Pessoa)
                .WithMany()
                .HasForeignKey(pj => pj.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PessoaJuridica>()
                .HasOne(pj => pj.Endereco)
                .WithMany()
                .HasForeignKey(pj => pj.EnderecoId)
                .OnDelete(DeleteBehavior.Cascade);


        }

    }
}