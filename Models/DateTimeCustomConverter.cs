using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class DateTimeCustomConverter : JsonConverter<DateTime>
    {
        private static readonly string[] AcceptedFormats = new[]
        {
            "yyyy/MM/dd",
            "yyyy/M/d",
            "yyyy/MM//dd",
            "yyyy-MM-dd",
            "yyyy-MM-ddTHH:mm:ss",
            "yyyy/MM/ddTHH:mm:ss",
            "o",
            "s"
        };

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return default;

            string s;
            if (reader.TokenType == JsonTokenType.String)
                s = reader.GetString() ?? string.Empty;
            else if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var n))
                s = n.ToString();
            else
                return default;

            s = s.Trim();
            if (string.IsNullOrEmpty(s))
                return default;

            // Normaliza dobles barras y separadores inconsistentes
            s = s.Replace("//", "/").Replace("\\", "/");

            if (DateTime.TryParseExact(s, AcceptedFormats, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var dt))
                return dt;

            if (DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt))
                return dt;

            // Si viene epoch en ms/segundos
            if (long.TryParse(s, out var val))
            {
                if (val > 1_000_000_000_000) // ms
                    return DateTimeOffset.FromUnixTimeMilliseconds(val).DateTime;
                if (val > 1_000_000_000) // s
                    return DateTimeOffset.FromUnixTimeSeconds(val).DateTime;
            }

            // Si no se pudo parsear, devuelve default para evitar excepción de deserialización
            return default;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("o"));
        }
    }
}