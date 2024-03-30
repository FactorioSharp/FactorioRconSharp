using SpecificationCompiler.Model;
using SpecificationCompiler.Specification;

namespace SpecificationCompiler.Compilation;

static class CompilationPipeline
{
    public static IEnumerable<FactorioModelFile> CompileSpecification(FactorioRuntimeApiSpecification specification)
    {
        // Classes of the specification are enumerated and compiled one by one. However some might get compiled ahead of time because they are the base class 
        // of a another one that is before them in the enumeration. This cache will store the compiled classes so that 1) they are only compiled once and 2) they are easily
        // accessible by looking up their name instead of going through the whole list of already compiled classes
        Dictionary<string, FactorioModelClass> _compiledClassesCache = new();

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

        foreach (FactorioRuntimeClassSpecification cls in specification.Classes)
        {
            FactorioModelClass compiledClass = CompileClass(specification, compiler, cls, _compiledClassesCache);

            files.Add(
                new FactorioModelFile
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
                    Statements = [compiledClass]
                }
            );
        }

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

    static FactorioModelClass CompileClass(
        FactorioRuntimeApiSpecification specification,
        FactorioModelFileCompiler compiler,
        FactorioRuntimeClassSpecification cls,
        IDictionary<string, FactorioModelClass> compiledClassesCache
    )
    {
        if (compiledClassesCache.TryGetValue(cls.Name, out FactorioModelClass? compiledClass))
        {
            return compiledClass;
        }

        FactorioModelClass[] baseClasses = cls.BaseClasses.Select(
                name =>
                {
                    FactorioRuntimeClassSpecification baseCls = specification.Classes.First(c => c.Name == name);
                    return CompileClass(specification, compiler, baseCls, compiledClassesCache);
                }
            )
            .ToArray();

        compiledClass = compiler.CompileClassFile(cls.Name, baseClasses);
        compiledClassesCache[cls.Name] = compiledClass;
        return compiledClass;
    }
}
