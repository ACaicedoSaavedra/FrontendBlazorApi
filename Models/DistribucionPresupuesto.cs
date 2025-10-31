using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class DistribucionPresupuesto
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public int Id { get; set; } 
        public int IdPresupuestoPadre { get; set; } 
        public int IdProyectoHijo { get; set; } 
        public double? MontoAsignado { get; set; }
        


    }
}