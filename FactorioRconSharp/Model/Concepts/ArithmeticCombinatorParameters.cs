#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

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
  public Union51882681 Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

/// <summary>
/// Union of literals:
///   - *
///   - /
///   - +
///   - -
///   - %
///   - ^
///   - <<
///   - >>
///   - AND
///   - OR
///   - XOR
/// </summary>
public enum Union51882681
{
  /// <summary>
  /// Literal value: *
  /// </summary>
  [FactorioRconDefinitionValue("*")]
  *,

  /// <summary>
  /// Literal value: /
  /// </summary>
  [FactorioRconDefinitionValue("/")]
  /,

  /// <summary>
  /// Literal value: +
  /// </summary>
  [FactorioRconDefinitionValue("+")]
  +,

  /// <summary>
  /// Literal value: -
  /// </summary>
  [FactorioRconDefinitionValue("-")]
  ,

  /// <summary>
  /// Literal value: %
  /// </summary>
  [FactorioRconDefinitionValue("%")]
  %,

  /// <summary>
  /// Literal value: ^
  /// </summary>
  [FactorioRconDefinitionValue("^")]
  ^,

  /// <summary>
  /// Literal value: <<
  /// </summary>
  [FactorioRconDefinitionValue("<<")]
  <<,

  /// <summary>
  /// Literal value: >>
  /// </summary>
  [FactorioRconDefinitionValue(">>")]
  >>,

  /// <summary>
  /// Literal value: AND
  /// </summary>
  [FactorioRconDefinitionValue("AND")]
  AND,

  /// <summary>
  /// Literal value: OR
  /// </summary>
  [FactorioRconDefinitionValue("OR")]
  OR,

  /// <summary>
  /// Literal value: XOR
  /// </summary>
  [FactorioRconDefinitionValue("XOR")]
  XOR,

}

