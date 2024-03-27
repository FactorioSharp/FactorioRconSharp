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
  =,

  /// <summary>
  /// Literal value: >
  /// </summary>
  [FactorioRconDefinitionValue(">")]
  >,

  /// <summary>
  /// Literal value: <
  /// </summary>
  [FactorioRconDefinitionValue("<")]
  <,

  /// <summary>
  /// Literal value: ≥
  /// </summary>
  [FactorioRconDefinitionValue("≥")]
  ≥,

  /// <summary>
  /// Literal value: >=
  /// </summary>
  [FactorioRconDefinitionValue(">=")]
  >=,

  /// <summary>
  /// Literal value: ≤
  /// </summary>
  [FactorioRconDefinitionValue("≤")]
  ≤,

  /// <summary>
  /// Literal value: <=
  /// </summary>
  [FactorioRconDefinitionValue("<=")]
  <=,

  /// <summary>
  /// Literal value: ≠
  /// </summary>
  [FactorioRconDefinitionValue("≠")]
  ≠,

  /// <summary>
  /// Literal value: !=
  /// </summary>
  [FactorioRconDefinitionValue("!=")]
  !=,

}

