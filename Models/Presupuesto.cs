using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Presupuesto
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public int Id { get; set; } 
        public int? IdProyecto { get; set; }
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public double? MontoSolicitado { get; set; }
        public string Estado { get; set; } = string.Empty;
         [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public double? MontoAprobado { get; set; } 
        public int? PeriodoAnio { get; set; } 
        public DateTime FechaSolicitud { get; set; }   =DateTime.Now;
        public DateTime FechaAprobacion { get; set; } = DateTime.Now;
        public string Observaciones { get; set; } = string.Empty;

    }
}