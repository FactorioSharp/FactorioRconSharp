#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CopperConnectionDefinition")]
public abstract class CopperConnectionDefinition
{
  [FactorioRconAttribute("source_wire_connector")]
  public WireConnectionIdEnum SourceWireConnector { get; set; }

  [FactorioRconAttribute("target_entity")]
  public LuaEntity TargetEntity { get; set; }

  [FactorioRconAttribute("target_wire_connector")]
  public WireConnectionIdEnum TargetWireConnector { get; set; }

}
