using System.Text.Json;
using System.Text.Json.Serialization;
using FactorioRconSharp.ClientGenerator.Compilation;
using FactorioRconSharp.ClientGenerator.Converters;
using FactorioRconSharp.ClientGenerator.Model;
using FactorioRconSharp.ClientGenerator.Model.Writers;
using FactorioRconSharp.ClientGenerator.Specification;

string specPath = "Resource/runtime-api-v1_1_104.json";
JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
{
    PropertyNameCaseInsensitive = true,
    Converters = { new FactorioRuntimeTypeSpecificationConverter(), new JsonStringEnumConverter() },
    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
};

FactorioRuntimeApiSpecification? parsedSpecification;
using (FileStream file = File.OpenRead(specPath))
{
    parsedSpecification = await JsonSerializer.DeserializeAsync<FactorioRuntimeApiSpecification>(file, options);
}

if (parsedSpecification == null)
{
    Console.Error.WriteLine($"Could not deserialize file {specPath}");
    return 1;
}

Console.WriteLine($"Parsed specification: {parsedSpecification.Application} v{parsedSpecification.ApplicationVersion}");
Console.WriteLine($"\tApi v{parsedSpecification.ApiVersion} ({parsedSpecification.Stage})");
Console.WriteLine($"\tClasses ({parsedSpecification.Classes.Length}): {string.Join(", ", parsedSpecification.Classes.Select(c => c.Name))}");
Console.WriteLine();

const string outPath = "out";

if (Directory.Exists(outPath))
{
    Directory.Delete(outPath, true);
}

Directory.CreateDirectory(outPath);

string definitionsPath = Path.Join(outPath, "Definitions");
Directory.CreateDirectory(definitionsPath);

string classesPath = Path.Join(outPath, "Classes");
Directory.CreateDirectory(classesPath);

string conceptsPath = Path.Join(outPath, "Concepts");
Directory.CreateDirectory(conceptsPath);

FactorioModelFileCompiler compiler = new(parsedSpecification);

foreach (FactorioRuntimeDefinitionSpecification definition in parsedSpecification.Defines)
{
    FactorioModelFile file = compiler.CompileDefinitionFile(definition.Name);

    string path = Path.Join(definitionsPath, file.Name + ".cs");

    await using StreamWriter writer = File.CreateText(path);
    await FactorioModelWriter.WriteFile(writer, file);
}

foreach (FactorioRuntimeClassSpecification cls in parsedSpecification.Classes)
{
    FactorioModelFile file = compiler.CompileClassFile(cls.Name);

    string path = Path.Join(classesPath, file.Name + ".cs");

    await using StreamWriter writer = File.CreateText(path);
    await FactorioModelWriter.WriteFile(writer, file);
}

foreach (FactorioRuntimeConceptSpecification concept in parsedSpecification.Concepts)
{
    FactorioModelFile file = compiler.CompileConceptFile(concept.Name);

    string path = Path.Join(conceptsPath, file.Name + ".cs");

    await using StreamWriter writer = File.CreateText(path);
    await FactorioModelWriter.WriteFile(writer, file);
}

return 0;
