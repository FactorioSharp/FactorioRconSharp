using System.Linq.Expressions;
using FactorioSharp.Rcon.Core.Parsing;
using FactorioSharp.Rcon.Core.Visitor;
using FactorioSharp.Rcon.Model;

namespace FactorioSharp.Rcon.Core;

public abstract class FactorioRconClientBase : IDisposable
{
    readonly FactorioRemoteConsole _lowLevelClient;

    public bool Connected => _lowLevelClient.Connected;

    public FactorioRconClientBase(string ipAddress, int port)
    {
        _lowLevelClient = new FactorioRemoteConsole(ipAddress, port);
    }

    public async Task<bool> ConnectAsync(string password) => await _lowLevelClient.ConnectAsync(password);
    public void Disconnect() => _lowLevelClient.Disconnect();

    public async Task ExecuteAsync(Expression<Action<FactorioRconGlobals>> action)
    {
        string expression = new FactorioRconTranslator().BuildExpression(action);
        await _lowLevelClient.ExecuteAsync(expression);
    }

    public async Task<T> ReadAsync<T>(Expression<Func<FactorioRconGlobals, T>> func)
    {
        string expression = new FactorioRconTranslator().BuildExpression(func);
        string strResult = await _lowLevelClient.ReadAsync(expression);

        return FactorioRconParser.Parse<T>(strResult);
    }

    public void Dispose()
    {
        _lowLevelClient.Dispose();
        GC.SuppressFinalize(this);
    }
}
