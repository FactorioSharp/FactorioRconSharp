namespace FactorioRconSharp.Clients.Methods;

public interface IFactorioRconAction
{
    Task ExecuteAsync();
}

public interface IFactorioRconAction<TParams>
{
    Task ExecuteAsync(TParams parameters);
}
