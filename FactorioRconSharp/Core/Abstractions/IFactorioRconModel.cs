﻿namespace FactorioRconSharp.Core.Abstractions;

/// <summary>
///     Common abstraction of classes representing a Factorio API object.
/// </summary>
public interface IFactorioRconModel
{
    void Load(string value);
    string Dump();
}