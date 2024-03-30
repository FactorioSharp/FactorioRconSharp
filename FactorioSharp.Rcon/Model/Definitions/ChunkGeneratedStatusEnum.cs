#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

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

