#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used by <see cref="GuiArrowSpecification" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("GuiArrowType")]
public abstract partial class GuiArrowType: OneOfBase<Literal63768962, Literal37360575, Literal9714877, Literal13295985, Literal50039263, Literal41852487, Literal5762573, Literal32896910>
{
}

[GenerateOneOf]
public abstract partial class Union57737299: OneOfBase<Literal63768962, Literal37360575, Literal9714877, Literal13295985, Literal50039263, Literal41852487, Literal5762573, Literal32896910>
{
}

/// <summary>
/// Literal value: nowhere
/// </summary>
public enum Literal63768962
{
  /// <summary>
  /// Literal value: nowhere
  /// </summary>
  [FactorioRconDefinitionValue("nowhere")]
  Nowhere,

}

/// <summary>
/// Literal value: goal
/// </summary>
public enum Literal37360575
{
  /// <summary>
  /// Literal value: goal
  /// </summary>
  [FactorioRconDefinitionValue("goal")]
  Goal,

}

/// <summary>
/// Literal value: entity_info
/// </summary>
public enum Literal9714877
{
  /// <summary>
  /// Literal value: entity_info
  /// </summary>
  [FactorioRconDefinitionValue("entity_info")]
  EntityInfo,

}

/// <summary>
/// Literal value: active_window
/// </summary>
public enum Literal13295985
{
  /// <summary>
  /// Literal value: active_window
  /// </summary>
  [FactorioRconDefinitionValue("active_window")]
  ActiveWindow,

}

/// <summary>
/// Literal value: entity
/// </summary>
public enum Literal50039263
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

/// <summary>
/// Literal value: position
/// </summary>
public enum Literal41852487
{
  /// <summary>
  /// Literal value: position
  /// </summary>
  [FactorioRconDefinitionValue("position")]
  Position,

}

/// <summary>
/// Literal value: crafting_queue
/// </summary>
public enum Literal5762573
{
  /// <summary>
  /// Literal value: crafting_queue
  /// </summary>
  [FactorioRconDefinitionValue("crafting_queue")]
  CraftingQueue,

}

/// <summary>
/// Literal value: item_stack
/// </summary>
public enum Literal32896910
{
  /// <summary>
  /// Literal value: item_stack
  /// </summary>
  [FactorioRconDefinitionValue("item_stack")]
  ItemStack,

}

