#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// The 'map type' dropdown in the map generation GUI is actually a selector for elevation generator. The base game sets `property_expression_names.elevation` to `"0_16-elevation"` to reproduce terrain from 0.16 or to `"0_17-island"` for the island preset. If generators are available for other properties, the 'map type' dropdown in the GUI will be renamed to 'elevation' and shown along with selectors for the other selectable properties.
/// </summary>
[FactorioRconConcept("MapGenSettings")]
public class MapGenSettings
{
}

