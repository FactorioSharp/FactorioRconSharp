namespace SpecificationCompiler.Model;

/// <summary>
///     A parameter of a method of a class in the factorio model
/// </summary>
public class FactorioModelClassMethodParameter
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public required string Type { get; set; }
    public bool Optional { get; set; } = false;
    public string? DefaultValue { get; set; }
}
