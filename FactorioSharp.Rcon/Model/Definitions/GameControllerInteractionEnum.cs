#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("game_controller_interaction")]
public enum GameControllerInteractionEnum
{
  /// <summary>
  /// Game controller will always hover this element regardless of type or state.
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Hover according to the element type and implementation.
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

  /// <summary>
  /// Never hover this element with a game controller.
  /// </summary>
  [FactorioRconDefinitionValue("normal")]
  Normal,

}

