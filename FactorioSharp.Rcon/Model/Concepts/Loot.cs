#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Loot")]
public class Loot
{
  /// <summary>
  /// Item prototype name of the result.
  /// </summary>
  [FactorioRconAttribute("item")]
  public string Item { get; set; }

  /// <summary>
  /// Probability that any loot at all will drop, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("probability")]
  public double Probability { get; set; }

  /// <summary>
  /// Minimum amount of loot to drop.
  /// </summary>
  [FactorioRconAttribute("count_min")]
  public double CountMin { get; set; }

  /// <summary>
  /// Maximum amount of loot to drop.
  /// </summary>
  [FactorioRconAttribute("count_max")]
  public double CountMax { get; set; }

}

