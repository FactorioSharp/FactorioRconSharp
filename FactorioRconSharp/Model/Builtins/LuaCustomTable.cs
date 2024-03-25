#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Builtins;

/// <summary>
///     Lazily evaluated table. For performance reasons, we sometimes return a custom table-like type instead of a native Lua table.
///     This custom type lazily constructs the necessary Lua wrappers of the corresponding C++ objects, therefore preventing their unnecessary construction in some cases.
///     There are some notable consequences to the usage of a custom table type rather than the native Lua table type:
///     Iterating a custom table is only possible using the `pairs` Lua function; `ipairs` won't work.
///     Another key difference is that custom tables cannot be serialised into a game save file -- if saving the game would require serialisation of a custom table, an error will be
///     displayed and the game will not be saved.
/// </summary>
public class LuaCustomTable<TKey, TValue>
{
    /// <summary>
    ///     The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
    /// </summary>
    [FactorioRconAttribute("object_name")]
    public string ObjectName { get; }

    /// <summary>
    ///     Is this object valid? This Lua object holds a reference to an object within the game engine.
    ///     It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object.
    ///     If that happens, the object becomes invalid, i.e. this attribute will be `false`.
    ///     Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
    /// </summary>
    [FactorioRconAttribute("valid")]
    public bool Valid { get; }

    /// <summary>
    ///     Number of elements in this table.
    /// </summary>
    [FactorioRconLengthOperator]
    public uint Length { get; }

    /// <summary>
    ///     Access an element of this custom table.
    /// </summary>
    public TValue this[TKey key] { get => throw FactorioModelUtils.UseClientReadAsyncMethod(); set => throw FactorioModelUtils.UseClientExecuteAsyncMethod(); }

    /// <summary>
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();
}
