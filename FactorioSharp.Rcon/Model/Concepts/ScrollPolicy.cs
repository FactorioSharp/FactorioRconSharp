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

