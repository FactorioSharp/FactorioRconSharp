#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A position defined using the map editor.
/// </summary>
[FactorioRconConcept("ScriptPosition")]
public abstract class ScriptPosition
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

public abstract class Table13164703
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

