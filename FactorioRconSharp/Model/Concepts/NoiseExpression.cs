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
/// A fragment of a functional program used to generate coherent noise, probably for purposes related to terrain generation. These can only be meaningfully written/modified during the data load phase. More detailed information is found on the [prototype docs](prototype:NamedNoiseExpression).
/// </summary>
[FactorioRconConcept("NoiseExpression")]
public abstract class NoiseExpression
{
  /// <summary>
  /// Names the type of the expression and determines what other fields are required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; set; }

}

public abstract class Table22496961
{
  /// <summary>
  /// Names the type of the expression and determines what other fields are required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; set; }

}

