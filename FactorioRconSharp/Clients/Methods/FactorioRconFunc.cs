namespace FactorioRconSharp.Clients.Methods;

class FactorioRconFunc<TResult> : IFactorioRconFunc<TResult> where TResult: IFactorioMethodResult, new()
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconFunc(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task<TResult> ExecuteAsync()
    {
        string resultStr = await _lowLevelClient.ReadAsync($"{Name}()");
        TResult result = new();
        result.LoadFromString(resultStr);

        return result;
    }
}

class FactorioRconFunc<TParams, TResult> : IFactorioRconFunc<TParams, TResult> where TParams: IFactorioMethodParameters where TResult: IFactorioMethodResult, new()
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconFunc(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task<TResult> ExecuteAsync(TParams parameters)
    {
        string resultStr = await _lowLevelClient.ReadAsync($"{Name}({parameters.ToParametersString()})");
        TResult result = new();
        result.LoadFromString(resultStr);

        return result;
    }
}
