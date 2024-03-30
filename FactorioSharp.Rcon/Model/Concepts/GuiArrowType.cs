#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Used by <see cref="GuiArrowSpecification" />.
/// </summary>
[FactorioRconDefinition("GuiArrowType")]
public enum GuiArrowType
{
  /// <summary>
  ///     Literal value: nowhere
  /// </summary>
  [FactorioRconDefinitionValue("nowhere")]
    Nowhere,

  /// <summary>
  ///     Literal value: goal
  /// </summary>
  [FactorioRconDefinitionValue("goal")]
    Goal,

  /// <summary>
  ///     Literal value: entity_info
  /// </summary>
  [FactorioRconDefinitionValue("entity_info")]
    EntityInfo,

  /// <summary>
  ///     Literal value: active_window
  /// </summary>
  [FactorioRconDefinitionValue("active_window")]
    ActiveWindow,

  /// <summary>
  ///     Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
    Entity,

  /// <summary>
  ///     Literal value: position
  /// </summary>
  [FactorioRconDefinitionValue("position")]
    Position,

  /// <summary>
  ///     Literal value: crafting_queue
  /// </summary>
  [FactorioRconDefinitionValue("crafting_queue")]
    CraftingQueue,

  /// <summary>
  ///     Literal value: item_stack
  /// </summary>
  [FactorioRconDefinitionValue("item_stack")]
    ItemStack
}
