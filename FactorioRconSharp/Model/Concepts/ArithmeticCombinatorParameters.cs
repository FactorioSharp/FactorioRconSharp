#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ArithmeticCombinatorParameters")]
public abstract class ArithmeticCombinatorParameters
{
  /// <summary>
  /// First signal to use in an operation. If not specified, the second argument will be the value of `first_constant`.
  /// </summary>
  [FactorioRconAttribute("first_signal")]
  public SignalID FirstSignal { get; set; }

  /// <summary>
  /// Second signal to use in an operation. If not specified, the second argument will be the value of `second_constant`.
  /// </summary>
  [FactorioRconAttribute("second_signal")]
  public SignalID SecondSignal { get; set; }

  /// <summary>
  /// Constant to use as the first argument of the operation. Has no effect when `first_signal` is set. Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("first_constant")]
  public int FirstConstant { get; set; }

  /// <summary>
  /// Constant to use as the second argument of the operation. Has no effect when `second_signal` is set. Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("second_constant")]
  public int SecondConstant { get; set; }

  /// <summary>
  /// When not specified, defaults to `"*"`.
  /// </summary>
  [FactorioRconAttribute("operation")]
  public Literals_ee7da92ad6bb4388aab68ce3797ce16b Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

