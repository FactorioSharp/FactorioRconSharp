#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("mouse_button_type")]
public enum MouseButtonTypeEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("left")]
  Left,

  [FactorioRconDefinitionValue("right")]
  Right,

  [FactorioRconDefinitionValue("middle")]
  Middle,

}

