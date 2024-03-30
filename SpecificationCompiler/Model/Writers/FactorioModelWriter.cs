namespace SpecificationCompiler.Model.Writers;

static partial class FactorioModelWriter
{
    const string ClassAttribute = "FactorioRconClass";
    const string ConceptAttribute = "FactorioRconConcept";
    const string DefinitionAttribute = "FactorioRconDefinition";
    const string? DefinitionValueAttribute = "FactorioRconDefinitionValue";
    const string AttributeAttribute = "FactorioRconAttribute";
    const string MethodAttribute = "FactorioRconMethod";

    public static async Task WriteFileAsync(TextWriter writer, FactorioModelFile file)
    {
        await writer.WriteLineAsync("#pragma warning disable CS8618");
        await writer.WriteLineAsync("// ReSharper disable UnassignedGetOnlyAutoProperty");

        await writer.WriteLineAsync();

        List<string> usingStmts = ["FactorioSharp.Rcon.Core.Abstractions", "FactorioSharp.Rcon.Model.Utils"];
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
                    await WriteClassAsync(writer, cls);
                    break;
                case FactorioModelEnum enm:
                    await WriteEnumAsync(writer, enm);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(statement));

            }
            await writer.WriteLineAsync();
        }
    }

    static async Task WriteClassAsync(TextWriter writer, FactorioModelClass cls, int indentLevel = 0)
    {
        if (cls.Documentation != null)
        {
            await cls.Documentation.WriteAsync(writer, indentLevel);
        }

        foreach (string attribute in cls.Attributes)
        {
            await writer.WriteLineAsync($"[{attribute}]", indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(cls.LuaName))
        {
            if (cls.IsFactorioClass)
            {
                await writer.WriteLineAsync($"[{ClassAttribute}(\"{cls.LuaName}\")]", indentLevel);
            }

            if (cls.IsFactorioConcept)
            {
                await writer.WriteLineAsync($"[{ConceptAttribute}(\"{cls.LuaName}\")]", indentLevel);
            }
        }

        string classDeclaration = $"public {(cls.IsAbstract ? "abstract " : "")}{(cls.IsPartial ? "partial " : "")}class {cls.Name}";

        if (string.IsNullOrWhiteSpace(cls.BaseClass))
        {
            await writer.WriteLineAsync(classDeclaration, indentLevel);
        }
        else
        {
            await writer.WriteLineAsync($"{classDeclaration}: {cls.BaseClass}", indentLevel);
        }

        await writer.WriteLineAsync("{", indentLevel);

        foreach (FactorioModelClassProperty property in cls.Properties)
        {
            await WritePropertyAsync(writer, property, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        foreach (FactorioModelClassOperator op in cls.Operators)
        {
            await WriteOperatorAsync(writer, op, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        foreach (FactorioModelClassMethod method in cls.Methods)
        {
            await WriteMethodAsync(writer, method, indentLevel + 1);
            await writer.WriteLineAsync();
        }

        await writer.WriteLineAsync("}", indentLevel);
    }

    static async Task WriteEnumAsync(TextWriter writer, FactorioModelEnum enm, int indentLevel = 0)
    {
        if (enm.Documentation != null)
        {
            await enm.Documentation.WriteAsync(writer, indentLevel);
        }

        if (!string.IsNullOrWhiteSpace(enm.LuaName))
        {
            await writer.WriteLineAsync($"[{DefinitionAttribute}(\"{enm.LuaName}\")]", indentLevel);
        }

        await writer.WriteLineAsync($"public enum {enm.Name}", indentLevel);
        await writer.WriteLineAsync("{", indentLevel);

        foreach (FactorioModelEnumValue value in enm.Values)
        {
            if (value.Documentation != null)
            {
                await value.Documentation.WriteAsync(writer, indentLevel + 1);
            }

            if (!string.IsNullOrWhiteSpace(value.LuaName))
            {
                await writer.WriteLineAsync($"[{DefinitionValueAttribute}(\"{value.LuaName}\")]", indentLevel + 1);
            }

            await writer.WriteLineAsync($"{value.Name},", indentLevel + 1);
            await writer.WriteLineAsync();
        }

        await writer.WriteLineAsync("}", indentLevel);
    }

    static async Task WritePropertyAsync(TextWriter writer, FactorioModelClassProperty property, int indentLevel = 0)
    {
        if (property is { Read: false, Write: false })
        {
            await writer.WriteCommentLineAsync($"Attribute {property.Name} skipped because both getter and setter are inaccessible", indentLevel);
            return;
        }

        if (property.Documentation != null)
        {
            await property.Documentation.WriteAsync(writer, indentLevel);
        }

        string getter = property.Read ? "get;" : "private get;";
        string setter = property.Write ? "set;" : "private set;";

        if (property.LuaName != null)
        {
            await writer.WriteLineAsync($"[{AttributeAttribute}(\"{property.LuaName}\")]", indentLevel);
        }

        await writer.WriteLineAsync($"public {(property.IsStatic ? "static " : "")}{property.Type} {property.Name} {{ {getter} {setter} }}", indentLevel);
    }

    static async Task WriteOperatorAsync(TextWriter writer, FactorioModelClassOperator op, int indentLevel = 0)
    {
        if (op is { Read: false, Write: false })
        {
            await writer.WriteCommentLineAsync($"Operator {op.OperatorType} skipped because both getter and setter are inaccessible", indentLevel);
            return;
        }

        switch (op.OperatorType)
        {
            case FactorioModelClassOperatorType.Indexer:
                await WriteIndexerAsync(writer, op, indentLevel);
                break;
        }
    }

    static async Task WriteMethodAsync(TextWriter writer, FactorioModelClassMethod method, int indentLevel = 0)
    {
        if (method.Documentation != null)
        {
            await method.Documentation.WriteAsync(writer, indentLevel);
        }

        foreach (FactorioModelClassMethodParameter parameter in method.Parameters)
        {
            if (string.IsNullOrEmpty(parameter.LuaName))
            {
                await writer.WriteDocumentationLineAsync($"<param name=\"{parameter.Name}\"></param>", indentLevel);
            }
            else
            {
                await writer.WriteDocumentationLineAsync($"<param name=\"{parameter.Name}\">Lua name: {parameter.LuaName}</param>", indentLevel);
            }
        }

        IEnumerable<string> parameters = method.Parameters.OrderBy(p => p.Optional ? 1 : 0).Select(ComputeParameter);

        await writer.WriteLineAsync($"[{MethodAttribute}(\"{method.LuaName}\")]", indentLevel);
        await writer.WriteLineAsync($"public abstract {method.ReturnType ?? "void"} {method.Name}({string.Join(", ", parameters)});", indentLevel);
    }

    static async Task WriteIndexerAsync(TextWriter writer, FactorioModelClassOperator op, int indentLevel = 0)
    {
        if (op.Documentation != null)
        {
            await op.Documentation.WriteAsync(writer, indentLevel);
        }

        string returnType = op.Optional ? $"{op.ReturnType}?" : op.ReturnType;
        string getter = op.Read ? "get; " : "";
        string setter = op.Write ? "set; " : "";

        await writer.WriteLineAsync($"public abstract {returnType} this[{op.KeyType} key] {{ {getter}{setter}}}", indentLevel);
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
}
