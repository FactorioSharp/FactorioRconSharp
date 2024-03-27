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
/// Defines which slider in the game's sound settings affects the volume of this sound. Furthermore, some sound types are mixed differently than others, e.g. zoom level effects are applied.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("SoundType")]
public abstract partial class SoundType: OneOfBase<Literal57263796, Literal50037355, Literal41797171, Literal4158431, Literal53485662, Literal7580331, Literal18503033>
{
}

[GenerateOneOf]
public abstract partial class Union25115601: OneOfBase<Literal57263796, Literal50037355, Literal41797171, Literal4158431, Literal53485662, Literal7580331, Literal18503033>
{
}

/// <summary>
/// Literal value: game-effect
/// </summary>
public enum Literal57263796
{
  /// <summary>
  /// Literal value: game-effect
  /// </summary>
  [FactorioRconDefinitionValue("game-effect")]
  GameEffect,

}

/// <summary>
/// Literal value: gui-effect
/// </summary>
public enum Literal50037355
{
  /// <summary>
  /// Literal value: gui-effect
  /// </summary>
  [FactorioRconDefinitionValue("gui-effect")]
  GuiEffect,

}

/// <summary>
/// Literal value: ambient
/// </summary>
public enum Literal41797171
{
  /// <summary>
  /// Literal value: ambient
  /// </summary>
  [FactorioRconDefinitionValue("ambient")]
  Ambient,

}

/// <summary>
/// Literal value: environment
/// </summary>
public enum Literal4158431
{
  /// <summary>
  /// Literal value: environment
  /// </summary>
  [FactorioRconDefinitionValue("environment")]
  Environment,

}

/// <summary>
/// Literal value: walking
/// </summary>
public enum Literal53485662
{
  /// <summary>
  /// Literal value: walking
  /// </summary>
  [FactorioRconDefinitionValue("walking")]
  Walking,

}

/// <summary>
/// Literal value: alert
/// </summary>
public enum Literal7580331
{
  /// <summary>
  /// Literal value: alert
  /// </summary>
  [FactorioRconDefinitionValue("alert")]
  Alert,

}

/// <summary>
/// Literal value: wind
/// </summary>
public enum Literal18503033
{
  /// <summary>
  /// Literal value: wind
  /// </summary>
  [FactorioRconDefinitionValue("wind")]
  Wind,

}

