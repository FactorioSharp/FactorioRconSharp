namespace FactorioRconSharp.ClientGenerator.Specification;

public abstract class FactorioRuntimeTypeSpecification
{
}

public class FactorioRuntimeLiteralTypeSpecification : FactorioRuntimeTypeSpecification
{
    public required object Value { get; set; }
}

public class FactorioRuntimeSimpleTypeSpecification : FactorioRuntimeTypeSpecification
{
    public required string Name { get; set; }
}

public class FactorioRuntimeKeyValueTypeSpecification : FactorioRuntimeTypeSpecification
{
    public required string Name { get; set; }
    public required FactorioRuntimeTypeSpecification Key { get; set; }
    public required FactorioRuntimeTypeSpecification Value { get; set; }
}

public class FactorioRuntimeUnionTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeTypeSpecification[] Options { get; set; } = Array.Empty<FactorioRuntimeTypeSpecification>();
    public bool FullFormat { get; set; }
}

public class FactorioRuntimeFunctionTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeTypeSpecification[] Parameters { get; set; } = Array.Empty<FactorioRuntimeTypeSpecification>();
}

public class FactorioRuntimeTableTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeParameterSpecification[] Parameters { get; set; } = Array.Empty<FactorioRuntimeParameterSpecification>();
}

public class FactorioRuntimeArrayTypeSpecification : FactorioRuntimeTypeSpecification
{
    public required FactorioRuntimeTypeSpecification Value { get; set; }
}
