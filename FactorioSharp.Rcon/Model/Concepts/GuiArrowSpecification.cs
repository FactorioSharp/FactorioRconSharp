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
/// Used for specifying where a GUI arrow should point to.
/// </summary>
[FactorioRconConcept("GuiArrowSpecification")]
public class GuiArrowSpecification
{
  [FactorioRconAttribute("margin")]
  public uint Margin { get; set; }

  /// <summary>
  /// This determines which of the following fields will be required.
  /// </summary>
  [FactorioRconAttribute("type")]
  public GuiArrowType Type { get; set; }

}

