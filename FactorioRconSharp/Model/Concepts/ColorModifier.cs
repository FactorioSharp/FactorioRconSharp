#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Same as <see cref="Color" />, but red, green, blue and alpha values can be any floating point number, without any special handling of the range [1, 255].
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ColorModifier")]
public abstract partial class ColorModifier: OneOfBase<Table37920736, Table43424763>
{
}

public abstract class Table37920736
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

public abstract class Table43424763
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

