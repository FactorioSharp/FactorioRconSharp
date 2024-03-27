#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SignalID")]
public abstract class SignalID
{
  [FactorioRconAttribute("type")]
  public Literals_100d15e3f9ab4fcfa415a97c690641e7 Type { get; set; }

  /// <summary>
  /// Name of the item, fluid or virtual signal.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

