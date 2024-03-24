namespace FactorioRconSharp.Clients.Variables;

abstract class FactorioRconVariable<T> : IFactorioRconVariable<T>
{
    protected readonly FactorioLowLevelRconClient LowLevelClient;

    public FactorioRconVariable(FactorioLowLevelRconClient lowLevelClient, string name)
    {
        LowLevelClient = lowLevelClient;
        Name = name;
    }

    public string Name { get; }

    public async Task<T> GetAsync()
    {
        string strValue = await LowLevelClient.ReadAsync(Name);
        return Parse(strValue);
    }

    public async Task SetAsync(T value)
    {
        string strValue = Dump(value);
        await LowLevelClient.ExecuteAsync($"{Name} = {strValue}");
    }

    protected abstract T Parse(string value);
    protected abstract string Dump(T value);
}
