#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CircuitCondition")]
public class CircuitCondition
{
  /// <summary>
  ///     Specifies how the inputs should be compared. If not specified, defaults to `"<"`.
  /// </summary>
  [FactorioRconAttribute("comparator")]
    public ComparatorString Comparator { get; set; }

  /// <summary>
  ///     Defaults to blank
  /// </summary>
  [FactorioRconAttribute("first_signal")]
    public SignalID FirstSignal { get; set; }

  /// <summary>
  ///     What to compare `first_signal` to. If not specified, `first_signal` will be compared to `constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
    public SignalID SecondSignal { get; set; }

  /// <summary>
  ///     Constant to compare `first_signal` to. Has no effect when `second_signal` is set. When neither `second_signal` nor `constant` are specified, the effect is as though `constant`
  ///     were specified with the value `0`.
  /// </summary>
  [FactorioRconAttribute("constant")]
    public int Constant { get; set; }
}
