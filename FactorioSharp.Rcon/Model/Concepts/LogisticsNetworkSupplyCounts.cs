#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("LogisticsNetworkSupplyCounts")]
public class LogisticsNetworkSupplyCounts
{
  /// <summary>
  ///     Number of available items in the storage members.
  /// </summary>
  [FactorioRconAttribute("storage")]
    public uint Storage { get; set; }

  /// <summary>
  ///     Number of available items in the passive provider members.
  /// </summary>
  [FactorioRconAttribute("passive-provider")]
    public uint PassiveProvider { get; set; }

  /// <summary>
  ///     Number of available items in the buffer members.
  /// </summary>
  [FactorioRconAttribute("buffer")]
    public uint Buffer { get; set; }

  /// <summary>
  ///     Number of available items in the active provider members.
  /// </summary>
  [FactorioRconAttribute("active-provider")]
    public uint ActiveProvider { get; set; }
}
