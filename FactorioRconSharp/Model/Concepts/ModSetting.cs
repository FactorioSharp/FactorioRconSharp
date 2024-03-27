#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ModSetting")]
public abstract class ModSetting
{
  /// <summary>
  /// The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
  public Union670163264 Value { get; set; }

}

