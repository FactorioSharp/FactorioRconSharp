using System.Globalization;

namespace FactorioRconSharp.Clients.Variables;

class FactorioRconFloatVariable : FactorioRconVariable<float>
{
    public FactorioRconFloatVariable(FactorioLowLevelRconClient lowLevelClient, string name) : base(lowLevelClient, name)
    {
    }

    protected override float Parse(string value) => float.TryParse(value, out float intValue) ? intValue : 0;
    protected override string Dump(float value) => value.ToString(CultureInfo.InvariantCulture);
}
