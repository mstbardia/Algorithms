using System.Text.Json;
using System.Text.Json.Serialization;

namespace Algorithms.Examples;

public static class Extensions
{
    public static string ToJson(this int[] inp)
    {
        return JsonSerializer.Serialize(inp);
    }
}