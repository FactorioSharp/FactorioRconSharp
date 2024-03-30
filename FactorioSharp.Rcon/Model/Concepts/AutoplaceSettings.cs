#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AutoplaceSettings")]
public class AutoplaceSettings: IFactorioRconModel
{
  /// <summary>
  /// Whether missing autoplace names for this type should be default enabled.
  /// </summary>
  [FactorioRconAttribute("treat_missing_as_default")]
  public bool TreatMissingAsDefault { get; set; }

  [FactorioRconAttribute("settings")]
  public Dictionary<string, AutoplaceControl> Settings { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

