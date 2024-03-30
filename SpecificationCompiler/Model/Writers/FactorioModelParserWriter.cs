namespace SpecificationCompiler.Model.Writers;

static class FactorioModelParserWriter
{
    public static async Task WriteStaticParserMethodAsync(TextWriter writer, FactorioModelClass cls, int indentLevel = 0) =>
        await writer.WriteLineAsync("public void Load(string str) => throw new NotImplementedException();", indentLevel);
}
