using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fall_Protection.Models;

namespace Fall_Protection.Data.Entities
{

    public class PessoaFisica
    {
        public int PessoaFisicaId { get; set; }
        public string Cpf { get; set; }
        public int PessoaId { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public GeneroEnum Genero { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa Pessoa { get; set; }


        // Construtor sem parâmetros (construtor padrão)
        public PessoaFisica()
        {
            // Pode inicializar propriedades padrão aqui, se necessário
        }

        // Construtor com parâmetros
        public PessoaFisica(string cpf, string rg, DateTime dataNascimento, GeneroEnum genero, int enderecoId)
            
        {
            EnderecoId = enderecoId;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Genero = genero;
        }
    }

}
