#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("DeciderCombinatorParameters")]
public abstract class DeciderCombinatorParameters
{
  /// <summary>
  /// Defaults to blank.
  /// </summary>
  [FactorioRconAttribute("first_signal")]
  public SignalID FirstSignal { get; set; }

  /// <summary>
  /// Second signal to use in an operation, if any. If this is not specified, the second argument to a decider combinator's operation is assumed to be the value of `constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
  public SignalID SecondSignal { get; set; }

  /// <summary>
  /// Constant to use as the second argument of operation. Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("constant")]
  public uint Constant { get; set; }

  /// <summary>
  /// Specifies how the inputs should be compared. If not specified, defaults to `"<"`.
  /// </summary>
  [FactorioRconAttribute("comparator")]
  public ComparatorString Comparator { get; set; }

  /// <summary>
  /// Defaults to blank.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

  /// <summary>
  /// Defaults to `true`. When `false`, will output a value of `1` for the given `output_signal`.
  /// </summary>
  [FactorioRconAttribute("copy_count_from_input")]
  public bool CopyCountFromInput { get; set; }

}

public abstract class Table19016246
{
  /// <summary>
  /// Defaults to blank.
  /// </summary>
  [FactorioRconAttribute("first_signal")]
  public SignalID FirstSignal { get; set; }

  /// <summary>
  /// Second signal to use in an operation, if any. If this is not specified, the second argument to a decider combinator's operation is assumed to be the value of `constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
  public SignalID SecondSignal { get; set; }

  /// <summary>
  /// Constant to use as the second argument of operation. Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("constant")]
  public uint Constant { get; set; }

  /// <summary>
  /// Specifies how the inputs should be compared. If not specified, defaults to `"<"`.
  /// </summary>
  [FactorioRconAttribute("comparator")]
  public ComparatorString Comparator { get; set; }

  /// <summary>
  /// Defaults to blank.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

  /// <summary>
  /// Defaults to `true`. When `false`, will output a value of `1` for the given `output_signal`.
  /// </summary>
  [FactorioRconAttribute("copy_count_from_input")]
  public bool CopyCountFromInput { get; set; }

}

