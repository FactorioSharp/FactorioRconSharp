namespace FactorioRconSharp.Clients.Variables;

public interface IFactorioRconVariable<T> : IFactorioRconReadonlyVariable<T>
{
    Task SetAsync(T value);
}