#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

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

