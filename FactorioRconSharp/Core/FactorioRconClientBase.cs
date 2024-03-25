using System.Linq.Expressions;
using FactorioRconSharp.Core.Parsing;
using FactorioRconSharp.Core.Visitor;
using FactorioRconSharp.Model;

namespace FactorioRconSharp.Core;

public abstract class FactorioRconClientBase : IDisposable
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public bool Connected => _lowLevelClient.Connected;

    public FactorioRconClientBase(string ipAddress, int port)
    {
        _lowLevelClient = new FactorioLowLevelRconClient(ipAddress, port);
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
