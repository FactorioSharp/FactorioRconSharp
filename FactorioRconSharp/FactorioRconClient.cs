using FactorioRconSharp.Clients;

namespace FactorioRconSharp;

public class FactorioRconClient : IDisposable
{
    readonly FactorioLowLevelRconClient _lowLevelClient;

    public FactorioRconClient(string ipAddress, int port)
    {
        _lowLevelClient = new FactorioLowLevelRconClient(ipAddress, port);

        Game = new FactorioRconGameClient(_lowLevelClient);
    }

    public bool Connected => _lowLevelClient.Connected;
    public FactorioRconGameClient Game { get; }

    public async Task<bool> ConnectAsync(string password) => await _lowLevelClient.ConnectAsync(password);
    public void Disconnect() => _lowLevelClient.Disconnect();

    public void Dispose()
    {
        _lowLevelClient.Dispose();
        GC.SuppressFinalize(this);
    }
}
