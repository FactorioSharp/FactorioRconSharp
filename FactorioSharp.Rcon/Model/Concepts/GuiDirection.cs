#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

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

