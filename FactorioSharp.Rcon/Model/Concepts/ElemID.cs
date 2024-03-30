#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ElemID")]
public class ElemID: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public ElemType Type { get; set; }

  /// <summary>
  /// Name of a prototype as defined by `type`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

