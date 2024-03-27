#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

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
  Gamesubtracteffect,

  /// <summary>
  /// Literal value: gui-effect
  /// </summary>
  [FactorioRconDefinitionValue("gui-effect")]
  Guisubtracteffect,

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

