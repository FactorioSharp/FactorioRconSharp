using FactorioRconSharp.Core;

namespace FactorioRconSharp.v1_1_104;

public class FactorioRconClient : FactorioRconClientBase<IFactorioRconModel_v1_1_104>
{
    public FactorioRconClient(string ipAddress, int port) : base(ipAddress, port)
    {
    }
}
