#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// The root of the GUI. This type houses the root elements, `top`, `left`, `center`, `goal`, and `screen`, to which other elements can be added to be displayed on screen.
/// </summary>
[FactorioRconClass("LuaGui")]
public abstract class LuaGui: LuaObject
{
  /// <summary>
  /// The player who owns this gui.
  /// </summary>
  [FactorioRconAttribute("player")]
  public LuaPlayer Player { get; private set; }

  /// <summary>
  /// The children GUI elements mapped by name <> element.
  /// </summary>
  [FactorioRconAttribute("children")]
  public Dictionary<string, LuaGuiElement> Children { get; private set; }

  /// <summary>
  /// The top part of the GUI. It is a flow element inside a scroll pane element.
  /// </summary>
  [FactorioRconAttribute("top")]
  public LuaGuiElement Top { get; private set; }

  /// <summary>
  /// The left part of the GUI. It is a flow element inside a scroll pane element.
  /// </summary>
  [FactorioRconAttribute("left")]
  public LuaGuiElement Left { get; private set; }

  /// <summary>
  /// The center part of the GUI. It is a flow element.
  /// </summary>
  [FactorioRconAttribute("center")]
  public LuaGuiElement Center { get; private set; }

  /// <summary>
  /// The flow used in the objectives window. It is a flow element. The objectives window is only visible when the flow is not empty or the objective text is set.
  /// </summary>
  [FactorioRconAttribute("goal")]
  public LuaGuiElement Goal { get; private set; }

  /// <summary>
  /// For showing a GUI somewhere on the entire screen. It is an empty-widget element.
  /// </summary>
  [FactorioRconAttribute("screen")]
  public LuaGuiElement Screen { get; private set; }

  /// <summary>
  /// For showing a GUI somewhere relative to one of the game GUIs. It is an empty-widget element.
  /// </summary>
  [FactorioRconAttribute("relative")]
  public LuaGuiElement Relative { get; private set; }

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
  /// Returns `true` if sprite_path is valid and contains loaded sprite, otherwise `false`. Sprite path of type `file` doesn't validate if file exists.
  /// 
  /// If you want to avoid needing a LuaGui object, <see cref="LuaGameScript.IsValidSpritePath" /> can be used instead.
  /// </summary>
  /// <param name="spritePath">Lua name: sprite_path</param>
  [FactorioRconMethod("is_valid_sprite_path")]
  public abstract bool IsValidSpritePath(SpritePath spritePath);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

