// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using FactorioRconSharp.ClientGenerator.Converters;
using FactorioRconSharp.ClientGenerator.Generators;
using FactorioRconSharp.ClientGenerator.Specification;

string path = "Resource/runtime-api-v1_1_104.json";
JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
{
    PropertyNameCaseInsensitive = true,
    Converters = { new FactorioRuntimeTypeSpecificationConverter() },
    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
};

FactorioRuntimeApiSpecification? parsedSpecification;
using (FileStream file = File.OpenRead(path))
{
    parsedSpecification = await JsonSerializer.DeserializeAsync<FactorioRuntimeApiSpecification>(file, options);
}

if (parsedSpecification == null)
{
    Console.Error.WriteLine($"Could not deserialize file {path}");
    return 1;
}

Console.WriteLine($"Parsed specification: {parsedSpecification.Application} v{parsedSpecification.ApplicationVersion}");
Console.WriteLine($"\tApi v{parsedSpecification.ApiVersion} ({parsedSpecification.Stage})");
Console.WriteLine($"\tClasses ({parsedSpecification.Classes.Length}): {string.Join(", ", parsedSpecification.Classes.Select(c => c.Name))}");
Console.WriteLine();

FactorioModelGenerator generator = new(parsedSpecification);
await generator.Generate("out");

return 0;
