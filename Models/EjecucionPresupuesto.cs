using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class EjecucionPresupuesto
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public int Id { get; set; } 
        public int IdPresupuesto { get; set; } 
        public int Anio { get; set; } 
        public double? MontoPlaneado { get; set; }
         public double? MontoEjecutado { get; set; }
         public string Observaciones { get; set; } = string.Empty;


    }
}