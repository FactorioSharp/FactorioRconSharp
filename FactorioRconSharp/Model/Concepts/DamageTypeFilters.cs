#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("DamageTypeFilters")]
public abstract class DamageTypeFilters
{
  /// <summary>
  /// Whether this is a whitelist or a blacklist of damage types. `true` means whitelist.
  /// </summary>
  [FactorioRconAttribute("whitelist")]
  public bool Whitelist { get; set; }

  /// <summary>
  /// The damage types to filter for. The value in the dictionary is meaningless and exists just to allow for easy lookup.
  /// </summary>
  [FactorioRconAttribute("types")]
  public Dictionary<string, Literal48342929> Types { get; set; }

}

public abstract class Table64506597
{
  /// <summary>
  /// Whether this is a whitelist or a blacklist of damage types. `true` means whitelist.
  /// </summary>
  [FactorioRconAttribute("whitelist")]
  public bool Whitelist { get; set; }

  /// <summary>
  /// The damage types to filter for. The value in the dictionary is meaningless and exists just to allow for easy lookup.
  /// </summary>
  [FactorioRconAttribute("types")]
  public Dictionary<string, Literal48342929> Types { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public abstract class Literal48342929
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconAttribute("True")]
  public static object Value { get; private set; }

}

