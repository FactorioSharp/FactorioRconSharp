#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("UnitGroupMapSettings")]
public class UnitGroupMapSettings
{
  /// <summary>
  /// The minimum amount of time in ticks a group will spend gathering before setting off. The actual time is a random time between the minimum and maximum times. Defaults to `3 600` ticks.
  /// </summary>
  [FactorioRconAttribute("min_group_gathering_time")]
  public uint MinGroupGatheringTime { get; set; }

  /// <summary>
  /// The maximum amount of time in ticks a group will spend gathering before setting off. The actual time is a random time between the minimum and maximum times. Defaults to `10*3 600=36 000` ticks.
  /// </summary>
  [FactorioRconAttribute("max_group_gathering_time")]
  public uint MaxGroupGatheringTime { get; set; }

  /// <summary>
  /// After gathering has finished, the group is allowed to wait this long in ticks for delayed members. New members are not accepted anymore however. Defaults to `2*3 600=7 200` ticks.
  /// </summary>
  [FactorioRconAttribute("max_wait_time_for_late_members")]
  public uint MaxWaitTimeForLateMembers { get; set; }

  /// <summary>
  /// The minimum group radius in tiles. The actual radius is adjusted based on the number of members. Defaults to `5.0`.
  /// </summary>
  [FactorioRconAttribute("min_group_radius")]
  public double MinGroupRadius { get; set; }

  /// <summary>
  /// The maximum group radius in tiles. The actual radius is adjusted based on the number of members. Defaults to `30.0`.
  /// </summary>
  [FactorioRconAttribute("max_group_radius")]
  public double MaxGroupRadius { get; set; }

  /// <summary>
  /// The maximum speed a percentage of its regular speed that a group member can speed up to when catching up with the group. Defaults to `1.4`, or 140%.
  /// </summary>
  [FactorioRconAttribute("max_member_speedup_when_behind")]
  public double MaxMemberSpeedupWhenBehind { get; set; }

  /// <summary>
  /// The minimum speed a percentage of its regular speed that a group member can slow down to when ahead of the group. Defaults to `0.6`, or 60%.
  /// </summary>
  [FactorioRconAttribute("max_member_slowdown_when_ahead")]
  public double MaxMemberSlowdownWhenAhead { get; set; }

  /// <summary>
  /// The minimum speed as a percentage of its maximum speed that a group will slow down to so members that fell behind can catch up. Defaults to `0.3`, or 30%.
  /// </summary>
  [FactorioRconAttribute("max_group_slowdown_factor")]
  public double MaxGroupSlowdownFactor { get; set; }

  /// <summary>
  /// When a member of a group falls back more than this factor times the group radius, the group will slow down to its `max_group_slowdown_factor` speed to let them catch up. Defaults to `3`.
  /// </summary>
  [FactorioRconAttribute("max_group_member_fallback_factor")]
  public double MaxGroupMemberFallbackFactor { get; set; }

  /// <summary>
  /// When a member of a group falls back more than this factor times the group radius, it will be dropped from the group. Defaults to `10`.
  /// </summary>
  [FactorioRconAttribute("member_disown_distance")]
  public double MemberDisownDistance { get; set; }

  [FactorioRconAttribute("tick_tolerance_when_member_arrives")]
  public uint TickToleranceWhenMemberArrives { get; set; }

  /// <summary>
  /// The maximum number of automatically created unit groups gathering for attack at any time. Defaults to `30`.
  /// </summary>
  [FactorioRconAttribute("max_gathering_unit_groups")]
  public uint MaxGatheringUnitGroups { get; set; }

  /// <summary>
  /// The maximum number of members for an attack unit group. This only affects automatically created unit groups, manual groups created through the API are unaffected. Defaults to `200`.
  /// </summary>
  [FactorioRconAttribute("max_unit_group_size")]
  public uint MaxUnitGroupSize { get; set; }

}

