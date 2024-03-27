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
/// An element of a custom GUI. This type is used to represent <see cref="LuaEntity),DifferentKindsOfElementsSupportDifferentAttributes;AttemptingToAccessAnAttributeOnAnElementThatDoesn'TSupportIt(ForInstance,TryingToAccessThe`ColumnCount`OfA`Textfield`" /> will result in a runtime error.
/// 
/// For information on all supported GUI elements, see <see cref="GuiElementType" />.
/// 
/// Each GUI element allows access to its children by having them as attributes. Thus, one can use the `parent.child` syntax to refer to children. Lua also supports the `parent["child"]` syntax to refer to the same element. This can be used in cases where the child has a name that isn't a valid Lua identifier.
/// </summary>
/// <examples>
/// <list type="bullet">  <item>This will add a label called `greeting` to the top flow. Immediately after, it will change its text to illustrate accessing child elements. 
/// ```
/// game.player.gui.top.add{type="label", name="greeting", caption="Hi"}
/// game.player.gui.top.greeting.caption = "Hello there!"
/// game.player.gui.top["greeting"].caption = "Actually, never mind, I don't like your face"
/// ```</item>  <item>This will add a tabbed-pane and 2 tabs with contents. 
/// ```
/// local tabbed_pane = game.player.gui.top.add{type="tabbed-pane"}
/// local tab1 = tabbed_pane.add{type="tab", caption="Tab 1"}
/// local tab2 = tabbed_pane.add{type="tab", caption="Tab 2"}
/// local label1 = tabbed_pane.add{type="label", caption="Label 1"}
/// local label2 = tabbed_pane.add{type="label", caption="Label 2"}
/// tabbed_pane.add_tab(tab1, label1)
/// tabbed_pane.add_tab(tab2, label2)
/// ```</item></list>
/// </examples>
[FactorioRconClass("LuaGuiElement")]
public abstract class LuaGuiElement: LuaObject
{
  /// <summary>
  /// The index of this GUI element (unique amongst the GUI elements of a LuaPlayer).
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; private set; }

  /// <summary>
  /// The GUI this element is a child of.
  /// </summary>
  [FactorioRconAttribute("gui")]
  public LuaGui Gui { get; private set; }

  /// <summary>
  /// The direct parent of this element. `nil` if this is a top-level element.
  /// </summary>
  [FactorioRconAttribute("parent")]
  public LuaGuiElement Parent { get; private set; }

  /// <summary>
  /// The name of this element. `""` if no name was set.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The text displayed on this element. For frames, this is the "heading". For other elements, like buttons or labels, this is the content.
  /// </summary>
  [FactorioRconAttribute("caption")]
  public LocalisedString Caption { get; set; }

  /// <summary>
  /// How much this progress bar is filled. It is a value in the range [0, 1].
  /// </summary>
  [FactorioRconAttribute("value")]
  public double Value { get; set; }

  /// <summary>
  /// Direction of this element's layout.
  /// </summary>
  [FactorioRconAttribute("direction")]
  public GuiDirection Direction { get; private set; }

  /// <summary>
  /// The style of this element. When read, this evaluates to a <see cref="LuaStyle).ForWriting,ItOnlyAcceptsAStringThatSpecifiesTheTextualIdentifier(PrototypeName" /> of the desired style.
  /// </summary>
  [FactorioRconAttribute("style")]
  public Union_0dbb0f87b0b84fadb7b5778cb553594e Style { get; set; }

  /// <summary>
  /// Sets whether this GUI element is visible or completely hidden, taking no space in the layout.
  /// </summary>
  [FactorioRconAttribute("visible")]
  public bool Visible { get; set; }

  /// <summary>
  /// The text contained in this textfield or text-box.
  /// </summary>
  [FactorioRconAttribute("text")]
  public string Text { get; set; }

  /// <summary>
  /// Names of all the children of this element. These are the identifiers that can be used to access the child as an attribute of this element.
  /// </summary>
  [FactorioRconAttribute("children_names")]
  public List<string> ChildrenNames { get; private set; }

  /// <summary>
  /// Is this checkbox or radiobutton checked?
  /// </summary>
  [FactorioRconAttribute("state")]
  public bool State { get; set; }

  /// <summary>
  /// Index into <see cref="LuaGameScript.Players" /> specifying the player who owns this element.
  /// </summary>
  [FactorioRconAttribute("player_index")]
  public uint PlayerIndex { get; private set; }

  /// <summary>
  /// The sprite to display on this sprite-button or sprite in the default state.
  /// </summary>
  [FactorioRconAttribute("sprite")]
  public SpritePath Sprite { get; set; }

  /// <summary>
  /// Whether the sprite widget should resize according to the sprite in it. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("resize_to_sprite")]
  public bool ResizeToSprite { get; set; }

  /// <summary>
  /// The sprite to display on this sprite-button when it is hovered.
  /// </summary>
  [FactorioRconAttribute("hovered_sprite")]
  public SpritePath HoveredSprite { get; set; }

  /// <summary>
  /// The sprite to display on this sprite-button when it is clicked.
  /// </summary>
  [FactorioRconAttribute("clicked_sprite")]
  public SpritePath ClickedSprite { get; set; }

  /// <summary>
  /// The text to display when hovering over this element. Writing `""` will disable the tooltip, while writing `nil` will set it to `"nil"`.
  /// </summary>
  [FactorioRconAttribute("tooltip")]
  public LocalisedString Tooltip { get; set; }

  /// <summary>
  /// The element tooltip to display when hovering over this element, or `nil`.
  /// </summary>
  [FactorioRconAttribute("elem_tooltip")]
  public ElemID ElemTooltip { get; set; }

  /// <summary>
  /// Policy of the horizontal scroll bar.
  /// </summary>
  [FactorioRconAttribute("horizontal_scroll_policy")]
  public ScrollPolicy HorizontalScrollPolicy { get; set; }

  /// <summary>
  /// Policy of the vertical scroll bar.
  /// </summary>
  [FactorioRconAttribute("vertical_scroll_policy")]
  public ScrollPolicy VerticalScrollPolicy { get; set; }

  /// <summary>
  /// The type of this GUI element.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// The child-elements of this GUI element.
  /// </summary>
  [FactorioRconAttribute("children")]
  public List<LuaGuiElement> Children { get; private set; }

  /// <summary>
  /// The items in this dropdown or listbox.
  /// </summary>
  [FactorioRconAttribute("items")]
  public List<LocalisedString> Items { get; set; }

  /// <summary>
  /// The selected index for this dropdown or listbox. Returns `0` if none is selected.
  /// </summary>
  [FactorioRconAttribute("selected_index")]
  public uint SelectedIndex { get; set; }

  /// <summary>
  /// The number to be shown in the bottom right corner of this sprite-button. Set this to `nil` to show nothing.
  /// </summary>
  [FactorioRconAttribute("number")]
  public double Number { get; set; }

  /// <summary>
  /// Related to the number to be shown in the bottom right corner of this sprite-button. When set to `true`, numbers that are non-zero and smaller than one are shown as a percentage rather than the value. For example, `0.5` will be shown as `50%` instead.
  /// </summary>
  [FactorioRconAttribute("show_percent_for_small_numbers")]
  public bool ShowPercentForSmallNumbers { get; set; }

  /// <summary>
  /// The location of this widget when stored in <see cref="LuaGui.Screen" />.
  /// </summary>
  [FactorioRconAttribute("location")]
  public GuiLocation Location { get; set; }

  /// <summary>
  /// Whether this frame auto-centers on window resize when stored in <see cref="LuaGui.Screen" />.
  /// </summary>
  [FactorioRconAttribute("auto_center")]
  public bool AutoCenter { get; set; }

  /// <summary>
  /// The text to display after the normal tab text (designed to work with numbers)
  /// </summary>
  [FactorioRconAttribute("badge_text")]
  public LocalisedString BadgeText { get; set; }

  /// <summary>
  /// Whether this button will automatically toggle when clicked.
  /// </summary>
  [FactorioRconAttribute("auto_toggle")]
  public bool AutoToggle { get; set; }

  /// <summary>
  /// Whether this button is currently toggled. When a button is toggled, it will use the `selected_graphical_set` and `selected_font_color` defined in its style.
  /// </summary>
  [FactorioRconAttribute("toggled")]
  public bool Toggled { get; set; }

  /// <summary>
  /// How this element should interact with game controllers.
  /// </summary>
  [FactorioRconAttribute("game_controller_interaction")]
  public GameControllerInteractionEnum GameControllerInteraction { get; set; }

  /// <summary>
  /// The position this camera or minimap is focused on, if any.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// The surface index this camera or minimap is using.
  /// </summary>
  [FactorioRconAttribute("surface_index")]
  public uint SurfaceIndex { get; set; }

  /// <summary>
  /// The zoom this camera or minimap is using. This value must be positive.
  /// </summary>
  [FactorioRconAttribute("zoom")]
  public double Zoom { get; set; }

  /// <summary>
  /// The player index this minimap is using.
  /// </summary>
  [FactorioRconAttribute("minimap_player_index")]
  public uint MinimapPlayerIndex { get; set; }

  /// <summary>
  /// The force this minimap is using, if any.
  /// </summary>
  [FactorioRconAttribute("force")]
  public string Force { get; set; }

  /// <summary>
  /// The elem type of this choose-elem-button.
  /// </summary>
  [FactorioRconAttribute("elem_type")]
  public ElemType ElemType { get; private set; }

  /// <summary>
  /// The elem value of this choose-elem-button, if any.
  /// </summary>
  [FactorioRconAttribute("elem_value")]
  public Union_22df73005d794679a76709044270b997 ElemValue { get; set; }

  /// <summary>
  /// The elem filters of this choose-elem-button, if any. The compatible type of filter is determined by `elem_type`.
  /// </summary>
  [FactorioRconAttribute("elem_filters")]
  public PrototypeFilter ElemFilters { get; set; }

  /// <summary>
  /// Whether the contents of this text-box are selectable. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("selectable")]
  public bool Selectable { get; set; }

  /// <summary>
  /// Whether this text-box will word-wrap automatically. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("word_wrap")]
  public bool WordWrap { get; set; }

  /// <summary>
  /// Whether this text-box is read-only. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("read_only")]
  public bool ReadOnly { get; set; }

  /// <summary>
  /// Whether this GUI element is enabled. Disabled GUI elements don't trigger events when clicked.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// Whether this GUI element is ignored by interaction. This makes clicks on this element 'go through' to the GUI element or even the game surface below it.
  /// </summary>
  [FactorioRconAttribute("ignored_by_interaction")]
  public bool IgnoredByInteraction { get; set; }

  /// <summary>
  /// Whether this choose-elem-button can be changed by the player.
  /// </summary>
  [FactorioRconAttribute("locked")]
  public bool Locked { get; set; }

  /// <summary>
  /// Whether this table should draw vertical grid lines.
  /// </summary>
  [FactorioRconAttribute("draw_vertical_lines")]
  public bool DrawVerticalLines { get; set; }

  /// <summary>
  /// Whether this table should draw horizontal grid lines.
  /// </summary>
  [FactorioRconAttribute("draw_horizontal_lines")]
  public bool DrawHorizontalLines { get; set; }

  /// <summary>
  /// Whether this table should draw a horizontal grid line below the first table row.
  /// </summary>
  [FactorioRconAttribute("draw_horizontal_line_after_headers")]
  public bool DrawHorizontalLineAfterHeaders { get; set; }

  /// <summary>
  /// The number of columns in this table.
  /// </summary>
  [FactorioRconAttribute("column_count")]
  public uint ColumnCount { get; private set; }

  /// <summary>
  /// Whether the content of this table should be vertically centered. Overrides <see cref="LuaStyle.ColumnAlignments" />. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("vertical_centering")]
  public bool VerticalCentering { get; set; }

  /// <summary>
  /// The value of this slider element.
  /// </summary>
  [FactorioRconAttribute("slider_value")]
  public double SliderValue { get; set; }

  /// <summary>
  /// The mouse button filters for this button or sprite-button.
  /// </summary>
  [FactorioRconAttribute("mouse_button_filter")]
  public MouseButtonFlags MouseButtonFilter { get; set; }

  /// <summary>
  /// Whether this textfield is limited to only numberic characters.
  /// </summary>
  [FactorioRconAttribute("numeric")]
  public bool Numeric { get; set; }

  /// <summary>
  /// Whether this textfield (when in numeric mode) allows decimal numbers.
  /// </summary>
  [FactorioRconAttribute("allow_decimal")]
  public bool AllowDecimal { get; set; }

  /// <summary>
  /// Whether this textfield (when in numeric mode) allows negative numbers.
  /// </summary>
  [FactorioRconAttribute("allow_negative")]
  public bool AllowNegative { get; set; }

  /// <summary>
  /// Whether this textfield displays as a password field, which renders all characters as `*`.
  /// </summary>
  [FactorioRconAttribute("is_password")]
  public bool IsPassword { get; set; }

  /// <summary>
  /// Whether this textfield loses focus after <see cref="Defines.Events.OnGuiConfirmed" /> is fired.
  /// </summary>
  [FactorioRconAttribute("lose_focus_on_confirm")]
  public bool LoseFocusOnConfirm { get; set; }

  /// <summary>
  /// Makes it so right-clicking on this textfield clears and focuses it.
  /// </summary>
  [FactorioRconAttribute("clear_and_focus_on_right_click")]
  public bool ClearAndFocusOnRightClick { get; set; }

  /// <summary>
  /// The `frame` that is being moved when dragging this GUI element, if any. This element needs to be a child of the `drag_target` at some level.
  /// </summary>
  [FactorioRconAttribute("drag_target")]
  public LuaGuiElement DragTarget { get; set; }

  /// <summary>
  /// The selected tab index for this tabbed pane, if any.
  /// </summary>
  [FactorioRconAttribute("selected_tab_index")]
  public uint SelectedTabIndex { get; set; }

  /// <summary>
  /// The tabs and contents being shown in this tabbed-pane.
  /// </summary>
  [FactorioRconAttribute("tabs")]
  public List<TabAndContent> Tabs { get; private set; }

  /// <summary>
  /// The entity associated with this entity-preview, camera, minimap, if any.
  /// </summary>
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; set; }

  /// <summary>
  /// The anchor for this relative widget, if any. Setting `nil` clears the anchor.
  /// </summary>
  [FactorioRconAttribute("anchor")]
  public GuiAnchor Anchor { get; set; }

  /// <summary>
  /// The tags associated with this LuaGuiElement.
  /// </summary>
  [FactorioRconAttribute("tags")]
  public Tags Tags { get; set; }

  /// <summary>
  /// Whether this element will raise <see cref="OnGuiLeave" />.
  /// </summary>
  [FactorioRconAttribute("raise_hover_events")]
  public bool RaiseHoverEvents { get; set; }

  /// <summary>
  /// The switch state for this switch.
  /// </summary>
  [FactorioRconAttribute("switch_state")]
  public SwitchState SwitchState { get; set; }

  /// <summary>
  /// Whether the `"none"` state is allowed for this switch.
  /// </summary>
  [FactorioRconAttribute("allow_none_state")]
  public bool AllowNoneState { get; set; }

  /// <summary>
  /// The text shown for the left switch label.
  /// </summary>
  [FactorioRconAttribute("left_label_caption")]
  public LocalisedString LeftLabelCaption { get; set; }

  /// <summary>
  /// The tooltip shown on the left switch label.
  /// </summary>
  [FactorioRconAttribute("left_label_tooltip")]
  public LocalisedString LeftLabelTooltip { get; set; }

  /// <summary>
  /// The text shown for the right switch label.
  /// </summary>
  [FactorioRconAttribute("right_label_caption")]
  public LocalisedString RightLabelCaption { get; set; }

  /// <summary>
  /// The tooltip shown on the right switch label.
  /// </summary>
  [FactorioRconAttribute("right_label_tooltip")]
  public LocalisedString RightLabelTooltip { get; set; }

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
  /// The indexing operator. Gets children by name.
  /// </summary>
  public abstract LuaGuiElement? this[uint key] { get; }

  /// <summary>
  /// Add a new child element to this GuiElement.
  /// </summary>
  /// <param name="type">Lua name: type</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="caption">Lua name: caption</param>
  /// <param name="tooltip">Lua name: tooltip</param>
  /// <param name="elemTooltip">Lua name: elem_tooltip</param>
  /// <param name="enabled">Lua name: enabled</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="ignoredByInteraction">Lua name: ignored_by_interaction</param>
  /// <param name="style">Lua name: style</param>
  /// <param name="tags">Lua name: tags</param>
  /// <param name="index">Lua name: index</param>
  /// <param name="anchor">Lua name: anchor</param>
  /// <param name="gameControllerInteraction">Lua name: game_controller_interaction</param>
  /// <param name="raiseHoverEvents">Lua name: raise_hover_events</param>
  [FactorioRconMethod("add")]
  public abstract LuaGuiElement Add(GuiElementType type, string? name = null, LocalisedString? caption = null, LocalisedString? tooltip = null, ElemID? elemTooltip = null, bool? enabled = null, bool? visible = null, bool? ignoredByInteraction = null, string? style = null, Tags? tags = null, uint? index = null, GuiAnchor? anchor = null, GameControllerInteractionEnum? gameControllerInteraction = null, bool? raiseHoverEvents = null);

  /// <summary>
  /// Remove children of this element. Any <see cref="LuaGuiElement" /> objects referring to the destroyed elements become invalid after this operation.
  /// </summary>
  [FactorioRconMethod("clear")]
  public abstract void Clear();

  /// <summary>
  /// Remove this element, along with its children. Any <see cref="LuaGuiElement" /> objects referring to the destroyed elements become invalid after this operation.
  /// </summary>
  /// <remarks>
  /// The top-level GUI elements - <see cref="LuaGui.Screen" /> - can't be destroyed.
  /// </remarks>
  [FactorioRconMethod("destroy")]
  public abstract void Destroy();

  /// <summary>
  /// The mod that owns this Gui element or `nil` if it's owned by the scenario script.
  /// </summary>
  /// <remarks>
  /// This has a not-super-expensive, but non-free cost to get.
  /// </remarks>
  [FactorioRconMethod("get_mod")]
  public abstract string? GetMod();

  /// <summary>
  /// Gets the index that this element has in its parent element.
  /// </summary>
  /// <remarks>
  /// This iterates through the children of the parent of this element, meaning this has a non-free cost to get, but is faster than doing the equivalent in Lua.
  /// </remarks>
  [FactorioRconMethod("get_index_in_parent")]
  public abstract uint GetIndexInParent();

  /// <summary>
  /// Swaps the children at the given indices in this element.
  /// </summary>
  /// <param name="index1">Lua name: index_1</param>
  /// <param name="index2">Lua name: index_2</param>
  [FactorioRconMethod("swap_children")]
  public abstract void SwapChildren(uint index1, uint index2);

  /// <summary>
  /// Removes the items in this dropdown or listbox.
  /// </summary>
  [FactorioRconMethod("clear_items")]
  public abstract void ClearItems();

  /// <summary>
  /// Gets the item at the given index from this dropdown or listbox.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_item")]
  public abstract LocalisedString GetItem(uint index);

  /// <summary>
  /// Sets the given string at the given index in this dropdown or listbox.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="@string">Lua name: string</param>
  [FactorioRconMethod("set_item")]
  public abstract void SetItem(uint index, LocalisedString @string);

  /// <summary>
  /// Inserts a string at the end or at the given index of this dropdown or listbox.
  /// </summary>
  /// <param name="@string">Lua name: string</param>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("add_item")]
  public abstract void AddItem(LocalisedString @string, uint? index = null);

  /// <summary>
  /// Removes the item at the given index from this dropdown or listbox.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("remove_item")]
  public abstract void RemoveItem(uint index);

  /// <summary>
  /// Gets this sliders minimum value.
  /// </summary>
  [FactorioRconMethod("get_slider_minimum")]
  public abstract double GetSliderMinimum();

  /// <summary>
  /// Gets this sliders maximum value.
  /// </summary>
  [FactorioRconMethod("get_slider_maximum")]
  public abstract double GetSliderMaximum();

  /// <summary>
  /// Sets this sliders minimum and maximum values.
  /// </summary>
  /// <remarks>
  /// The minimum can't be >= the maximum.
  /// </remarks>
  /// <param name="minimum">Lua name: minimum</param>
  /// <param name="maximum">Lua name: maximum</param>
  [FactorioRconMethod("set_slider_minimum_maximum")]
  public abstract void SetSliderMinimumMaximum(double minimum, double maximum);

  /// <summary>
  /// Gets the minimum distance this slider can move.
  /// </summary>
  [FactorioRconMethod("get_slider_value_step")]
  public abstract double GetSliderValueStep();

  /// <summary>
  /// Returns whether this slider only allows being moved to discrete positions.
  /// </summary>
  [FactorioRconMethod("get_slider_discrete_slider")]
  public abstract bool GetSliderDiscreteSlider();

  /// <summary>
  /// Returns whether this slider only allows discrete values.
  /// </summary>
  [FactorioRconMethod("get_slider_discrete_values")]
  public abstract bool GetSliderDiscreteValues();

  /// <summary>
  /// Sets the minimum distance this slider can move.
  /// </summary>
  /// <remarks>
  /// The minimum distance can't be > (max - min).
  /// </remarks>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_slider_value_step")]
  public abstract void SetSliderValueStep(double value);

  /// <summary>
  /// Sets whether this slider only allows being moved to discrete positions.
  /// </summary>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_slider_discrete_slider")]
  public abstract void SetSliderDiscreteSlider(bool value);

  /// <summary>
  /// Sets whether this slider only allows discrete values.
  /// </summary>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_slider_discrete_values")]
  public abstract void SetSliderDiscreteValues(bool value);

  /// <summary>
  /// Focuses this GUI element if possible.
  /// </summary>
  [FactorioRconMethod("focus")]
  public abstract void Focus();

  /// <summary>
  /// Scrolls this scroll bar to the top.
  /// </summary>
  [FactorioRconMethod("scroll_to_top")]
  public abstract void ScrollToTop();

  /// <summary>
  /// Scrolls this scroll bar to the bottom.
  /// </summary>
  [FactorioRconMethod("scroll_to_bottom")]
  public abstract void ScrollToBottom();

  /// <summary>
  /// Scrolls this scroll bar to the left.
  /// </summary>
  [FactorioRconMethod("scroll_to_left")]
  public abstract void ScrollToLeft();

  /// <summary>
  /// Scrolls this scroll bar to the right.
  /// </summary>
  [FactorioRconMethod("scroll_to_right")]
  public abstract void ScrollToRight();

  /// <summary>
  /// Scrolls this scroll bar such that the specified GUI element is visible to the player.
  /// </summary>
  /// <param name="element">Lua name: element</param>
  /// <param name="scrollMode">Lua name: scroll_mode</param>
  [FactorioRconMethod("scroll_to_element")]
  public abstract void ScrollToElement(LuaGuiElement element, Literals_29fcda1f0e554553ab638952ade83c00? scrollMode = null);

  /// <summary>
  /// Selects all the text in this textbox.
  /// </summary>
  [FactorioRconMethod("select_all")]
  public abstract void SelectAll();

  /// <summary>
  /// Selects a range of text in this textbox.
  /// </summary>
  /// <param name="startIndex">Lua name: start_index</param>
  /// <param name="endIndex">Lua name: end_index</param>
  [FactorioRconMethod("select")]
  public abstract void Select(int startIndex, int endIndex);

  /// <summary>
  /// Adds the given tab and content widgets to this tabbed pane as a new tab.
  /// </summary>
  /// <param name="tab">Lua name: tab</param>
  /// <param name="content">Lua name: content</param>
  [FactorioRconMethod("add_tab")]
  public abstract void AddTab(LuaGuiElement tab, LuaGuiElement content);

  /// <summary>
  /// Removes the given tab and its associated content from this tabbed pane.
  /// </summary>
  /// <remarks>
  /// Removing a tab does not destroy the tab or the tab contents. It just removes them from the view.
  /// When removing tabs, <see cref="LuaGuiElement.SelectedTabIndex" /> needs to be manually updated.
  /// </remarks>
  /// <param name="tab">Lua name: tab</param>
  [FactorioRconMethod("remove_tab")]
  public abstract void RemoveTab(LuaGuiElement tab);

  /// <summary>
  /// Forces this frame to re-auto-center. Only works on frames stored directly in <see cref="LuaGui.Screen" />.
  /// </summary>
  [FactorioRconMethod("force_auto_center")]
  public abstract void ForceAutoCenter();

  /// <summary>
  /// Scrolls the scroll bar such that the specified listbox item is visible to the player.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="scrollMode">Lua name: scroll_mode</param>
  [FactorioRconMethod("scroll_to_item")]
  public abstract void ScrollToItem(int index, Literals_bc4e64134af2491c8fdd2a4b683976c5? scrollMode = null);

  /// <summary>
  /// Moves this GUI element to the "front" so it will draw over other elements.
  /// </summary>
  /// <remarks>
  /// Only works for elements in <see cref="LuaGui.Screen" />
  /// </remarks>
  [FactorioRconMethod("bring_to_front")]
  public abstract void BringToFront();

  /// <summary>
  /// Closes the dropdown list if this is a dropdown and it is open.
  /// </summary>
  [FactorioRconMethod("close_dropdown")]
  public abstract void CloseDropdown();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

