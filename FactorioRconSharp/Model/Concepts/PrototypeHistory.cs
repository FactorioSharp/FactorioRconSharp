#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("PrototypeHistory")]
public class PrototypeHistory
{
  /// <summary>
  /// The mod that created this prototype.
  /// </summary>
  [FactorioRconAttribute("created")]
  public string Created { get; set; }

  /// <summary>
  /// The mods that changed this prototype in the order they changed it.
  /// </summary>
  [FactorioRconAttribute("changed")]
  public List<string> Changed { get; set; }

}

