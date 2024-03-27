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
  /// Literal value: ≥
  /// </summary>
  [FactorioRconDefinitionValue("≥")]
  Ge,

  /// <summary>
  /// Literal value: >=
  /// </summary>
  [FactorioRconDefinitionValue(">=")]
  Ge,

  /// <summary>
  /// Literal value: ≤
  /// </summary>
  [FactorioRconDefinitionValue("≤")]
  Le,

  /// <summary>
  /// Literal value: <=
  /// </summary>
  [FactorioRconDefinitionValue("<=")]
  Le,

  /// <summary>
  /// Literal value: ≠
  /// </summary>
  [FactorioRconDefinitionValue("≠")]
  Ne,

  /// <summary>
  /// Literal value: !=
  /// </summary>
  [FactorioRconDefinitionValue("!=")]
  Ne,

}

