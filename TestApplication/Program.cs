using FactorioSharp.Rcon;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());
uint playerCount = await client.ReadAsync(g => g.Game.Players.Length);

Console.WriteLine($"Map string: {mapString}");
Console.WriteLine($"Player count: {playerCount}");
