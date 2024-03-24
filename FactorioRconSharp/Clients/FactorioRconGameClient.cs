using FactorioRconSharp.Clients.Variables;

namespace FactorioRconSharp.Clients;

public class FactorioRconGameClient
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    internal FactorioRconGameClient(FactorioLowLevelRconClient lowLevelClient)
    {
        _lowLevelClient = lowLevelClient;

        ConsoleCommandUsed = new FactorioRconBoolVariable(_lowLevelClient, "game.console_command_used");
        Tick = new FactorioRconUintVariable(_lowLevelClient, "game.tick");
        TicksPlayed = new FactorioRconUintVariable(_lowLevelClient, "game.ticks_played");
        TickPaused = new FactorioRconBoolVariable(_lowLevelClient, "game.tick_paused");
        TicksToRun = new FactorioRconUintVariable(_lowLevelClient, "game.ticks_to_run");
        Finished = new FactorioRconBoolVariable(_lowLevelClient, "game.finished");
        FinishedButContinuing = new FactorioRconBoolVariable(_lowLevelClient, "game.finished_but_continuing");
        Speed = new FactorioRconFloatVariable(_lowLevelClient, "game.speed");
        EnemyHasVisionOnLandMines = new FactorioRconBoolVariable(_lowLevelClient, "game.enemy_has_vision_on_land_mines");
        AutoSaveEnabled = new FactorioRconBoolVariable(_lowLevelClient, "game.autosave_enabled");
        DrawResourceSelection = new FactorioRconBoolVariable(_lowLevelClient, "game.draw_resource_selection");
        MaxForceDistractionDistance = new FactorioRconDoubleVariable(_lowLevelClient, "game.max_force_distraction_distance");
        MaxForceDistractionChunkDistance = new FactorioRconUintVariable(_lowLevelClient, "game.max_force_distraction_chunk_distance");
        MaxElectricPoleSupplyAreaDistance = new FactorioRconFloatVariable(_lowLevelClient, "game.max_electric_pole_supply_area_distance");
        MaxElectricPoleConnectionDistance = new FactorioRconDoubleVariable(_lowLevelClient, "game.max_electric_pole_connection_distance");
        MaxBeaconSupplyAreaDistance = new FactorioRconDoubleVariable(_lowLevelClient, "game.max_beacon_supply_area_distance");
        MaxGateActivationDistance = new FactorioRconDoubleVariable(_lowLevelClient, "game.max_gate_activation_distance");
        MaxInserterReachDistance = new FactorioRconDoubleVariable(_lowLevelClient, "game.max_inserter_reach_distance");
        MaxPipeToGroundDistance = new FactorioRconUintVariable(_lowLevelClient, "game.max_pipe_to_ground_distance");
        MaxUndergroundBeltDistance = new FactorioRconUintVariable(_lowLevelClient, "game.max_underground_belt_distance");
    }

    public IFactorioRconReadonlyVariable<bool> ConsoleCommandUsed { get; }
    public IFactorioRconReadonlyVariable<uint> Tick { get; }
    public IFactorioRconReadonlyVariable<uint> TicksPlayed { get; }
    public IFactorioRconVariable<bool> TickPaused { get; }
    public IFactorioRconVariable<uint> TicksToRun { get; }
    public IFactorioRconReadonlyVariable<bool> Finished { get; }
    public IFactorioRconReadonlyVariable<bool> FinishedButContinuing { get; }
    public IFactorioRconVariable<float> Speed { get; }
    public IFactorioRconVariable<bool> EnemyHasVisionOnLandMines { get; }
    public IFactorioRconVariable<bool> AutoSaveEnabled { get; }
    public IFactorioRconVariable<bool> DrawResourceSelection { get; }
    public IFactorioRconReadonlyVariable<double> MaxForceDistractionDistance { get; }
    public IFactorioRconReadonlyVariable<uint> MaxForceDistractionChunkDistance { get; }
    public IFactorioRconReadonlyVariable<float> MaxElectricPoleSupplyAreaDistance { get; }
    public IFactorioRconReadonlyVariable<double> MaxElectricPoleConnectionDistance { get; }
    public IFactorioRconReadonlyVariable<double> MaxBeaconSupplyAreaDistance { get; }
    public IFactorioRconReadonlyVariable<double> MaxGateActivationDistance { get; }
    public IFactorioRconReadonlyVariable<double> MaxInserterReachDistance { get; }
    public IFactorioRconReadonlyVariable<uint> MaxPipeToGroundDistance { get; }
    public IFactorioRconReadonlyVariable<uint> MaxUndergroundBeltDistance { get; }
}
