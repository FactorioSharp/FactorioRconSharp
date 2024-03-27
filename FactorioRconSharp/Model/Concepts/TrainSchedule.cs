#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

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

public abstract class Table59256863
{
  /// <summary>
  /// Index of the currently active record
  /// </summary>
  [FactorioRconAttribute("current")]
  public uint Current { get; set; }

  [FactorioRconAttribute("records")]
  public List<TrainScheduleRecord> Records { get; set; }

}

