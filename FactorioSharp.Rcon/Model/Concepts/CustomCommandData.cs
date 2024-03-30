#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CustomCommandData")]
public class CustomCommandData: IFactorioRconModel
{
  /// <summary>
  /// The name of the command.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The tick the command was used in.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; set; }

  /// <summary>
  /// The player who issued the command, or `nil` if it was issued from the server console.
  /// </summary>
  [FactorioRconAttribute("player_index")]
  public uint PlayerIndex { get; set; }

  /// <summary>
  /// The parameter passed after the command, if there is one.
  /// </summary>
  [FactorioRconAttribute("parameter")]
  public string Parameter { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

