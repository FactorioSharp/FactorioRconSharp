#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Commands can be given to enemies and unit groups.
/// </summary>
[FactorioRconConcept("Command")]
public abstract class Command
{
  /// <summary>
  /// Type of command. The remaining fields depend on the value of this field.
  /// </summary>
  [FactorioRconAttribute("type")]
  public CommandEnum Type { get; set; }

}

public abstract class Table21818579
{
  /// <summary>
  /// Type of command. The remaining fields depend on the value of this field.
  /// </summary>
  [FactorioRconAttribute("type")]
  public CommandEnum Type { get; set; }

}

