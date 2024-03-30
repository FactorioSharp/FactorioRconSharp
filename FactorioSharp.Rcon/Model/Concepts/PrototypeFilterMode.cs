#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     One of the following values:
/// </summary>
[FactorioRconDefinition("PrototypeFilterMode")]
public enum PrototypeFilterMode
{
  /// <summary>
  ///     Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
    None,

  /// <summary>
  ///     Literal value: whitelist
  /// </summary>
  [FactorioRconDefinitionValue("whitelist")]
    Whitelist,

  /// <summary>
  ///     Literal value: blacklist
  /// </summary>
  [FactorioRconDefinitionValue("blacklist")]
    Blacklist
}
