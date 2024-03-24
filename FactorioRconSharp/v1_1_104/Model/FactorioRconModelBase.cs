namespace FactorioRconSharp.v1_1_104.Model;

public class FactorioRconModelBase
{
    protected NotSupportedException UseClientReadAsyncMethod() => new($"Use this method through the {nameof(FactorioRconClient)}.{nameof(FactorioRconClient.ReadAsync)} method");
    protected NotSupportedException UseClientExecuteAsyncMethod() => new($"Use this method through the {nameof(FactorioRconClient)}.{nameof(FactorioRconClient.ExecuteAsync)} method");
}
