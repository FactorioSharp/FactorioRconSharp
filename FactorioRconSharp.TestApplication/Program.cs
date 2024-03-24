using FactorioRconSharp.v1_1_104;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

Console.WriteLine("Map Settings:");
Console.WriteLine($"\tgame.map_settings._max_failed_behavior_count = {await client.ReadAsync(g => g.Game.MapSettings.MaxFailedBehaviorCount)}");
