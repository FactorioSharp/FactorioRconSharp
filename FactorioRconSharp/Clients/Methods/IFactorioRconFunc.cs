namespace FactorioRconSharp.Clients.Methods;

public interface IFactorioRconFunc<TResult>
{
    Task<TResult> ExecuteAsync();
}

public interface IFactorioRconFunc<TParams, TResult>
{
    Task<TResult> ExecuteAsync(TParams parameters);
}
