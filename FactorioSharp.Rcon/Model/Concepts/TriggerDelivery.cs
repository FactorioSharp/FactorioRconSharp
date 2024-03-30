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
public class TriggerDelivery: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public Literals1588419106 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

