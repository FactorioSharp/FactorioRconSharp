#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Encapsulates statistic data for different parts of the game. In the context of flow statistics, `input` and `output` describe on which side of the associated GUI the values are shown. Input values are shown on the left side, output values on the right side.
/// 
/// Examples:
/// - The item production GUI shows "consumption" on the right, thus `output` describes the item consumption numbers. The same goes for fluid consumption.
/// - The kills GUI shows "losses" on the right, so `output` describes how many of the force's entities were killed by enemies.
/// - The electric network GUI shows "power consumption" on the left side, so in this case `input` describes the power consumption numbers.
/// </summary>
[FactorioRconClass("LuaFlowStatistics")]
public abstract class LuaFlowStatistics: LuaObject
{
  /// <summary>
  /// List of input counts indexed by prototype name. Represents the data that is shown on the left side of the GUI for the given statistics.
  /// </summary>
  [FactorioRconAttribute("input_counts")]
  public Dictionary<string, Union1926731213> InputCounts { get; private set; }

  /// <summary>
  /// List of output counts indexed by prototype name. Represents the data that is shown on the right side of the GUI for the given statistics.
  /// </summary>
  [FactorioRconAttribute("output_counts")]
  public Dictionary<string, Union1926731213> OutputCounts { get; private set; }

  /// <summary>
  /// The force these statistics belong to. `nil` for pollution statistics.
  /// </summary>
  [FactorioRconAttribute("force")]
  public LuaForce Force { get; private set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Gets the total input count for a given prototype.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_input_count")]
  public abstract Union1926731213 GetInputCount(string name);

  /// <summary>
  /// Sets the total input count for a given prototype.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("set_input_count")]
  public abstract void SetInputCount(string name, Union1926731213 count);

  /// <summary>
  /// Gets the total output count for a given prototype.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_output_count")]
  public abstract Union1926731213 GetOutputCount(string name);

  /// <summary>
  /// Sets the total output count for a given prototype.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("set_output_count")]
  public abstract void SetOutputCount(string name, Union1926731213 count);

  /// <summary>
  /// Gets the flow count value for the given time frame. If `sample_index` is not provided, then the value returned is the average across the provided precision time period. These are the values shown in the bottom section of the statistics GUIs.
  /// 
  /// Use `sample_index` to access the data used to generate the statistics graphs. Each precision level contains 300 samples of data so at a precision of 1 minute, each sample contains data averaged across 60s / 300 = 0.2s = 12 ticks.
  /// 
  /// All return values are normalized to be per-tick for electric networks and per-minute for all other types.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="input">Lua name: input</param>
  /// <param name="precisionIndex">Lua name: precision_index</param>
  /// <param name="sampleIndex">Lua name: sample_index</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("get_flow_count")]
  public abstract double GetFlowCount(string name, bool input, FlowPrecisionIndexEnum precisionIndex, ushort? sampleIndex = null, bool? count = null);

  /// <summary>
  /// Adds a value to this flow statistics.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("on_flow")]
  public abstract void OnFlow(string name, float count);

  /// <summary>
  /// Reset all the statistics data to 0.
  /// </summary>
  [FactorioRconMethod("clear")]
  public abstract void Clear();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

