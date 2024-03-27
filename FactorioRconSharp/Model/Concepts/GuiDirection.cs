#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Direction of a <see cref="LuaGuiElement.Direction" /> layout.
/// </summary>
[FactorioRconDefinition("GuiDirection")]
public enum GuiDirection
{
  /// <summary>
  /// Literal value: horizontal
  /// </summary>
  [FactorioRconDefinitionValue("horizontal")]
  Horizontal,

  /// <summary>
  /// Literal value: vertical
  /// </summary>
  [FactorioRconDefinitionValue("vertical")]
  Vertical,

}

