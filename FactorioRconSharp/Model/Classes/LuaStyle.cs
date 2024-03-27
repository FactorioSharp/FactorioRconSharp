#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Style of a GUI element. All of the attributes listed here may be `nil` if not available for a particular GUI element.
/// </summary>
[FactorioRconClass("LuaStyle")]
public abstract class LuaStyle: LuaObject
{
  /// <summary>
  /// Gui of the <see cref="LuaGuiElement" /> of this style.
  /// </summary>
  [FactorioRconAttribute("gui")]
  public LuaGui Gui { get; private set; }

  /// <summary>
  /// Name of this style.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Minimal width ensures, that the widget will never be smaller than than that size. It can't be squashed to be smaller.
  /// </summary>
  [FactorioRconAttribute("minimal_width")]
  public int MinimalWidth { get; set; }

  /// <summary>
  /// Maximal width ensures, that the widget will never be bigger than than that size. It can't be stretched to be bigger.
  /// </summary>
  [FactorioRconAttribute("maximal_width")]
  public int MaximalWidth { get; set; }

  /// <summary>
  /// Minimal height ensures, that the widget will never be smaller than than that size. It can't be squashed to be smaller.
  /// </summary>
  [FactorioRconAttribute("minimal_height")]
  public int MinimalHeight { get; set; }

  /// <summary>
  /// Maximal height ensures, that the widget will never be bigger than than that size. It can't be stretched to be bigger.
  /// </summary>
  [FactorioRconAttribute("maximal_height")]
  public int MaximalHeight { get; set; }

  /// <summary>
  /// Natural width specifies the width of the element tries to have, but it can still be squashed/stretched to have a smaller or bigger size.
  /// </summary>
  [FactorioRconAttribute("natural_width")]
  public int NaturalWidth { get; set; }

  /// <summary>
  /// Natural height specifies the height of the element tries to have, but it can still be squashed/stretched to have a smaller or bigger size.
  /// </summary>
  [FactorioRconAttribute("natural_height")]
  public int NaturalHeight { get; set; }

  [FactorioRconAttribute("top_padding")]
  public int TopPadding { get; set; }

  [FactorioRconAttribute("right_padding")]
  public int RightPadding { get; set; }

  [FactorioRconAttribute("bottom_padding")]
  public int BottomPadding { get; set; }

  [FactorioRconAttribute("left_padding")]
  public int LeftPadding { get; set; }

  [FactorioRconAttribute("top_margin")]
  public int TopMargin { get; set; }

  [FactorioRconAttribute("right_margin")]
  public int RightMargin { get; set; }

  [FactorioRconAttribute("bottom_margin")]
  public int BottomMargin { get; set; }

  [FactorioRconAttribute("left_margin")]
  public int LeftMargin { get; set; }

  /// <summary>
  /// Horizontal align of the inner content of the widget, if any.
  /// </summary>
  [FactorioRconAttribute("horizontal_align")]
  public Type375078767 HorizontalAlign { get; set; }

  /// <summary>
  /// Vertical align of the inner content of the widget, if any.
  /// </summary>
  [FactorioRconAttribute("vertical_align")]
  public Type375078767 VerticalAlign { get; set; }

  [FactorioRconAttribute("font_color")]
  public Color FontColor { get; set; }

  [FactorioRconAttribute("font")]
  public string Font { get; set; }

  /// <summary>
  /// Space between the table cell contents top and border.
  /// </summary>
  [FactorioRconAttribute("top_cell_padding")]
  public int TopCellPadding { get; set; }

  /// <summary>
  /// Space between the table cell contents right and border.
  /// </summary>
  [FactorioRconAttribute("right_cell_padding")]
  public int RightCellPadding { get; set; }

  /// <summary>
  /// Space between the table cell contents bottom and border.
  /// </summary>
  [FactorioRconAttribute("bottom_cell_padding")]
  public int BottomCellPadding { get; set; }

  /// <summary>
  /// Space between the table cell contents left and border.
  /// </summary>
  [FactorioRconAttribute("left_cell_padding")]
  public int LeftCellPadding { get; set; }

  /// <summary>
  /// Whether the GUI element stretches its size horizontally to other elements. `nil` if this element does not support stretching.
  /// </summary>
  [FactorioRconAttribute("horizontally_stretchable")]
  public bool HorizontallyStretchable { get; set; }

  /// <summary>
  /// Whether the GUI element stretches its size vertically to other elements. `nil` if this element does not support stretching.
  /// </summary>
  [FactorioRconAttribute("vertically_stretchable")]
  public bool VerticallyStretchable { get; set; }

  /// <summary>
  /// Whether the GUI element can be squashed (by maximal width of some parent element) horizontally. `nil` if this element does not support squashing. This is mainly meant to be used for scroll-pane The default value is false.
  /// </summary>
  [FactorioRconAttribute("horizontally_squashable")]
  public bool HorizontallySquashable { get; set; }

  /// <summary>
  /// Whether the GUI element can be squashed (by maximal height of some parent element) vertically. `nil` if this element does not support squashing. This is mainly meant to be used for scroll-pane The default (parent) value for scroll pane is true, false otherwise.
  /// </summary>
  [FactorioRconAttribute("vertically_squashable")]
  public bool VerticallySquashable { get; set; }

  /// <summary>
  /// How this GUI element handles rich text.
  /// </summary>
  [FactorioRconAttribute("rich_text_setting")]
  public RichTextSettingEnum RichTextSetting { get; set; }

  [FactorioRconAttribute("hovered_font_color")]
  public Color HoveredFontColor { get; set; }

  [FactorioRconAttribute("clicked_font_color")]
  public Color ClickedFontColor { get; set; }

  [FactorioRconAttribute("disabled_font_color")]
  public Color DisabledFontColor { get; set; }

