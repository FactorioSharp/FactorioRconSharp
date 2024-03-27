using System.Collections;
using System.Reflection;
using System.Text;

namespace FactorioRconSharp.ClientGenerator.Extensions;

/// <remarks>
///     Shamelessly copied from https://stackoverflow.com/questions/852181/c-printing-all-properties-of-an-object
/// </remarks>
public class ObjectDumper
{
    int _level;
    readonly int _indentSize;
    readonly StringBuilder _stringBuilder;
    readonly List<int> _hashListOfFoundElements;

    ObjectDumper(int indentSize)
    {
        _indentSize = indentSize;
        _stringBuilder = new StringBuilder();
        _hashListOfFoundElements = new List<int>();
    }

    public static string Dump(object? element) => Dump(element, 2);

    public static string Dump(object? element, int indentSize)
    {
        ObjectDumper instance = new(indentSize);
        return instance.DumpElement(element);
    }

    string DumpElement(object? element)
    {
        if (element is null or ValueType or string)
        {
            Write(FormatValue(element));
        }
        else
        {
            Type objectType = element.GetType();
            if (!typeof(IEnumerable).IsAssignableFrom(objectType))
            {
                Write("{{{0}}}", objectType.FullName);
                _hashListOfFoundElements.Add(element.GetHashCode());
                _level++;
            }

            IEnumerable? enumerableElement = element as IEnumerable;
            if (enumerableElement != null)
            {
                foreach (object? item in enumerableElement)
                {
                    if (item is IEnumerable && !(item is string))
                    {
                        _level++;
                        DumpElement(item);
                        _level--;
                    }
                    else
                    {
                        if (!AlreadyTouched(item))
                        {
                            DumpElement(item);
                        }
                        else
                        {
                            Write("{{{0}}} <-- bidirectional reference found", item.GetType().FullName);
                        }
                    }
                }
            }
            else
            {
                MemberInfo[] members = element.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance);
                foreach (MemberInfo memberInfo in members)
                {
                    FieldInfo? fieldInfo = memberInfo as FieldInfo;
                    PropertyInfo? propertyInfo = memberInfo as PropertyInfo;

                    if (fieldInfo == null && propertyInfo == null)
                    {
                        continue;
                    }

                    Type? type = fieldInfo != null ? fieldInfo.FieldType : propertyInfo?.PropertyType;
                    object? value = fieldInfo != null ? fieldInfo.GetValue(element) : propertyInfo?.GetValue(element, null);

                    if (type != null && (type.IsValueType || type == typeof(string)))
                    {
                        Write("{0}: {1}", memberInfo.Name, FormatValue(value));
                    }
                    else
                    {
                        bool isEnumerable = typeof(IEnumerable).IsAssignableFrom(type);
                        Write("{0}: {1}", memberInfo.Name, isEnumerable ? "..." : "{ }");

                        bool alreadyTouched = !isEnumerable && AlreadyTouched(value);
                        _level++;
                        if (!alreadyTouched)
                        {
                            DumpElement(value);
                        }
                        else
                        {
                            Write("{{{0}}} <-- bidirectional reference found", value?.GetType().FullName);
                        }
                        _level--;
                    }
                }
            }

            if (!typeof(IEnumerable).IsAssignableFrom(objectType))
            {
                _level--;
            }
        }

        return _stringBuilder.ToString();
    }

    bool AlreadyTouched(object? value)
    {
        if (value == null)
        {
            return false;
        }

        int hash = value.GetHashCode();
        for (int i = 0; i < _hashListOfFoundElements.Count; i++)
        {
            if (_hashListOfFoundElements[i] == hash)
            {
                return true;
            }
        }
        return false;
    }

    void Write(string? value, params object?[] args)
    {
        if (value == null)
        {
            return;
        }

        string space = new(' ', _level * _indentSize);
        value = string.Format(value, args);
        _stringBuilder.AppendLine(space + value);
    }

    static string? FormatValue(object? o) =>
        o switch
        {
            null => "null",
            DateTime time => time.ToShortDateString(),
            string => $"\"{o}\"",
            '\0' => string.Empty,
            ValueType => o.ToString(),
            IEnumerable => "...",
            _ => "{ }"
        };
}
