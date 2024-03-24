using RconSharp;

namespace FactorioRCON;

public class FactorioLowLevelRconClient : IDisposable
{
    readonly RconClient _rconClient;
    bool _connected;

    public FactorioLowLevelRconClient(string ipAddress, int port)
    {
        _rconClient = RconClient.Create(ipAddress, port);
    }

    public async Task<bool> ConnectAsync(string password)
    {
        AssertNotConnected();

        await _rconClient.ConnectAsync();

        if (!await _rconClient.AuthenticateAsync(password))
        {
            throw new InvalidOperationException("Authentication failed");
        }

        _connected = true;
        return true;
    }

    public async Task<string> ExecuteAsync(string command)
    {
        AssertConnected();

        return await _rconClient.ExecuteCommandAsync($"/c rcon.print({command})");
    }

    public void Close()
    {
        AssertConnected();
        _rconClient.Disconnect();
    }

    public void Dispose()
    {
        if (_connected)
        {
            Close();
        }

        GC.SuppressFinalize(this);
    }

    void AssertNotConnected()
    {
        if (_connected)
        {
            throw new InvalidOperationException("Client is already connected");
        }
    }

    void AssertConnected()
    {
        if (!_connected)
        {
            throw new InvalidOperationException("Client is not connected");
        }
    }
}
