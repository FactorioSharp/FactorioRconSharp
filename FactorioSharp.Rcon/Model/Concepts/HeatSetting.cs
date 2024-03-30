#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// The settings used by a heat-interface type entity.
/// </summary>
[FactorioRconConcept("HeatSetting")]
public class HeatSetting: IFactorioRconModel
{
  /// <summary>
  /// The target temperature. Defaults to the minimum temperature of the heat buffer.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Literals798748880 Mode { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

