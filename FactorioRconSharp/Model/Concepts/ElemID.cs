#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ElemID")]
public class ElemID
{
  [FactorioRconAttribute("type")]
  public ElemType Type { get; set; }

  /// <summary>
  /// Name of a prototype as defined by `type`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

