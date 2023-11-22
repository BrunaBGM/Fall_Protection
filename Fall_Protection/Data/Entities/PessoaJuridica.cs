using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall_Protection.Data.Entities
{
 
    public class PessoaJuridica
    {
        public int PessoaJuridicaId { get; set; }
        public int PessoaId { get; set; }
        public string Cnpj { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa Pessoa { get; set; }
        public PessoaJuridica()
        {

        }
        public PessoaJuridica(string cnpj, int enderecoId)
       
        {
            EnderecoId = enderecoId;
            Cnpj = cnpj;
        }

    }
}
