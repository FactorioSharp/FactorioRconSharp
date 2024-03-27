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
/// 
/// By default, none of these flags are set.
/// </summary>
[FactorioRconConcept("ItemPrototypeFlags")]
public abstract class ItemPrototypeFlags: Dictionary<ItemPrototypeFlag, Literal38756850>
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal38756850
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

