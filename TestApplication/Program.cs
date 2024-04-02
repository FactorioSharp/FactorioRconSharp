using System.Text.Json;
using FactorioSharp.Rcon;
using FactorioSharp.Rcon.Core.Converters;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

JsonSerializerOptions jsonSerializerOptions = new() { Converters = { new OneOfJsonConverterFactory() } };

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string? mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());
int? playerCount = await client.ReadAsync(g => (int)g.Game.Players.Length);
int connectedPlayerCount = await client.ReadAsync(g => g.Game.ConnectedPlayers.Count);
DifficultyEnum difficulty = await client.ReadAsync(g => g.Game.Difficulty);
LuaCustomTable<Union2142551273, LuaForce>? forces = await client.ReadAsync(g => g.Game.Forces);
LuaCustomTable<string, LuaItemPrototype>? items = await client.ReadAsync(g => g.Game.ItemPrototypes);

uint playerIndex = 1;
Dictionary<string, Union1104138130>? inputCount = await client.ReadAsync((g, index) => ((LuaForce)g.Game.Players[index].Force).FluidProductionStatistics.InputCounts, playerIndex);

Console.WriteLine($"Map string: {mapString}");
Console.WriteLine($"Player count: {playerCount}");
Console.WriteLine($"Connected player count: {connectedPlayerCount}");
Console.WriteLine($"Difficulty: {difficulty}");
Console.WriteLine($"Forces: {JsonSerializer.Serialize(forces?.Keys, jsonSerializerOptions)}");
Console.WriteLine($"Items: {JsonSerializer.Serialize(items?.Keys, jsonSerializerOptions)}");
Console.WriteLine($"Fluid stats: {JsonSerializer.Serialize(inputCount, jsonSerializerOptions)}");

client.Disconnect();
