#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("controllers")]
public enum ControllersEnum
{
  /// <summary>
  ///     Can't interact with the world, can only observe. Used in the multiplayer waiting-to-respawn screen.
  /// </summary>
  [FactorioRconDefinitionValue("ghost")]
    Ghost,

  /// <summary>
  ///     The controller controls a character. This is the default controller in freeplay.
  /// </summary>
  [FactorioRconDefinitionValue("character")]
    Character,

  /// <summary>
  ///     The controller isn't tied to a character. This is the default controller in sandbox.
  /// </summary>
  [FactorioRconDefinitionValue("god")]
    God,

  /// <summary>
  ///     The Editor Controller near ultimate power to do almost anything in the game.
  /// </summary>
  [FactorioRconDefinitionValue("editor")]
    Editor,

  /// <summary>
  ///     The player can't interact with the world, and the camera pans around in a predefined manner.
  /// </summary>
  [FactorioRconDefinitionValue("cutscene")]
    Cutscene,

  /// <summary>
  ///     Can't change anything in the world but can view anything.
  /// </summary>
  [FactorioRconDefinitionValue("spectator")]
    Spectator
}
