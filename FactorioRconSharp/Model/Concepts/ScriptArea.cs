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
/// An area defined using the map editor.
/// </summary>
[FactorioRconConcept("ScriptArea")]
public abstract class ScriptArea
{
  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  [FactorioRconAttribute("id")]
  public uint Id { get; set; }

}

public abstract class Table1723951
{
  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  [FactorioRconAttribute("id")]
  public uint Id { get; set; }

}

