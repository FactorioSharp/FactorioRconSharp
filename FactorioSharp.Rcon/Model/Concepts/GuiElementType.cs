#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconDefinition("GuiElementType")]
public enum GuiElementType
{
  /// <summary>
  ///     Literal value: button
  /// </summary>
  [FactorioRconDefinitionValue("button")]
    Button,

  /// <summary>
  ///     Literal value: sprite-button
  /// </summary>
  [FactorioRconDefinitionValue("sprite-button")]
    SpriteButton,

  /// <summary>
  ///     Literal value: checkbox
  /// </summary>
  [FactorioRconDefinitionValue("checkbox")]
    Checkbox,

  /// <summary>
  ///     Literal value: flow
  /// </summary>
  [FactorioRconDefinitionValue("flow")]
    Flow,

  /// <summary>
  ///     Literal value: frame
  /// </summary>
  [FactorioRconDefinitionValue("frame")]
    Frame,

  /// <summary>
  ///     Literal value: label
  /// </summary>
  [FactorioRconDefinitionValue("label")]
    Label,

  /// <summary>
  ///     Literal value: line
  /// </summary>
  [FactorioRconDefinitionValue("line")]
    Line,

  /// <summary>
  ///     Literal value: progressbar
  /// </summary>
  [FactorioRconDefinitionValue("progressbar")]
    Progressbar,

  /// <summary>
  ///     Literal value: table
  /// </summary>
  [FactorioRconDefinitionValue("table")]
    Table,

  /// <summary>
  ///     Literal value: textfield
  /// </summary>
  [FactorioRconDefinitionValue("textfield")]
    Textfield,

  /// <summary>
  ///     Literal value: radiobutton
  /// </summary>
  [FactorioRconDefinitionValue("radiobutton")]
    Radiobutton,

  /// <summary>
  ///     Literal value: sprite
  /// </summary>
  [FactorioRconDefinitionValue("sprite")]
    Sprite,

  /// <summary>
  ///     Literal value: scroll-pane
  /// </summary>
  [FactorioRconDefinitionValue("scroll-pane")]
    ScrollPane,

  /// <summary>
  ///     Literal value: drop-down
  /// </summary>
  [FactorioRconDefinitionValue("drop-down")]
    DropDown,

  /// <summary>
  ///     Literal value: list-box
  /// </summary>
  [FactorioRconDefinitionValue("list-box")]
    ListBox,

  /// <summary>
  ///     Literal value: camera
  /// </summary>
  [FactorioRconDefinitionValue("camera")]
    Camera,

  /// <summary>
  ///     Literal value: choose-elem-button
  /// </summary>
  [FactorioRconDefinitionValue("choose-elem-button")]
    ChooseElemButton,

  /// <summary>
  ///     Literal value: text-box
  /// </summary>
  [FactorioRconDefinitionValue("text-box")]
    TextBox,

  /// <summary>
  ///     Literal value: slider
  /// </summary>
  [FactorioRconDefinitionValue("slider")]
    Slider,

  /// <summary>
  ///     Literal value: minimap
  /// </summary>
  [FactorioRconDefinitionValue("minimap")]
    Minimap,

  /// <summary>
  ///     Literal value: entity-preview
  /// </summary>
  [FactorioRconDefinitionValue("entity-preview")]
    EntityPreview,

  /// <summary>
  ///     Literal value: empty-widget
  /// </summary>
  [FactorioRconDefinitionValue("empty-widget")]
    EmptyWidget,

  /// <summary>
  ///     Literal value: tabbed-pane
  /// </summary>
  [FactorioRconDefinitionValue("tabbed-pane")]
    TabbedPane,

  /// <summary>
  ///     Literal value: tab
  /// </summary>
  [FactorioRconDefinitionValue("tab")]
    Tab,

  /// <summary>
  ///     Literal value: switch
  /// </summary>
  [FactorioRconDefinitionValue("switch")]
    Switch
}
