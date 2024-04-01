# Factorio RCON

Provide an RCON client for Factorio in .NET Standard 2.1.
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

```c#
using FactorioSharp.Rcon.Core;

using FactorioRemoteConsole console = new("127.0.0.1", 27015);
bool connected = await console.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);
```

You should now see a new log message in the factorio console:

```
Info RemoteCommandProcessor.cpp:252: New RCON connection from IP ADDR:({127.0.0.1:57463})
```

### Using the client

The client compiles the C# expressions that it receives into Lua commands that are executed through the console:

```c#
using FactorioSharp.Rcon;

using FactorioRconClient client = new("127.0.0.1", 27015);
bool connected = await client.ConnectAsync("password");

Console.WriteLine("Connected: " + connected);

string mapString = await client.ReadAsync(g => g.Game.GetMapExchangeString());

Console.WriteLine($"Map string: {mapString}");
```

The specification used to generate the model is that of [Factorio v1.1.104](https://lua-api.factorio.com/1.1.104/runtime-api.json).
The compiler is available in the `SpecificationCompiler` project.

#### Limitations

The client is meant to make writing Lua commands feel as much as possible like writing C# code. However, it is NOT the same.

##### External context

The command cannot use variables from outside the lambda that defines it because the translator that produces the Lua code doesn't have access to that. So the following code will result in an exception: 

```c#
uint index = 1;
string playerName = await client.ReadAsync(g => g.Game.Players[index].Name);
```

To make it possible to use variables from the outside, the `ReadAsync` and `ExecuteAsync` methods can be given a context:
- either a single value: 

```c#
uint index = 1;
string playerName = await client.ReadAsync((g, i) => g.Game.Players[i].Name, index);
```

- or multiple values as a dictionary:

```c#
uint index = 1;
Dictionary<string, object> context = new() {{ "index", index }};
string playerName = await client.ReadAsync((g, ctx) => g.Game.Players[(uint)ctx["index"]].Name, context);
```

**WIP** In a future version, it will be possible to use an anonymous object instead of a dictionary to remove the need of casting the values.