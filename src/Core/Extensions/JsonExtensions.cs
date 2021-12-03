using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Extensions
{
    /// <summary>
    /// It allows to centralize and easily change the library used for handling JSON. At this moment the one provided by the framework is used, but it could be changed for example by NewtonSoft
    /// </summary>
    public static class JsonExtensions
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true

        };

        public static T FromJson<T>(this string json) => JsonSerializer.Deserialize<T>(json, _jsonOptions);

        public static string ToJson<T>(this T obj) => JsonSerializer.Serialize<T>(obj, _jsonOptions);

    }
}
