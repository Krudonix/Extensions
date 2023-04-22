using System.Text.Json;

namespace Extensions.Json
{
    public static class StringJSonExtensions
    {
        public static string ToJson<T>(this T target)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(target, options);
        }

        public static T? FromJson<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
