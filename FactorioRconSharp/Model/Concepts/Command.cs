#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Commands can be given to enemies and unit groups.
/// </summary>
[FactorioRconConcept("Command")]
public class Command
{
  /// <summary>
  /// Type of command. The remaining fields depend on the value of this field.
  /// </summary>
  [FactorioRconAttribute("type")]
  public CommandEnum Type { get; set; }

}

