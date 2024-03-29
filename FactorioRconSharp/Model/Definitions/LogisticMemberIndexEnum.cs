#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("logistic_member_index")]
public enum LogisticMemberIndexEnum
{
  [FactorioRconDefinitionValue("logistic_container")]
  LogisticContainer,

  [FactorioRconDefinitionValue("vehicle_storage")]
  VehicleStorage,

  [FactorioRconDefinitionValue("character_requester")]
  CharacterRequester,

  [FactorioRconDefinitionValue("character_storage")]
  CharacterStorage,

  [FactorioRconDefinitionValue("character_provider")]
  CharacterProvider,

  [FactorioRconDefinitionValue("generic_on_off_behavior")]
  GenericOnOffBehavior,

}

