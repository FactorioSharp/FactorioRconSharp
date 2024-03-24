using FactorioRconSharp.Core.Abstractions;

namespace FactorioRconSharp.v1_1_104.Model;

public class FactorioRconMapSettings
{
    [FactorioRconAttribute("max_failed_behavior_count")]
    public uint MaxFailedBehaviorCount { get; set; }
}
