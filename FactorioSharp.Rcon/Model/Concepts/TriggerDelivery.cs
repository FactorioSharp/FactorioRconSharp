#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TriggerDelivery")]
public class TriggerDelivery
{
  [FactorioRconAttribute("type")]
  public Literals107688790 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public LuaArray<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public LuaArray<TriggerEffectItem> TargetEffects { get; set; }

}

