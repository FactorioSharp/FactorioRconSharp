#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ItemStackDefinition")]
public abstract class ItemStackDefinition
{
  /// <summary>
  /// Prototype name of the item the stack holds.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Number of items the stack holds. If not specified, defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// Health of the items in the stack. Defaults to `1.0`.
  /// </summary>
  [FactorioRconAttribute("health")]
  public float Health { get; set; }

  /// <summary>
  /// Durability of the tool items in the stack.
  /// </summary>
  [FactorioRconAttribute("durability")]
  public double Durability { get; set; }

  /// <summary>
  /// Amount of ammo in the ammo items in the stack.
  /// </summary>
  [FactorioRconAttribute("ammo")]
  public double Ammo { get; set; }

  /// <summary>
  /// Tags of the items with tags in the stack.
  /// </summary>
  [FactorioRconAttribute("tags")]
  public List<string> Tags { get; set; }

}

public abstract class Table36017716
{
  /// <summary>
  /// Prototype name of the item the stack holds.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Number of items the stack holds. If not specified, defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// Health of the items in the stack. Defaults to `1.0`.
  /// </summary>
  [FactorioRconAttribute("health")]
  public float Health { get; set; }

  /// <summary>
  /// Durability of the tool items in the stack.
  /// </summary>
  [FactorioRconAttribute("durability")]
  public double Durability { get; set; }

  /// <summary>
  /// Amount of ammo in the ammo items in the stack.
  /// </summary>
  [FactorioRconAttribute("ammo")]
  public double Ammo { get; set; }

  /// <summary>
  /// Tags of the items with tags in the stack.
  /// </summary>
  [FactorioRconAttribute("tags")]
  public List<string> Tags { get; set; }

}

