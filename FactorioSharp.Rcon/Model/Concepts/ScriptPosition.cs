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
/// A position defined using the map editor.
/// </summary>
[FactorioRconConcept("ScriptPosition")]
public class ScriptPosition
{
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  [FactorioRconAttribute("id")]
  public uint Id { get; set; }

}

