namespace FactorioRconSharp.Clients.Methods;

class FactorioRconBoolFunc : IFactorioRconFunc<bool>
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconBoolFunc(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task<bool> ExecuteAsync()
    {
        string resultStr = await _lowLevelClient.ReadAsync($"{Name}()");
        return bool.TryParse(resultStr, out bool result) && result;
    }
}

class FactorioRconStringFunc : IFactorioRconFunc<string>
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconStringFunc(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        _lowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task<string> ExecuteAsync() => await _lowLevelClient.ReadAsync($"{Name}()");
}
