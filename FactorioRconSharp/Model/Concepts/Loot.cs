#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Loot")]
public abstract class Loot
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

