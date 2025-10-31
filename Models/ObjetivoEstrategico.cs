using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class ObjetivoEstrategico
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public int Id { get; set; } 
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int IdVariable { get; set; }


    }
}