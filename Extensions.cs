using System.Text.Json;

namespace Algorithms;

public static class Extensions
{
    public static string ToJson(this int[] inp)
    {
        return JsonSerializer.Serialize(inp);
    }
    
    public static string ToJson(this List<int> inp)
    {
        return JsonSerializer.Serialize(inp);
    }
}