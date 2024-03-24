public class FactorioRconModelBase
{
    protected NotSupportedException UseClientReadAsyncMethod() => new("Use this method through the FactorioRconClient.ReadAsync method");
    protected NotSupportedException UseClientExecuteAsyncMethod() => new("Use this method through the FactorioRconClient.ExecuteAsync method");
}
