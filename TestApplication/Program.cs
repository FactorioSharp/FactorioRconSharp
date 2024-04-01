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

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());
int playerCount = await client.ReadAsync(g => (int)g.Game.Players.Length);
DifficultyEnum difficulty = await client.ReadAsync(g => g.Game.Difficulty);
LuaCustomTable<Union66691991, LuaForce> forces = await client.ReadAsync(g => g.Game.Forces);
LuaCustomTable<string, LuaItemPrototype> items = await client.ReadAsync(g => g.Game.ItemPrototypes);

uint playerIndex = 1;
Dictionary<string, Union1732410965> inputCount = await client.ReadAsync((g, index) => ((LuaForce)g.Game.Players[index].Force).ItemProductionStatistics.InputCounts, playerIndex);

Console.WriteLine($"Map string: {mapString}");
Console.WriteLine($"Player count: {playerCount}");
Console.WriteLine($"Difficulty: {difficulty}");
Console.WriteLine($"Forces: {JsonSerializer.Serialize(forces.Keys, jsonSerializerOptions)}");
Console.WriteLine($"Items: {JsonSerializer.Serialize(items.Keys, jsonSerializerOptions)}");
Console.WriteLine($"Item stats: {JsonSerializer.Serialize(inputCount, jsonSerializerOptions)}");

client.Disconnect();
