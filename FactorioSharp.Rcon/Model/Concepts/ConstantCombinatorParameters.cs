#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ConstantCombinatorParameters")]
public class ConstantCombinatorParameters: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

