using System.Text.Json;
using FactorioSharp.Rcon;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());
int playerCount = await client.ReadAsync(g => (int)g.Game.Players.Length);
DifficultyEnum difficulty = await client.ReadAsync(g => g.Game.Difficulty);
Dictionary<string, Union1834264937> inputCount = await client.ReadAsync(g => ((LuaForce)g.Game.Players[1].Force).ItemProductionStatistics.InputCounts);

Console.WriteLine($"Map string: {mapString}");
Console.WriteLine($"Player count: {playerCount}");
Console.WriteLine($"Difficulty: {difficulty}");
Console.WriteLine($"Item stats: {JsonSerializer.Serialize(inputCount)}");

client.Disconnect();
