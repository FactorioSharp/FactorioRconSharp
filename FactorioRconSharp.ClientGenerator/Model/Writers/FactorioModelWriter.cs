using System.Text.RegularExpressions;
using CaseExtensions;

namespace FactorioRconSharp.ClientGenerator.Model.Writers;

public static partial class FactorioModelWriter
{
    const string ClassAttribute = "FactorioRconClass";
    const string ConceptAttribute = "FactorioRconConcept";
    const string DefinitionAttribute = "FactorioRconDefinition";
    const string? DefinitionValueAttribute = "FactorioRconDefinitionValue";
    const string AttributeAttribute = "FactorioRconAttribute";
    const string MethodAttribute = "FactorioRconMethod";

    public static async Task WriteFile(TextWriter writer, FactorioModelFile file)
    {
        await writer.WriteLineAsync("#pragma warning disable CS8618");
        await writer.WriteLineAsync("// ReSharper disable UnassignedGetOnlyAutoProperty");

        await writer.WriteLineAsync();

        List<string> usingStmts = ["FactorioRconSharp.Core.Abstractions", "FactorioRconSharp.Model.Utils"];
        usingStmts.AddRange(file.Usings.Concat(file.Statements.SelectMany(stmt => stmt.RequireAdditionalUsing)));

        foreach (string usingStmt in usingStmts.Distinct().Order())
        {
            await writer.WriteLineAsync($"using {usingStmt};");
        }

        await writer.WriteLineAsync();

        if (!string.IsNullOrWhiteSpace(file.Namespace))
        {
            await writer.WriteLineAsync($"namespace {file.Namespace};");
            await writer.WriteLineAsync();
        }

        foreach (FactorioModelTopLevelStatement statement in file.Statements)
        {
            switch (statement)
            {
                case FactorioModelClass cls:
                    await WriteClass(writer, cls);
                    break;
                case FactorioModelEnum enm:
                    await WriteEnum(writer, enm);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(statement));

            }
            await writer.WriteLineAsync();
        }
    }

    static async Task WriteClass(TextWriter writer, FactorioModelClass cls, int indentLevel = 0)
    {
        if (cls.Documentation != null)
        {
            await WriteDocumentation(writer, cls.Documentation, indentLevel);
        }

        foreach (string attribute in cls.Attributes)
        {
            await WriteLineAsync(writer, $"[{attribute}]", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(cls.LuaName))
        {
            if (cls.IsFactorioClass)
            {
                await WriteLineAsync(writer, $"[{ClassAttribute}(\"{cls.LuaName}\")]", indentLevel);
            }

            if (cls.IsFactorioConcept)
            {
                await WriteLineAsync(writer, $"[{ConceptAttribute}(\"{cls.LuaName}\")]", indentLevel);
            }
        }

        string classDeclaration = $"public abstract {(cls.IsPartial ? "partial " : "")}class {cls.Name}";

        if (string.IsNullOrWhiteSpace(cls.BaseClass))
        {
            await WriteLineAsync(writer, classDeclaration, indentLevel);
        }
        else
        {
            await WriteLineAsync(writer, $"{classDeclaration}: {cls.BaseClass}", indentLevel);
        }

        await WriteLineAsync(writer, "{", indentLevel);

        foreach (FactorioModelClassProperty property in cls.Properties)
        {
            await WriteProperty(writer, property, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        foreach (FactorioModelClassOperator op in cls.Operators)
        {
            await WriteOperator(writer, op, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        foreach (FactorioModelClassMethod method in cls.Methods)
        {
            await WriteMethod(writer, method, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        await WriteLineAsync(writer, "}", indentLevel);
    }

    static async Task WriteEnum(TextWriter writer, FactorioModelEnum enm, int indentLevel = 0)
    {
        if (enm.Documentation != null)
        {
            await WriteDocumentation(writer, enm.Documentation, indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(enm.LuaName))
        {
            await WriteLineAsync(writer, $"[{DefinitionAttribute}(\"{enm.LuaName}\")]", indentLevel);
        }

        await WriteLineAsync(writer, $"public enum {enm.Name}", indentLevel);
        await WriteLineAsync(writer, "{", indentLevel);

        foreach (FactorioModelEnumValue value in enm.Values)
        {
            if (value.Documentation != null)
            {
                await WriteDocumentation(writer, value.Documentation, indentLevel + 1);
            }

            if (!string.IsNullOrWhiteSpace(value.LuaName))
            {
                await WriteLineAsync(writer, $"[{DefinitionValueAttribute}(\"{value.LuaName}\")]", indentLevel + 1);
            }

            await WriteLineAsync(writer, $"{value.Name},", indentLevel + 1);
            await writer.WriteLineAsync();
        }

        await WriteLineAsync(writer, "}", indentLevel);
    }

    static async Task WriteProperty(TextWriter writer, FactorioModelClassProperty property, int indentLevel = 0)
    {
        if (property is { Read: false, Write: false })
        {
            await WriteCommentLineAsync(writer, $"Attribute {property.Name} skipped because both getter and setter are inaccessible", indentLevel);
            return;
        }

        if (property.Documentation != null)
        {
            await WriteDocumentation(writer, property.Documentation, indentLevel);
        }

        string getter = property.Read ? "get;" : "private get;";
        string setter = property.Write ? "set;" : "private set;";

        if (property.LuaName != null)
        {
            await WriteLineAsync(writer, $"[{AttributeAttribute}(\"{property.LuaName}\")]", indentLevel);
        }

        await WriteLineAsync(writer, $"public {(property.IsStatic ? "static " : "")}{property.Type} {property.Name} {{ {getter} {setter} }}", indentLevel);
    }

    static async Task WriteOperator(TextWriter writer, FactorioModelClassOperator op, int indentLevel = 0)
    {
        if (op is { Read: false, Write: false })
        {
            await WriteCommentLineAsync(writer, $"Operator {op.OperatorType} skipped because both getter and setter are inaccessible", indentLevel);
            return;
        }

        switch (op.OperatorType)
        {
            case FactorioModelClassOperatorType.Indexer:
                await WriteIndexer(writer, op, indentLevel);
                break;
        }
    }

    static async Task WriteMethod(TextWriter writer, FactorioModelClassMethod method, int indentLevel = 0)
    {
        if (method.Documentation != null)
        {
            await WriteDocumentation(writer, method.Documentation, indentLevel);
        }

        foreach (FactorioModelClassMethodParameter parameter in method.Parameters)
        {
            if (string.IsNullOrEmpty(parameter.LuaName))
            {
                await WriteDocumentationLineAsync(writer, $"<param name=\"{parameter.Name}\"></param>", indentLevel);
            }
            else
            {
                await WriteDocumentationLineAsync(writer, $"<param name=\"{parameter.Name}\">Lua name: {parameter.LuaName}</param>", indentLevel);
            }
        }

        IEnumerable<string> parameters = method.Parameters.OrderBy(p => p.Optional ? 1 : 0).Select(ComputeParameter);

        await WriteLineAsync(writer, $"[{MethodAttribute}(\"{method.LuaName}\")]", indentLevel);
        await WriteLineAsync(writer, $"public abstract {method.ReturnType ?? "void"} {method.Name}({string.Join(", ", parameters)});", indentLevel);
    }

    static async Task WriteIndexer(TextWriter writer, FactorioModelClassOperator op, int indentLevel = 0)
    {
        if (op.Documentation != null)
        {
            await WriteDocumentation(writer, op.Documentation, indentLevel);
        }

        string returnType = op.Optional ? $"{op.ReturnType}?" : op.ReturnType;
        string getter = op.Read ? "get; " : "";
        string setter = op.Write ? "set; " : "";

        await WriteLineAsync(writer, $"public abstract {returnType} this[{op.KeyType} key] {{ {getter}{setter}}}", indentLevel);
    }

    static async Task WriteDocumentation(TextWriter writer, FactorioModelDocumentation documentation, int indentLevel = 0)
    {
        if (!string.IsNullOrWhiteSpace(documentation.Summary))
        {
            await WriteDocumentationLineAsync(writer, "<summary>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{ReplaceDocumentationLinks(documentation.Summary)}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</summary>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Remarks))
        {
            await WriteDocumentationLineAsync(writer, "<remarks>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{ReplaceDocumentationLinks(documentation.Remarks)}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</remarks>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Examples))
        {
            await WriteDocumentationLineAsync(writer, "<examples>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{ReplaceDocumentationLinks(documentation.Examples)}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</examples>", indentLevel);
        }
    }

    static string ComputeParameter(FactorioModelClassMethodParameter parameter)
    {
        if (parameter.DefaultValue != null)
        {
            return $"{parameter.Type} {parameter.Name} = {parameter.DefaultValue}";
        }

        if (parameter.Optional)
        {
            return $"{parameter.Type}? {parameter.Name} = null";
        }

        return $"{parameter.Type} {parameter.Name}";
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

    #region Indent

    static async Task WriteLineAsync(TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, indent);
    }

    static async Task WriteCommentLineAsync(TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, $"{indent}// ");
    }

    static async Task WriteDocumentationLineAsync(TextWriter writer, string content, int indentLevel)
    {
        string indent = GetIndent(indentLevel);
        await WriteLineAsync(writer, content, $"{indent}/// ");
    }

    static async Task WriteLineAsync(TextWriter writer, string? content, string? prefix)
    {
        string[] lines = content?.Split([Environment.NewLine, "\n", "\r"], StringSplitOptions.None) ?? [""];
        foreach (string line in lines)
        {
            await writer.WriteLineAsync($"{prefix}{line}");
        }
    }

    static readonly Dictionary<int, string> IndentCache = new();

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

    #endregion

    [GeneratedRegex(@"\[.*\]\(runtime:(?<symbol>.*)\)", RegexOptions.Multiline | RegexOptions.Compiled)]
    private static partial Regex DocumentationLinkRegex();
}
