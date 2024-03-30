#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TriggerEffectItem")]
public class TriggerEffectItem: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public TriggerEffectItemType Type { get; set; }

  [FactorioRconAttribute("repeat_count")]
  public ushort RepeatCount { get; set; }

  [FactorioRconAttribute("repeat_count_deviation")]
  public ushort RepeatCountDeviation { get; set; }

  [FactorioRconAttribute("probability")]
  public float Probability { get; set; }

  [FactorioRconAttribute("affects_target")]
  public bool AffectsTarget { get; set; }

  [FactorioRconAttribute("show_in_tooltip")]
  public bool ShowInTooltip { get; set; }

  [FactorioRconAttribute("damage_type_filters")]
  public DamageTypeFilters DamageTypeFilters { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

