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
/// One of the following values:
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("CursorBoxRenderType")]
public abstract partial class CursorBoxRenderType: OneOfBase<Literal803548, Literal26517107, Literal2649323, Literal20318803, Literal66540731, Literal48360500, Literal52392654, Literal51235992>
{
}

[GenerateOneOf]
public abstract partial class Union58998806: OneOfBase<Literal803548, Literal26517107, Literal2649323, Literal20318803, Literal66540731, Literal48360500, Literal52392654, Literal51235992>
{
}

/// <summary>
/// Literal value: entity
/// </summary>
public abstract class Literal803548
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconAttribute("entity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: electricity
/// </summary>
public abstract class Literal26517107
{
  /// <summary>
  /// Literal value: electricity
  /// </summary>
  [FactorioRconAttribute("electricity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: copy
/// </summary>
public abstract class Literal2649323
{
  /// <summary>
  /// Literal value: copy
  /// </summary>
  [FactorioRconAttribute("copy")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-allowed
/// </summary>
public abstract class Literal20318803
{
  /// <summary>
  /// Literal value: not-allowed
  /// </summary>
  [FactorioRconAttribute("not-allowed")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: pair
/// </summary>
public abstract class Literal66540731
{
  /// <summary>
  /// Literal value: pair
  /// </summary>
  [FactorioRconAttribute("pair")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: logistics
/// </summary>
public abstract class Literal48360500
{
  /// <summary>
  /// Literal value: logistics
  /// </summary>
  [FactorioRconAttribute("logistics")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: train-visualization
/// </summary>
public abstract class Literal52392654
{
  /// <summary>
  /// Literal value: train-visualization
  /// </summary>
  [FactorioRconAttribute("train-visualization")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: blueprint-snap-rectangle
/// </summary>
public abstract class Literal51235992
{
  /// <summary>
  /// Literal value: blueprint-snap-rectangle
  /// </summary>
  [FactorioRconAttribute("blueprint-snap-rectangle")]
  public static object Value { get; private set; }

}

