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
public abstract partial class SoundType: OneOfBase<Literal47783528, Literal63930002, Literal352779, Literal7408374, Literal21358135, Literal45867655, Literal23696664>
{
}

[GenerateOneOf]
public abstract partial class Union8666726: OneOfBase<Literal47783528, Literal63930002, Literal352779, Literal7408374, Literal21358135, Literal45867655, Literal23696664>
{
}

/// <summary>
/// Literal value: game-effect
/// </summary>
public abstract class Literal47783528
{
  /// <summary>
  /// Literal value: game-effect
  /// </summary>
  [FactorioRconAttribute("game-effect")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: gui-effect
/// </summary>
public abstract class Literal63930002
{
  /// <summary>
  /// Literal value: gui-effect
  /// </summary>
  [FactorioRconAttribute("gui-effect")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ambient
/// </summary>
public abstract class Literal352779
{
  /// <summary>
  /// Literal value: ambient
  /// </summary>
  [FactorioRconAttribute("ambient")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: environment
/// </summary>
public abstract class Literal7408374
{
  /// <summary>
  /// Literal value: environment
  /// </summary>
  [FactorioRconAttribute("environment")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: walking
/// </summary>
public abstract class Literal21358135
{
  /// <summary>
  /// Literal value: walking
  /// </summary>
  [FactorioRconAttribute("walking")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: alert
/// </summary>
public abstract class Literal45867655
{
  /// <summary>
  /// Literal value: alert
  /// </summary>
  [FactorioRconAttribute("alert")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: wind
/// </summary>
public abstract class Literal23696664
{
  /// <summary>
  /// Literal value: wind
  /// </summary>
  [FactorioRconAttribute("wind")]
  public static object Value { get; private set; }

}

