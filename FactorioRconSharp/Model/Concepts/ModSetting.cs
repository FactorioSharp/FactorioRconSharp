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
  public Union_78ca48ec41f546e1b1e2a62ad4ddf7ee Value { get; set; }

}

