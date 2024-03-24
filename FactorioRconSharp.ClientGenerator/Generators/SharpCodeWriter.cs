using System.Text;

namespace FactorioRconSharp.ClientGenerator.Generators;

public class SharpCodeWriter
{
    readonly StringBuilder _builder;
    readonly string _indent;
    int _indentLevel;
    bool _comment;

    public SharpCodeWriter(int indentSize = 2)
    {
        _indent = string.Join("", Enumerable.Range(0, indentSize).Select(_ => "  "));
        _builder = new StringBuilder();
    }

    public SharpCodeWriter AppendLine(string? str = null)
    {
        string[] lines = str?.Split([Environment.NewLine, "\n", "\r"], StringSplitOptions.None) ?? [""];
        foreach (string t in lines)
        {
            AppendLineInternal(t);
        }

        return this;
    }

    public SharpCodeWriter AppendCommentLine(string? str = null)
    {
        Comment();
        AppendLine(str);
        Uncomment();

        return this;
    }

    public SharpCodeWriter Indent()
    {
        _indentLevel++;
        return this;
    }

    public SharpCodeWriter Unindent()
    {
        _indentLevel--;
        return this;
    }

    public SharpCodeWriter Comment()
    {
        _comment = true;
        return this;
    }

    public SharpCodeWriter Uncomment()
    {
        _comment = false;
        return this;
    }

    public override string ToString() => _builder.ToString();

    void AppendLineInternal(string t)
    {
        for (int i = 0; i < _indentLevel; i++)
        {
            _builder.Append(_indent);
        }

        if (_comment)
        {
            _builder.Append("/// ");
        }

        _builder.AppendLine(t);
    }
}
