#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("input_method")]
public enum InputMethodEnum
{
  [FactorioRconDefinitionValue("keyboard_and_mouse")]
  KeyboardAndMouse,

  [FactorioRconDefinitionValue("game_controller")]
  GameController,

}

