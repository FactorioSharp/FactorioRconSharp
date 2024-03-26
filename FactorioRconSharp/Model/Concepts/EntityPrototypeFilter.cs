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
/// Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("EntityPrototypeFilter")]
public abstract class EntityPrototypeFilter
{
  /// <summary>
  /// The condition to filter on. One of `"flying-robot"`, `"robot-with-logistics-interface"`, `"rail"`, `"ghost"`, `"explosion"`, `"vehicle"`, `"crafting-machine"`, `"rolling-stock"`, `"turret"`, `"transport-belt-connectable"`, `"wall-connectable"`, `"buildable"`, `"placable-in-editor"`, `"clonable"`, `"selectable"`, `"hidden"`, `"entity-with-health"`, `"building"`, `"fast-replaceable"`, `"uses-direction"`, `"minable"`, `"circuit-connectable"`, `"autoplace"`, `"blueprintable"`, `"item-to-place"`, `"name"`, `"type"`, `"collision-mask"`, `"flag"`, `"build-base-evolution-requirement"`, `"selection-priority"`, `"emissions"`, `"crafting-category"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union28705829 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

public abstract class Table28759041
{
  /// <summary>
  /// The condition to filter on. One of `"flying-robot"`, `"robot-with-logistics-interface"`, `"rail"`, `"ghost"`, `"explosion"`, `"vehicle"`, `"crafting-machine"`, `"rolling-stock"`, `"turret"`, `"transport-belt-connectable"`, `"wall-connectable"`, `"buildable"`, `"placable-in-editor"`, `"clonable"`, `"selectable"`, `"hidden"`, `"entity-with-health"`, `"building"`, `"fast-replaceable"`, `"uses-direction"`, `"minable"`, `"circuit-connectable"`, `"autoplace"`, `"blueprintable"`, `"item-to-place"`, `"name"`, `"type"`, `"collision-mask"`, `"flag"`, `"build-base-evolution-requirement"`, `"selection-priority"`, `"emissions"`, `"crafting-category"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union28705829 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

[GenerateOneOf]
public abstract partial class Union28705829: OneOfBase<Literal27162691, Literal49520539>
{
}

/// <summary>
/// Literal value: or
/// </summary>
public abstract class Literal27162691
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconAttribute("or")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: and
/// </summary>
public abstract class Literal49520539
{
  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconAttribute("and")]
  public static object Value { get; private set; }

}

[GenerateOneOf]
public abstract partial class Union26809489: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

[GenerateOneOf]
public abstract partial class Union39277698: OneOfBase<Literal65311427, Literal14983193, Literal31859421, Literal51507982>
{
}

/// <summary>
/// Literal value: collides
/// </summary>
public abstract class Literal65311427
{
  /// <summary>
  /// Literal value: collides
  /// </summary>
  [FactorioRconAttribute("collides")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: layers-equals
/// </summary>
public abstract class Literal14983193
{
  /// <summary>
  /// Literal value: layers-equals
  /// </summary>
  [FactorioRconAttribute("layers-equals")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: contains-any
/// </summary>
public abstract class Literal31859421
{
  /// <summary>
  /// Literal value: contains-any
  /// </summary>
  [FactorioRconAttribute("contains-any")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: contains-all
/// </summary>
public abstract class Literal51507982
{
  /// <summary>
  /// Literal value: contains-all
  /// </summary>
  [FactorioRconAttribute("contains-all")]
  public static object Value { get; private set; }

}

[GenerateOneOf]
public abstract partial class Union17336470: OneOfBase<string, List<string>>
{
}

[GenerateOneOf]
public abstract partial class Union32995582: OneOfBase<string, List<string>>
{
}

