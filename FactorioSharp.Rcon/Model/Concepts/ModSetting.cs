#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModSetting")]
public class ModSetting: IFactorioRconModel
{
  /// <summary>
  /// The value of the mod setting. The type depends on the kind of setting.
  /// </summary>
  [FactorioRconAttribute("value")]
  public Union1628237159 Value { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

