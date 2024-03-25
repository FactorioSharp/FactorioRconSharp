using System.Linq.Expressions;
using FactorioRconSharp;
using FactorioRconSharp.Core.Visitor;
using FactorioRconSharp.Model;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

Console.WriteLine("Game:");

await Log(g => g.Game.IsDemo());
await Log(g => g.Game.IsMultiplayer());
await Log(g => g.Game.GetMapExchangeString());
await Log(g => g.Game.GetActiveEntitiesCount(null));
await Log(g => g.Game.GetActiveEntitiesCount(1));
await Log(g => g.Game.GetActiveEntitiesCount("nauvis"));

return;

async Task Log<T>(Expression<Func<FactorioRconGlobals, T>> func)
{
    string strExpression = new FactorioRconTranslator().BuildExpression(func);
    T result = await client.ReadAsync(func);

    Console.WriteLine($"\t{strExpression}: {result}");
}
