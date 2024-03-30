#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModChangeData")]
public class ModChangeData
{
  /// <summary>
  ///     Old version of the mod. May be `nil` if the mod wasn't previously present (i.e. it was just added).
  /// </summary>
  [FactorioRconAttribute("old_version")]
    public string OldVersion { get; set; }

  /// <summary>
  ///     New version of the mod. May be `nil` if the mod is no longer present (i.e. it was just removed).
  /// </summary>
  [FactorioRconAttribute("new_version")]
    public string NewVersion { get; set; }
}
