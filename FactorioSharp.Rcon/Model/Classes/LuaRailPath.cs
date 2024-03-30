#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// A rail path.
/// </summary>
[FactorioRconClass("LuaRailPath")]
public abstract class LuaRailPath: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// The total number of rails in this path.
  /// </summary>
  [FactorioRconAttribute("size")]
  public uint Size { get; private set; }

  /// <summary>
  /// The current rail index.
  /// </summary>
  [FactorioRconAttribute("current")]
  public uint Current { get; private set; }

  /// <summary>
  /// The total path distance.
  /// </summary>
  [FactorioRconAttribute("total_distance")]
  public double TotalDistance { get; private set; }

  /// <summary>
  /// The total distance travelled.
  /// </summary>
  [FactorioRconAttribute("travelled_distance")]
  public double TravelledDistance { get; private set; }

  /// <summary>
  /// Array of the rails that this path travels over.
  /// </summary>
  [FactorioRconAttribute("rails")]
  public LuaCustomTable<uint, LuaEntity> Rails { get; private set; }

  /// <summary>
  /// If the path goes from the front of the train
  /// </summary>
  [FactorioRconAttribute("is_front")]
  public bool IsFront { get; private set; }

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

  public void Load(string str) => throw new NotImplementedException();
}

