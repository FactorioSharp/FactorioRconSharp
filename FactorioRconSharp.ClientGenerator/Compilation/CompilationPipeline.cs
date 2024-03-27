using FactorioRconSharp.ClientGenerator.Model;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Compilation;

static class CompilationPipeline
{
    public static IEnumerable<FactorioModelFile> CompileSpecification(FactorioRuntimeApiSpecification specification)
    {
        FactorioModelFileCompiler compiler = new(specification);

        List<FactorioModelFile> files = [];

        files.AddRange(specification.Defines.Select(d => compiler.CompileDefinitionFile(d.Name)));
        files.AddRange(specification.Classes.Select(c => compiler.CompileClassFile(c.Name)));
        files.AddRange(specification.Concepts.Select(c => compiler.CompileConceptFile(c.Name)));

        return files;
    }
}
