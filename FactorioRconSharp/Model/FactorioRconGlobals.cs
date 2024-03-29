using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Classes;

namespace FactorioRconSharp.Model;

public class FactorioRconGlobals
{
    [FactorioRconAttribute("game")]
    public LuaGameScript Game { get; }
}
