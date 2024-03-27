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
/// Prototype of a custom input.
/// </summary>
[FactorioRconClass("LuaCustomInputPrototype")]
public abstract class LuaCustomInputPrototype: LuaObject
{
  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// The default key sequence for this custom input.
  /// </summary>
  [FactorioRconAttribute("key_sequence")]
  public string KeySequence { get; private set; }

  /// <summary>
  /// The default alternative key sequence for this custom input, if any
  /// </summary>
  [FactorioRconAttribute("alternative_key_sequence")]
  public string AlternativeKeySequence { get; private set; }

  /// <summary>
  /// The default controller key sequence for this custom input, if any
  /// </summary>
  [FactorioRconAttribute("controller_key_sequence")]
  public string ControllerKeySequence { get; private set; }

  /// <summary>
  /// The default controller alternative key sequence for this custom input, if any
  /// </summary>
  [FactorioRconAttribute("controller_alternative_key_sequence")]
  public string ControllerAlternativeKeySequence { get; private set; }

  /// <summary>
  /// The linked game control name, if any.
  /// </summary>
  [FactorioRconAttribute("linked_game_control")]
  public string LinkedGameControl { get; private set; }

  /// <summary>
  /// The consuming type.
  /// </summary>
  [FactorioRconAttribute("consuming")]
  public Literals1207571592 Consuming { get; private set; }

  /// <summary>
  /// The action that happens when this custom input is triggered.
  /// </summary>
  [FactorioRconAttribute("action")]
  public string Action { get; private set; }

  /// <summary>
  /// Whether this custom input is enabled. Disabled custom inputs exist but are not used by the game.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; private set; }

  /// <summary>
  /// Whether this custom input is enabled while using the spectator controller.
  /// </summary>
  [FactorioRconAttribute("enabled_while_spectating")]
  public bool EnabledWhileSpectating { get; private set; }

  /// <summary>
  /// Whether this custom input is enabled while using the cutscene controller.
  /// </summary>
  [FactorioRconAttribute("enabled_while_in_cutscene")]
  public bool EnabledWhileInCutscene { get; private set; }

  /// <summary>
  /// Whether this custom input will include the selected prototype (if any) when triggered.
  /// </summary>
  [FactorioRconAttribute("include_selected_prototype")]
  public bool IncludeSelectedPrototype { get; private set; }

  /// <summary>
  /// The item that gets spawned when this custom input is fired, if any.
  /// </summary>
  [FactorioRconAttribute("item_to_spawn")]
  public LuaItemPrototype ItemToSpawn { get; private set; }

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

