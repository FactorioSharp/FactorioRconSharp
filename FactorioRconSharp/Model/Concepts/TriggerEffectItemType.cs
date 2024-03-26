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
/// Used by <see cref="TriggerEffectItem" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TriggerEffectItemType")]
public abstract partial class TriggerEffectItemType: OneOfBase<Literal30330347, Literal32957531, Literal21019525, Literal38756850, Literal8587493, Literal46119628, Literal28988105, Literal4770431, Literal33070207, Literal23385714, Literal21337957, Literal45443930, Literal14798442, Literal42331837, Literal16553355, Literal12076145, Literal52272470, Literal23980061, Literal33819242, Literal39115446>
{
}

[GenerateOneOf]
public abstract partial class Union65357506: OneOfBase<Literal30330347, Literal32957531, Literal21019525, Literal38756850, Literal8587493, Literal46119628, Literal28988105, Literal4770431, Literal33070207, Literal23385714, Literal21337957, Literal45443930, Literal14798442, Literal42331837, Literal16553355, Literal12076145, Literal52272470, Literal23980061, Literal33819242, Literal39115446>
{
}

/// <summary>
/// Literal value: damage
/// </summary>
public abstract class Literal30330347
{
  /// <summary>
  /// Literal value: damage
  /// </summary>
  [FactorioRconAttribute("damage")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-entity
/// </summary>
public abstract class Literal32957531
{
  /// <summary>
  /// Literal value: create-entity
  /// </summary>
  [FactorioRconAttribute("create-entity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-explosion
/// </summary>
public abstract class Literal21019525
{
  /// <summary>
  /// Literal value: create-explosion
  /// </summary>
  [FactorioRconAttribute("create-explosion")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-fire
/// </summary>
public abstract class Literal38756850
{
  /// <summary>
  /// Literal value: create-fire
  /// </summary>
  [FactorioRconAttribute("create-fire")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-smoke
/// </summary>
public abstract class Literal8587493
{
  /// <summary>
  /// Literal value: create-smoke
  /// </summary>
  [FactorioRconAttribute("create-smoke")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-trivial-smoke
/// </summary>
public abstract class Literal46119628
{
  /// <summary>
  /// Literal value: create-trivial-smoke
  /// </summary>
  [FactorioRconAttribute("create-trivial-smoke")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-particle
/// </summary>
public abstract class Literal28988105
{
  /// <summary>
  /// Literal value: create-particle
  /// </summary>
  [FactorioRconAttribute("create-particle")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-sticker
/// </summary>
public abstract class Literal4770431
{
  /// <summary>
  /// Literal value: create-sticker
  /// </summary>
  [FactorioRconAttribute("create-sticker")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: create-decorative
/// </summary>
public abstract class Literal33070207
{
  /// <summary>
  /// Literal value: create-decorative
  /// </summary>
  [FactorioRconAttribute("create-decorative")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: nested-result
/// </summary>
public abstract class Literal23385714
{
  /// <summary>
  /// Literal value: nested-result
  /// </summary>
  [FactorioRconAttribute("nested-result")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: play-sound
/// </summary>
public abstract class Literal21337957
{
  /// <summary>
  /// Literal value: play-sound
  /// </summary>
  [FactorioRconAttribute("play-sound")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: push-back
/// </summary>
public abstract class Literal45443930
{
  /// <summary>
  /// Literal value: push-back
  /// </summary>
  [FactorioRconAttribute("push-back")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: destroy-cliffs
/// </summary>
public abstract class Literal14798442
{
  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconAttribute("destroy-cliffs")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: show-explosion-on-chart
/// </summary>
public abstract class Literal42331837
{
  /// <summary>
  /// Literal value: show-explosion-on-chart
  /// </summary>
  [FactorioRconAttribute("show-explosion-on-chart")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: insert-item
/// </summary>
public abstract class Literal16553355
{
  /// <summary>
  /// Literal value: insert-item
  /// </summary>
  [FactorioRconAttribute("insert-item")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: script
/// </summary>
public abstract class Literal12076145
{
  /// <summary>
  /// Literal value: script
  /// </summary>
  [FactorioRconAttribute("script")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: set-tile
/// </summary>
public abstract class Literal52272470
{
  /// <summary>
  /// Literal value: set-tile
  /// </summary>
  [FactorioRconAttribute("set-tile")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: invoke-tile-trigger
/// </summary>
public abstract class Literal23980061
{
  /// <summary>
  /// Literal value: invoke-tile-trigger
  /// </summary>
  [FactorioRconAttribute("invoke-tile-trigger")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: destroy-decoratives
/// </summary>
public abstract class Literal33819242
{
  /// <summary>
  /// Literal value: destroy-decoratives
  /// </summary>
  [FactorioRconAttribute("destroy-decoratives")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: camera-effect
/// </summary>
public abstract class Literal39115446
{
  /// <summary>
  /// Literal value: camera-effect
  /// </summary>
  [FactorioRconAttribute("camera-effect")]
  public static object Value { get; private set; }

}

