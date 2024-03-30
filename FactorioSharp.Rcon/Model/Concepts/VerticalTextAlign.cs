#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     The text is aligned so that the target position is at the given side of the text.
///     For example, `"top"` aligned text means the top of the text is at the target position. Or in other words, the target is at the top of the text.
/// </summary>
[FactorioRconDefinition("VerticalTextAlign")]
public enum VerticalTextAlign
{
  /// <summary>
  ///     Literal value: top
  /// </summary>
  [FactorioRconDefinitionValue("top")]
    Top,

  /// <summary>
  ///     Literal value: middle
  /// </summary>
  [FactorioRconDefinitionValue("middle")]
    Middle,

  /// <summary>
  ///     Literal value: baseline
  /// </summary>
  [FactorioRconDefinitionValue("baseline")]
    Baseline,

  /// <summary>
  ///     Literal value: bottom
  /// </summary>
  [FactorioRconDefinitionValue("bottom")]
    Bottom
}
