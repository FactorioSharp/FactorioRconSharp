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
  public Union66394946 Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

public abstract class Table28726945
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
  public Union66394946 Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

[GenerateOneOf]
public abstract partial class Union66394946: OneOfBase<Literal52116595, Literal20706689, Literal32187286, Literal4844372, Literal34622967, Literal55993668, Literal35016340, Literal64254500, Literal7167227, Literal16294043, Literal6630602>
{
}

/// <summary>
/// Literal value: *
/// </summary>
public enum Literal52116595
{
  /// <summary>
  /// Literal value: *
  /// </summary>
  [FactorioRconDefinitionValue("*")]
  *,

}

/// <summary>
/// Literal value: /
/// </summary>
public enum Literal20706689
{
  /// <summary>
  /// Literal value: /
  /// </summary>
  [FactorioRconDefinitionValue("/")]
  /,

}

/// <summary>
/// Literal value: +
/// </summary>
public enum Literal32187286
{
  /// <summary>
  /// Literal value: +
  /// </summary>
  [FactorioRconDefinitionValue("+")]
  +,

}

/// <summary>
/// Literal value: -
/// </summary>
public enum Literal4844372
{
  /// <summary>
  /// Literal value: -
  /// </summary>
  [FactorioRconDefinitionValue("-")]
  ,

}

/// <summary>
/// Literal value: %
/// </summary>
public enum Literal34622967
{
  /// <summary>
  /// Literal value: %
  /// </summary>
  [FactorioRconDefinitionValue("%")]
  %,

}

/// <summary>
/// Literal value: ^
/// </summary>
public enum Literal55993668
{
  /// <summary>
  /// Literal value: ^
  /// </summary>
  [FactorioRconDefinitionValue("^")]
  ^,

}

/// <summary>
/// Literal value: <<
/// </summary>
public enum Literal35016340
{
  /// <summary>
  /// Literal value: <<
  /// </summary>
  [FactorioRconDefinitionValue("<<")]
  <<,

}

/// <summary>
/// Literal value: >>
/// </summary>
public enum Literal64254500
{
  /// <summary>
  /// Literal value: >>
  /// </summary>
  [FactorioRconDefinitionValue(">>")]
  >>,

}

/// <summary>
/// Literal value: AND
/// </summary>
public enum Literal7167227
{
  /// <summary>
  /// Literal value: AND
  /// </summary>
  [FactorioRconDefinitionValue("AND")]
  AND,

}

/// <summary>
/// Literal value: OR
/// </summary>
public enum Literal16294043
{
  /// <summary>
  /// Literal value: OR
  /// </summary>
  [FactorioRconDefinitionValue("OR")]
  OR,

}

/// <summary>
/// Literal value: XOR
/// </summary>
public enum Literal6630602
{
  /// <summary>
  /// Literal value: XOR
  /// </summary>
  [FactorioRconDefinitionValue("XOR")]
  XOR,

}

