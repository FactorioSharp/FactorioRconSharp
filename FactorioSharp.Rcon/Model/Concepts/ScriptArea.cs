#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// An area defined using the map editor.
/// </summary>
[FactorioRconConcept("ScriptArea")]
public class ScriptArea: IFactorioRconModel
{
  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  [FactorioRconAttribute("id")]
  public uint Id { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

