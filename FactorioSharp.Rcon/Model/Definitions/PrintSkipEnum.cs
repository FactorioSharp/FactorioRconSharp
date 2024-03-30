#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("print_skip")]
public enum PrintSkipEnum
{
  /// <summary>
  /// Print will not be skipped.
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

  /// <summary>
  /// Print will be skipped if same text was recently printed (within last 60 ticks). Used by most game messages.
  /// </summary>
  [FactorioRconDefinitionValue("if_redundant")]
  IfRedundant,

  /// <summary>
  /// Print will be skipped if same text is still visible (printed within last 1152 ticks). Used by some notifications.
  /// </summary>
  [FactorioRconDefinitionValue("if_visible")]
  IfVisible,

}

