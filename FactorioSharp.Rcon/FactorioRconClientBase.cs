using System.Linq.Expressions;
using FactorioSharp.Rcon.Core;
using FactorioSharp.Rcon.Core.Parsing;
using FactorioSharp.Rcon.Core.Visitor;
using FactorioSharp.Rcon.Model;

namespace FactorioSharp.Rcon;

public class FactorioRconClient : IDisposable
{
    public FactorioRemoteConsole LowLevelClient { get; }

    public bool Silent { get => LowLevelClient.Silent; set => LowLevelClient.Silent = value; }
    public bool Connected => LowLevelClient.Connected;

    public FactorioRconClient(string ipAddress, int port)
    {
        LowLevelClient = new FactorioRemoteConsole(ipAddress, port);
    }

    public async Task<bool> ConnectAsync(string password) => await LowLevelClient.ConnectAsync(password);
    public void Disconnect() => LowLevelClient.Disconnect();

    public async Task ExecuteAsync(Expression<Action<FactorioRconGlobals>> action)
    {
        string expression = new FactorioRconTranslator().BuildExpression(action);
        await LowLevelClient.ExecuteAsync(expression);
    }

    public async Task ExecuteAsync<TArg>(Expression<Action<FactorioRconGlobals, TArg>> action, TArg arg)
    {
        string expression = new FactorioRconTranslator(arg).BuildExpression(action);
        await LowLevelClient.ExecuteAsync(expression);
    }

    public async Task ExecuteAsync(Expression<Action<FactorioRconGlobals, Dictionary<string, object>>> action, Dictionary<string, object> ctx)
    {
        string expression = new FactorioRconTranslator(ctx).BuildExpression(action);
        await LowLevelClient.ExecuteAsync(expression);
    }

    public async Task<T?> ReadAsync<T>(Expression<Func<FactorioRconGlobals, T>> func)
    {
        string expression = new FactorioRconTranslator().BuildExpression(func);
        return await ReadAsync<T>(expression);
    }

    public async Task<TValue?> ReadAsync<TArg, TValue>(Expression<Func<FactorioRconGlobals, TArg, TValue>> func, TArg arg)
    {
        string expression = new FactorioRconTranslator(arg).BuildExpression(func);
        return await ReadAsync<TValue>(expression);
    }

    public async Task<T?> ReadAsync<T>(Expression<Func<FactorioRconGlobals, Dictionary<string, object>, T>> func, Dictionary<string, object> ctx)
    {
        string expression = new FactorioRconTranslator(ctx).BuildExpression(func);
        return await ReadAsync<T>(expression);
    }

    public void Dispose()
    {
        LowLevelClient.Dispose();
        GC.SuppressFinalize(this);
    }

    async Task<T?> ReadAsync<T>(string expression)
    {
        string strResult;
        Type type = typeof(T);
        if (type.IsTableType())
        {
            strResult = await LowLevelClient.ReadAsync($"game.table_to_json({expression})");
        }
        else if (type.IsLuaCustomTable())
        {
            strResult = await LowLevelClient.ExecuteAsync($"result = {{}}; for k, v in pairs({expression}) do result[k] = v; end; rcon.print(game.table_to_json(result))");
        }
        else
        {
            strResult = await LowLevelClient.ReadAsync(expression);
        }

        return FactorioRconParser.Parse<T>(strResult.Trim());
    }
}
