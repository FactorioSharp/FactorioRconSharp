using FactorioRconSharp.ClientGenerator.Model;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Compilation;

static class CompilationPipeline
{
    public static IEnumerable<FactorioModelFile> CompileSpecification(FactorioRuntimeApiSpecification specification)
    {
        FactorioModelFileCompiler compiler = new(specification);

        IEnumerable<FactorioRuntimeTypeSpecification> anonymousTypes = specification.Concepts.SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes)
            .Concat(specification.Classes.SelectMany(FactorioSpecificationTypeExtractor.ExtractTypes));

        List<FactorioModelTopLevelStatement> compiledAnonymousTypes = anonymousTypes.Distinct().SelectMany(compiler.CompileType).ToList();

        List<FactorioModelFile> files =
        [
            new FactorioModelFile
            {
                Name = "AnonymousTypes",
                Namespace = "FactorioRconSharp.Model.Anonymous",
                Usings =
                [
                    "FactorioRconSharp.Model.Builtins",
                    "FactorioRconSharp.Model.Definitions",
                    "FactorioRconSharp.Model.Classes",
                    "FactorioRconSharp.Model.Concepts"
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
                            Namespace = "FactorioRconSharp.Model.Definitions",
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
                        Namespace = "FactorioRconSharp.Model.Classes",
                        Usings =
                        [
                            "FactorioRconSharp.Model.Builtins",
                            "FactorioRconSharp.Model.Anonymous",
                            "FactorioRconSharp.Model.Concepts",
                            "FactorioRconSharp.Model.Definitions"
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
                            Namespace = "FactorioRconSharp.Model.Concepts",
                            Usings =
                            [
                                "FactorioRconSharp.Model.Builtins",
                                "FactorioRconSharp.Model.Anonymous",
                                "FactorioRconSharp.Model.Classes",
                                "FactorioRconSharp.Model.Definitions"
                            ],
                            Statements = new[] { compiledConcept }.Concat(auxiliaryTypes).ToArray()
                        };
                    }
                )
        );

        return files;
    }
}
