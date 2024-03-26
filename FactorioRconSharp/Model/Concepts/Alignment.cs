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
/// A <see cref="String" /> that specifies where a GUI element should be.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("Alignment")]
public abstract partial class Alignment: OneOfBase<Literal51998856, Literal18234153, Literal47372899, Literal55306802, Literal20592155, Literal29782071, Literal21443715, Literal47664838, Literal61437506, Literal15119229, Literal49068367>
{
}

[GenerateOneOf]
public abstract partial class Union50411038: OneOfBase<Literal51998856, Literal18234153, Literal47372899, Literal55306802, Literal20592155, Literal29782071, Literal21443715, Literal47664838, Literal61437506, Literal15119229, Literal49068367>
{
}

/// <summary>
/// Literal value: top-left
/// </summary>
public abstract class Literal51998856
{
  /// <summary>
  /// Literal value: top-left
  /// </summary>
  [FactorioRconAttribute("top-left")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: middle-left
/// </summary>
public abstract class Literal18234153
{
  /// <summary>
  /// Literal value: middle-left
  /// </summary>
  [FactorioRconAttribute("middle-left")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: left
/// </summary>
public abstract class Literal47372899
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconAttribute("left")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: bottom-left
/// </summary>
public abstract class Literal55306802
{
  /// <summary>
  /// Literal value: bottom-left
  /// </summary>
  [FactorioRconAttribute("bottom-left")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: top-center
/// </summary>
public abstract class Literal20592155
{
  /// <summary>
  /// Literal value: top-center
  /// </summary>
  [FactorioRconAttribute("top-center")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: middle-center
/// </summary>
public abstract class Literal29782071
{
  /// <summary>
  /// Literal value: middle-center
  /// </summary>
  [FactorioRconAttribute("middle-center")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: center
/// </summary>
public abstract class Literal21443715
{
  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconAttribute("center")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: bottom-center
/// </summary>
public abstract class Literal47664838
{
  /// <summary>
  /// Literal value: bottom-center
  /// </summary>
  [FactorioRconAttribute("bottom-center")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: top-right
/// </summary>
public abstract class Literal61437506
{
  /// <summary>
  /// Literal value: top-right
  /// </summary>
  [FactorioRconAttribute("top-right")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: right
/// </summary>
public abstract class Literal15119229
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconAttribute("right")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: bottom-right
/// </summary>
public abstract class Literal49068367
{
  /// <summary>
  /// Literal value: bottom-right
  /// </summary>
  [FactorioRconAttribute("bottom-right")]
  public static object Value { get; private set; }

}

