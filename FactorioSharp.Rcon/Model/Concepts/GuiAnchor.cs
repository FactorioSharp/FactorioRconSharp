#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("GuiAnchor")]
public class GuiAnchor
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
  public LuaArray<string> Names { get; set; }

}

