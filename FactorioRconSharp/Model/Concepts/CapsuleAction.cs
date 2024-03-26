#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CapsuleAction")]
public abstract class CapsuleAction
{
  [FactorioRconAttribute("type")]
  public Union54608724 Type { get; set; }

}

public abstract class Table3289664
{
  [FactorioRconAttribute("type")]
  public Union54608724 Type { get; set; }

}

[GenerateOneOf]
public abstract partial class Union54608724: OneOfBase<Literal7256877, Literal69002, Literal2553105, Literal27356029, Literal5540138>
{
}

/// <summary>
/// Literal value: throw
/// </summary>
public abstract class Literal7256877
{
  /// <summary>
  /// Literal value: throw
  /// </summary>
  [FactorioRconAttribute("throw")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: equipment-remote
/// </summary>
public abstract class Literal69002
{
  /// <summary>
  /// Literal value: equipment-remote
  /// </summary>
  [FactorioRconAttribute("equipment-remote")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: use-on-self
/// </summary>
public abstract class Literal2553105
{
  /// <summary>
  /// Literal value: use-on-self
  /// </summary>
  [FactorioRconAttribute("use-on-self")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: artillery-remote
/// </summary>
public abstract class Literal27356029
{
  /// <summary>
  /// Literal value: artillery-remote
  /// </summary>
  [FactorioRconAttribute("artillery-remote")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: destroy-cliffs
/// </summary>
public abstract class Literal5540138
{
  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconAttribute("destroy-cliffs")]
  public static object Value { get; private set; }

}

