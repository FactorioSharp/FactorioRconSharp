#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("GuiAnchor")]
public abstract class GuiAnchor
{
  [FactorioRconAttribute("gui")]
  public RelativeGuiTypeEnum Gui { get; set; }

  [FactorioRconAttribute("position")]
  public RelativeGuiPositionEnum Position { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened things type matches the type.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened thing matches the name. `name` takes precedence over `names`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened thing matches one of the names. When reading an anchor, `names` is always populated.
  /// </summary>
  [FactorioRconAttribute("names")]
  public List<string> Names { get; set; }

}

public abstract class Table56367281
{
  [FactorioRconAttribute("gui")]
  public RelativeGuiTypeEnum Gui { get; set; }

  [FactorioRconAttribute("position")]
  public RelativeGuiPositionEnum Position { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened things type matches the type.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened thing matches the name. `name` takes precedence over `names`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// If provided, only anchors the GUI element when the opened thing matches one of the names. When reading an anchor, `names` is always populated.
  /// </summary>
  [FactorioRconAttribute("names")]
  public List<string> Names { get; set; }

}

