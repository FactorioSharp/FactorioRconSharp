using SpecificationCompiler.Model;
using SpecificationCompiler.Specification;

namespace SpecificationCompiler.Compilation;

static class CompilationPipeline
{
    public static IEnumerable<FactorioModelFile> CompileSpecification(FactorioRuntimeApiSpecification specification)
    {
        FactorioModelFileCompiler compiler = new(specification);

        IEnumerable<FactorioRuntimeTypeSpecification> anonymousTypes = specification.Concepts.SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes)
            .Concat(specification.Classes.SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes))
            .Concat(specification.GlobalObjects.Select(o => o.Type).SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes))
            .Concat(specification.GlobalFunctions.SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes));

        List<FactorioModelTopLevelStatement> compiledAnonymousTypes = anonymousTypes.Distinct().SelectMany(compiler.CompileType).ToList();

        List<FactorioModelFile> files =
        [
            new FactorioModelFile
            {
                Name = "AnonymousTypes",
                Namespace = "FactorioSharp.Rcon.Model.Anonymous",
                Usings =
                [
                    "FactorioSharp.Rcon.Model.Builtins",
                    "FactorioSharp.Rcon.Model.Definitions",
                    "FactorioSharp.Rcon.Model.Classes",
                    "FactorioSharp.Rcon.Model.Concepts"
                ],
                Statements = compiledAnonymousTypes.ToArray()
            }
        ];

        files.AddRange(
            specification.Defines.Select(d => compiler.CompileDefinitionFile(d.Name))
                .Select(
                    enums =>
                    {
                        FactorioModelEnum[] enumsArray = enums as FactorioModelEnum[] ?? enums.ToArray();
                        return new FactorioModelFile
                        {
                            Name = enumsArray.First().Name,
                            Namespace = "FactorioSharp.Rcon.Model.Definitions",
                            Statements = enumsArray.ToArray<FactorioModelTopLevelStatement>()
                        };
                    }
                )
        );

        files.AddRange(
            specification.Classes.Select(c => compiler.CompileClassFile(c.Name))
                .Select(
                    cls => new FactorioModelFile
                    {
                        Name = cls.Name,
                        Namespace = "FactorioSharp.Rcon.Model.Classes",
                        Usings =
                        [
                            "FactorioSharp.Rcon.Model.Builtins",
                            "FactorioSharp.Rcon.Model.Anonymous",
                            "FactorioSharp.Rcon.Model.Concepts",
                            "FactorioSharp.Rcon.Model.Definitions"
                        ],
                        Statements = [cls]
                    }
                )
        );

        files.AddRange(
            specification.Concepts.Select(c => compiler.CompileConceptFile(c.Name))
                .Select(
                    statements =>
                    {
                        (FactorioModelTopLevelStatement compiledConcept, IEnumerable<FactorioModelTopLevelStatement> auxiliaryTypes) = statements;
                        return new FactorioModelFile
                        {
                            Name = compiledConcept.Name,
                            Namespace = "FactorioSharp.Rcon.Model.Concepts",
                            Usings =
                            [
                                "FactorioSharp.Rcon.Model.Builtins",
                                "FactorioSharp.Rcon.Model.Anonymous",
                                "FactorioSharp.Rcon.Model.Classes",
                                "FactorioSharp.Rcon.Model.Definitions"
                            ],
                            Statements = new[] { compiledConcept }.Concat(auxiliaryTypes).ToArray()
                        };
                    }
                )
        );

        FactorioModelTopLevelStatement globalStatement = compiler.CompileGlobals();
        files.Add(
            new FactorioModelFile
            {
                Name = globalStatement.Name,
                Namespace = "FactorioSharp.Rcon.Model",
                Usings =
                [
                    "FactorioSharp.Rcon.Model.Builtins",
                    "FactorioSharp.Rcon.Model.Anonymous",
                    "FactorioSharp.Rcon.Model.Classes",
                    "FactorioSharp.Rcon.Model.Concepts",
                    "FactorioSharp.Rcon.Model.Definitions"
                ],
                Statements = [globalStatement]
            }
        );

        return files;
    }
}
