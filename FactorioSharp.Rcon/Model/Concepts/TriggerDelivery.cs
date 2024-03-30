#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TriggerDelivery")]
public class TriggerDelivery
{
    [FactorioRconAttribute("type")]
    public Literals1176204203 Type { get; set; }

    [FactorioRconAttribute("source_effects")]
    public List<TriggerEffectItem> SourceEffects { get; set; }

    [FactorioRconAttribute("target_effects")]
    public List<TriggerEffectItem> TargetEffects { get; set; }
}
