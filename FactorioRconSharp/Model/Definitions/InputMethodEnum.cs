#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("input_method")]
public enum InputMethodEnum
{
  [FactorioRconDefinitionValue("keyboard_and_mouse")]
  KeyboardAndMouse,

  [FactorioRconDefinitionValue("game_controller")]
  GameController,

}

