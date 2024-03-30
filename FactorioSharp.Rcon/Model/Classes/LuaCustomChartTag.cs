#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     A custom tag that shows on the map view.
/// </summary>
[FactorioRconClass("LuaCustomChartTag")]
public abstract class LuaCustomChartTag : LuaObject
{
  /// <summary>
  ///     This tag's icon, if it has one. Writing `nil` removes it.
  /// </summary>
  [FactorioRconAttribute("icon")]
    public SignalID Icon { get; set; }

  /// <summary>
  ///     The player who last edited this tag.
  /// </summary>
  [FactorioRconAttribute("last_user")]
    public LuaPlayer LastUser { get; set; }

  /// <summary>
  ///     The position of this tag.
  /// </summary>
  [FactorioRconAttribute("position")]
    public MapPosition Position { get; private set; }

    [FactorioRconAttribute("text")]
    public string Text { get; set; }

    /// <summary>
    ///     The unique ID for this tag on this force.
    /// </summary>
    [FactorioRconAttribute("tag_number")]
    public uint TagNumber { get; private set; }

    /// <summary>
    ///     The force this tag belongs to.
    /// </summary>
    [FactorioRconAttribute("force")]
    public LuaForce Force { get; private set; }

    /// <summary>
    ///     The surface this tag belongs to.
    /// </summary>
    [FactorioRconAttribute("surface")]
    public LuaSurface Surface { get; private set; }

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
    ///     Destroys this tag.
    /// </summary>
    [FactorioRconMethod("destroy")]
    public abstract void Destroy();

    /// <summary>
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
