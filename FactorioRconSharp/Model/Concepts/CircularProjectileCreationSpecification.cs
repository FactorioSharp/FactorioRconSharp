#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircularProjectileCreationSpecification")]
public abstract class CircularProjectileCreationSpecification
{
  [FactorioRconAttribute("[1]")]
  public RealOrientation [1] { get; set; }

  [FactorioRconAttribute("[2]")]
  public Vector [2] { get; set; }

}

public abstract class Table61816437
{
  [FactorioRconAttribute("[1]")]
  public RealOrientation [1] { get; set; }

  [FactorioRconAttribute("[2]")]
  public Vector [2] { get; set; }

}

