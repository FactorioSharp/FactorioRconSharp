using FactorioRCON;

using FactorioLowLevelRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string tick = await client.ExecuteAsync("game.tick");

Console.WriteLine("Tick: " + tick);
