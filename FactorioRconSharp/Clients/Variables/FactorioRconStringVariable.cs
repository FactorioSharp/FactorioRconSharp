namespace FactorioRconSharp.Clients.Variables;

class FactorioRconStringVariable : FactorioRconVariable<string>
{
    public FactorioRconStringVariable(FactorioLowLevelRconClient lowLevelClient, string name) : base(lowLevelClient, name)
    {
    }

    protected override string Parse(string value) => value;
    protected override string Dump(string value) => value;
}