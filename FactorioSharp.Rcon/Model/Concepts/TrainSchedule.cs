#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainSchedule")]
public class TrainSchedule
{
  /// <summary>
  ///     Index of the currently active record
  /// </summary>
  [FactorioRconAttribute("current")]
    public uint Current { get; set; }

    [FactorioRconAttribute("records")]
    public List<TrainScheduleRecord> Records { get; set; }
}
