#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

/// <summary>
/// State of a chain signal.
/// </summary>
[FactorioRconDefinition("chain_signal_state")]
public enum ChainSignalStateEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("all_open")]
  AllOpen,

  [FactorioRconDefinitionValue("partially_open")]
  PartiallyOpen,

  [FactorioRconDefinitionValue("none_open")]
  NoneOpen,

}

