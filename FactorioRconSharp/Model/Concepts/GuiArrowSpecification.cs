#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used for specifying where a GUI arrow should point to.
/// </summary>
[FactorioRconConcept("GuiArrowSpecification")]
public abstract class GuiArrowSpecification
{
  [FactorioRconAttribute("margin")]
  public uint Margin { get; set; }

  /// <summary>
  /// This determines which of the following fields will be required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public GuiArrowType Type { get; set; }

}

/// <summary>
/// Union of literals:
///   - player
///   - target
///   - player-quickbar
///   - player-equipment-bar
/// </summary>
public enum Union5141801
{
  /// <summary>
  /// Literal value: player
  /// </summary>
  [FactorioRconDefinitionValue("player")]
  Player,

  /// <summary>
  /// Literal value: target
  /// </summary>
  [FactorioRconDefinitionValue("target")]
  Target,

  /// <summary>
  /// Literal value: player-quickbar
  /// </summary>
  [FactorioRconDefinitionValue("player-quickbar")]
  PlayerQuickbar,

  /// <summary>
  /// Literal value: player-equipment-bar
  /// </summary>
  [FactorioRconDefinitionValue("player-equipment-bar")]
  PlayerEquipmentBar,

}

