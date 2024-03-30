#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("PlaceAsTileResult")]
public class PlaceAsTileResult
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

