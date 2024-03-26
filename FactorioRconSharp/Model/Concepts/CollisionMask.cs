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
/// A set of flags. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// </summary>
[FactorioRconConcept("CollisionMask")]
public abstract class CollisionMask: Dictionary<CollisionMaskLayer, Literal45363346>
{
}

/// <summary>
/// Literal value: True
/// </summary>
public abstract class Literal45363346
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconAttribute("True")]
  public static object Value { get; private set; }

}

