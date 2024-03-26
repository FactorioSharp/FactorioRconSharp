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
/// A set of flags on a selection tool that define how entities and tiles are selected. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// </summary>
[FactorioRconConcept("SelectionModeFlags")]
public abstract class SelectionModeFlags: Dictionary<Union50828906, Literal1621362>
{
}

[GenerateOneOf]
public abstract partial class Union50828906: OneOfBase<Literal59990429, Literal5053392, Literal52757806, Literal5881768, Literal16298857, Literal66186817, Literal32993134, Literal12786415, Literal3335338, Literal56298650, Literal2675291, Literal31876919, Literal38595343, Literal18741581, Literal22349861, Literal21638512, Literal62427466, Literal28114888, Literal33617916, Literal35903370, Literal53356298, Literal28025981, Literal30328337, Literal48406645>
{
}

/// <summary>
/// Literal value: blueprint
/// </summary>
public abstract class Literal59990429
{
  /// <summary>
  /// Literal value: blueprint
  /// </summary>
  [FactorioRconAttribute("blueprint")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: deconstruct
/// </summary>
public abstract class Literal5053392
{
  /// <summary>
  /// Literal value: deconstruct
  /// </summary>
  [FactorioRconAttribute("deconstruct")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: cancel-deconstruct
/// </summary>
public abstract class Literal52757806
{
  /// <summary>
  /// Literal value: cancel-deconstruct
  /// </summary>
  [FactorioRconAttribute("cancel-deconstruct")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: items
/// </summary>
public abstract class Literal5881768
{
  /// <summary>
  /// Literal value: items
  /// </summary>
  [FactorioRconAttribute("items")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: trees
/// </summary>
public abstract class Literal16298857
{
  /// <summary>
  /// Literal value: trees
  /// </summary>
  [FactorioRconAttribute("trees")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: buildable-type
/// </summary>
public abstract class Literal66186817
{
  /// <summary>
  /// Literal value: buildable-type
  /// </summary>
  [FactorioRconAttribute("buildable-type")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: nothing
/// </summary>
public abstract class Literal32993134
{
  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconAttribute("nothing")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: items-to-place
/// </summary>
public abstract class Literal12786415
{
  /// <summary>
  /// Literal value: items-to-place
  /// </summary>
  [FactorioRconAttribute("items-to-place")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: any-entity
/// </summary>
public abstract class Literal3335338
{
  /// <summary>
  /// Literal value: any-entity
  /// </summary>
  [FactorioRconAttribute("any-entity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: any-tile
/// </summary>
public abstract class Literal56298650
{
  /// <summary>
  /// Literal value: any-tile
  /// </summary>
  [FactorioRconAttribute("any-tile")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: same-force
/// </summary>
public abstract class Literal2675291
{
  /// <summary>
  /// Literal value: same-force
  /// </summary>
  [FactorioRconAttribute("same-force")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-same-force
/// </summary>
public abstract class Literal31876919
{
  /// <summary>
  /// Literal value: not-same-force
  /// </summary>
  [FactorioRconAttribute("not-same-force")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: friend
/// </summary>
public abstract class Literal38595343
{
  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconAttribute("friend")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: enemy
/// </summary>
public abstract class Literal18741581
{
  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconAttribute("enemy")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: upgrade
/// </summary>
public abstract class Literal22349861
{
  /// <summary>
  /// Literal value: upgrade
  /// </summary>
  [FactorioRconAttribute("upgrade")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: cancel-upgrade
/// </summary>
public abstract class Literal21638512
{
  /// <summary>
  /// Literal value: cancel-upgrade
  /// </summary>
  [FactorioRconAttribute("cancel-upgrade")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: downgrade
/// </summary>
public abstract class Literal62427466
{
  /// <summary>
  /// Literal value: downgrade
  /// </summary>
  [FactorioRconAttribute("downgrade")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity-with-health
/// </summary>
public abstract class Literal28114888
{
  /// <summary>
  /// Literal value: entity-with-health
  /// </summary>
  [FactorioRconAttribute("entity-with-health")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity-with-force
/// </summary>
public abstract class Literal33617916
{
  /// <summary>
  /// Literal value: entity-with-force
  /// </summary>
  [FactorioRconAttribute("entity-with-force")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: is-military-target
/// </summary>
public abstract class Literal35903370
{
  /// <summary>
  /// Literal value: is-military-target
  /// </summary>
  [FactorioRconAttribute("is-military-target")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity-with-owner
/// </summary>
public abstract class Literal53356298
{
  /// <summary>
  /// Literal value: entity-with-owner
  /// </summary>
  [FactorioRconAttribute("entity-with-owner")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: avoid-rolling-stock
/// </summary>
public abstract class Literal28025981
{
  /// <summary>
  /// Literal value: avoid-rolling-stock
  /// </summary>
  [FactorioRconAttribute("avoid-rolling-stock")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity-ghost
/// </summary>
public abstract class Literal30328337
{
  /// <summary>
  /// Literal value: entity-ghost
  /// </summary>
  [FactorioRconAttribute("entity-ghost")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: tile-ghost
/// </summary>
public abstract class Literal48406645
{
  /// <summary>
  /// Literal value: tile-ghost
  /// </summary>
  [FactorioRconAttribute("tile-ghost")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public abstract class Literal1621362
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconAttribute("True")]
  public static object Value { get; private set; }

}

