#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// Control behavior for mining drills.
/// </summary>
[FactorioRconClass("LuaMiningDrillControlBehavior")]
public abstract class LuaMiningDrillControlBehavior: LuaGenericOnOffControlBehavior
{
  /// <summary>
  /// `true` if this drill is enabled or disabled using the logistics or circuit condition.
  /// </summary>
  [FactorioRconAttribute("circuit_enable_disable")]
  public bool CircuitEnableDisable { get; set; }

  /// <summary>
  /// `true` if this drill should send the resources in the field to the circuit network. Which resources depends on <see cref="LuaMiningDrillControlBehavior.ResourceReadMode" />
  /// </summary>
  [FactorioRconAttribute("circuit_read_resources")]
  public bool CircuitReadResources { get; set; }

  /// <summary>
  /// If the mining drill should send just the resources in its area or the entire field it's on to the circuit network.
  /// </summary>
  [FactorioRconAttribute("resource_read_mode")]
  public ControlBehaviorMiningDrillResourceReadModeEnum ResourceReadMode { get; set; }

  /// <summary>
  /// The resource entities that the mining drill will send information about to the circuit network or an empty array.
  /// </summary>
  [FactorioRconAttribute("resource_read_targets")]
  public List<LuaEntity> ResourceReadTargets { get; private set; }

}

