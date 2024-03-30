#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("LuaPlayerBuiltEntityEventFilter")]
public class LuaPlayerBuiltEntityEventFilter
{
  /// <summary>
  ///     The condition to filter on. One of `"ghost"`, `"rail"`, `"rail-signal"`, `"rolling-stock"`, `"robot-with-logistics-interface"`, `"vehicle"`, `"turret"`, `"crafting-machine"`,
  ///     `"wall-connectable"`, `"transport-belt-connectable"`, `"circuit-network-connectable"`, `"type"`, `"name"`, `"ghost_type"`, `"ghost_name"`, `"force"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
    public string Filter { get; set; }

  /// <summary>
  ///     How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
    public Literals1605436502 Mode { get; set; }

  /// <summary>
  ///     Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
    public bool Invert { get; set; }
}
