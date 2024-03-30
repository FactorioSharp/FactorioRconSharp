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
/// Defines which slider in the game's sound settings affects the volume of this sound. Furthermore, some sound types are mixed differently than others, e.g. zoom level effects are applied.
/// </summary>
[FactorioRconDefinition("SoundType")]
public enum SoundType
{
  /// <summary>
  /// Literal value: game-effect
  /// </summary>
  [FactorioRconDefinitionValue("game-effect")]
  GameEffect,

  /// <summary>
  /// Literal value: gui-effect
  /// </summary>
  [FactorioRconDefinitionValue("gui-effect")]
  GuiEffect,

  /// <summary>
  /// Literal value: ambient
  /// </summary>
  [FactorioRconDefinitionValue("ambient")]
  Ambient,

  /// <summary>
  /// Literal value: environment
  /// </summary>
  [FactorioRconDefinitionValue("environment")]
  Environment,

  /// <summary>
  /// Literal value: walking
  /// </summary>
  [FactorioRconDefinitionValue("walking")]
  Walking,

  /// <summary>
  /// Literal value: alert
  /// </summary>
  [FactorioRconDefinitionValue("alert")]
  Alert,

  /// <summary>
  /// Literal value: wind
  /// </summary>
  [FactorioRconDefinitionValue("wind")]
  Wind,

}

