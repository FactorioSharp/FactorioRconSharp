#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModSetting")]
public class ModSetting
{
  /// <summary>
  ///     The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
    public Union1680461584 Value { get; set; }
}
