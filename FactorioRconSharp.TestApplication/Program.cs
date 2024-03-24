using FactorioRconSharp;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

Console.WriteLine("Game: ");
Console.WriteLine($"\tgame.tick = {await client.Game.Tick.GetAsync()}");
Console.WriteLine($"\tgame.ticks_played = {await client.Game.TicksPlayed.GetAsync()}");
Console.WriteLine($"\tgame.tick_paused = {await client.Game.TickPaused.GetAsync()}");
Console.WriteLine($"\tgame.ticks_to_run = {await client.Game.TicksToRun.GetAsync()}");
Console.WriteLine($"\tgame.finished = {await client.Game.Finished.GetAsync()}");
Console.WriteLine($"\tgame.finished_but_continuing = {await client.Game.FinishedButContinuing.GetAsync()}");
Console.WriteLine($"\tgame.speed = {await client.Game.Speed.GetAsync()}");
Console.WriteLine($"\tgame.enemy_has_vision_on_land_mines = {await client.Game.EnemyHasVisionOnLandMines.GetAsync()}");
Console.WriteLine($"\tgame.autosave_enabled = {await client.Game.AutoSaveEnabled.GetAsync()}");
Console.WriteLine($"\tgame.draw_resource_selection = {await client.Game.DrawResourceSelection.GetAsync()}");
Console.WriteLine($"\tgame.max_force_distraction_distance = {await client.Game.MaxForceDistractionDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_force_distraction_chunk_distance = {await client.Game.MaxForceDistractionChunkDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_electric_pole_supply_area_distance = {await client.Game.MaxElectricPoleSupplyAreaDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_electric_pole_connection_distance = {await client.Game.MaxElectricPoleConnectionDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_beacon_supply_area_distance = {await client.Game.MaxBeaconSupplyAreaDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_gate_activation_distance = {await client.Game.MaxGateActivationDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_inserter_reach_distance = {await client.Game.MaxInserterReachDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_pipe_to_ground_distance = {await client.Game.MaxPipeToGroundDistance.GetAsync()}");
Console.WriteLine($"\tgame.max_underground_belt_distance = {await client.Game.MaxUndergroundBeltDistance.GetAsync()}");

Console.WriteLine($"\tgame.is_demo = {await client.Game.IsDemo.ExecuteAsync()}");
Console.WriteLine($"\tgame.is_multiplayer = {await client.Game.IsMultiplayer.ExecuteAsync()}");
Console.WriteLine($"\tgame.get_map_exchange_string = {await client.Game.GetMapExchangeString.ExecuteAsync()}");
