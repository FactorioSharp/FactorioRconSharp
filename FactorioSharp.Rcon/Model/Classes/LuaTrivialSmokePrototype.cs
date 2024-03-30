#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Prototype of a trivial smoke.
/// </summary>
[FactorioRconClass("LuaTrivialSmokePrototype")]
public abstract class LuaTrivialSmokePrototype : LuaObject
{
  /// <summary>
  ///     Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; private set; }

  /// <summary>
  ///     The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
    public string Order { get; private set; }

    [FactorioRconAttribute("localised_name")]
    public LocalisedString LocalisedName { get; private set; }

    [FactorioRconAttribute("localised_description")]
    public LocalisedString LocalisedDescription { get; private set; }

    [FactorioRconAttribute("color")]
    public Color Color { get; private set; }

    [FactorioRconAttribute("start_scale")]
    public double StartScale { get; private set; }

    [FactorioRconAttribute("end_scale")]
    public double EndScale { get; private set; }

    [FactorioRconAttribute("movement_slow_down_factor")]
    public double MovementSlowDownFactor { get; private set; }

    [FactorioRconAttribute("duration")]
    public uint Duration { get; private set; }

    [FactorioRconAttribute("spread_duration")]
    public uint SpreadDuration { get; private set; }

    [FactorioRconAttribute("fade_away_duration")]
    public uint FadeAwayDuration { get; private set; }

    [FactorioRconAttribute("fade_in_duration")]
    public uint FadeInDuration { get; private set; }

    [FactorioRconAttribute("glow_fade_away_duration")]
    public uint GlowFadeAwayDuration { get; private set; }

    [FactorioRconAttribute("cyclic")]
    public bool Cyclic { get; private set; }

    [FactorioRconAttribute("affected_by_wind")]
    public bool AffectedByWind { get; private set; }

    [FactorioRconAttribute("show_when_smoke_off")]
    public bool ShowWhenSmokeOff { get; private set; }

    [FactorioRconAttribute("glow_animation")]
    public bool GlowAnimation { get; private set; }

    [FactorioRconAttribute("render_layer")]
    public RenderLayer RenderLayer { get; private set; }

    /// <summary>
    ///     Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the
    ///     corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the
    ///     game state might have occurred between the creation of the Lua object and its access.
    /// </summary>
    [FactorioRconAttribute("valid")]
    public bool Valid { get; private set; }

    /// <summary>
    ///     The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
    /// </summary>
    [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

    /// <summary>
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
