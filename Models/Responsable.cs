using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Responsable
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

         public int Id { get; set; }
        public int IdTipoResponsable { get; set; } 
        public int IdUsuario { get; set; } 
        public string Nombre { get; set; }= string.Empty;
        
    }
}