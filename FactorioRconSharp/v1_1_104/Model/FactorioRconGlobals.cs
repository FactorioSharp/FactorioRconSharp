using FactorioRconSharp.Core.Abstractions;

namespace FactorioRconSharp.v1_1_104.Model;

public class FactorioRconGlobals
{
    [FactorioRconAttribute("game")]
    public FactorioRconLuaGameScript Game { get; } = new();
}
