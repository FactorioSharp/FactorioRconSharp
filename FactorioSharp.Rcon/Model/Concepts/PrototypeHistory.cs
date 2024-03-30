#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("PrototypeHistory")]
public class PrototypeHistory: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

