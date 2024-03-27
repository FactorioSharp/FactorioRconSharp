#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("LogisticsNetworkSupplyCounts")]
public abstract class LogisticsNetworkSupplyCounts
{
  /// <summary>
  /// Number of available items in the storage members.
  /// </summary>
  [FactorioRconAttribute("storage")]
  public uint Storage { get; set; }

  /// <summary>
  /// Number of available items in the passive provider members.
  /// </summary>
  [FactorioRconAttribute("passive-provider")]
  public uint Passivesubtractprovider { get; set; }

  /// <summary>
  /// Number of available items in the buffer members.
  /// </summary>
  [FactorioRconAttribute("buffer")]
  public uint Buffer { get; set; }

  /// <summary>
  /// Number of available items in the active provider members.
  /// </summary>
  [FactorioRconAttribute("active-provider")]
  public uint Activesubtractprovider { get; set; }

}
