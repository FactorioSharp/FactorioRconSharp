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
/// Scroll policy of a <see cref="LuaGuiElement" />.
/// </summary>
[FactorioRconDefinition("ScrollPolicy")]
public enum ScrollPolicy
{
  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

  /// <summary>
  /// Literal value: dont-show-but-allow-scrolling
  /// </summary>
  [FactorioRconDefinitionValue("dont-show-but-allow-scrolling")]
  DontShowButAllowScrolling,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: auto
  /// </summary>
  [FactorioRconDefinitionValue("auto")]
  Auto,

  /// <summary>
  /// Literal value: auto-and-reserve-space
  /// </summary>
  [FactorioRconDefinitionValue("auto-and-reserve-space")]
  AutoAndReserveSpace,

}

