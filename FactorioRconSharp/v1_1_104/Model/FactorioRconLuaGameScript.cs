﻿using FactorioRconSharp.Core.Abstractions;

namespace FactorioRconSharp.v1_1_104.Model;

public class FactorioRconLuaGameScript : FactorioRconModelBase
{
    [FactorioRconAttribute("map_settings")]
    public FactorioRconMapSettings MapSettings { get; } = new();

    [FactorioRconMethod("is_demo")]
    public bool IsDemo() => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("is_multiplayer")]
    public bool IsMultiplayer() => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("get_map_exchange_string")]
    public string GetMapExchangeString() => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("get_active_entities_count")]
    public uint GetActiveEntitiesCount() => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("get_active_entities_count")]
    public uint GetActiveEntitiesCount(uint surface) => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("get_active_entities_count")]
    public uint GetActiveEntitiesCount(string surface) => throw UseClientReadAsyncMethod();

    [FactorioRconMethod("regenerate_entity")]
    public void RegenerateEntity(string surface) => throw UseClientExecuteAsyncMethod();

    [FactorioRconMethod("regenerate_entity")]
    public void RegenerateEntity(string[] surface) => throw UseClientExecuteAsyncMethod();
}
