#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("chunk_generated_status")]
public enum ChunkGeneratedStatusEnum
{
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  [FactorioRconDefinitionValue("custom_tiles")]
  CustomTiles,

  [FactorioRconDefinitionValue("basic_tiles")]
  BasicTiles,

  [FactorioRconDefinitionValue("corrected_tiles")]
  CorrectedTiles,

  [FactorioRconDefinitionValue("tiles")]
  Tiles,

  [FactorioRconDefinitionValue("entities")]
  Entities,

}

