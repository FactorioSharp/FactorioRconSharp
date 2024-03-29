# Factorio RCON

Provide an RCON client for Factorio in C#.
This library provides two clients:
- `FactorioRemoteConsole`: a low-level client that provides direct access to the factorio console, it allows to execute any string in the Factorio console through the RCON connection. 
- `FactorioRconClient`: a high-level client that exposes the runtime API model as C# symbols to help explore and type check the commands being executed

## Quick start

The RCON interface must be enabled when running factorio. It must also be secured using a password.
Add the following parameters to the factorio launch command: `--rcon-port 25575 --rcon-password factory`

For example
```
bin\x64\factorio.exe --start-server saves/save.zip --rcon-port 27015 --rcon-password password
```

You should see a log message in the factorio console that looks like:

```
Info RemoteCommandProcessor.cpp:133: Starting RCON interface at IP ADDR:({0.0.0.0:27015})
```

### Using the console

Once the server is running with RCON enabled, we can attach a client:

```
using FactorioRconSharp.Core;

using FactorioRemoteConsole console = new("127.0.0.1", 27015);
bool connected = await console.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);
```

You should now see a new log message in the factorio console:

```
Info RemoteCommandProcessor.cpp:252: New RCON connection from IP ADDR:({127.0.0.1:57463})
```

### Using the client

The client compiles the C# expressions that it is given into Lua commands that are executed through the console:

```
using FactorioRconSharp;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());

Console.WriteLine($"Map string: {mapString}");
```