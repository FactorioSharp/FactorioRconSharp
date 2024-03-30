#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("UpgradeFilter")]
public class UpgradeFilter
{
  [FactorioRconAttribute("type")]
  public Literals847830485 Type { get; set; }

  /// <summary>
  /// Name of the item, or entity.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

