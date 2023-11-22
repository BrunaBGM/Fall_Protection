using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fall_Protection.Models;

namespace Fall_Protection.Data.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int PessoaId { get; set; }
        public StatusEnum StatusCliente { get; set; }
        public int NumeroContrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public Pessoa Pessoa { get; set; } = null!;

        public void GerarNumeroContratoAleatorio()
        {
            Random random = new Random();
            NumeroContrato = random.Next(100000, 999999);
        }
    }
}
