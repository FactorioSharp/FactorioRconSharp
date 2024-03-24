using System.Globalization;

namespace FactorioRconSharp.Clients.Variables;

class FactorioRconDoubleVariable : FactorioRconVariable<double>
{
    public FactorioRconDoubleVariable(FactorioLowLevelRconClient lowLevelClient, string name) : base(lowLevelClient, name)
    {
    }

    protected override double Parse(string value) => double.TryParse(value, out double intValue) ? intValue : 0;
    protected override string Dump(double value) => value.ToString(CultureInfo.InvariantCulture);
}
