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
/// Used for specifying where a GUI arrow should point to.
/// </summary>
[FactorioRconConcept("GuiArrowSpecification")]
public abstract class GuiArrowSpecification
{
  [FactorioRconAttribute("margin")]
  public uint Margin { get; set; }

  /// <summary>
  /// This determines which of the following fields will be required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public GuiArrowType Type { get; set; }

}

public abstract class Table33324024
{
  [FactorioRconAttribute("margin")]
  public uint Margin { get; set; }

  /// <summary>
  /// This determines which of the following fields will be required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public GuiArrowType Type { get; set; }

}

[GenerateOneOf]
public abstract partial class Union26872619: OneOfBase<Literal41108474, Literal51295077, Literal11162226, Literal55269108>
{
}

/// <summary>
/// Literal value: player
/// </summary>
public abstract class Literal41108474
{
  /// <summary>
  /// Literal value: player
  /// </summary>
  [FactorioRconAttribute("player")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: target
/// </summary>
public abstract class Literal51295077
{
  /// <summary>
  /// Literal value: target
  /// </summary>
  [FactorioRconAttribute("target")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: player-quickbar
/// </summary>
public abstract class Literal11162226
{
  /// <summary>
  /// Literal value: player-quickbar
  /// </summary>
  [FactorioRconAttribute("player-quickbar")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: player-equipment-bar
/// </summary>
public abstract class Literal55269108
{
  /// <summary>
  /// Literal value: player-equipment-bar
  /// </summary>
  [FactorioRconAttribute("player-equipment-bar")]
  public static object Value { get; private set; }

}

