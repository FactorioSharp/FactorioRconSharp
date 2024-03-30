using FactorioSharp.Rcon;
using FactorioSharp.Rcon.Model.Definitions;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());
int playerCount = await client.ReadAsync(g => (int)g.Game.Players.Length);
DifficultyEnum difficulty = await client.ReadAsync(g => g.Game.Difficulty);

Console.WriteLine($"Map string: {mapString}");
Console.WriteLine($"Player count: {playerCount}");
Console.WriteLine($"Difficulty: {difficulty}");

client.Disconnect();
