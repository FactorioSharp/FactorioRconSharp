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
/// Control behavior for transport belts.
/// </summary>
[FactorioRconClass("LuaTransportBeltControlBehavior")]
public abstract class LuaTransportBeltControlBehavior: LuaGenericOnOffControlBehavior
{
  /// <summary>
  /// If the belt will be enabled/disabled based off the circuit network.
  /// </summary>
  [FactorioRconAttribute("enable_disable")]
  public bool EnableDisable { get; set; }

  /// <summary>
  /// If the belt will read the contents and send them to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_contents")]
  public bool ReadContents { get; set; }

  /// <summary>
  /// The read mode for the belt.
  /// </summary>
  [FactorioRconAttribute("read_contents_mode")]
  public ControlBehaviorTransportBeltContentReadModeEnum ReadContentsMode { get; set; }

}

