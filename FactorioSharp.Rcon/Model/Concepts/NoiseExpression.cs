#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A fragment of a functional program used to generate coherent noise, probably for purposes related to terrain generation. These can only be meaningfully written/modified during
///     the data load phase. More detailed information is found on the [prototype docs](prototype:NamedNoiseExpression).
/// </summary>
[FactorioRconConcept("NoiseExpression")]
public class NoiseExpression
{
  /// <summary>
  ///     Names the type of the expression and determines what other fields are required.
  /// </summary>
  [FactorioRconAttribute("type")]
    public string Type { get; set; }
}
