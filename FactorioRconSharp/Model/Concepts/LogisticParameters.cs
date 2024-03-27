#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("LogisticParameters")]
public abstract class LogisticParameters
{
  /// <summary>
  /// The item. `nil` clears the filter.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("min")]
  public uint Min { get; set; }

  /// <summary>
  /// Defaults to max uint.
  /// </summary>
  [FactorioRconAttribute("max")]
  public uint Max { get; set; }

}
