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
/// Parameters that affect the look and control of the game. Updating any of the member attributes here will immediately take effect in the game engine.
/// </summary>
[FactorioRconConcept("GameViewSettings")]
public class GameViewSettings: IFactorioRconModel
{
  /// <summary>
  /// Show the controller GUI elements. This includes the toolbar, the selected tool slot, the armour slot, and the gun and ammunition slots.
  /// </summary>
  [FactorioRconAttribute("show_controller_gui")]
  public bool ShowControllerGui { get; set; }

  /// <summary>
  /// Show the chart in the upper right-hand corner of the screen.
  /// </summary>
  [FactorioRconAttribute("show_minimap")]
  public bool ShowMinimap { get; set; }

  /// <summary>
  /// Show research progress and name in the upper right-hand corner of the screen.
  /// </summary>
  [FactorioRconAttribute("show_research_info")]
  public bool ShowResearchInfo { get; set; }

  /// <summary>
  /// Show overlay icons on entities. Also known as "alt-mode".
  /// </summary>
  [FactorioRconAttribute("show_entity_info")]
  public bool ShowEntityInfo { get; set; }

  /// <summary>
  /// Show the flashing alert icons next to the player's toolbar.
  /// </summary>
  [FactorioRconAttribute("show_alert_gui")]
  public bool ShowAlertGui { get; set; }

  /// <summary>
  /// When `true` (the default), mousing over an entity will select it. Otherwise, moving the mouse won't update entity selection.
  /// </summary>
  [FactorioRconAttribute("update_entity_selection")]
  public bool UpdateEntitySelection { get; set; }

  /// <summary>
  /// When `true` (`false` is default), the rails will always show the rail block visualisation.
  /// </summary>
  [FactorioRconAttribute("show_rail_block_visualisation")]
  public bool ShowRailBlockVisualisation { get; set; }

  /// <summary>
  /// Shows or hides the buttons row.
  /// </summary>
  [FactorioRconAttribute("show_side_menu")]
  public bool ShowSideMenu { get; set; }

  /// <summary>
  /// Shows or hides the view options when map is opened.
  /// </summary>
  [FactorioRconAttribute("show_map_view_options")]
  public bool ShowMapViewOptions { get; set; }

  /// <summary>
  /// Shows or hides the tooltip that is displayed when selecting an entity.
  /// </summary>
  [FactorioRconAttribute("show_entity_tooltip")]
  public bool ShowEntityTooltip { get; set; }

  /// <summary>
  /// Shows or hides quickbar of shortcuts.
  /// </summary>
  [FactorioRconAttribute("show_quickbar")]
  public bool ShowQuickbar { get; set; }

  /// <summary>
  /// Shows or hides the shortcut bar.
  /// </summary>
  [FactorioRconAttribute("show_shortcut_bar")]
  public bool ShowShortcutBar { get; set; }

  /// <summary>
  /// Shows or hides the crafting queue.
  /// </summary>
  [FactorioRconAttribute("show_crafting_queue")]
  public bool ShowCraftingQueue { get; set; }

  /// <summary>
  /// Shows or hides the tool window with the weapons and armor.
  /// </summary>
  [FactorioRconAttribute("show_tool_bar")]
  public bool ShowToolBar { get; set; }

  /// <summary>
  /// Shows or hides the mouse and keyboard/controller button hints in the bottom left corner if they are enabled in the interface settings.
  /// </summary>
  [FactorioRconAttribute("show_hotkey_suggestions")]
  public bool ShowHotkeySuggestions { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

