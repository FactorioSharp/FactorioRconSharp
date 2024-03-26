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
/// Prototype of an optimized particle.
/// </summary>
[FactorioRconClass("LuaParticlePrototype")]
public abstract class LuaParticlePrototype: LuaObject
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

  [FactorioRconAttribute("regular_trigger_effect")]
  public TriggerEffectItem RegularTriggerEffect { get; private set; }

  [FactorioRconAttribute("ended_in_water_trigger_effect")]
  public TriggerEffectItem EndedInWaterTriggerEffect { get; private set; }

  [FactorioRconAttribute("render_layer")]
  public RenderLayer RenderLayer { get; private set; }

  [FactorioRconAttribute("render_layer_when_on_ground")]
  public RenderLayer RenderLayerWhenOnGround { get; private set; }

  [FactorioRconAttribute("life_time")]
  public uint LifeTime { get; private set; }

  [FactorioRconAttribute("regular_trigger_effect_frequency")]
  public uint RegularTriggerEffectFrequency { get; private set; }

  [FactorioRconAttribute("movement_modifier_when_on_ground")]
  public float MovementModifierWhenOnGround { get; private set; }

  [FactorioRconAttribute("movement_modifier")]
  public float MovementModifier { get; private set; }

  [FactorioRconAttribute("mining_particle_frame_speed")]
  public float MiningParticleFrameSpeed { get; private set; }

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

