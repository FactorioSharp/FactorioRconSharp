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
public abstract partial class GuiDirection: OneOfBase<Literal15794481, Literal63248657>
{
}

[GenerateOneOf]
public abstract partial class Union51882681: OneOfBase<Literal15794481, Literal63248657>
{
}

/// <summary>
/// Literal value: horizontal
/// </summary>
public enum Literal15794481
{
  /// <summary>
  /// Literal value: horizontal
  /// </summary>
  [FactorioRconDefinitionValue("horizontal")]
  Horizontal,

}

/// <summary>
/// Literal value: vertical
/// </summary>
public enum Literal63248657
{
  /// <summary>
  /// Literal value: vertical
  /// </summary>
  [FactorioRconDefinitionValue("vertical")]
  Vertical,

}

