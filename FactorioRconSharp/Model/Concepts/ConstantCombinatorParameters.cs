#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ConstantCombinatorParameters")]
public abstract class ConstantCombinatorParameters
{
  /// <summary>
  /// Signal to emit.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public SignalID Signal { get; set; }

  /// <summary>
  /// Value of the signal to emit.
  /// </summary>
  [FactorioRconAttribute("count")]
  public int Count { get; set; }

  /// <summary>
  /// Index of the constant combinator's slot to set this signal to.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}
