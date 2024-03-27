#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ModSetting")]
public abstract class ModSetting
{
  /// <summary>
  /// The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
  public Union24924036 Value { get; set; }

}

public abstract class Table35570930
{
  /// <summary>
  /// The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
  public Union24924036 Value { get; set; }

}

[GenerateOneOf]
public abstract partial class Union24924036: OneOfBase<int, double, bool, string, Color>
{
}

