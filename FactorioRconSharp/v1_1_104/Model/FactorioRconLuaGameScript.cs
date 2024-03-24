using FactorioRconSharp.Core.Abstractions;

namespace FactorioRconSharp.v1_1_104.Model;

public class FactorioRconLuaGameScript
{
    [FactorioRconAttribute("map_settings")]
    public FactorioRconMapSettings MapSettings { get; } = new();
}
