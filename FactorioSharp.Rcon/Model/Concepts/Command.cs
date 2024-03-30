#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Commands can be given to enemies and unit groups.
/// </summary>
[FactorioRconConcept("Command")]
public class Command: IFactorioRconModel
{
  /// <summary>
  /// Type of command. The remaining fields depend on the value of this field.
  /// </summary>
  [FactorioRconAttribute("type")]
  public CommandEnum Type { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

