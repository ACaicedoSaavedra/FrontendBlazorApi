using System.Text.Json.Serialization;
public class RespuestaApi<T>
{
    [JsonPropertyName("datos")]   // La API devuelve todo dentro de "datos"
    public T? Datos { get; set; }
}