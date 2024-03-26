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
  public Union34392072 Value { get; set; }

}

public abstract class Table56724303
{
  /// <summary>
  /// The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
  public Union34392072 Value { get; set; }

}

[GenerateOneOf]
public abstract partial class Union34392072: OneOfBase<int, double, bool, string, Color>
{
}

