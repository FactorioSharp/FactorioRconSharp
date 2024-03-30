namespace SpecificationCompiler.Model.Writers;

static class TextWriterExtensions
{
    static readonly Dictionary<int, string> IndentCache = new();

    public static async Task WriteLineAsync(this TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, indent);
    }

    public static async Task WriteCommentLineAsync(this TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, $"{indent}// ");
    }

    public static async Task WriteDocumentationLineAsync(this TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, $"{indent}/// ");
    }

    static async Task WriteLineAsync(this TextWriter writer, string? content, string? prefix)
    {
        string[] lines = content?.Split([Environment.NewLine, "\n", "\r"], StringSplitOptions.None) ?? [""];
        foreach (string line in lines)
        {
            await writer.WriteLineAsync($"{prefix}{line}");
        }
    }

    static string GetIndent(int indentLevel)
    {
        const int indentSize = 2;

        if (IndentCache.TryGetValue(indentLevel, out string? indent))
        {
            return indent;
        }

        indent = new string(' ', indentLevel * indentSize);
        IndentCache[indentLevel] = indent;

        return indent;
    }
}
