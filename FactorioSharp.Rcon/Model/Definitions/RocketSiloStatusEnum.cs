#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

/// <summary>
///     The various parts of the launch sequence of the rocket silo.
/// </summary>
[FactorioRconDefinition("rocket_silo_status")]
public enum RocketSiloStatusEnum
{
  /// <summary>
  ///     The rocket silo is crafting rocket parts. When there are enough rocket parts, the silo will switch into the `create_rocket` state.
  /// </summary>
  [FactorioRconDefinitionValue("building_rocket")]
    BuildingRocket,

  /// <summary>
  ///     The next state is `lights_blinking_open`. The rocket silo rocket entity gets created.
  /// </summary>
  [FactorioRconDefinitionValue("create_rocket")]
    CreateRocket,

  /// <summary>
  ///     The next state is `doors_opening`. The rocket is getting prepared for launch.
  /// </summary>
  [FactorioRconDefinitionValue("lights_blinking_open")]
    LightsBlinkingOpen,

  /// <summary>
  ///     The next state is `doors_opened`. The rocket is getting prepared for launch.
  /// </summary>
  [FactorioRconDefinitionValue("doors_opening")]
    DoorsOpening,

  /// <summary>
  ///     The next state is `rocket_rising` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting prepared for launch.
  /// </summary>
  [FactorioRconDefinitionValue("doors_opened")]
    DoorsOpened,

  /// <summary>
  ///     The next state is `arms_advance` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting prepared for launch.
  /// </summary>
  [FactorioRconDefinitionValue("rocket_rising")]
    RocketRising,

  /// <summary>
  ///     The next state is `rocket_ready` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting prepared for launch.
  /// </summary>
  [FactorioRconDefinitionValue("arms_advance")]
    ArmsAdvance,

  /// <summary>
  ///     The rocket launch can be started by the player. When the launch is started, the silo switches into the `launch_starting` state.
  /// </summary>
  [FactorioRconDefinitionValue("rocket_ready")]
    RocketReady,

  /// <summary>
  ///     The next state is `launch_started`.
  /// </summary>
  [FactorioRconDefinitionValue("launch_starting")]
    LaunchStarting,

  /// <summary>
  ///     The next state is `arms_retract` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting launched.
  /// </summary>
  [FactorioRconDefinitionValue("engine_starting")]
    EngineStarting,

  /// <summary>
  ///     The next state is `rocket_flying` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting launched.
  /// </summary>
  [FactorioRconDefinitionValue("arms_retract")]
    ArmsRetract,

  /// <summary>
  ///     The next state is `lights_blinking_close`. The rocket is getting launched.
  /// </summary>
  [FactorioRconDefinitionValue("rocket_flying")]
    RocketFlying,

  /// <summary>
  ///     The next state is `doors_closing`.
  /// </summary>
  [FactorioRconDefinitionValue("lights_blinking_close")]
    LightsBlinkingClose,

  /// <summary>
  ///     The next state is `building_rocket`.
  /// </summary>
  [FactorioRconDefinitionValue("doors_closing")]
    DoorsClosing,

  /// <summary>
  ///     The next state is `engine_starting` or if the rocket is destroyed in this state then the next state will be `lights_blinking_close`. The rocket is getting launched.
  /// </summary>
  [FactorioRconDefinitionValue("launch_started")]
    LaunchStarted
}
