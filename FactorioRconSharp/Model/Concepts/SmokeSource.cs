#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SmokeSource")]
public class SmokeSource
{
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("frequency")]
  public double Frequency { get; set; }

  [FactorioRconAttribute("offset")]
  public double Offset { get; set; }

  [FactorioRconAttribute("position")]
  public Vector Position { get; set; }

  [FactorioRconAttribute("north_position")]
  public Vector NorthPosition { get; set; }

  [FactorioRconAttribute("east_position")]
  public Vector EastPosition { get; set; }

  [FactorioRconAttribute("south_position")]
  public Vector SouthPosition { get; set; }

  [FactorioRconAttribute("west_position")]
  public Vector WestPosition { get; set; }

  [FactorioRconAttribute("deviation")]
  public MapPosition Deviation { get; set; }

  [FactorioRconAttribute("starting_frame_speed")]
  public ushort StartingFrameSpeed { get; set; }

  [FactorioRconAttribute("starting_frame_speed_deviation")]
  public double StartingFrameSpeedDeviation { get; set; }

  [FactorioRconAttribute("starting_frame")]
  public ushort StartingFrame { get; set; }

  [FactorioRconAttribute("starting_frame_deviation")]
  public double StartingFrameDeviation { get; set; }

  [FactorioRconAttribute("slow_down_factor")]
  public byte SlowDownFactor { get; set; }

  [FactorioRconAttribute("height")]
  public float Height { get; set; }

  [FactorioRconAttribute("height_deviation")]
  public float HeightDeviation { get; set; }

  [FactorioRconAttribute("starting_vertical_speed")]
  public float StartingVerticalSpeed { get; set; }

  [FactorioRconAttribute("starting_vertical_speed_deviation")]
  public float StartingVerticalSpeedDeviation { get; set; }

  [FactorioRconAttribute("vertical_speed_slowdown")]
  public float VerticalSpeedSlowdown { get; set; }

}

