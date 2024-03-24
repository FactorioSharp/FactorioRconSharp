namespace FactorioRconSharp.Clients.Variables;

class FactorioRconUintVariable : FactorioRconVariable<uint>
{
    public FactorioRconUintVariable(FactorioLowLevelRconClient lowLevelClient, string name) : base(lowLevelClient, name)
    {
    }

    protected override uint Parse(string value) => uint.TryParse(value, out uint intValue) ? intValue : 0;
    protected override string Dump(uint value) => value.ToString();
}
