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
/// A string that specifies how the inputs should be compared
/// </summary>
[FactorioRconDefinition("ComparatorString")]
public enum ComparatorString
{
  /// <summary>
  /// Literal value: =
  /// </summary>
  [FactorioRconDefinitionValue("=")]
  Eq,

  /// <summary>
  /// Literal value: >
  /// </summary>
  [FactorioRconDefinitionValue(">")]
  Gt,

  /// <summary>
  /// Literal value: <
  /// </summary>
  [FactorioRconDefinitionValue("<")]
  Lt,

  /// <summary>
  /// Literal value: ≥, >=
  /// </summary>
  [FactorioRconDefinitionValue("≥")]
  Ge,

  /// <summary>
  /// Literal value: ≤, <=
  /// </summary>
  [FactorioRconDefinitionValue("≤")]
  Le,

  /// <summary>
  /// Literal value: ≠, !=
  /// </summary>
  [FactorioRconDefinitionValue("≠")]
  Ne,

}

