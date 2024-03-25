using System.Text;

namespace FactorioRconSharp.ClientGenerator.Model.Writers;

public static class FactorioModelWriter
{
    public static async Task WriteFile(TextWriter writer, FactorioModelFile file)
    {
        foreach (string usingStmt in file.Usings)
        {
            await writer.WriteLineAsync($"using {usingStmt};");
        }

        await writer.WriteLineAsync();

        if (!string.IsNullOrWhiteSpace(file.Namespace))
        {
            await writer.WriteLineAsync($"namespace {file.Namespace};");
        }

        await writer.WriteLineAsync();

        foreach (FactorioModelClass cls in file.Classes)
        {
            await WriteClass(writer, cls);
        }
    }

    static async Task WriteClass(TextWriter writer, FactorioModelClass cls, int indentLevel = 0)
    {
        if (cls.Documentation != null)
        {
            await WriteDocumentation(writer, cls.Documentation, indentLevel);
        }

        string? inheritance = ComputeInheritance(cls);

        if (inheritance == null)
        {
            await WriteLineAsync(writer, $"public class {cls.Name}", indentLevel);
        }
        else
        {
            await WriteLineAsync(writer, $"public class {cls.Name}: {inheritance}", indentLevel);
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

        await WriteLineAsync(writer, $"[FactorioRconAttribute(\"{property.LuaName}\")]", indentLevel);
        await WriteLineAsync(writer, $"public {property.Type} {property.Name} {{ {getter} {setter} }}", indentLevel);
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
                await WriteDocumentationLineAsync(writer, $"<param name=\"{parameter.Name}></param>\"", indentLevel);
            }
            else
            {
                await WriteDocumentationLineAsync(writer, $"<param name=\"{parameter.Name}>Lua name: {parameter.LuaName}</param>\"", indentLevel);
            }
        }

        IEnumerable<string> parameters = method.Parameters.Select(ComputeParameter);
        string exception = method.ReturnType == null ? "UseClientExecuteAsyncMethod()" : "UseClientReadAsyncMethod()";

        await WriteLineAsync(writer, $"[FactorioRconMethod(\"{method.LuaName}\")]", indentLevel);
        await WriteLineAsync(writer, $"public {method.ReturnType ?? "void"} {method.Name}({string.Join(", ", parameters)}) => throw {exception};", indentLevel);
    }

    static async Task WriteIndexer(TextWriter writer, FactorioModelClassOperator op, int indentLevel = 0)
    {
        if (op.Documentation != null)
        {
            await WriteDocumentation(writer, op.Documentation, indentLevel);
        }

        string returnType = op.Optional ? $"{op.ReturnType}?" : op.ReturnType;
        string getter = op.Read ? "get;" : "private get;";
        string setter = op.Write ? "set;" : "private set;";

        await WriteLineAsync(
            writer,
            $"public {returnType} this[{op.KeyType} key] {{ {getter} => throw UseClientReadAsyncMethod(); {setter} => throw UseClientExecuteAsyncMethod(); }}",
            indentLevel
        );
    }

    static async Task WriteDocumentation(TextWriter writer, FactorioModelDocumentation documentation, int indentLevel = 0)
    {
        if (!string.IsNullOrWhiteSpace(documentation.Summary))
        {
            await WriteDocumentationLineAsync(writer, "<summary>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{documentation.Summary}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</summary>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Remarks))
        {
            await WriteDocumentationLineAsync(writer, "<remarks>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{documentation.Remarks}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</remarks>", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(documentation.Examples))
        {
            await WriteDocumentationLineAsync(writer, "<examples>", indentLevel);
            await WriteDocumentationLineAsync(writer, $"{documentation.Examples}", indentLevel);
            await WriteDocumentationLineAsync(writer, "</examples>", indentLevel);
        }
    }

    static string? ComputeInheritance(FactorioModelClass cls)
    {
        if (cls.BaseClassName == null && cls.Interfaces.Length == 0)
        {
            return null;
        }

        StringBuilder inheritanceBuilder = new();

        if (cls.BaseClassName != null)
        {
            inheritanceBuilder.Append(cls.BaseClassName);
        }

        foreach (string clsInterface in cls.Interfaces)
        {
            inheritanceBuilder.Append($", {clsInterface}");
        }

        return inheritanceBuilder.ToString();
    }

    static string ComputeParameter(FactorioModelClassMethodParameter parameter)
    {
        string type = parameter.Optional ? $"{parameter.Type}?" : parameter.Type;

        if (parameter.DefaultValue == null)
        {
            return $"{type} {parameter.Name}";
        }

        return $"{type} {parameter.Name} = {parameter.DefaultValue}";
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
}
