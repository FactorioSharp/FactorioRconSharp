#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ScriptRenderTarget")]
public class ScriptRenderTarget: IFactorioRconModel
{
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; set; }

  [FactorioRconAttribute("entity_offset")]
  public Vector EntityOffset { get; set; }

  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

