#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TriggerDelivery")]
public abstract class TriggerDelivery
{
  [FactorioRconAttribute("type")]
  public Literals869690557 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

