#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircularProjectileCreationSpecification")]
public abstract class CircularProjectileCreationSpecification
{
  [FactorioRconAttribute("[1]")]
  public RealOrientation first { get; set; }

  [FactorioRconAttribute("[2]")]
  public Vector second { get; set; }

}

