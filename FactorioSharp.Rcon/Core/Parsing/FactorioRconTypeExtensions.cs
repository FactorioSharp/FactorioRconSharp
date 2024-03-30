using System.Collections;

namespace FactorioSharp.Rcon.Core.Parsing;

static class FactorioRconTypeExtensions
{
    public static bool IsTableType(this Type type) => typeof(IDictionary).IsAssignableFrom(type);
}
