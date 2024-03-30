using System.Text.RegularExpressions;
using CaseExtensions;

namespace SpecificationCompiler.Model.Writers;

static partial class FactorioModelDocumentationWriterExtensions
{
    public static async Task WriteAsync(this FactorioModelDocumentation documentation, TextWriter writer, int indentLevel = 0)
    {
        if (!string.IsNullOrWhiteSpace(documentation.Summary))
        {
            await writer.WriteDocumentationLineAsync("<summary>", indentLevel);
            await writer.WriteDocumentationLineAsync($"{ReplaceDocumentationLinks(documentation.Summary)}", indentLevel);
            await writer.WriteDocumentationLineAsync("</summary>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Remarks))
        {
            await writer.WriteDocumentationLineAsync("<remarks>", indentLevel);
            await writer.WriteDocumentationLineAsync($"{ReplaceDocumentationLinks(documentation.Remarks)}", indentLevel);
            await writer.WriteDocumentationLineAsync("</remarks>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Examples))
        {
            await writer.WriteDocumentationLineAsync("<examples>", indentLevel);
            await writer.WriteDocumentationLineAsync($"{ReplaceDocumentationLinks(documentation.Examples)}", indentLevel);
            await writer.WriteDocumentationLineAsync("</examples>", indentLevel);
        }
    }

    static string ReplaceDocumentationLinks(string documentation)
    {
        Regex linkRegex = DocumentationLinkRegex();

        MatchCollection matches = linkRegex.Matches(documentation);
        foreach (Match match in matches.ToArray())
        {
            string symbol = match.Groups["symbol"].Value;
            string sharpSymbol = string.Join(".", symbol.Split("::").Select(s => s.ToPascalCase()));
            documentation = documentation.Replace(match.Value, $"<see cref=\"{sharpSymbol}\" />");
        }

        return documentation;
    }

    [GeneratedRegex(@"\[.*\]\(runtime:(?<symbol>.*)\)", RegexOptions.Multiline | RegexOptions.Compiled)]
    private static partial Regex DocumentationLinkRegex();
}
