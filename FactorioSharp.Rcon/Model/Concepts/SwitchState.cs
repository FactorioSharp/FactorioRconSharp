#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     State of a GUI <see cref="LuaGuiElement.SwitchState" />.
/// </summary>
[FactorioRconDefinition("SwitchState")]
public enum SwitchState
{
  /// <summary>
  ///     Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
    Left,

  /// <summary>
  ///     Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
    Right,

  /// <summary>
  ///     Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
    None
}
