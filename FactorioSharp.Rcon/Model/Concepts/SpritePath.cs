#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// It can be either the name of a [SpritePrototype](prototype:SpritePrototype) defined in the data stage, or a path in form "type/name".
/// 
/// The validity of a SpritePath can be verified at runtime using <see cref="LuaGameScript.IsValidSpritePath" />.
/// 
/// The supported types are:
/// - `"item"` - for example "item/iron-plate" is the icon sprite of iron plate
/// - `"entity"` - for example "entity/small-biter" is the icon sprite of the small biter
/// - `"technology"`
/// - `"recipe"`
/// - `"item-group"`
/// - `"fluid"`
/// - `"tile"`
/// - `"virtual-signal"`
/// - `"achievement"`
/// - `"equipment"`
/// - `"file"` - path to an image file located inside the current scenario. This file is not preloaded so it will be slower; for frequently used sprites, it is better to define sprite prototype and use it instead.
/// - `"utility"` - sprite defined in the utility-sprites object, these are the pictures used by the game internally for the UI.
/// </summary>
[FactorioRconConcept("SpritePath")]
public class SpritePath: Alias<string>
{
}

