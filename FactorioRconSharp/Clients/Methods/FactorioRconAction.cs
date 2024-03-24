namespace FactorioRconSharp.Clients.Methods;

class FactorioRconAction : IFactorioRconAction
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconAction(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task ExecuteAsync() => await _lowLevelClient.ExecuteAsync($"{Name}()");
}

class FactorioRconAction<TParams> : IFactorioRconAction<TParams> where TParams: IFactorioMethodParameters
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconAction(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task ExecuteAsync(TParams parameters) => await _lowLevelClient.ExecuteAsync($"{Name}({parameters.ToParametersString()})");
}
