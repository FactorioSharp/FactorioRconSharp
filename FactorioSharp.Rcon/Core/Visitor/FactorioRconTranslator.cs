using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model;

namespace FactorioSharp.Rcon.Core.Visitor;

public class FactorioRconTranslator : ExpressionVisitor
{
    StringBuilder _acc = null!;
    readonly IReadOnlyDictionary<string, object>? _dictCtx;
    readonly object? _valueCtx;

    public FactorioRconTranslator()
    {
    }

    public FactorioRconTranslator(IReadOnlyDictionary<string, object> dictCtx)
    {
        _dictCtx = dictCtx;
    }

    public FactorioRconTranslator(object? valueCtx)
    {
        _valueCtx = valueCtx;
    }

    public string BuildExpression(Expression<Action<FactorioRconGlobals>> action)
    {
        _acc = new StringBuilder();

        Visit(action.Body);

        return _acc.ToString();
    }

    public string BuildExpression<TArg>(Expression<Action<FactorioRconGlobals, TArg>> action)
    {
        _acc = new StringBuilder();

        Visit(action.Body);

        return _acc.ToString();
    }

    public string BuildExpression<TValue>(Expression<Func<FactorioRconGlobals, TValue>> func)
    {
        _acc = new StringBuilder();

        Visit(func.Body);

        return _acc.ToString();
    }

    public string BuildExpression<TArg, TValue>(Expression<Func<FactorioRconGlobals, TArg, TValue>> func)
    {
        _acc = new StringBuilder();

        Visit(func.Body);

        return _acc.ToString();
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
        AppendValue(node.Value);
        return node;
    }

    protected override Expression VisitUnary(UnaryExpression node)
    {
        _acc.Append('(');

        switch (node.NodeType)
        {
            case ExpressionType.Not:
                _acc.Append("not ");
                break;
            case ExpressionType.Negate:
            case ExpressionType.NegateChecked:
                _acc.Append("- ");
                break;
            case ExpressionType.Convert:
            case ExpressionType.ConvertChecked:
                break;
            default:
                throw new NotSupportedException($"The unary operator {node.NodeType} is not supported");
        }

        Visit(node.Operand);

        _acc.Append(')');

        return node;
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        _acc.Append('(');

        Visit(node.Left);

        switch (node.NodeType)
        {
            case ExpressionType.And:
            case ExpressionType.AndAlso:
                _acc.Append(" and ");
                break;
            case ExpressionType.Or:
            case ExpressionType.OrElse:
                _acc.Append(" or ");
                break;
            case ExpressionType.Add:
            case ExpressionType.AddChecked:
                if (node.Left.Type == typeof(string))
                {
                    _acc.Append(" .. ");
                }
                else
                {
                    _acc.Append(" + ");
                }
                break;
            case ExpressionType.Subtract:
            case ExpressionType.SubtractChecked:
                _acc.Append(" - ");
                break;
            case ExpressionType.Multiply:
            case ExpressionType.MultiplyChecked:
                _acc.Append(" * ");
                break;
            case ExpressionType.Divide:
                _acc.Append(" / ");
                break;
            case ExpressionType.Power:
                _acc.Append(" ^ ");
                break;
            case ExpressionType.GreaterThan:
                _acc.Append(" > ");
                break;
            case ExpressionType.GreaterThanOrEqual:
                _acc.Append(" >= ");
                break;
            case ExpressionType.LessThan:
                _acc.Append(" < ");
                break;
            case ExpressionType.LessThanOrEqual:
                _acc.Append(" <= ");
                break;
            case ExpressionType.Equal:
                _acc.Append(" == ");
                break;
            case ExpressionType.NotEqual:
                _acc.Append(" ~= ");
                break;
            default:
                throw new NotSupportedException($"The binary operator {node.NodeType} is not supported");
        }

        Visit(node.Right);

        _acc.Append(')');

        return node;
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        FactorioRconAttributeAttribute? attributeAttribute = node.Member.GetCustomAttribute<FactorioRconAttributeAttribute>();
        if (attributeAttribute != null)
        {
            if (node.Expression is not ParameterExpression)
            {
                Visit(node.Expression);
                _acc.Append('.');
            }

            _acc.Append(attributeAttribute.Name);
            return node;
        }

        FactorioRconLengthOperatorAttribute? lengthAttribute = node.Member.GetCustomAttribute<FactorioRconLengthOperatorAttribute>();
        if (lengthAttribute != null)
        {
            _acc.Append("#");

            if (node.Expression is not ParameterExpression)
            {
                Visit(node.Expression);
            }

            return node;
        }

        throw new InvalidOperationException($"The member {node} cannot be used in an RCON expression because it is not marked with the [FactorioRconAttribute] attribute");
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        if (node.Type != typeof(FactorioRconGlobals) && _valueCtx != null)
        {
            AppendValue(_valueCtx);
        }

        return node;
    }

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
        FactorioRconMethodAttribute? attribute = node.Method.GetCustomAttribute<FactorioRconMethodAttribute>();
        if (attribute != null)
        {
            Visit(node.Object);

            _acc.Append('.');

            _acc.Append(attribute.Name);

            _acc.Append('(');

            for (int index = 0; index < node.Arguments.Count; index++)
            {
                if (index > 0)
                {
                    _acc.Append(", ");
                }

                Visit(node.Arguments[index]);
            }

            _acc.Append(')');

            return node;
        }

        string? indexerName = node.Object?.Type.GetCustomAttribute<DefaultMemberAttribute>()?.MemberName;
        if (indexerName != null && node.Method.Name == $"get_{indexerName}")
        {
            return VisitIndexer(node);
        }

        throw new InvalidOperationException($"The method {node} cannot be used in an RCON expression because it is not marked with the [FactorioRconMethod] attribute");
    }

    Expression VisitIndexer(MethodCallExpression node)
    {
        if (node.Object is ParameterExpression parameterExpression && parameterExpression.Type == typeof(Dictionary<string, object>))
        {
            // the indexed variable is the global context

            if (_dictCtx == null)
            {
                throw new InvalidOperationException("No context was provided");
            }

            Expression? ctxVariableNameExpression = node.Arguments.First();
            if (ctxVariableNameExpression is not ConstantExpression { Value: string ctxVariableName })
            {
                throw new InvalidOperationException("Context variable name was expected to be a string");
            }

            if (_dictCtx.TryGetValue(ctxVariableName, out object? value))
            {
                AppendValue(value);
            }
            else
            {
                throw new InvalidOperationException($"Variable {ctxVariableName} not in part of context");
            }
        }
        else
        {
            Visit(node.Object);

            _acc.Append('[');

            for (int index = 0; index < node.Arguments.Count; index++)
            {
                if (index > 0)
                {
                    _acc.Append(", ");
                }

                Visit(node.Arguments[index]);
            }

            _acc.Append(']');
        }

        return node;
    }

    protected override Expression VisitNewArray(NewArrayExpression node)
    {
        _acc.Append('{');

        for (int index = 0; index < node.Expressions.Count; index++)
        {
            if (index > 0)
            {
                _acc.Append(", ");
            }

            Visit(node.Expressions[index]);
        }

        _acc.Append('}');

        return node;
    }

    void AppendValue(object value)
    {
        if (value is string str)
        {
            _acc.Append('"');
            _acc.Append(str);
            _acc.Append('"');
        }
        else
        {
            _acc.Append(value);
        }
    }
}
