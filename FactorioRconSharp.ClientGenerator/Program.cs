// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;
using FactorioRconSharp.ClientGenerator.Converters;
using FactorioRconSharp.ClientGenerator.Model;
using FactorioRconSharp.ClientGenerator.Model.Compilers;
using FactorioRconSharp.ClientGenerator.Model.Writers;
using FactorioRconSharp.ClientGenerator.Specification;

string path = "Resource/runtime-api-v1_1_104.json";
JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
{
    PropertyNameCaseInsensitive = true,
    Converters = { new FactorioRuntimeTypeSpecificationConverter(), new JsonStringEnumConverter() },
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

FactorioModelFileCompiler compiler = new(parsedSpecification);

foreach (FactorioRuntimeClassSpecification cls in parsedSpecification.Classes)
{
    FactorioModelFile file = compiler.CompileClassFile(cls.Name);

    string outPath = Path.Join("out", file.Name + ".cs");

    await using StreamWriter writer = File.CreateText(outPath);
    await FactorioModelWriter.WriteFile(writer, file);
}

foreach (FactorioRuntimeConceptSpecification concept in parsedSpecification.Concepts)
{
    FactorioModelFile file = compiler.CompileConceptFile(concept.Name);

    string outPath = Path.Join("out", file.Name + ".cs");

    await using StreamWriter writer = File.CreateText(outPath);
    await FactorioModelWriter.WriteFile(writer, file);
}

return 0;
