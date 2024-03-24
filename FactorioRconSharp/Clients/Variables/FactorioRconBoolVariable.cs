using System.Globalization;

namespace FactorioRconSharp.Clients.Variables;

class FactorioRconBoolVariable : FactorioRconVariable<bool>
{
    public FactorioRconBoolVariable(FactorioLowLevelRconClient lowLevelClient, string name) : base(lowLevelClient, name)
    {
    }

    protected override bool Parse(string value) => bool.TryParse(value, out bool intValue) && intValue;
    protected override string Dump(bool value) => value.ToString(CultureInfo.InvariantCulture);
}