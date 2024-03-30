using System.Collections;
using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Core.Parsing;

static class FactorioRconTypeExtensions
{
    public static bool IsFactorioRconModel(this Type type) => typeof(IFactorioRconModel).IsAssignableFrom(type);
    public static bool IsTableType(this Type type) => typeof(IDictionary).IsAssignableFrom(type);
}
