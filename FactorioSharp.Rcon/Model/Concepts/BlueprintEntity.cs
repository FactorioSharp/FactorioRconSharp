#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// The representation of an entity inside of a blueprint. It has at least these fields, but can contain additional ones depending on the kind of entity.
/// </summary>
[FactorioRconConcept("BlueprintEntity")]
public class BlueprintEntity
{
  /// <summary>
  /// The entity's unique identifier in the blueprint.
  /// </summary>
  [FactorioRconAttribute("entity_number")]
  public uint EntityNumber { get; set; }

  /// <summary>
  /// The prototype name of the entity.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The position of the entity.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// The direction the entity is facing. Only present for entities that can face in different directions and when the entity is not facing north.
  /// </summary>
  [FactorioRconAttribute("direction")]
  public DirectionEnum Direction { get; set; }

  /// <summary>
  /// The entity tags of the entity, if there are any. Only relevant for entity ghosts.
  /// </summary>
  [FactorioRconAttribute("tags")]
  public Tags Tags { get; set; }

  /// <summary>
  /// The items that the entity will request when revived, if there are any. It's a mapping of prototype names to amounts. Only relevant for entity ghosts.
  /// </summary>
  [FactorioRconAttribute("items")]
  public Dictionary<string, uint> Items { get; set; }

  /// <summary>
  /// The circuit network connections of the entity, if there are any. Only relevant for entities that support circuit connections.
  /// </summary>
  [FactorioRconAttribute("connections")]
  public BlueprintCircuitConnection Connections { get; set; }

  /// <summary>
  /// The control behavior of the entity, if it has one. The format of the control behavior depends on the entity's type. Only relevant for entities that support control behaviors.
  /// </summary>
  [FactorioRconAttribute("control_behavior")]
  public BlueprintControlBehavior ControlBehavior { get; set; }

  /// <summary>
  /// The schedule of the entity, if it has one. Only relevant for locomotives.
  /// </summary>
  [FactorioRconAttribute("schedule")]
  public List<TrainScheduleRecord> Schedule { get; set; }

}

