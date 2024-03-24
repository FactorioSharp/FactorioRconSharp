namespace FactorioRconSharp.Clients.Variables;

public interface IFactorioRconReadonlyVariable<T>
{
    Task<T> GetAsync();
}