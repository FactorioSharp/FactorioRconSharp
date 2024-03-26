#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ElemID")]
public abstract class ElemID
{
  [FactorioRconAttribute("type")]
  public ElemType Type { get; set; }

  /// <summary>
  /// Name of a prototype as defined by `type`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

public abstract class Table6322590
{
  [FactorioRconAttribute("type")]
  public ElemType Type { get; set; }

  /// <summary>
  /// Name of a prototype as defined by `type`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

