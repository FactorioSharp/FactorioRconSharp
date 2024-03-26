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
/// Direction of a <see cref="LuaGuiElement.Direction" /> layout.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("GuiDirection")]
public abstract partial class GuiDirection: OneOfBase<Literal48472089, Literal63513313>
{
}

[GenerateOneOf]
public abstract partial class Union1671451: OneOfBase<Literal48472089, Literal63513313>
{
}

/// <summary>
/// Literal value: horizontal
/// </summary>
public abstract class Literal48472089
{
  /// <summary>
  /// Literal value: horizontal
  /// </summary>
  [FactorioRconAttribute("horizontal")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: vertical
/// </summary>
public abstract class Literal63513313
{
  /// <summary>
  /// Literal value: vertical
  /// </summary>
  [FactorioRconAttribute("vertical")]
  public static object Value { get; private set; }

}

