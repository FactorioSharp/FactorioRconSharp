#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircuitCondition")]
public abstract class CircuitCondition
{
  /// <summary>
  /// Specifies how the inputs should be compared. If not specified, defaults to `"<"`.
  /// </summary>
  [FactorioRconAttribute("comparator")]
  public ComparatorString Comparator { get; set; }

  /// <summary>
  /// Defaults to blank
  /// </summary>
  [FactorioRconAttribute("first_signal")]
  public SignalID FirstSignal { get; set; }

  /// <summary>
  /// What to compare `first_signal` to. If not specified, `first_signal` will be compared to `constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
  public SignalID SecondSignal { get; set; }

  /// <summary>
  /// Constant to compare `first_signal` to. Has no effect when `second_signal` is set. When neither `second_signal` nor `constant` are specified, the effect is as though `constant` were specified with the value `0`.
  /// </summary>
  [FactorioRconAttribute("constant")]
  public int Constant { get; set; }

}

public abstract class Table13896890
{
  /// <summary>
  /// Specifies how the inputs should be compared. If not specified, defaults to `"<"`.
  /// </summary>
  [FactorioRconAttribute("comparator")]
  public ComparatorString Comparator { get; set; }

  /// <summary>
  /// Defaults to blank
  /// </summary>
  [FactorioRconAttribute("first_signal")]
  public SignalID FirstSignal { get; set; }

  /// <summary>
  /// What to compare `first_signal` to. If not specified, `first_signal` will be compared to `constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
  public SignalID SecondSignal { get; set; }

  /// <summary>
  /// Constant to compare `first_signal` to. Has no effect when `second_signal` is set. When neither `second_signal` nor `constant` are specified, the effect is as though `constant` were specified with the value `0`.
  /// </summary>
  [FactorioRconAttribute("constant")]
  public int Constant { get; set; }

}

