#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AutoplaceSpecificationRestriction")]
public class AutoplaceSpecificationRestriction: IFactorioRconModel
{
  /// <summary>
  /// Tile prototype name
  /// </summary>
  [FactorioRconAttribute("first")]
  public string First { get; set; }

  /// <summary>
  /// Second prototype name
  /// </summary>
  [FactorioRconAttribute("second")]
  public string Second { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

