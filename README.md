# Factorio RCON

Provide an RCON client for Factorio in C#.
This library provides two clients:
- a low-level client that provides direct access to the factorio console
- a high-level client that encapsulates the features accessible through the command console and structures the input and outputs of the command

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

Once the server is running with RCON enabled, we can attach a client:

```
using FactorioRCON;

using FactorioLowLevelRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);
```

You should now see a new log message in the factorio console:

```
Info RemoteCommandProcessor.cpp:252: New RCON connection from IP ADDR:({127.0.0.1:57463})
```