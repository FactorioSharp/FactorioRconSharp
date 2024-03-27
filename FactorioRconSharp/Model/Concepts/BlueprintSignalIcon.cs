#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("BlueprintSignalIcon")]
public abstract class BlueprintSignalIcon
{
  /// <summary>
  /// The icon to use. It can be any item icon as well as any virtual signal icon.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public SignalID Signal { get; set; }

  /// <summary>
  /// Index of the icon in the blueprint icons slots. Has to be an integer in the range [1, 4].
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

