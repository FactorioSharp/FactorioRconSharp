#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used for specifying where a GUI arrow should point to.
/// </summary>
[FactorioRconConcept("GuiArrowSpecification")]
public abstract class GuiArrowSpecification
{
  [FactorioRconAttribute("margin")]
  public uint Margin { get; set; }

  /// <summary>
  /// This determines which of the following fields will be required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public GuiArrowType Type { get; set; }

}

