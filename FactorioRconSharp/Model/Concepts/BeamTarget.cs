#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("BeamTarget")]
public abstract class BeamTarget
{
  /// <summary>
  /// The target entity.
  /// </summary>
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; set; }

  /// <summary>
  /// The target position.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

}

