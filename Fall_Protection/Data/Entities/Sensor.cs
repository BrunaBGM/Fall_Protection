using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall_Protection.Data.Entities
{

    public class Sensor
    {

        public int SensorId { get; set; }
        public string DispositivoModelo { get; set; }
        public string DispositivoNumeroSerie { get; set; }
        public int LocalizacaoSensor { get; set; }
        public string StatusSensor { get; set; }
        public decimal PrecoAparelho { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
