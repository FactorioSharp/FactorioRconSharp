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
/// A collection of units moving and attacking together. The engine creates autonomous unit groups to attack polluted areas. The script can create and control such groups as well. Groups can accept commands in the same manner as regular units.
/// </summary>
[FactorioRconClass("LuaUnitGroup")]
public abstract class LuaUnitGroup: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// Members of this group.
  /// </summary>
  [FactorioRconAttribute("members")]
  public List<LuaEntity> Members { get; private set; }

  /// <summary>
  /// Group position. This can have different meanings depending on the group state. When the group is gathering, the position is the place of gathering. When the group is moving, the position is the expected position of its members along the path. When the group is attacking, it is the average position of its members.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; private set; }

  /// <summary>
  /// Whether this group is gathering, moving or attacking.
  /// </summary>
  [FactorioRconAttribute("state")]
  public GroupStateEnum State { get; private set; }

  /// <summary>
  /// The force of this unit group.
  /// </summary>
  [FactorioRconAttribute("force")]
  public LuaForce Force { get; private set; }

  /// <summary>
  /// The surface of this unit group.
  /// </summary>
  [FactorioRconAttribute("surface")]
  public LuaSurface Surface { get; private set; }

  /// <summary>
  /// The group number for this unit group.
  /// </summary>
  [FactorioRconAttribute("group_number")]
  public uint GroupNumber { get; private set; }

  /// <summary>
  /// Whether this unit group is controlled by a script or by the game engine. This can be changed using <see cref="LuaUnitGroup.SetAutonomous" />.
  /// </summary>
  [FactorioRconAttribute("is_script_driven")]
  public bool IsScriptDriven { get; private set; }

  /// <summary>
  /// The command given to this group, if any.
  /// </summary>
  [FactorioRconAttribute("command")]
  public Command Command { get; private set; }

  /// <summary>
  /// The distraction command given to this group, if any.
  /// </summary>
  [FactorioRconAttribute("distraction_command")]
  public Command DistractionCommand { get; private set; }

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
  /// Make a unit a member of this group. Has the same effect as giving a `group_command` with this group to the unit.
  /// </summary>
  /// <remarks>
  /// The member must have the same force as the unit group.
  /// </remarks>
  /// <param name="unit">Lua name: unit</param>
  [FactorioRconMethod("add_member")]
  public abstract void AddMember(LuaEntity unit);

  /// <summary>
  /// Give this group a command.
  /// </summary>
  /// <param name="command">Lua name: command</param>
  [FactorioRconMethod("set_command")]
  public abstract void SetCommand(Command command);

  /// <summary>
  /// Give this group a distraction command.
  /// </summary>
  /// <param name="command">Lua name: command</param>
  [FactorioRconMethod("set_distraction_command")]
  public abstract void SetDistractionCommand(Command command);

  /// <summary>
  /// Make this group autonomous. Autonomous groups will automatically attack polluted areas. Autonomous groups aren't considered to be <see cref="LuaUnitGroup.IsScriptDriven" />.
  /// </summary>
  [FactorioRconMethod("set_autonomous")]
  public abstract void SetAutonomous();

  /// <summary>
  /// Make the group start moving even if some of its members haven't yet arrived.
  /// </summary>
  [FactorioRconMethod("start_moving")]
  public abstract void StartMoving();

  /// <summary>
  /// Dissolve this group. Its members won't be destroyed, they will be merely unlinked from this group.
  /// </summary>
  [FactorioRconMethod("destroy")]
  public abstract void Destroy();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

  public void Load(string str) => throw new NotImplementedException();
}

