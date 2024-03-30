#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Decorative")]
public class Decorative: IFactorioRconModel
{
  /// <summary>
  /// The name of the decorative prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("amount")]
  public byte Amount { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

