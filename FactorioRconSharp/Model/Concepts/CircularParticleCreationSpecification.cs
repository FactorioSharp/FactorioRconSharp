#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircularParticleCreationSpecification")]
public abstract class CircularParticleCreationSpecification
{
  /// <summary>
  /// Name of the <see cref="LuaEntityPrototype" />.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("direction")]
  public float Direction { get; set; }

  [FactorioRconAttribute("direction_deviation")]
  public float DirectionDeviation { get; set; }

  [FactorioRconAttribute("speed")]
  public float Speed { get; set; }

  [FactorioRconAttribute("speed_deviation")]
  public float SpeedDeviation { get; set; }

  [FactorioRconAttribute("starting_frame_speed")]
  public float StartingFrameSpeed { get; set; }

  [FactorioRconAttribute("starting_frame_speed_deviation")]
  public float StartingFrameSpeedDeviation { get; set; }

  [FactorioRconAttribute("height")]
  public float Height { get; set; }

  [FactorioRconAttribute("height_deviation")]
  public float HeightDeviation { get; set; }

  [FactorioRconAttribute("vertical_speed")]
  public float VerticalSpeed { get; set; }

  [FactorioRconAttribute("vertical_speed_deviation")]
  public float VerticalSpeedDeviation { get; set; }

  /// <summary>
  /// This vector is a table with `x` and `y` keys instead of an array.
  /// </summary>
  [FactorioRconAttribute("center")]
  public Vector Center { get; set; }

  [FactorioRconAttribute("creation_distance")]
  public double CreationDistance { get; set; }

  [FactorioRconAttribute("creation_distance_orientation")]
  public double CreationDistanceOrientation { get; set; }

  [FactorioRconAttribute("use_source_position")]
  public bool UseSourcePosition { get; set; }

}

