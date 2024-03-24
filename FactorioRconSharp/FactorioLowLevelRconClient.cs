using RconSharp;

namespace FactorioRconSharp;

public class FactorioLowLevelRconClient : IDisposable
{
    readonly RconClient _rconClient;
    public bool Connected { get; private set; }

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

        Connected = true;
        return true;
    }

    public async Task<string> ExecuteAsync(string command)
    {
        AssertConnected();
        return await _rconClient.ExecuteCommandAsync($"/c {command}");
    }

    public async Task<string> ReadAsync(string expression) => await ExecuteAsync($"rcon.print({expression})");

    public void Disconnect()
    {
        AssertConnected();
        _rconClient.Disconnect();
    }

    public void Dispose()
    {
        if (Connected)
        {
            Disconnect();
        }

        GC.SuppressFinalize(this);
    }

    void AssertNotConnected()
    {
        if (Connected)
        {
            throw new InvalidOperationException("Client is already connected");
        }
    }

    void AssertConnected()
    {
        if (!Connected)
        {
            throw new InvalidOperationException("Client is not connected");
        }
    }
}
