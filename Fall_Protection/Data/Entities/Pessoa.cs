using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall_Protection.Data.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string TipoPessoa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Pessoa()
        {
           
        }

        public Pessoa(string nome, string tipoPessoa, string email, string telefone)
        {
           
            Nome = nome;
            TipoPessoa = tipoPessoa;
            Email = email;
            Telefone = telefone;
        }
    }
}
