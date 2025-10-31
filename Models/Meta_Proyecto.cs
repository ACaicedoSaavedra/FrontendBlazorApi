using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Meta_Proyecto
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public int IdMeta { get; set; } 
        public int IdProyecto { get; set; } 
        public DateTime FechaAsociacion { get; set; }=DateTime.Now;
        



    }
}