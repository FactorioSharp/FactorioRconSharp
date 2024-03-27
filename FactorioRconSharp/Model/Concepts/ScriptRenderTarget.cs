#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ScriptRenderTarget")]
public abstract class ScriptRenderTarget
{
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; set; }

  [FactorioRconAttribute("entity_offset")]
  public Vector EntityOffset { get; set; }

  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

}