  [FactorioRconAttribute("pie_progress_color")]
  public Color PieProgressColor { get; set; }

  [FactorioRconAttribute("clicked_vertical_offset")]
  public int ClickedVerticalOffset { get; set; }

  [FactorioRconAttribute("selected_font_color")]
  public Color SelectedFontColor { get; set; }

  [FactorioRconAttribute("selected_hovered_font_color")]
  public Color SelectedHoveredFontColor { get; set; }

  [FactorioRconAttribute("selected_clicked_font_color")]
  public Color SelectedClickedFontColor { get; set; }

  [FactorioRconAttribute("strikethrough_color")]
  public Color StrikethroughColor { get; set; }

  [FactorioRconAttribute("draw_grayscale_picture")]
  public bool DrawGrayscalePicture { get; set; }

  /// <summary>
  /// Horizontal space between individual cells.
  /// </summary>
  [FactorioRconAttribute("horizontal_spacing")]
  public int HorizontalSpacing { get; set; }

  /// <summary>
  /// Vertical space between individual cells.
  /// </summary>
  [FactorioRconAttribute("vertical_spacing")]
  public int VerticalSpacing { get; set; }

  [FactorioRconAttribute("use_header_filler")]
  public bool UseHeaderFiller { get; set; }

  [FactorioRconAttribute("bar_width")]
  public uint BarWidth { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  /// <summary>
  /// Array containing the alignment for every column of this table element. Even though this property is marked as read-only, the alignment can be changed by indexing the LuaCustomTable, like so:
  /// </summary>
  [FactorioRconAttribute("column_alignments")]
  public LuaCustomTable<uint, Alignment> ColumnAlignments { get; private set; }

  [FactorioRconAttribute("single_line")]
  public bool SingleLine { get; set; }

  [FactorioRconAttribute("extra_top_padding_when_activated")]
  public int ExtraTopPaddingWhenActivated { get; set; }

  [FactorioRconAttribute("extra_bottom_padding_when_activated")]
  public int ExtraBottomPaddingWhenActivated { get; set; }

  [FactorioRconAttribute("extra_left_padding_when_activated")]
  public int ExtraLeftPaddingWhenActivated { get; set; }

  [FactorioRconAttribute("extra_right_padding_when_activated")]
  public int ExtraRightPaddingWhenActivated { get; set; }

  [FactorioRconAttribute("extra_top_margin_when_activated")]
  public int ExtraTopMarginWhenActivated { get; set; }

  [FactorioRconAttribute("extra_bottom_margin_when_activated")]
  public int ExtraBottomMarginWhenActivated { get; set; }

  [FactorioRconAttribute("extra_left_margin_when_activated")]
  public int ExtraLeftMarginWhenActivated { get; set; }

  [FactorioRconAttribute("extra_right_margin_when_activated")]
  public int ExtraRightMarginWhenActivated { get; set; }

  [FactorioRconAttribute("stretch_image_to_widget_size")]
  public bool StretchImageToWidgetSize { get; set; }

  [FactorioRconAttribute("badge_font")]
  public string BadgeFont { get; set; }

  [FactorioRconAttribute("badge_horizontal_spacing")]
  public int BadgeHorizontalSpacing { get; set; }

  [FactorioRconAttribute("default_badge_font_color")]
  public Color DefaultBadgeFontColor { get; set; }

  [FactorioRconAttribute("selected_badge_font_color")]
  public Color SelectedBadgeFontColor { get; set; }

  [FactorioRconAttribute("disabled_badge_font_color")]
  public Color DisabledBadgeFontColor { get; set; }

  /// <summary>
  /// Sets both minimal and maximal width to the given value.
  /// </summary>
  [FactorioRconAttribute("width")]
  public int Width { private get; set; }

  /// <summary>
  /// Sets both minimal and maximal height to the given value.
  /// </summary>
  [FactorioRconAttribute("height")]
  public int Height { private get; set; }

  /// <summary>
  /// Sets both width and height to the given value. Also accepts an array with two values, setting width to the first and height to the second one.
  /// </summary>
  [FactorioRconAttribute("size")]
  public Type375078767 Size { private get; set; }

  /// <summary>
  /// Sets top/right/bottom/left paddings to this value. An array with two values sets top/bottom padding to the first value and left/right padding to the second value. An array with four values sets top, right, bottom, left padding respectively.
  /// </summary>
  [FactorioRconAttribute("padding")]
  public Type375078767 Padding { private get; set; }

  /// <summary>
  /// Sets top/right/bottom/left margins to this value. An array with two values sets top/bottom margin to the first value and left/right margin to the second value. An array with four values sets top, right, bottom, left margin respectively.
  /// </summary>
  [FactorioRconAttribute("margin")]
  public Type375078767 Margin { private get; set; }

  /// <summary>
  /// Space between the table cell contents and border. Sets top/right/bottom/left cell paddings to this value.
  /// </summary>
  [FactorioRconAttribute("cell_padding")]
  public int CellPadding { private get; set; }

  /// <summary>
  /// Sets `extra_top/right/bottom/left_padding_when_activated` to this value. An array with two values sets top/bottom padding to the first value and left/right padding to the second value. An array with four values sets top, right, bottom, left padding respectively.
  /// </summary>
  [FactorioRconAttribute("extra_padding_when_activated")]
  public Type375078767 ExtraPaddingWhenActivated { private get; set; }

  /// <summary>
  /// Sets `extra_top/right/bottom/left_margin_when_activated` to this value. An array with two values sets top/bottom margin to the first value and left/right margin to the second value. An array with four values sets top, right, bottom, left margin respectively.
  /// </summary>
  [FactorioRconAttribute("extra_margin_when_activated")]
  public Type375078767 ExtraMarginWhenActivated { private get; set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

