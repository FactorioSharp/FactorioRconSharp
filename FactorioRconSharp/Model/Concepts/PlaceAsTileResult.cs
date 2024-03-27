#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("PlaceAsTileResult")]
public abstract class PlaceAsTileResult
{
  /// <summary>
  /// The tile prototype.
  /// </summary>
  [FactorioRconAttribute("result")]
  public LuaTilePrototype Result { get; set; }

  [FactorioRconAttribute("condition_size")]
  public uint ConditionSize { get; set; }

  [FactorioRconAttribute("condition")]
  public CollisionMask Condition { get; set; }

}

