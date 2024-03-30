#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SignalID")]
public class SignalID: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public Literals452139114 Type { get; set; }

  /// <summary>
  /// Name of the item, fluid or virtual signal.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

