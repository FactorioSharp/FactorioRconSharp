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
/// A string that specifies how the inputs should be compared
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ComparatorString")]
public abstract partial class ComparatorString: OneOfBase<Literal8636590, Literal49134518, Literal15614904, Literal50179053, Literal45906415, Literal56217625, Literal19698399, Literal34382671, Literal57573383>
{
}

[GenerateOneOf]
public abstract partial class Union35009294: OneOfBase<Literal8636590, Literal49134518, Literal15614904, Literal50179053, Literal45906415, Literal56217625, Literal19698399, Literal34382671, Literal57573383>
{
}

/// <summary>
/// Literal value: =
/// </summary>
public enum Literal8636590
{
  /// <summary>
  /// Literal value: =
  /// </summary>
  [FactorioRconDefinitionValue("=")]
  =,

}

/// <summary>
/// Literal value: >
/// </summary>
public enum Literal49134518
{
  /// <summary>
  /// Literal value: >
  /// </summary>
  [FactorioRconDefinitionValue(">")]
  >,

}

/// <summary>
/// Literal value: <
/// </summary>
public enum Literal15614904
{
  /// <summary>
  /// Literal value: <
  /// </summary>
  [FactorioRconDefinitionValue("<")]
  <,

}

/// <summary>
/// Literal value: ≥
/// </summary>
public enum Literal50179053
{
  /// <summary>
  /// Literal value: ≥
  /// </summary>
  [FactorioRconDefinitionValue("≥")]
  ≥,

}

/// <summary>
/// Literal value: >=
/// </summary>
public enum Literal45906415
{
  /// <summary>
  /// Literal value: >=
  /// </summary>
  [FactorioRconDefinitionValue(">=")]
  >=,

}

/// <summary>
/// Literal value: ≤
/// </summary>
public enum Literal56217625
{
  /// <summary>
  /// Literal value: ≤
  /// </summary>
  [FactorioRconDefinitionValue("≤")]
  ≤,

}

/// <summary>
/// Literal value: <=
/// </summary>
public enum Literal19698399
{
  /// <summary>
  /// Literal value: <=
  /// </summary>
  [FactorioRconDefinitionValue("<=")]
  <=,

}

/// <summary>
/// Literal value: ≠
/// </summary>
public enum Literal34382671
{
  /// <summary>
  /// Literal value: ≠
  /// </summary>
  [FactorioRconDefinitionValue("≠")]
  ≠,

}

/// <summary>
/// Literal value: !=
/// </summary>
public enum Literal57573383
{
  /// <summary>
  /// Literal value: !=
  /// </summary>
  [FactorioRconDefinitionValue("!=")]
  !=,

}

