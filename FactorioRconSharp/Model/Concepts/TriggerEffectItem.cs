#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TriggerEffectItem")]
public abstract class TriggerEffectItem
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

}

