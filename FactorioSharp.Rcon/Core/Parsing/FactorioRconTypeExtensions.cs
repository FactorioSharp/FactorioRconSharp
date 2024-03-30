using System.Collections;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Core.Parsing;

static class FactorioRconTypeExtensions
{
    public static bool IsTableType(this Type type) => typeof(IDictionary).IsAssignableFrom(type);
    public static bool IsLuaCustomTable(this Type type) => typeof(ILuaCustomTable).IsAssignableFrom(type);
}
