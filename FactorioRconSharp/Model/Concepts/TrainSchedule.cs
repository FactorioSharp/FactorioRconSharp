#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TrainSchedule")]
public abstract class TrainSchedule
{
  /// <summary>
  /// Index of the currently active record
  /// </summary>
  [FactorioRconAttribute("current")]
  public uint Current { get; set; }

  [FactorioRconAttribute("records")]
  public List<TrainScheduleRecord> Records { get; set; }

}

