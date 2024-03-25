namespace FactorioRconSharp.Model.Utils;

public static class FactorioModelUtils
{
    public static NotSupportedException UseClientReadAsyncMethod() =>
        new($"Use this method through the {nameof(FactorioRconClient)}.{nameof(FactorioRconClient.ReadAsync)} method");

    public static NotSupportedException UseClientExecuteAsyncMethod() =>
        new($"Use this method through the {nameof(FactorioRconClient)}.{nameof(FactorioRconClient.ExecuteAsync)} method");
}
