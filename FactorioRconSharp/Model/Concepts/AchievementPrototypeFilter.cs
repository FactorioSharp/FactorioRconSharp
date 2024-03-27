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
/// Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("AchievementPrototypeFilter")]
public abstract class AchievementPrototypeFilter
{
  /// <summary>
  /// The condition to filter on. One of `"allowed-without-fight"`, `"type"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union29782071 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Union29782071
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

[GenerateOneOf]
public abstract partial class Union21443715: OneOfBase<string, List<string>>
{
}

