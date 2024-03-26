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
  public Union42209503 Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

public abstract class Table50051574
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
  public Union42209503 Operation { get; set; }

  /// <summary>
  /// Specifies the signal to output.
  /// </summary>
  [FactorioRconAttribute("output_signal")]
  public SignalID OutputSignal { get; set; }

}

[GenerateOneOf]
public abstract partial class Union42209503: OneOfBase<Literal16116045, Literal64712146, Literal64712930, Literal64735656, Literal65394697, Literal17398045, Literal34781257, Literal2023519, Literal58682072, Literal24058510, Literal26608156>
{
}

/// <summary>
/// Literal value: *
/// </summary>
public abstract class Literal16116045
{
  /// <summary>
  /// Literal value: *
  /// </summary>
  [FactorioRconAttribute("*")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: /
/// </summary>
public abstract class Literal64712146
{
  /// <summary>
  /// Literal value: /
  /// </summary>
  [FactorioRconAttribute("/")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: +
/// </summary>
public abstract class Literal64712930
{
  /// <summary>
  /// Literal value: +
  /// </summary>
  [FactorioRconAttribute("+")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: -
/// </summary>
public abstract class Literal64735656
{
  /// <summary>
  /// Literal value: -
  /// </summary>
  [FactorioRconAttribute("-")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: %
/// </summary>
public abstract class Literal65394697
{
  /// <summary>
  /// Literal value: %
  /// </summary>
  [FactorioRconAttribute("%")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ^
/// </summary>
public abstract class Literal17398045
{
  /// <summary>
  /// Literal value: ^
  /// </summary>
  [FactorioRconAttribute("^")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: <<
/// </summary>
public abstract class Literal34781257
{
  /// <summary>
  /// Literal value: <<
  /// </summary>
  [FactorioRconAttribute("<<")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: >>
/// </summary>
public abstract class Literal2023519
{
  /// <summary>
  /// Literal value: >>
  /// </summary>
  [FactorioRconAttribute(">>")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: AND
/// </summary>
public abstract class Literal58682072
{
  /// <summary>
  /// Literal value: AND
  /// </summary>
  [FactorioRconAttribute("AND")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: OR
/// </summary>
public abstract class Literal24058510
{
  /// <summary>
  /// Literal value: OR
  /// </summary>
  [FactorioRconAttribute("OR")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: XOR
/// </summary>
public abstract class Literal26608156
{
  /// <summary>
  /// Literal value: XOR
  /// </summary>
  [FactorioRconAttribute("XOR")]
  public static object Value { get; private set; }

}

