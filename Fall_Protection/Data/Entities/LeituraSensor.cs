using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall_Protection.Data.Entities
{
    public class LeituraSensor
    {
        public int LeituraSensorId { get; set; }
        public DateTime DataLeitura { get; set; }
        public string TipoDado { get; set; }
        public string ValorLeitura { get; set; }
    }
}
