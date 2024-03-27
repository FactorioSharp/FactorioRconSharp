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
/// An array of fluid boxes of an entity. Entities may contain more than one fluid box, and some can change the number of fluid boxes -- for instance, an assembling machine will change its number of fluid boxes depending on its active recipe. See <see cref="Fluid" />.
/// 
/// Do note that reading from a <see cref="LuaFluidBox" /> creates a new table and writing will copy the given fields from the table into the engine's own fluid box structure. Therefore, the correct way to update a fluidbox of an entity is to read it first, modify the table, then write the modified table back. Directly accessing the returned table's attributes won't have the desired effect.
/// </summary>
/// <examples>
/// Double the temperature of the fluid in `entity`'s first fluid box. 
/// ```
/// fluid = entity.fluidbox[1]
/// fluid.temperature = fluid.temperature * 2
/// entity.fluidbox[1] = fluid
/// ```
/// </examples>
[FactorioRconClass("LuaFluidBox")]
public abstract class LuaFluidBox: LuaObject
{
  /// <summary>
  /// The entity that owns this fluidbox.
  /// </summary>
  [FactorioRconAttribute("owner")]
  public LuaEntity Owner { get; private set; }

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
  /// Number of fluid boxes.
  /// </summary>
  [FactorioRconAttribute("length")]
  public uint Length { get; private set; }

  /// <summary>
  /// Access, set or clear a fluid box. The index must always be in bounds (see <see cref="LuaFluidBox.LengthOperator)" />. New fluidboxes may not be added or removed using this operator.
  /// 
  /// Is `nil` if the given fluid box does not contain any fluid. Writing `nil` removes all fluid from the fluid box.
  /// </summary>
  public abstract Fluid? this[uint key] { get; }

  /// <summary>
  /// The prototype of this fluidbox index. If this is used on a fluidbox of a crafting machine which due to recipe was created by merging multiple prototypes, a table of prototypes that were merged will be returned instead
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_prototype")]
  public abstract Union3650154 GetPrototype(uint index);

  /// <summary>
  /// The capacity of the given fluidbox index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_capacity")]
  public abstract double GetCapacity(uint index);

  /// <summary>
  /// The fluidboxes to which the fluidbox at the given index is connected.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_connections")]
  public abstract List<LuaFluidBox> GetConnections(uint index);

  /// <summary>
  /// Get the fluid box's connections and associated data.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_pipe_connections")]
  public abstract List<PipeConnection> GetPipeConnections(uint index);

  /// <summary>
  /// Get a fluid box filter
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_filter")]
  public abstract FluidBoxFilter? GetFilter(uint index);

  /// <summary>
  /// Set a fluid box filter.
  /// </summary>
  /// <remarks>
  /// Some entities cannot have their fluidbox filter set, notably fluid wagons and crafting machines.
  /// </remarks>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_filter")]
  public abstract bool SetFilter(uint index, Union5193697 filter);

  /// <summary>
  /// Flow through the fluidbox in the last tick. It is the larger of in-flow and out-flow.
  /// </summary>
  /// <remarks>
  /// Fluid wagons do not track it and will return 0.
  /// </remarks>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_flow")]
  public abstract double GetFlow(uint index);

  /// <summary>
  /// Returns the fluid the fluidbox is locked onto
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_locked_fluid")]
  public abstract string? GetLockedFluid(uint index);

  /// <summary>
  /// Gets unique fluid system identifier of selected fluid box. May return nil for fluid wagon, fluid turret's internal buffer or a fluidbox which does not belong to a fluid system
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_fluid_system_id")]
  public abstract uint? GetFluidSystemId(uint index);

  /// <summary>
  /// Gets counts of all fluids in the fluid system. May return `nil` for fluid wagon, fluid turret's internal buffer, or a fluidbox which does not belong to a fluid system.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_fluid_system_contents")]
  public abstract Dictionary<string, uint>? GetFluidSystemContents(uint index);

  /// <summary>
  /// Flushes all fluid from this fluidbox and its fluid system.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("flush")]
  public abstract Dictionary<string, float> Flush(uint index, FluidIdentification? fluid = null);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

