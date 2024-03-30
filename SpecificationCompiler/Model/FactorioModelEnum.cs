namespace SpecificationCompiler.Model;

public class FactorioModelEnum : FactorioModelTopLevelStatement
{
    public FactorioModelEnumValue[] Values { get; set; } = Array.Empty<FactorioModelEnumValue>();
}
