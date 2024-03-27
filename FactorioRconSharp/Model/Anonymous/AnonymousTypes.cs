#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;
using OneOf;

namespace FactorioRconSharp.Model.Anonymous;

public abstract class Type_abdd1f73f7e344ad928f33bca1ee722d: string
{
}

public abstract class Type_9b15866a2d724df8be18b17e2b7e6eb8: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_2d067f1080b442949a099790afe49e07
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_bdc18f7e3ae14a438933ab1b4d197114: string
{
}

public abstract class Type_97a7239727d44c3d97de416383c93f0b: string
{
}

public abstract class Type_8734bcd07b7f467984293371d862557b: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_7d507b6f0b084f4cbccd8d38d39ad834: OneOfBase<string, List<string>>
{
}

public abstract class Type_9d3e2a5929f54cfb979e4b4ac4d44682: DifficultySettings
{
}

public abstract class Type_6113301739ff41dc8c57ef320dff9d8c: EnemyEvolutionMapSettings
{
}

public abstract class Type_b920a6e3215f48b595495435987ce152: EnemyExpansionMapSettings
{
}

public abstract class Type_2f0335d515d144978f73e86ff57952ec: PollutionMapSettings
{
}

public abstract class Type_44412dcacec34fe58c34fb4902328f79: SignalID
{
}

public abstract class Type_f239622db7ab46a79ed04d113395cdb0: LocalisedString
{
}

public abstract class Type_40363f3b3674401b9dfc5d590213304f: MapPosition
{
}

public abstract class Type_ed66b94341564ad5aee9d18f263317c5: LuaEntityPrototype
{
}

public abstract class Type_fb37e09507f04d2bb9bb04ccf408e496: LuaEntity
{
}

public abstract class Type_24dadb327fb2457c91bee5bb48f49aa6: uint
{
}

public abstract class Type_66c81adbcbc9422d8d7b9d9dc5fd644b: TriggerItem
{
}

public abstract class Type_8bfc930be2f74e0e98475ebc2c5c5c92: List<TriggerItem>
{
}

public abstract class Type_ec80cb97806442b8a4e2ce1dbda63b5a: string
{
}

public abstract class Type_9d77503ccaa94cb4bfcb1362789bb58b: bool
{
}

public abstract class Type_044f2878675e4c8e9bc930c93ce0ad86: double
{
}

public abstract class Type_40e8b4d995934c9b8c9579ab18eb85ec: double
{
}

public abstract class Type_1d04263129424fa286b4f19ffc7ce20a: double
{
}

public abstract class Type_31e88c6be1a0426080b327af58a30965: double
{
}

public abstract class Type_29cacea160834fd59133c1e9254232ac: TargetType
{
}

public abstract class Type_c920a2d05064456ead615d0b6c9344b6: string
{
}

public abstract class Type_826b1d127ec6401b81703be32965be74: bool
{
}

public abstract class Type_c0d6583dc62449abafb630eeb826af20: double
{
}

public abstract class Type_cf82d012b3314c1c9ed4bbc142f35daf: LuaTable
{
}

public abstract class Type_1ef144027ec94847957d35888849e92c: LuaObject
{
}

public abstract class Type_3758c6bb999a438a933dc9d3224a6fa7: string
{
}

public abstract class Type_7421b376e6f9412d9c8375291799f5b1: bool
{
}

public abstract class Type_f8ce605560e64f5db1303c6c17d33ca7: double
{
}

public abstract class Type_26ddf414324d4101909f8ec19e315a96: LuaTable
{
}

public abstract class Type_47e3d563b3764cc189497d85c8b20492: int
{
}

public abstract class Type_3b7e26101eec4ce287b6b163a06d4e58: SignalID
{
}

/// <summary>
/// Union of literals:
///   - *
///   - /
///   - +
///   - -
///   - %
///   - ^
///   - <<
///   - >>
///   - AND
///   - OR
///   - XOR
/// </summary>
public enum Literals_f1d353e37e56463b8088746142df84fd
{
  /// <summary>
  /// Literal value: *
  /// </summary>
  [FactorioRconDefinitionValue("*")]
  Multiply,

  /// <summary>
  /// Literal value: /
  /// </summary>
  [FactorioRconDefinitionValue("/")]
  Divide,

  /// <summary>
  /// Literal value: +
  /// </summary>
  [FactorioRconDefinitionValue("+")]
  Add,

  /// <summary>
  /// Literal value: -
  /// </summary>
  [FactorioRconDefinitionValue("-")]
  Subtract,

  /// <summary>
  /// Literal value: %
  /// </summary>
  [FactorioRconDefinitionValue("%")]
  Percent,

  /// <summary>
  /// Literal value: ^
  /// </summary>
  [FactorioRconDefinitionValue("^")]
  Pow,

  /// <summary>
  /// Literal value: <<
  /// </summary>
  [FactorioRconDefinitionValue("<<")]
  Lsl,

  /// <summary>
  /// Literal value: >>
  /// </summary>
  [FactorioRconDefinitionValue(">>")]
  Lsr,

  /// <summary>
  /// Literal value: AND
  /// </summary>
  [FactorioRconDefinitionValue("AND")]
  AND,

  /// <summary>
  /// Literal value: OR
  /// </summary>
  [FactorioRconDefinitionValue("OR")]
  OR,

  /// <summary>
  /// Literal value: XOR
  /// </summary>
  [FactorioRconDefinitionValue("XOR")]
  XOR,

}

public abstract class Type_bb46e89fa3db4cd1ae690531ae0e6285: SignalID
{
}

public abstract class Type_9e6f8264389d4bbab960fff5153bcbe1: int
{
}

public abstract class Type_d366577152344fa2899b9061810b4ced: SignalID
{
}

public abstract class Type_98a2b7d77b2a4b99be0474ae162d5a77: double
{
}

public abstract class Type_4c7cecd844614780bcd6d83f75b999f7: string
{
}

public abstract class Type_c741b85c59f441b5b3306b95b5961bd8: string
{
}

public abstract class Type_d2f42b31a99e47b3b2ec6cffdd7b27be: List<string>
{
}

public abstract class Type_ec0a951dfb3f432ebbec7b7590845691: float
{
}

public abstract class Type_b71257fb5564438a8c1ab2413b352294: AmmoType
{
}

public abstract class Type_fd603ff6c5044ec289c66f9bc4e6cbac: float
{
}

public abstract class Type_33244e348ab440f7b0dece9bd25518fd: float
{
}

public abstract class Type_028834bf60e74c308e2366b3cd267093: float
{
}

public abstract class Type_5fd6e0ff3716486ca661878b2765e9de: float
{
}

public abstract class Type_50ee5c4b994c489f94ba86bbbc03ed67: float
{
}

public abstract class Type_5d973404c69e4917a0ff24b8434a34e1: float
{
}

public abstract class Type_054ad4b622fe4ffda625461bfef73fe6: float
{
}

public abstract class Type_4268ed2476814fdb908fd6ea516ac13b: double
{
}

public abstract class Type_9c6d11ae71044a7fae98ec7dadbb4b83: float
{
}

/// <summary>
/// Union of literals:
///   - center-to-center
///   - bounding-box-to-bounding-box
/// </summary>
public enum Literals_77395830b02b466cb3d03687c2adec7d
{
  /// <summary>
  /// Literal value: center-to-center
  /// </summary>
  [FactorioRconDefinitionValue("center-to-center")]
  Centersubtracttosubtractcenter,

  /// <summary>
  /// Literal value: bounding-box-to-bounding-box
  /// </summary>
  [FactorioRconDefinitionValue("bounding-box-to-bounding-box")]
  Boundingsubtractboxsubtracttosubtractboundingsubtractbox,

}

public abstract class Type_9100cb1e0ef441de888ccd507fb49838: float
{
}

public abstract class Type_c19979b4ac8046caa1feed6ea56131cc: float
{
}

/// <summary>
/// Union of literals:
///   - projectile
///   - stream
///   - beam
/// </summary>
public enum Literals_eda1b911450a4c9b91afff369f2ccda6
{
  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconDefinitionValue("stream")]
  Stream,

  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconDefinitionValue("beam")]
  Beam,

}

public abstract class Type_dd83c8b16eaf4b1281d85e951284537f: uint
{
}

public abstract class Type_9c3c4d0e6ac746b5b0e4fae5eded30cc: Vector
{
}

public abstract class Type_33d3e830571e49e68363ab3d86130eaa: float
{
}

public abstract class Type_530c5fc1752a40b286672fe713d060e1: CircularProjectileCreationSpecification
{
}

public abstract class Type_e6fac2b077604ac6bf3174ae73538dd0: List<CircularProjectileCreationSpecification>
{
}

public abstract class Type_03446a1401214333bba02e6667ab3670: float
{
}

public abstract class Type_08a09ee86e6b407b8b82d912d858080b: CircularParticleCreationSpecification
{
}

public abstract class Type_c102fc7a22b34520b1bd8ba231a3d289: float
{
}

public abstract class Type_1d697ae51d1b415182f7d0af5b1f1d98: AttackParameterFluid
{
}

public abstract class Type_59470113571244f59f4d2c16d3616099: List<AttackParameterFluid>
{
}

public abstract class Type_03ee7e71411b4101906bba7f8159302e: float
{
}

public abstract class Type_88039ad9691d4fa7b045ce5a039094ab: GunShift4Way
{
}

public abstract class Type_78a16aa5398e43a586da60d4669bf6a6: CircularProjectileCreationSpecification
{
}

public abstract class Type_cb1da34a357243d0b53a7a85c90d8cfd: List<CircularProjectileCreationSpecification>
{
}

public abstract class Type_7971ac94c7c346329e860d7a9cd0beec: MapGenSize
{
}

public abstract class Type_eae36e42f32745ac9a0d18901073977e: MapGenSize
{
}

public abstract class Type_439a6935d91b40f8af4eccdf09eab210: MapGenSize
{
}

public abstract class Type_4da75d72096541ed8381ef5896da191d: string
{
}

public abstract class Type_eafa5089961d464fbeaf2b13c30edac0: AutoplaceControl
{
}

public abstract class Type_50ed0a91114d4c7484284af0c61d4850: Dictionary<string, AutoplaceControl>
{
}

public abstract class Type_a546ca2a68c4476ab640169702f1e204: bool
{
}

public abstract class Type_f9687184e99045fbafc7a5732c13932d: string
{
}

public abstract class Type_7fc1ce2a05c14698add7fd9323273619: double
{
}

public abstract class Type_e1b0c3a3520d4804a9f35226cd61173c: bool
{
}

public abstract class Type_dbb91dcaf25e41c697d6e6661a5c6911: string
{
}

public abstract class Type_e72f929e023641bcbbb598dbd8446673: double
{
}

public abstract class Type_85b3b70acd65424bb9fafabe705741cd: string
{
}

public abstract class Type_4522553952d9496cbdbb5c280753df76: AutoplaceSpecificationPeak
{
}

public abstract class Type_e9fc2cee2f354bf9adea26d6c5278a4a: List<AutoplaceSpecificationPeak>
{
}

public abstract class Type_eea732bd68544f11bc25b527e99918a7: uint
{
}

public abstract class Type_fafdda84642942e0b3539b0778df7a06: NoiseExpression
{
}

public abstract class Type_2e9a00876171467c855f400aa0ebf004: double
{
}

public abstract class Type_1622eaf6f61c4fd5b75ca49566459611: double
{
}

public abstract class Type_d78aa5a99e384c398afac0bfd57fe1b9: NoiseExpression
{
}

public abstract class Type_b2fc2a91e916468982073f69c060edd2: double
{
}

public abstract class Type_994de02110fe48179d2fbaa732637625: double
{
}

public abstract class Type_17899346629a4bb881cef07504f9c611: double
{
}

public abstract class Type_e582baff7d8142df8981c043000625ac: uint
{
}

public abstract class Type_723be9aed73547f384eac0da61075d37: AutoplaceSpecificationRestriction
{
}

public abstract class Type_752dfff90df3477c905313d4ceef4f1f: List<AutoplaceSpecificationRestriction>
{
}

public abstract class Type_987a5bca605d42f19f78190bad7f4ced: double
{
}

public abstract class Type_1ebc1db91ab44b51bfc79b3a0c9fba0c: double
{
}

public abstract class Type_91c225cabf9144e88ba5f4a5803983d2: double
{
}

public abstract class Type_39d9f0e92fed42dd80b711e8bf2d4365: double
{
}

public abstract class Type_03290c361ac6451f81aa131686625d0d: double
{
}

public abstract class Type_60b97bf8d3d141c48d78ab0073669da5: double
{
}

public abstract class Type_580cc9db592d4ec99022e3353bba471d: double
{
}

public abstract class Type_e0c7a7bd8849455186510835946ef46c: double
{
}

public abstract class Type_12c1378547074e53a14ee2db7c9d82d0: double
{
}

public abstract class Type_56ee0254530647daac9c3c2e767741d0: double
{
}

public abstract class Type_22639039fdc3429183039ed2a9151a45: double
{
}

public abstract class Type_1157cb3f06974108bf625f4efbe72242: double
{
}

public abstract class Type_fc233649bd174a8bad0c87fbce4d9069: double
{
}

public abstract class Type_4dac3ed362f44187b2c82c9166baaed1: double
{
}

public abstract class Type_c5dcc8e6830b4b2f91ba7e214a5e588e: double
{
}

public abstract class Type_bc93cc8819d245fd91b73e0fbdd778cf: double
{
}

public abstract class Type_1671c16dbd494e34819b5253db9ff632: string
{
}

public abstract class Type_98c294e60b17401cb8a71603cc19d6cc: double
{
}

public abstract class Type_7fd9acfd6960430e82827bd4f47b7929: double
{
}

public abstract class Type_f22f6cb7588643218c60cff8925163fe: double
{
}

public abstract class Type_b26c199369914b8e8efc1f1146ba0238: double
{
}

public abstract class Type_baf8026dace94d648bd33dec048b22dc: double
{
}

public abstract class Type_551636e92d9941daaac97f23d72e6a25: double
{
}

public abstract class Type_1f14128eec684e949e0b99a35a04b151: double
{
}

public abstract class Type_1b0206741ff84de58e72a583a638181b: double
{
}

public abstract class Type_f37bd8a27d2f438cbd940725bd3792df: double
{
}

public abstract class Type_972d64c27dda46edb02ea7cf877c0e86: double
{
}

public abstract class Type_941dfebd8c2f43d5b21d271ba7d4f796: double
{
}

public abstract class Type_d4893c8208904c9c868ffd1388483990: double
{
}

public abstract class Type_bf37d81c41674e3281b84f7321f0340f: double
{
}

public abstract class Type_7cd02e41de934d2a8bab6b4bc7fbe909: double
{
}

public abstract class Type_eacfbbdcc4bf4e3597431d44b617bb9a: double
{
}

public abstract class Type_f0d49f9e2fa54b06b6e523224cf06819: double
{
}

public abstract class Type_a7f4b70a305c4b1f818c17355f40fe7a: double
{
}

public abstract class Type_57c4aaceef39406b89804f03260d7726: double
{
}

public abstract class Type_3e17499e304a4046aab8a8eed5280641: string
{
}

public abstract class Type_3958dfcdbfa242869cf89c225d2bbffc: string
{
}

public abstract class Type_20bc5ac6c8544a118f44ffc47c73bee2: LuaEntity
{
}

public abstract class Type_b4319e21ec4947d6a09802f74e94c69d: MapPosition
{
}

public abstract class Type_05f5b11af0014222af429e49a4b15a3a: BlueprintCircuitConnection
{
}

public abstract class Type_c8279f03e11444fea6ffa09a75c341f8: BlueprintControlBehavior
{
}

public abstract class Type_1decabda1afd4c3ca0640dc2672758c3: DirectionEnum
{
}

public abstract class Type_b01f2d29ae534c1f81ef610838c23c7a: uint
{
}

public abstract class Type_d72acf7343674c4c9197b46d67881503: string
{
}

public abstract class Type_cddc5ecf9c2b4c17bae7ea38d00f2bc2: uint
{
}

public abstract class Type_598e46861d7345929c9ed35c4a59442a: Dictionary<string, uint>
{
}

public abstract class Type_58851841c9114c43a8f3940ef85935e4: string
{
}

public abstract class Type_0cca0a2ba18f4596ac0be53d6f12675d: MapPosition
{
}

public abstract class Type_a676750492cb40d2bc1443f0e5cd2ba5: TrainScheduleRecord
{
}

public abstract class Type_394e40aaa19f4d26af48046cd9471f90: List<TrainScheduleRecord>
{
}

public abstract class Type_a82a08a259564d6aa60c8c9cf8274381: Tags
{
}

public abstract class Type_2d5be2c6ab324166bdc454bd2f77123b: uint
{
}

public abstract class Type_add4813256bc4942844362edbf3f4742: SignalID
{
}

public abstract class Type_76d5f8f21ce141a184311f617f901f20: MapPosition
{
}

public abstract class Type_6174d5ec781f4b5aaba91124a34ce24e: RealOrientation
{
}

public abstract class Type_ffcbd5d3d1f04909a2966e598aa5886c: MapPosition
{
}

public abstract class Table_dc8d8d07229c458ab3082642a7d38ffb
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public abstract class Type_9ad0160ce6d44ad28370a27a45d58834: MapPosition
{
}

public abstract class Type_3812098776434017ac6c657d47f0fd0f: RealOrientation
{
}

public abstract class Type_72fb8ce1d97b457eae81131bbdc597c7: MapPosition
{
}

public abstract class Table_ea2d926222c24d84bea310e63a839be1
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

/// <summary>
/// Union of literals:
///   - throw
///   - equipment-remote
///   - use-on-self
///   - artillery-remote
///   - destroy-cliffs
/// </summary>
public enum Literals_21d38f063cd94d7db6064a4fd784ebda
{
  /// <summary>
  /// Literal value: throw
  /// </summary>
  [FactorioRconDefinitionValue("throw")]
  Throw,

  /// <summary>
  /// Literal value: equipment-remote
  /// </summary>
  [FactorioRconDefinitionValue("equipment-remote")]
  Equipmentsubtractremote,

  /// <summary>
  /// Literal value: use-on-self
  /// </summary>
  [FactorioRconDefinitionValue("use-on-self")]
  Usesubtractonsubtractself,

  /// <summary>
  /// Literal value: artillery-remote
  /// </summary>
  [FactorioRconDefinitionValue("artillery-remote")]
  Artillerysubtractremote,

  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  Destroysubtractcliffs,

}

public abstract class Type_5909790e7c024fddac886197aa8295dd: string
{
}

public abstract class Type_0f6fc4419b604cabbd21c66a29c3f95d: AttackParameters
{
}

public abstract class Type_daa061d4c5c94c008afa9b91c7a8a07c: float
{
}

public abstract class Type_a245b08a827a493492313b77ff065fef: uint
{
}

public abstract class Type_bdb5f6b0a1a548d995f2252e78e766f8: string
{
}

public abstract class Type_15aa31c38f644808bf6e8eb181f6f910: AttackParameters
{
}

public abstract class Type_80fc3c72fde9442c8dc114cc1bec18f8: bool
{
}

public abstract class Type_a9ed4f54b5044c53b4a2e59be667636a: AttackParameters
{
}

public abstract class Type_06171adafc634b2fa1a8c4b092c3b105: SignalID
{
}

public abstract class Type_f524f034950c4807add32dd52cac436b: PlayerIdentification
{
}

public abstract class Type_c60cd1a2fb46480fa98ef2aefc31ced9: MapPosition
{
}

public abstract class Type_b5978d5e15a24770a6615b3b3dedc0f9: string
{
}

public abstract class Type_55d6e68380224e369063d2c9a1130325: int
{
}

public abstract class Type_06a2124bc03a4a1b950ce54e016dffd7: int
{
}

public abstract class Table_adfdacdb8baf4b4997fb8e29cfd0c9a6
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_8af923a9bf19414c9f19edb7f363dd52: int
{
}

public abstract class Type_1445d1071e19491e9f5bdc2e67668fc4: int
{
}

public abstract class Table_75cd2f4401c04355ae57993a4561f2b1
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_2951006139d84ac2a9cfd24270d479d0: BoundingBox
{
}

public abstract class Type_e01690c4a10048fe91b778b8e2b64896: int
{
}

public abstract class Type_95a6c6e4c882484c9de64165a5a998e1: int
{
}

public abstract class Type_cdefd7e000284b32a2144cf81a8be55c: ComparatorString
{
}

public abstract class Type_7913451ceea24dca83f2133fd6c75435: int
{
}

public abstract class Type_62c02ba1ce4544988fd6701ed77ad67e: SignalID
{
}

public abstract class Type_fed19aa6f1c64be8a224492f1ac73e86: SignalID
{
}

public abstract class Type_8bfd8ef7bea44aabb97027a6740b9070: CircuitCondition
{
}

public abstract class Type_9b0d9a2f39c24ac39362618eb030f0be: bool
{
}

public abstract class Type_76abd9cc851e4b0c9c27c10b9c78a8cb: CircuitConnectorIdEnum
{
}

public abstract class Type_dd677340cbf54f118f1b1b7693e6f99b: CircuitConnectorIdEnum
{
}

public abstract class Type_89f998eaae0e45308cc44759cd13686a: LuaEntity
{
}

public abstract class Type_5e6485dc2efb47b89f0c839bd2640265: WireTypeEnum
{
}

public abstract class Type_0f376b7dd6f94f85b6a07b6332fe2037: Vector
{
}

public abstract class Type_7ddd9f545c114c99a67a8fbd2a8b7aa0: double
{
}

public abstract class Type_b02ce923e1964e76acc3b44ef84e9f48: double
{
}

public abstract class Type_7e8dfea2a6ad4658b163da55d4e8a9d9: float
{
}

public abstract class Type_698a92100bb64bd99619e2057fef4c32: float
{
}

public abstract class Type_bb5ffbb5df424534a3651eb2fe86ced5: float
{
}

public abstract class Type_b6e3c5c1fffa4df2925e8732e7c2c9cc: float
{
}

public abstract class Type_b1b382e3982c40609a7d94b1f4c8a4ff: string
{
}

public abstract class Type_c25c6830b8824d1fa3e23026d9767895: float
{
}

public abstract class Type_fe2397dc447448c4b269314559f73e85: float
{
}

public abstract class Type_8d621a7e602c469fbac6acbd02d9cabe: float
{
}

public abstract class Type_ef3b3cae563c40d8a2a4b1789ae8fa3a: float
{
}

public abstract class Type_e389fc6f1628493d809bd0d6a900d057: bool
{
}

public abstract class Type_26c2920c631447d0b1e4f54d44a869b6: float
{
}

public abstract class Type_3cbb31851d914ec2b5887e9af41566a0: float
{
}

public abstract class Type_fc07be475171411ebbd673465ed2f931: RealOrientation
{
}

public abstract class Type_413e9b042bed44a68715e1953e63e7cb: Vector
{
}

public abstract class Type_8e8a7a130ffd4e54a66b940619bfb01d: float
{
}

public abstract class Type_01a43febd3eb4b3bbdddff4707ce10d8: float
{
}

public abstract class Type_676bc762325c4632b389a05928a4e727: string
{
}

public abstract class Type_811831a840ad43e6a53207618e6479d8: MapGenSize
{
}

public abstract class Type_82b86135154544308cb3cf1c3b1ee062: CollisionMaskLayer
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_05ed402ac68e456faa18a0084e2cb3de
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_c369ae228dd7441395ff8555951e8d51: CollisionMaskLayer
{
}

/// <summary>
/// Literal value: not-colliding-with-itself
/// </summary>
public enum Literal_7e14632bec7043e5bfcb3b2a6a6f4c8a
{
  /// <summary>
  /// Literal value: not-colliding-with-itself
  /// </summary>
  [FactorioRconDefinitionValue("not-colliding-with-itself")]
  Notsubtractcollidingsubtractwithsubtractitself,

}

/// <summary>
/// Literal value: consider-tile-transitions
/// </summary>
public enum Literal_2d4a55eedec243e3be6062707c106009
{
  /// <summary>
  /// Literal value: consider-tile-transitions
  /// </summary>
  [FactorioRconDefinitionValue("consider-tile-transitions")]
  Considersubtracttilesubtracttransitions,

}

/// <summary>
/// Literal value: colliding-with-tiles-only
/// </summary>
public enum Literal_2b19e8ada34340108c627034d1ee8675
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  Collidingsubtractwithsubtracttilessubtractonly,

}

[GenerateOneOf]
public abstract partial class Union_706db0ae4f37485e8a5a102fed820cf4: OneOfBase<CollisionMaskLayer, Literal_7e14632bec7043e5bfcb3b2a6a6f4c8a, Literal_2d4a55eedec243e3be6062707c106009, Literal_2b19e8ada34340108c627034d1ee8675>
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_93c6283af7154962b9290e477206ced1
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_eb8adf68cb7d4ac982d2f4b39129b8fd: float
{
}

public abstract class Type_ee330c84946d49be8a65cd88d935d5f1: float
{
}

public abstract class Type_b6b7d578f37f4af18713e537b4e87eaa: float
{
}

public abstract class Type_66ce05c2dd3b4eb3b7bbeb9c5f02beb4: float
{
}

public abstract class Table_ff9525e1833c47b09758f16b409af3b1
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

public abstract class Type_3e55682fec5f4cda916ca6410282fee1: float
{
}

public abstract class Type_69b4e6cc7384414f8d631fddca7cd432: float
{
}

public abstract class Type_112659a1735842b8a3402cfc8ecf9a90: float
{
}

public abstract class Type_252b4d2412cb4f6fae65976555ddf7c4: float
{
}

public abstract class Table_948a475b21a843d5a98b159754b71aac
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

public abstract class Type_e25cc8de77c14a2295388877a989bba7: float
{
}

public abstract class Type_35bc0f0887304684909e2df593bd5778: float
{
}

public abstract class Type_829de7b41544410d9daafbe5b7b0e546: float
{
}

public abstract class Type_a42ba2ae287e470aa5f4797509cb8e3d: float
{
}

public abstract class Table_096a3faa8e2e4f018c42df1414babba9
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

public abstract class Type_77dccb679f0b4beb9763cd32eba21d40: float
{
}

public abstract class Type_a45fb3f36a6a479f824c32b87842ccf9: float
{
}

public abstract class Type_3a8a0c4575c64ad4b8e255676d6fb336: float
{
}

public abstract class Type_791ad97897704a1799b2d74032dd1413: float
{
}

public abstract class Table_f420f7d5bbb4456d9d1e016f088d29aa
{
  [FactorioRconAttribute("r")]
  public float R { get; set; }

  [FactorioRconAttribute("g")]
  public float G { get; set; }

  [FactorioRconAttribute("b")]
  public float B { get; set; }

  [FactorioRconAttribute("a")]
  public float A { get; set; }

}

public abstract class Type_5ee6f08c32c2412c865fe5096cf99355: CommandEnum
{
}

public abstract class Type_f5ebc77e4499468f833b82dec980c030: DistractionEnum
{
}

public abstract class Type_e7b4bcf52f62404aab6cb5b3950233a0: LuaEntity
{
}

public abstract class Type_c186f8daaeaf4647906ad4be48cf0975: MapPosition
{
}

public abstract class Type_3d8bdbc6686d4e298cf0b1bc7a8a5fd6: DistractionEnum
{
}

public abstract class Type_517a1bdbda73417885c3a50ed4530df7: double
{
}

public abstract class Type_00d9488eb4144b4bbf4f6803a928e54d: MapPosition
{
}

public abstract class Type_79f0a683fe114c67820229bb0b14b25a: DistractionEnum
{
}

public abstract class Type_348c69d628434b9ca8bb4433dd66b08c: bool
{
}

public abstract class Type_6c39a93f423341beb39af15bdf4c9b29: Command
{
}

public abstract class Type_d7605fa176be4b74b0390bbd41d2c658: List<Command>
{
}

public abstract class Type_a01c1afbbd0c4255ae907577784d4480: CompoundCommandEnum
{
}

public abstract class Type_c0a7223643804262a394b9cdf0faf01e: DistractionEnum
{
}

public abstract class Type_070b1911382a4406b2822fd99d47763e: LuaEntity
{
}

public abstract class Type_2e0048cf731245f5b38a440857c19d9c: MapPosition
{
}

public abstract class Type_efdce2226a9041d586fdaf841b78d889: LuaEntity
{
}

public abstract class Type_7ca710490064490db8e0bf0de01e10e6: DistractionEnum
{
}

public abstract class Type_0f89d32a27354c4aa7cbb7a85b407968: PathfinderFlags
{
}

public abstract class Type_a2ff9c3f7e464256ac1a9b80eeb59a5d: double
{
}

public abstract class Type_d325f8d938c34d09a9575b59b6bc1304: DistractionEnum
{
}

public abstract class Type_5a40a64d16de4035be5440be613b376a: LuaUnitGroup
{
}

public abstract class Type_8e625f44722943559e0897dc872ad8f3: bool
{
}

public abstract class Type_b33ea2bad7d7462297610c98fc783d7c: DistractionEnum
{
}

public abstract class Type_a933bbc4243746f4a18bb3b1345de96f: uint
{
}

public abstract class Type_18dd2fb1ba5a4ac6b49ca013f10bfde2: DistractionEnum
{
}

public abstract class Type_48a3b93d1617424e9e337088090ca1e9: double
{
}

public abstract class Type_b64d1c42286a4fe781d9ecef96a862a7: uint
{
}

public abstract class Type_32e67888ea264d5b8d22fb6a3892a1a4: bool
{
}

public abstract class Type_89dcd0c48454459ab568979482fd1da3: bool
{
}

public abstract class Type_ca5dafa78c0045aba7c35425168edf9f: string
{
}

public abstract class Type_5856487653944a30b5c4b7df565576f6: ModChangeData
{
}

public abstract class Type_18d1cb2a4a30442d8380a411aacd0492: Dictionary<string, ModChangeData>
{
}

public abstract class Type_4f9cb88e44e94b89b46776077f078471: bool
{
}

public abstract class Type_4102593a748b4365a392960e307bef44: string
{
}

public abstract class Type_b2059eece64047679b0178482d8a0398: string
{
}

public abstract class Type_4a298549d0a8438cae8659add8e9271a: int
{
}

public abstract class Type_14c698470b9444df986c0df9a8443e22: uint
{
}

public abstract class Type_854d5725861347d69de4045d00607583: SignalID
{
}

public abstract class Type_5f224c4f4d434ae282727558d04c4b4c: WireConnectionIdEnum
{
}

public abstract class Type_6dcde9c87e3c418ab2d2c3b4ab1262a8: LuaEntity
{
}

public abstract class Type_57fc628b4ba6491d92b834d3f83b88e8: WireConnectionIdEnum
{
}

public abstract class Type_6bc11dc4300d41bf9fa10410d94cdce5: uint
{
}

public abstract class Type_dab3a44e025d489e9f6b329f9109e681: uint
{
}

public abstract class Type_f4fcfe71b862457ab856ebb0148d837a: bool
{
}

public abstract class Type_cebafddcc61e4f5cbd5f504d8b5ce7d2: string
{
}

public abstract class Type_905d7eed0b7a46d495bcdcd6cf3a025a: string
{
}

public abstract class Type_73fd8235cfe84f5d9c09575101db4bc4: string
{
}

public abstract class Type_2ed50bc195c64cbaaccd47fde9563191: uint
{
}

public abstract class Type_7890c8a3ad004e18b1cf6471389e86f6: uint
{
}

public abstract class Type_cada97fe82be4fd9b50efa48c97c45ef: MapPosition
{
}

public abstract class Type_6ceb0d16bada4bc1a1f24ba5075feac6: LuaEntity
{
}

public abstract class Type_7d52e1a6a1ab4d33a1eceed86ff213a2: LuaUnitGroup
{
}

[GenerateOneOf]
public abstract partial class Union_3cb8fd8aa3af4616bd5fca2e1b28376b: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

public abstract class Type_e1416f13fb1d4f1e91559b49afe5d229: uint
{
}

public abstract class Type_bc9306a1a31242ac964365d3864702c5: uint
{
}

public abstract class Type_836a5c5672cf4b089641cccf11549533: double
{
}

public abstract class Type_215ded8285414db38d6e189e40d54f99: string
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_5f951419aa4441ac94c2837533b5a9a7
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_ecb827ec32824184b92b9355c4f15677: Dictionary<string, Literal_5f951419aa4441ac94c2837533b5a9a7>
{
}

public abstract class Type_04f66a03f2204002bb3448e8f391fcb5: bool
{
}

public abstract class Type_f8fbcb7f6ddb4ed08e413e48e75b0cb2: ComparatorString
{
}

public abstract class Type_b2f8d6f78380496f9c78a6aa58a9e854: uint
{
}

public abstract class Type_057d79c5f1b94e77b7b94231e7270f7c: bool
{
}

public abstract class Type_69d1527f70bb48c39785f71a04e0262c: SignalID
{
}

public abstract class Type_ff50747c2c304ee68e4064c66e266492: SignalID
{
}

public abstract class Type_20134e3464714ff2aeb3735614ca11f4: SignalID
{
}

public abstract class Type_3d7d8f52b04045b6beeb31ad85edbf2d: byte
{
}

public abstract class Type_a187014a8f2a4869a04831c45e680070: string
{
}

public abstract class Type_5f1e1754fdaa415abd113cfb4ce46797: TilePosition
{
}

public abstract class Type_bae9faa11d74417c81696830f57c870d: string
{
}

public abstract class Type_49b65ebc28b54bbbb0d5fb416ef305b5: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_778e9f9a56964564b5d34c98c6a15ba5
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_4e8078cb4f604fbf89edde03fb800f47: CollisionMask
{
}

public abstract class Type_6aadb9f34bc84bf5b65c0edff115a1d1: CollisionMaskWithFlags
{
}

[GenerateOneOf]
public abstract partial class Union_b21b663ae4674871bfd07fffcc1bc6e8: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

public abstract class Type_6266a2c8b5254b468130bd21cf6b5968: string
{
}

public abstract class Type_39f1353e34814fcea49089a91aa4183b: uint
{
}

public abstract class Type_2609ed94cf1544899dfd812e10b0b668: LuaDecorativePrototype
{
}

public abstract class Type_0904ff43f6094600ae5e75407565fc7f: TilePosition
{
}

public abstract class Type_34224f6a5c1849fbb0816c669b3f2d69: DifficultySettingsRecipeDifficultyEnum
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals_7d61362c18764140a0fbda40bb3d417e
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconDefinitionValue("after-victory")]
  Aftersubtractvictory,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

}

public abstract class Type_06b3b15e7df64529aa95238a30a190ed: DifficultySettingsTechnologyDifficultyEnum
{
}

public abstract class Type_6e9fced30ddb4950a32fcd86fc359b6e: double
{
}

public abstract class Type_cfc44bf0b4944c72a48eb2fac2f69be5: uint
{
}

public abstract class Type_7bf45151a0834dd29a94ce68f29b62d7: uint
{
}

public abstract class Type_629610a515a44cbcb3f8732c1853e0eb: CircuitConnectorIdEnum
{
}

public abstract class Type_b204f80501b14656b171d8c4aee967a4: LuaEntity
{
}

public abstract class Type_1fad830e9a2d4d8eb57e1505f38691fc: WireConnectionIdEnum
{
}

public abstract class Type_426a8c454caa4665835e22ba7fb003f1: string
{
}

public abstract class Type_7232b8e46965483781ee7d1e69d2a8ef: ElemType
{
}

public abstract class Type_95836c7281624c3eb2a18b87bfb9259f: double
{
}

public abstract class Type_b2b3f6ae966f4ac2ac4b8406ce65e8a1: bool
{
}

public abstract class Type_ffed643476e14365a159dd9f1c6c3c7c: double
{
}

public abstract class Type_65f22a33fccb4650a6da726247d8e594: double
{
}

public abstract class Type_551be7e6ef954ebb8fa4a5e03083d7df: double
{
}

public abstract class Type_d7c20ad0e2484b8bb2dd18c94e30c72a: bool
{
}

public abstract class Type_c6157eee62c34e96a913a0354570cdfa: uint
{
}

public abstract class Type_dfd76898a6ed4246951be0121ac20294: uint
{
}

public abstract class Type_265447179548465783f39b652ebf1d0f: double
{
}

public abstract class Type_d13185806004435c9c85c7f5504650b7: uint
{
}

public abstract class Type_bf8e9b4903234d54a13c3f304837d80a: uint
{
}

public abstract class Type_c5e98b2ead004c0e827ecc20c79829d4: uint
{
}

public abstract class Type_645dbb0107f74d5a9dfdf7ee060ee47e: double
{
}

public abstract class Type_d2f64fe2c13240dfa54477d776dc5233: double
{
}

public abstract class Type_8e1a66f6da904e20977d258c4b11089f: double
{
}

public abstract class Type_37ce2d24e55d43ac932e5c80bbed0bc8: uint
{
}

public abstract class Type_7e5e0b63b8b141eaba15b863b72dc975: uint
{
}

public abstract class Type_e3bed8d2875a42e18a3f3d43348541ee: string
{
}

public abstract class Type_04b42c0a6f4845bc90fa49475ea9df6a: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_f34326f81f634ae6a100e41e241e331a
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_fd5fd7d4d7604ecb83e44454120c8b56: ComparatorString
{
}

public abstract class Type_cfb0258370f74b00989025b046bf2497: double
{
}

public abstract class Type_846423fa1dd3457b99e34b138b4665cf: CollisionMask
{
}

public abstract class Type_8c981b457fb848fd80368a84e10e642d: CollisionMaskWithFlags
{
}

[GenerateOneOf]
public abstract partial class Union_3dd2502383f144509888a569baf31a53: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - collides
///   - layers-equals
///   - contains-any
///   - contains-all
/// </summary>
public enum Literals_98696e36bd0048cf882e427c80c6d3fc
{
  /// <summary>
  /// Literal value: collides
  /// </summary>
  [FactorioRconDefinitionValue("collides")]
  Collides,

  /// <summary>
  /// Literal value: layers-equals
  /// </summary>
  [FactorioRconDefinitionValue("layers-equals")]
  Layerssubtractequals,

  /// <summary>
  /// Literal value: contains-any
  /// </summary>
  [FactorioRconDefinitionValue("contains-any")]
  Containssubtractany,

  /// <summary>
  /// Literal value: contains-all
  /// </summary>
  [FactorioRconDefinitionValue("contains-all")]
  Containssubtractall,

}

public abstract class Type_efd3e1f2415d4889937bed7f8a48a3df: string
{
}

public abstract class Type_8230fa44f24b4378b0b706447b6bf338: ComparatorString
{
}

public abstract class Type_e29d1472bc7e47ae98265de6a76472be: double
{
}

public abstract class Type_1ed4bbec7878465cb40adcd41a085d0e: EntityPrototypeFlag
{
}

public abstract class Type_804c91089a42413caf41e5dee96cb478: string
{
}

public abstract class Type_f29d57fcd4604998920460e7daad44fc: string
{
}

public abstract class Type_1d6550b19d7e409fbf86826ba94cc22b: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_660b1cde6c5b4a588d2b1e992e780523: OneOfBase<string, List<string>>
{
}

public abstract class Type_d57076b7125c4f56add85eae59df3cd1: ComparatorString
{
}

public abstract class Type_c0f787e3ea6e446892b1c66d1d738839: byte
{
}

public abstract class Type_550223ce023a4893b97d0a423f5b8bea: string
{
}

public abstract class Type_74366432fb08450cae5d1f749c669563: string
{
}

public abstract class Type_2f252dc27f19413997261cfe52bb261a: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_92c51fde42f140ea9a25b7442db39750: OneOfBase<string, List<string>>
{
}

public abstract class Type_16c4652d386c49b2b490e3e6de908c6a: EntityPrototypeFlag
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_8273657b723b4ff0be3b5a6d4f31544f
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_e7410abb4bc2474d9882e9eb5c85096f: LuaEntity
{
}

public abstract class Type_eca924adc6b24cd59a64ef3df835c1b6: LuaEntityPrototype
{
}

public abstract class Type_19391b10f0634cd8afd45a538a0248e0: string
{
}

public abstract class Type_903ca70450ce46d7a219d26f5c402f7d: uint
{
}

public abstract class Type_27c29337c1114d9586f3e637add66c14: uint
{
}

public abstract class Type_74d8971d3b6f49af91a474a21f107ef8: int
{
}

public abstract class Type_80decc36b28446cabf5e2e00ae119a62: int
{
}

public abstract class Table_00e4a96940cb4356a7391fc9a07736a9
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_afb198b61c5846c5959803bf56a34c64: int
{
}

public abstract class Type_cb84e08e371a4c7896529ee7aa7cd688: int
{
}

public abstract class Table_69a3f2c3725c4b04b5d961d8b10f14e6
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_d745a334cb954019bb7596dfeaf32670: string
{
}

public abstract class Type_aae2c1ee246c49fea146914cc20952f4: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_a7f672a7c5254ecfa7ef3cb41020a7f8
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_9c06bec1029347f983e1d4cb9ccf30dd: string
{
}

public abstract class Type_a16f19b0f36b49a696390ffb07196be0: string
{
}

public abstract class Type_5f8f7c2da44d48ac8a9a210d5335ce7b: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_5652b0a1393046a4a82c37e45a6195f9: OneOfBase<string, List<string>>
{
}

public abstract class Type_b8f79a6824d34fdbb05a26aef6cce455: string
{
}

public abstract class Type_816ff9400926421580b53728be155f47: EventsEnum
{
}

public abstract class Type_9a0213b8671b48f384ae908cdbe7f037: uint
{
}

public abstract class Type_7c1d56ff23e5464580e4b6ef7e66e7bd: LuaEntityClonedEventFilter
{
}

public abstract class Type_9134a047e4dc4d089795d46082bf598b: LuaEntityDamagedEventFilter
{
}

public abstract class Type_623830b27e81445e86c003ce6c71f9b5: LuaPlayerMinedEntityEventFilter
{
}

public abstract class Type_d94ce915fc514b05b938b6a22e41bdb0: LuaPreRobotMinedEntityEventFilter
{
}

public abstract class Type_b3a7b4287e6346898a7076c05caec2c9: LuaRobotBuiltEntityEventFilter
{
}

public abstract class Type_96d1f067b225496bb6687f0f087525d1: LuaPostEntityDiedEventFilter
{
}

public abstract class Type_c67a0132e3a247c5888ff3347b66aad8: LuaEntityDiedEventFilter
{
}

public abstract class Type_c7cbd03c047d40c5a9d26126a0a30416: LuaScriptRaisedReviveEventFilter
{
}

public abstract class Type_71c0fc503c6d49e9a63a6521870035df: LuaPrePlayerMinedEntityEventFilter
{
}

public abstract class Type_9cbf29eb7b844f7b86d72d768a466b9f: LuaEntityMarkedForDeconstructionEventFilter
{
}

public abstract class Type_0ec6de476d0c470c8a377e473e77f8ae: LuaPreGhostDeconstructedEventFilter
{
}

public abstract class Type_7bc80e726c98460d9de168f9a54e10c5: LuaPreGhostUpgradedEventFilter
{
}

public abstract class Type_533cb2a1ecb148afa90dbc2fb99f2bd2: LuaEntityDeconstructionCancelledEventFilter
{
}

public abstract class Type_8a3f36c2adff42b3aa0c9366f5e94462: LuaEntityMarkedForUpgradeEventFilter
{
}

public abstract class Type_8afcf9c956dd4a6eb9833aa9fe391da9: LuaSectorScannedEventFilter
{
}

public abstract class Type_c98af008149d4a72a3ec732c6f2707dc: LuaRobotMinedEntityEventFilter
{
}

public abstract class Type_e235e327e06742408987a384881a4866: LuaScriptRaisedDestroyEventFilter
{
}

public abstract class Type_f77bfe4bd3a2450aa4e62ed566afef58: LuaUpgradeCancelledEventFilter
{
}

public abstract class Type_6bb973a2c60d489aa9df691744c4abd8: LuaScriptRaisedBuiltEventFilter
{
}

public abstract class Type_7faaf3075d6f4740b5989e9120a7a3d3: LuaPlayerBuiltEntityEventFilter
{
}

public abstract class Type_f5a380a33a744dcab57463c2591ce7d8: LuaPlayerRepairedEntityEventFilter
{
}

[GenerateOneOf]
public abstract partial class Union_0ed18e18a60f4389a945b10ce162330a: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter, LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter, LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

public abstract class Type_be121c02a4ec4500957e412372e872d1: double
{
}

public abstract class Type_cc38631d7459449db68ff5d555e77445: string
{
}

public abstract class Type_ce2e5ed04a454e318b7599fbaf7f163f: double
{
}

public abstract class Type_f873b634cefa4b8cb760ec38541941af: uint
{
}

public abstract class Type_51346c56ef524f9ebeb9796fce6461ef: Vector
{
}

public abstract class Type_8e104e665ce146d4b59c5b21e7baf167: List<Vector>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals_da378d394a79433e807441deaa88d06d
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  Inputsubtractoutput,

}

public abstract class Type_db60bf1a898041f9b499dc870784c71e: double
{
}

public abstract class Type_d34602cc2f454d768d3f1616e03855a6: double
{
}

public abstract class Type_7998e93d83544d9d9ba1a0e4d1076942: string
{
}

public abstract class Type_abfb674926db47c3a2654738191404d0: bool
{
}

public abstract class Type_7cb66375310544048d9be858f0d6d9e0: double
{
}

public abstract class Type_90e839373f364beab4e048284887d974: double
{
}

public abstract class Type_741e2974cf854ccf8b2c2bd11af43b4d: string
{
}

public abstract class Type_0001aeb09aca4806af8562cb5ea58b74: string
{
}

public abstract class Type_a79a0fd14d41430284c26296b6b9417c: LuaFluidPrototype
{
}

public abstract class Type_4a089a20395045fbb334c380ed94bb56: Fluid
{
}

public abstract class Type_f3896e50f6654d2382d93751f7ce020e: string
{
}

public abstract class Type_11092beb25494eda9e3c2cc47954d4bd: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_a78d1b81a9b44b948b8852b8a622aae8
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_9aa6526acbb143e18ebbe2d0b0f82fcc: ComparatorString
{
}

public abstract class Type_f9cee05d25784c9088c0dfa479b5860b: double
{
}

public abstract class Type_0cad9ffa8f434278b57d6b17414362b2: ComparatorString
{
}

public abstract class Type_ed92a6b8af794bd8a9718ae8708f30ee: double
{
}

public abstract class Type_1c03b1f2d9af4d35a130f8e7d76a1ecb: ComparatorString
{
}

public abstract class Type_7bf13abfa12a4fc4a6ea414f34538ca1: double
{
}

public abstract class Type_9095bc2d90ff44579283455b7bfaa321: ComparatorString
{
}

public abstract class Type_502bfea946b14a67a7312407dd5a2c78: double
{
}

public abstract class Type_57a678bd24ff40aa81489b554680321a: ComparatorString
{
}

public abstract class Type_4d5b5964e16b489ea6dbec2509c60ad7: double
{
}

public abstract class Type_a000023f363b4d3e8467c2de260c0d7b: ComparatorString
{
}

public abstract class Type_fd96b6ecddd6493fa59d2cb3aff368b6: double
{
}

public abstract class Type_2225e70e60fc41cdbb46576cca1f6282: string
{
}

public abstract class Type_9be7d48f8870477883654073d8a23fcc: string
{
}

public abstract class Type_a2704bda47c74bfab3aa60a8c25006f1: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_0ebef2d684384df68a1bb1d89a8b5084: OneOfBase<string, List<string>>
{
}

public abstract class Type_3f61da843365446ba7aee26382820fe9: string
{
}

public abstract class Type_4ea810420c2a4fd59630b4755ee1b011: byte
{
}

public abstract class Type_d187dd8981cc418d938b701527c182b0: string
{
}

public abstract class Type_f2c954a0d88f411baa2d4096acf2aef7: LuaForce
{
}

public abstract class Type_ce37554334224e74953ecabee4a77c2a: bool
{
}

public abstract class Type_4ad51508ff3a4676835ec033d6b2f90b: bool
{
}

public abstract class Type_7afe4747737b453d8a2d6059a3a2d01e: bool
{
}

public abstract class Type_875ed41480464009a185b0a5e110be76: bool
{
}

public abstract class Type_8031624bf2c04db79df5376202798dc9: bool
{
}

public abstract class Type_44b80724d4024fb0b0592d1684d4a2f1: bool
{
}

public abstract class Type_e371fd6a22e641f1a98b97e2ac6043ad: bool
{
}

public abstract class Type_9fda9c0ba8b74a6f8e9972f35022f506: bool
{
}

public abstract class Type_6fe2255c45d5457480087b6bc11e67db: bool
{
}

public abstract class Type_cb56e61648f14a7fb4d4e10fb411d252: bool
{
}

public abstract class Type_79db68954b67409bac266e0698ffbb88: bool
{
}

public abstract class Type_a22063e160f7494faa86ac4d909807d6: bool
{
}

public abstract class Type_042ac8e549054352a5389b721fc195f5: bool
{
}

public abstract class Type_9551bd4ccd304e33b26e30a7b84f468c: bool
{
}

public abstract class Type_95d44e5ec4b74af0a5ee41898bbe67e8: bool
{
}

public abstract class Type_9fb5462d457a42f183928d2c8030b871: RelativeGuiTypeEnum
{
}

public abstract class Type_9aa9d4427219490999caa82e749f4086: string
{
}

public abstract class Type_ae5b964da3a94108bfd3c9c33c8356bb: string
{
}

public abstract class Type_640a2c745be047788b1fbbe57a399a99: List<string>
{
}

public abstract class Type_050c994c641b4b758746ae83767dc67e: RelativeGuiPositionEnum
{
}

public abstract class Type_589773d4a1d644ca9d71a1a0305ded04: string
{
}

public abstract class Type_50abfe4360d64745b6013b7ba5d1105a: uint
{
}

public abstract class Type_f12c44451d43466aaa996b9fb3d134ec: GuiArrowType
{
}

public abstract class Type_49e397d9ec234f1ab24aeae603ec394c: uint
{
}

public abstract class Type_b981d049005b49fabaed5e69b043bfdd: LuaEntity
{
}

public abstract class Type_56de6186ad8243358bdc885b0f4fab94: InventoryEnum
{
}

public abstract class Type_c095279efa2e486793dd2937f7c2cfc0: uint
{
}

/// <summary>
/// Union of literals:
///   - player
///   - target
///   - player-quickbar
///   - player-equipment-bar
/// </summary>
public enum Literals_d53e0a9adf6744b0bd35ad7a4eec0ad6
{
  /// <summary>
  /// Literal value: player
  /// </summary>
  [FactorioRconDefinitionValue("player")]
  Player,

  /// <summary>
  /// Literal value: target
  /// </summary>
  [FactorioRconDefinitionValue("target")]
  Target,

  /// <summary>
  /// Literal value: player-quickbar
  /// </summary>
  [FactorioRconDefinitionValue("player-quickbar")]
  Playersubtractquickbar,

  /// <summary>
  /// Literal value: player-equipment-bar
  /// </summary>
  [FactorioRconDefinitionValue("player-equipment-bar")]
  Playersubtractequipmentsubtractbar,

}

public abstract class Type_bfb8594e3d614b8d9c848d80dbb8a474: MapPosition
{
}

public abstract class Type_ec90265d775745b1b9d1b404293da6d1: int
{
}

public abstract class Type_2f84e812dc6945f38537691ffc16f509: int
{
}

public abstract class Table_ed5a91c2cb6741a4ae7a0c4254ec839f
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_c3949c2fd98a4e1792010c834f7c324f: int
{
}

public abstract class Type_c6fa6e7289ad4d67bf10b666450c910d: int
{
}

public abstract class Table_5b9d9e8bd4164da684d8fb5577e17d1f
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_3b63b72c60b446e6866df412ba880dd8: Vector
{
}

public abstract class Type_cdc4565508424d908ebc653de5856dbb: Vector
{
}

public abstract class Type_3ddb3f8231ab4de990d87d64ce2fb686: Vector
{
}

public abstract class Type_35ed573704da40b89a4fc42245b00bf9: Vector
{
}

public abstract class Type_8f104678429b47f0b8157d282b3e9554: DirectionEnum
{
}

public abstract class Type_ded573051ffa4dc1b7622d870c0ff106: Vector
{
}

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
///   - add
///   - remove
/// </summary>
public enum Literals_f75f1cba6e98411cad0faec8903619c0
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  Atsubtractleast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  Atsubtractmost,

  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconDefinitionValue("exactly")]
  Exactly,

  /// <summary>
  /// Literal value: add
  /// </summary>
  [FactorioRconDefinitionValue("add")]
  Add,

  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconDefinitionValue("remove")]
  Remove,

}

public abstract class Type_b70d94a03b5a41ce8ca49bf9ec266fbc: double
{
}

public abstract class Type_a7b1d9a128cc4d1db9b50de539195054: uint
{
}

public abstract class Type_d6ffb74640bf48f1910fc6616c74000e: uint
{
}

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
/// </summary>
public enum Literals_1cec9eaa54324c379cd053ae1e607fe7
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  Atsubtractleast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  Atsubtractmost,

  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconDefinitionValue("exactly")]
  Exactly,

}

public abstract class Type_15a0e4e54d314775bea7463a9d573c02: string
{
}

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
///   - add
///   - remove
/// </summary>
public enum Literals_be1a045570354d5ba0197758fa42b59e
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  Atsubtractleast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  Atsubtractmost,

  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconDefinitionValue("exactly")]
  Exactly,

  /// <summary>
  /// Literal value: add
  /// </summary>
  [FactorioRconDefinitionValue("add")]
  Add,

  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconDefinitionValue("remove")]
  Remove,

}

public abstract class Type_63d5ca7acc8a4e12885b259c1a4b90ca: string
{
}

public abstract class Type_5143cde8616b487f886571b62b39cac8: double
{
}

public abstract class Type_ce325b8a8a6f46cc86dc28cd07c45a68: double
{
}

public abstract class Type_7809c008c9f645bcac07bd262cb930c1: double
{
}

public abstract class Type_90b8ecce80094728be0ed670c20d03c7: uint
{
}

public abstract class Type_524b0c7a7b874bc297271ea50f2c997e: double
{
}

[GenerateOneOf]
public abstract partial class Union_72b5d03b5fa346ada9757dff92965e7c: OneOfBase<uint, double>
{
}

public abstract class Type_6fc74034642240bcb4114f86edd11eca: string
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals_c6b60a194aca4df890cd6b24aa44a85b
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

}

public abstract class Type_4617be6ffcc248ce920413e272c1d1cb: double
{
}

public abstract class Type_ec0bf508e25448268e68448340405c01: double
{
}

public abstract class Type_bdcd5a7d17eb4fb8b9c2f38e250ed195: CircuitCondition
{
}

public abstract class Type_ec4bae18eb5b4c5ea811da473ab958a9: CircuitCondition
{
}

public abstract class Type_45b324c26cd64f66b3240f35060d6b15: uint
{
}

public abstract class Type_56b2eda1340641669b987c4f14393349: string
{
}

public abstract class Type_598df300ba2b48308de988f146d5eb28: string
{
}

public abstract class Type_028253ea87fc490b960ad17772318d26: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_db9e8988cb4a42c7aa4255fd3d8812dc
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_1332412934e64b94a4da29d17efb93d1: ItemPrototypeFilter
{
}

public abstract class Type_8baad731047d4f7eb63c76bcf4682c8a: List<ItemPrototypeFilter>
{
}

public abstract class Type_83ac92cc34e048b4b65f851108238e24: ComparatorString
{
}

public abstract class Type_50e49f1c495149819fde8843ba5162e3: uint
{
}

public abstract class Type_0416c730b20849c88d1bf8fab7d134f8: ItemPrototypeFlag
{
}

public abstract class Type_2a7687ef0bbf47c2a3599bdf4a1f3efd: ComparatorString
{
}

public abstract class Type_c71000ffcb854ddbbabd87a07a296eae: double
{
}

public abstract class Type_5254785e5d0e4b85bd92dc01104babfe: string
{
}

public abstract class Type_72bfe237b9c24f0e8080fe618c951494: ComparatorString
{
}

public abstract class Type_5233de9aebaf4529bab373e545eab313: double
{
}

public abstract class Type_23d90dd07b7d41d5bfaef37dcc337750: ComparatorString
{
}

public abstract class Type_24fe29bbc13e4bb9839ca3d6ab056f13: double
{
}

public abstract class Type_b21873ab22804d81aca5746f1e60d4a3: ComparatorString
{
}

public abstract class Type_0347d87acab748628152682683a28295: double
{
}

public abstract class Type_f0edfd098c9f492eb0633fb3e399964e: string
{
}

public abstract class Type_0080b326df0b4f0982e24a81f5c2f168: string
{
}

public abstract class Type_44d1d267c20e42e187dd3b919e9ff863: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_7bec163ea57245e889c4753e0f641a24: OneOfBase<string, List<string>>
{
}

public abstract class Type_2395b7dca9a84e458fdfd4e87e959bbb: TilePrototypeFilter
{
}

public abstract class Type_691556671a414c5a919420af130b11e3: List<TilePrototypeFilter>
{
}

public abstract class Type_0b691d8384bf40e591f8a198e372140e: EntityPrototypeFilter
{
}

public abstract class Type_e4f19bb4c9624d1ca51b4e542cc92d3e: List<EntityPrototypeFilter>
{
}

public abstract class Type_de7e0eb4ccfd45918954bdd7af1b2f63: EquipmentPrototypeFilter
{
}

public abstract class Type_9d0a8b5cc6914862845a99d874b585ed: List<EquipmentPrototypeFilter>
{
}

public abstract class Type_e18bb0cfd1214a1e9abc20f6b4820766: ComparatorString
{
}

public abstract class Type_892ab38b4d894727a9dab1eb22b5d529: uint
{
}

public abstract class Type_681589f59994466ea43fb6c72b0a916d: string
{
}

public abstract class Type_ea99843594dc4242821896763e481f66: string
{
}

public abstract class Type_0f9313acbdde482485fb9db180a007b5: string
{
}

public abstract class Type_b701c789bd4f44b3a83cfdfd86bcde7d: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_19d9fc6e99eb4a5daa59fc399a91dadd: OneOfBase<string, List<string>>
{
}

public abstract class Type_ec2e38f33aac4e3985d68fa9e5816483: ComparatorString
{
}

public abstract class Type_81e7d0a11f634a558f7ea37502c5e745: uint
{
}

public abstract class Type_fcb32fe1e9f842d592788c017126b241: ItemPrototypeFlag
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_70acd68533cb4a6293231544934e2b56
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_a0488007686042189a2c7757c7f04ad6: LuaItemStack
{
}

public abstract class Type_a57159b5a1404f0dab0e6b23640b180a: LuaItemPrototype
{
}

public abstract class Type_9a31f6cf26394144a8db0327e6772287: string
{
}

public abstract class Type_c80491cde4434a5f8773cf7c193437b1: double
{
}

public abstract class Type_8968eaf510cd425098503284b788f032: uint
{
}

public abstract class Type_86e3207639044578a3a5f581881dfd94: double
{
}

public abstract class Type_d607816b469d451bac9c4c33aef6c972: float
{
}

public abstract class Type_485fc30a2e964b62b07e043cc73d2c96: string
{
}

public abstract class Type_dde1ea7664fb4440b11ceb798752f334: string
{
}

public abstract class Type_26e6d51e8f7c4d2d9be8ca6c70154412: List<string>
{
}

public abstract class Type_044cac607887429eaefe76a661e6ae29: SimpleItemStack
{
}

public abstract class Type_b57f49e9565643cab61fe06afce5ef4d: LuaItemStack
{
}

public abstract class Type_e9da5853201c41e2beae6bcfc9bbe3d9: InventoryEnum
{
}

public abstract class Type_7efa28fc6fc140ff9e59867c7b9d348a: uint
{
}

public abstract class Type_c1d2201afadd421497ac63b0844b641e: string
{
}

public abstract class Type_88520c6ad9c640708f56e35f65f0069b: double
{
}

public abstract class Type_0105099a5fdd4b7db552798a628790f7: bool
{
}

public abstract class Type_be18adbcd0f4478086287f84696c4b07: LuaObject
{
}

public abstract class Type_6f3a209c0bf84621ab82d0a30755278f: LuaNil
{
}

public abstract class Type_a3d81498bfc34b40a13ed7d094bb0fef: LocalisedString
{
}

public abstract class Type_3a151b8f988e45b5873b413e020d0d0f: List<LocalisedString>
{
}

public abstract class Type_f38a4d29aa6b4db9830a002e47d89a9c: uint
{
}

public abstract class Type_4a6de204769045c7b373c4b200f9c357: uint
{
}

public abstract class Type_4e4cf27fa6104c2e803181b2c21b6ade: string
{
}

public abstract class Type_deda49e70a414880bcb34c41a3dd1a14: uint
{
}

public abstract class Type_a6ff881758cb43a9b3359d9ce37e983d: uint
{
}

public abstract class Type_0e58d88e87d846288703face567ec555: string
{
}

public abstract class Type_05f6e460d52940c090b6dd2425bf4952: uint
{
}

public abstract class Type_6a782766422b48d2bcbc9468821cc603: uint
{
}

public abstract class Type_56f51ab5d1004a68bf4e5594f265e182: uint
{
}

public abstract class Type_4a30d0bbd3274126a9575592acaf9f9c: uint
{
}

public abstract class Type_555e5debca0646b6a48729d65b50dbab: LuaLogisticPoint
{
}

public abstract class Type_71de32f11c2c4c4d942f6981dec6b1e0: List<LuaLogisticPoint>
{
}

public abstract class Type_6133bc76f3204a7595497b997ebfeccf: LuaLogisticPoint
{
}

public abstract class Type_2979877f58224442a2abf46f88678e61: List<LuaLogisticPoint>
{
}

public abstract class Type_2e53e9a0a9b34080b6f49ad5eb2c303d: LuaLogisticPoint
{
}

public abstract class Type_ea80fb41215148e6999623e898519677: List<LuaLogisticPoint>
{
}

public abstract class Type_c4a96303d687421a934f7389fe62a9ba: LuaLogisticPoint
{
}

public abstract class Type_0a966cdc4fcd41ea9bdd422caf0b8c8d: List<LuaLogisticPoint>
{
}

public abstract class Type_d36a86a876144c49af5831d33e900dec: double
{
}

public abstract class Type_b65a18a740214fd1936b21456f45b0e3: double
{
}

public abstract class Type_371823fcc4e74ef5a91532990b47ae8b: string
{
}

public abstract class Type_927b274776f5466daf4dce969d260ae2: double
{
}

public abstract class Type_adcb065d3699419ea097d590b4a42b9b: string
{
}

public abstract class Type_e3c832c826284fe496769d9a7bed0c20: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_4d8984c35b6b4be88bb5261c27962435
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_4276d155b2d542af812e47e1203cc31e: string
{
}

public abstract class Type_d3c28e40bc5747298499ca16b943c1c5: string
{
}

public abstract class Type_dcb3a7ad10324f7196d6c63437781f5d: string
{
}

public abstract class Type_cf7697dc46f3418598e9da4edadb1e95: string
{
}

public abstract class Type_39c974d2c58d4371b272e2461830e5c8: string
{
}

public abstract class Type_416076902b80415c89a7c74ecdea8712: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_dee25834b0114c72ae37091cc69edf0f
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_13457e139d19469d808e7bd9fcbc9517: string
{
}

public abstract class Type_3df73b25807a4c6d801eb28522f8e884: ComparatorString
{
}

public abstract class Type_c28208fd26de41c794b15c798639b6c7: float
{
}

public abstract class Type_3219cd9c950f4e5b85cf6a3eb22d1893: ComparatorString
{
}

public abstract class Type_164e977634bf4d30aadde2f7cb80a8c3: float
{
}

public abstract class Type_67e6d752e9f642a394bbce340ef4e31e: string
{
}

public abstract class Type_420d0dffbc5b41de9c82082ee34d00cd: string
{
}

public abstract class Type_b7459026619d479bb5a84a67a0469f5c: string
{
}

public abstract class Type_de549dd761f84158a76c55da18291a5a: ComparatorString
{
}

public abstract class Type_9250cfe0659345559b7e53ab256d1f9a: float
{
}

public abstract class Type_093cedce4efa441481aca4aebce5ed34: string
{
}

public abstract class Type_0817405acd374f46a88ad200699abbcc: string
{
}

public abstract class Type_8de2f3b250ba442da08cc953b6fd0c49: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_1fb9cd213f9f489e934aae4102505af8
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_a882b4fc3258453a868e52514d94aecc: string
{
}

public abstract class Type_32bc15d0ce014375a4bd51bd022065c5: string
{
}

public abstract class Type_ac066fe86457425e997f9e85b6b038d0: string
{
}

public abstract class Type_a7b6e45119e248289343b1e81c021df5: string
{
}

public abstract class Type_d9ca918e8bfc4a24b934062cfdf77aa8: string
{
}

public abstract class Type_62cc029ceccd490a8ddf3bddcd076943: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_8d221a5a21804309bb4f3e1487343369
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_626a40eb68b44b119fba7cfd72da415e: string
{
}

public abstract class Type_31ebb30a78f34dd594ca880f75173710: string
{
}

public abstract class Type_a7194fd2d5744dee993142989d5d7fd2: string
{
}

public abstract class Type_766afaabe2c540c1b52bc4188d9ac381: string
{
}

public abstract class Type_0c774125d31f4f6fa60fc9ddc08eb228: string
{
}

public abstract class Type_e95fbfe2d030495b8f961e4dcfe7fcb5: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_ac3cd229108c4e6ba72094f556315f23
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_10d8c7114eb5453f9db3154673efeb34: string
{
}

public abstract class Type_84409ba6473e4a8aa346bb3b28658dd5: string
{
}

public abstract class Type_e1e6ee58ac544cf1b975d72f0e0f95d4: string
{
}

public abstract class Type_d6ddfecad0cd4e6990cdf4112b5a5ac2: string
{
}

public abstract class Type_6aac617efb444f2ea859763c79b75bb1: string
{
}

public abstract class Type_ff19994245b845cd8be8d3ba5e34543d: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_1764d78100d74f0f8b072dfd42794b12
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_7e2681309cf84eb79fffafe5d3e966be: string
{
}

public abstract class Type_b37a2f0b38b044dcbdd4b2e39347e67e: string
{
}

public abstract class Type_3645168b4eaf4501ac50e925ede7cf65: string
{
}

public abstract class Type_c6c76e3b28ef4fabb97b7551b1469f96: string
{
}

public abstract class Type_62f084d0ee6b4cf38004fbf30422dd32: string
{
}

public abstract class Type_e68ab0b1eb4b4607b9662f5b8b3f8cc0: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_744776ca75904667a7b8f1d035334ebd
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_276f1edd822f4fe5a3ebc3834a9bec52: string
{
}

public abstract class Type_83427fe4f02b48df8530f7038cc18e8a: string
{
}

public abstract class Type_a4c27ebcbd594ac1b2256e25d28700af: string
{
}

public abstract class Type_a28665dc43964a14b9980090c9dd9a15: string
{
}

public abstract class Type_c24c4d9ee0dc4277931dd6557d1ad0e6: string
{
}

public abstract class Type_fd38d4a182b44d1f80a66ab3fde2e79f: string
{
}

public abstract class Type_799a47977a374d9aa974e7568c620a96: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_9729ebf796c14838bfdf952fc3f139f6
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_92680ff79b98429a9f156dbcf21270bb: string
{
}

public abstract class Type_e35df92f8a234a0f9240814808473fe9: string
{
}

public abstract class Type_9399ac3828cd4e148681887da3ce95f4: string
{
}

public abstract class Type_75644c17e44f4170ae6b2a850df7fa89: string
{
}

public abstract class Type_3a3ed292b1f44c3b857ccaa7acec0a7d: string
{
}

public abstract class Type_28b153a6cc8944019c8888bf7631a422: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_dfb938163d374fca880177030519782f
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_4d18f1085d8b419b82cb27f391d20d77: string
{
}

public abstract class Type_5b725941e885434991291c13862fa8fc: string
{
}

public abstract class Type_1110e57af7c0431ab32f63d64abadecd: string
{
}

public abstract class Type_dc337c9b2c734da491946dd45f2e814a: string
{
}

public abstract class Type_a53d36eeb52e41f082cb70f81991b889: string
{
}

public abstract class Type_61b4035a3ccb4af6ab85b804a7d14dd5: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_3bff53f7c93e4927989752abada48ffa
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_ed09558c7f284de0bf72d2b7d6ba015b: string
{
}

public abstract class Type_459cb16a7418474ca0e4838c953bf294: string
{
}

public abstract class Type_62b8d638717842898f5a68cec6c46770: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_8b8769f9269e4f11940ac0a0bb42e229
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_3d63a45bfaea46c0b469904edc09d99f: string
{
}

public abstract class Type_64fd1e73f9104e2c9c00aadce2949ef8: string
{
}

public abstract class Type_42dd86bb758241379e87faee33bb50a5: string
{
}

public abstract class Type_63083c1c332d4f43925a629c6d5ccb44: string
{
}

public abstract class Type_0457e9db390f42829858e91bc802ea6b: string
{
}

public abstract class Type_0b944158ee5c4459abdd97e9bb92c76b: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_3fb9c9469f79499691f0a04cd3782213
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_1ad97c12ea8a4830a6ffbb7fd21d3f9d: string
{
}

public abstract class Type_d3694136046544cd936cf11754b20d2e: string
{
}

public abstract class Type_3c91dae1c18a4c36bb0bd359fc811ef9: string
{
}

public abstract class Type_a7bd6de916e142269fab8f8c3f2fc4b7: string
{
}

public abstract class Type_453cf920f402469ea352c295b5241115: string
{
}

public abstract class Type_152850ecc21b446bb0b7ceaed58f5d10: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_52c590b0ad674116822fa026a6bc3c8d
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_02459740405740c5b4ddb1bc9aa65657: string
{
}

public abstract class Type_0883d6c7ea614590bb03f1eb1161cc2b: string
{
}

public abstract class Type_861af5306b244201b49a7cc68f4b4b00: string
{
}

public abstract class Type_12ddc8c90f954764955f0db17d53750a: string
{
}

public abstract class Type_39a2331756674fbf80e7c61b8642e47a: string
{
}

public abstract class Type_64df791f4480479081693dc010604719: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_01e7255625384b65acca35c0d0ef0779
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_1d6138e573ec44ee8de927c21ec5b716: string
{
}

public abstract class Type_28e4f9c0162f4ab7ba151c87934410ac: string
{
}

public abstract class Type_5a5e99e97ab940b3894fece58843c7d1: string
{
}

public abstract class Type_0148e645b72f4e1a947cacb0620f7143: string
{
}

public abstract class Type_2479430ed1e7457bb83775c550abfc04: string
{
}

public abstract class Type_0789b91880134f0991c2ab4c1ce7481a: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_e6a5e2c1aca14654a582d1f8272a0ee7
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_6eb6d89b265748f3ad7b7272492698fd: string
{
}

public abstract class Type_2bc7f63b38e14b5b9d515f5cb6606276: string
{
}

public abstract class Type_c2659dce883043fe9a0997aa22446ca2: string
{
}

public abstract class Type_49a3b6ad21554a218b2209b033572670: string
{
}

public abstract class Type_9c981cffb1094fcbb836cde67b2e3d54: string
{
}

public abstract class Type_7b8129e8c1b84642a52c398b06019e9d: string
{
}

public abstract class Type_4e8a3756e020446a82eabe6cbd1048f3: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_5d48c93bbba14b5e95e70e66bbdb93ac
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_6842daa8f36f462eab6808b1b60204d9: string
{
}

public abstract class Type_29ac76359bf048568eb212423bb284b9: string
{
}

public abstract class Type_73f7ecf96f36491eb86edd8244c0ac77: string
{
}

public abstract class Type_c2a76b59c35140509f594cf00f1898f9: string
{
}

public abstract class Type_20e05702a57748359718ba07d1910ccf: string
{
}

public abstract class Type_e46190cbe4aa4f72a2c7c28c164f911f: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_fe3d5914e5454beb9974f9f8a8423ec2
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_d385a310fa804bf8bd82330e310bbd03: string
{
}

public abstract class Type_72969bc8d2f64cf98a5c19a1244688eb: string
{
}

public abstract class Type_c4b49e2596884cccb8501c80975cb83f: string
{
}

public abstract class Type_0545020b84884ec9a6aa5dc083028238: string
{
}

public abstract class Type_71c1b4074f24420d8cd1919895d78096: string
{
}

public abstract class Type_3f6ac8f6b62f47aaaceeaf465c5dd660: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_ec615ff95e4849bd840472f9461c89bc
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_14b4492cb1654d36a3b1dda84eddf572: string
{
}

public abstract class Type_33a34368e34549448e43904ccd27b0dc: string
{
}

public abstract class Type_0a5e4550a3d0432bad170876d930264e: string
{
}

public abstract class Type_dc596cc8928044148dea711400820e07: string
{
}

public abstract class Type_abfb24a9aa60433cbeea9d78e63b8bbe: string
{
}

public abstract class Type_7f11007454c4477392f8a278d1e87424: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_226742afd4474b79b44de0d24d75c56b
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_1f55a40261fc43db9c09ef5dd0eb0589: string
{
}

public abstract class Type_7ba8d176ef1b400196133aba605bc9f1: string
{
}

public abstract class Type_087fa4974b9041ac97951c4488b43372: string
{
}

public abstract class Type_76f92fb81be145bd9c6a86435bef1edf: string
{
}

public abstract class Type_03a4352461724a2bbe228ebca08d3e34: string
{
}

public abstract class Type_eab61c12a7f947b787191329d9904b34: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_b478c449968641b7a35d8be36e287705
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_644c6385f3b247e498e69ed8b8b2aae2: string
{
}

public abstract class Type_5ebde6125fbf490790c9e29b1ef293e4: string
{
}

public abstract class Type_a26a4ea561b94f5da85d48a48666f904: string
{
}

public abstract class Type_8908841fedf640cbbadfecc84a8b59c4: string
{
}

public abstract class Type_eef0824e770546bdbc12bc7180b6a786: string
{
}

public abstract class Type_e230d7b05bfc4acfac2623cc4f5b7163: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_049ee2231ed24eb48dde867119e56856
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_b2ddcc1332db4082b5c4eb0b22c80018: string
{
}

public abstract class Type_df0d2ec318a341648dad5a07e543cc26: string
{
}

public abstract class Type_9d44b358fa2749f3acbc4db7352cbd2e: string
{
}

public abstract class Type_96f4ee78264544af9c98390dfe91c37e: string
{
}

public abstract class Type_9cb6b30af0e94bd6991c04f01a71d15f: string
{
}

public abstract class Type_a522d1a824f14bfdb18d4b2ea1dda17e: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_0e4f9101fd7f435e86c70a7c38becbc5
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_fa95b811b2714653acd2f2a06ce90190: string
{
}

public abstract class Type_2a0978f0043e4deda5f9155a3921793b: string
{
}

public abstract class Type_3f0eee54060a4da7a95f2651d2b0a748: string
{
}

public abstract class Type_2252ed5c8e3848539c4e6fdc67c55b69: string
{
}

public abstract class Type_70608b89908046b19d41552f8e5bad48: MapDifficultySettings
{
}

public abstract class Type_36d94a27a0f04427be2734ecab0e939c: EnemyEvolutionMapSettings
{
}

public abstract class Type_2a96e0493f7a4a1e90a844d4eda067d8: EnemyExpansionMapSettings
{
}

public abstract class Type_5158bae7d0974f08bb77605cca61cb15: uint
{
}

public abstract class Type_24808d0760f640d2b501fca38b49f0a2: PathFinderMapSettings
{
}

public abstract class Type_0efd6e0dcce14397a2145b029cf12997: PollutionMapSettings
{
}

public abstract class Type_86a279ee1d994f09859a86ca58655c45: SteeringMapSettings
{
}

public abstract class Type_9b080ea485c8418797a5b090ac015fc6: UnitGroupMapSettings
{
}

public abstract class Type_62140d9e5acb42c28c9a12eadbecb3f4: DifficultySettingsRecipeDifficultyEnum
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals_569f88425cc64efba2968dda0198df13
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconDefinitionValue("after-victory")]
  Aftersubtractvictory,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

}

public abstract class Type_07bf6d72ddf24327aa3e796e13b7c581: DifficultySettingsTechnologyDifficultyEnum
{
}

public abstract class Type_fed2fa7ae6504e198c6a3027bad0c352: double
{
}

public abstract class Type_16fb26027dd3429bae43726348d270b2: MapGenSettings
{
}

public abstract class Type_778a4f107b38475a867e59a78dc87851: MapAndDifficultySettings
{
}

public abstract class Type_3ed1468e0d3d4913a1f7bc7eec09e6e9: AdvancedMapGenSettings
{
}

public abstract class Type_2e8beb53b65244fbb6ffb484d1860ccb: MapGenSettings
{
}

public abstract class Type_75d53cbf4b894b66a0e356f7ab2e315b: bool
{
}

public abstract class Type_e4b551533bba4eb4a11be0e2f0c13fb1: string
{
}

public abstract class Type_6840265b956a4adf95ac6891cd4a679a: string
{
}

public abstract class Type_6be38c15032a42e8ab375d3576f27fd7: AutoplaceControl
{
}

public abstract class Type_fc3368703adc4e62b3da2fd5ae77bf91: Dictionary<string, AutoplaceControl>
{
}

/// <summary>
/// Union of literals:
///   - entity
///   - tile
///   - decorative
/// </summary>
public enum Literals_878e3f848e804a38845160655e05ea06
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

  /// <summary>
  /// Literal value: tile
  /// </summary>
  [FactorioRconDefinitionValue("tile")]
  Tile,

  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconDefinitionValue("decorative")]
  Decorative,

}

public abstract class Type_31f633ef4dec44e3b57445ca1e0a8781: AutoplaceSettings
{
}

public abstract class Type_0fdc96fc661a4358b576e375d5cc9c7d: Dictionary<Literals_878e3f848e804a38845160655e05ea06, AutoplaceSettings>
{
}

public abstract class Type_e7bdf50f60694531950088cfefdd8393: CliffPlacementSettings
{
}

public abstract class Type_a5d7e2705854416b8170341de36fd1d2: bool
{
}

public abstract class Type_a1eaf2033c4e48d9ad096271562213a4: uint
{
}

public abstract class Type_9ad9746de4ea40b6b6bbfac9c9b64498: bool
{
}

public abstract class Type_7a2393b64e1a47118199a5f81602b218: string
{
}

public abstract class Type_8ee1abc950fe43a18468713a23b9b0db: string
{
}

public abstract class Type_787d7e312d5a4d3ba8acb379d95512c6: Dictionary<string, string>
{
}

public abstract class Type_8dbc6698a3d04a69a7dd4109a8fa56a3: uint
{
}

public abstract class Type_e44f59006d4141399aa4c7dc4f8efc67: MapGenSize
{
}

public abstract class Type_33847893c879472dbc95ef570626f2bd: MapPosition
{
}

public abstract class Type_c07db804cf1548b6acc0ed0ddbafe894: List<MapPosition>
{
}

public abstract class Type_020bcad03fc243b2b07937b1ac9189d0: MapGenSize
{
}

public abstract class Type_99ea4ee173064ed0af37076efa9f5b9a: MapGenSize
{
}

public abstract class Type_b741f6b8fe9a46da8ca0024f53850ac1: uint
{
}

public abstract class Type_df2a40f3219b465f965a2b1bb3353722: float
{
}

/// <summary>
/// Literal value: none
/// </summary>
public enum Literal_f30eb622d040419eaa8d58740838aabc
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

}

/// <summary>
/// Literal value: very-low
/// </summary>
public enum Literal_e51c581fc1a34fb39011f02ae3ad4eec
{
  /// <summary>
  /// Literal value: very-low
  /// </summary>
  [FactorioRconDefinitionValue("very-low")]
  Verysubtractlow,

}

/// <summary>
/// Literal value: very-small
/// </summary>
public enum Literal_102b380c45344ac383740a26f6ab1e09
{
  /// <summary>
  /// Literal value: very-small
  /// </summary>
  [FactorioRconDefinitionValue("very-small")]
  Verysubtractsmall,

}

/// <summary>
/// Literal value: very-poor
/// </summary>
public enum Literal_e43b361f899a45ddba10f1eca5d38cda
{
  /// <summary>
  /// Literal value: very-poor
  /// </summary>
  [FactorioRconDefinitionValue("very-poor")]
  Verysubtractpoor,

}

/// <summary>
/// Literal value: low
/// </summary>
public enum Literal_115914cc1e104744aa75a0fdf4f2dca1
{
  /// <summary>
  /// Literal value: low
  /// </summary>
  [FactorioRconDefinitionValue("low")]
  Low,

}

/// <summary>
/// Literal value: small
/// </summary>
public enum Literal_616300625ab84e489d9fe5a1f02d9e6d
{
  /// <summary>
  /// Literal value: small
  /// </summary>
  [FactorioRconDefinitionValue("small")]
  Small,

}

/// <summary>
/// Literal value: poor
/// </summary>
public enum Literal_a0111335fcc74b7baca051ed86540c1c
{
  /// <summary>
  /// Literal value: poor
  /// </summary>
  [FactorioRconDefinitionValue("poor")]
  Poor,

}

/// <summary>
/// Literal value: normal
/// </summary>
public enum Literal_51b682aeef244d4b930d9a78557a26dc
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconDefinitionValue("normal")]
  Normal,

}

/// <summary>
/// Literal value: medium
/// </summary>
public enum Literal_0040f0baa4a94329b81a42986e8810a0
{
  /// <summary>
  /// Literal value: medium
  /// </summary>
  [FactorioRconDefinitionValue("medium")]
  Medium,

}

/// <summary>
/// Literal value: regular
/// </summary>
public enum Literal_99ad6bbdf8924229a61dc2c5917ee807
{
  /// <summary>
  /// Literal value: regular
  /// </summary>
  [FactorioRconDefinitionValue("regular")]
  Regular,

}

/// <summary>
/// Literal value: high
/// </summary>
public enum Literal_488d1f1551424c3a815a5ca30414a0e7
{
  /// <summary>
  /// Literal value: high
  /// </summary>
  [FactorioRconDefinitionValue("high")]
  High,

}

/// <summary>
/// Literal value: big
/// </summary>
public enum Literal_369219cc278d46a996eddcf902fc14f3
{
  /// <summary>
  /// Literal value: big
  /// </summary>
  [FactorioRconDefinitionValue("big")]
  Big,

}

/// <summary>
/// Literal value: good
/// </summary>
public enum Literal_1c132724e24743b0a3b56de070d7c093
{
  /// <summary>
  /// Literal value: good
  /// </summary>
  [FactorioRconDefinitionValue("good")]
  Good,

}

/// <summary>
/// Literal value: very-high
/// </summary>
public enum Literal_c538f795210b4f0ea9262a285bb75415
{
  /// <summary>
  /// Literal value: very-high
  /// </summary>
  [FactorioRconDefinitionValue("very-high")]
  Verysubtracthigh,

}

/// <summary>
/// Literal value: very-big
/// </summary>
public enum Literal_b6406933cc45404f8e579ab0a8430e85
{
  /// <summary>
  /// Literal value: very-big
  /// </summary>
  [FactorioRconDefinitionValue("very-big")]
  Verysubtractbig,

}

/// <summary>
/// Literal value: very-good
/// </summary>
public enum Literal_17801df5a2ec4c8480e7f41bbaeb0edc
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  Verysubtractgood,

}

public abstract class Type_5aa1588088644ceeb7ba13ef93ae293a: double
{
}

public abstract class Type_c5317695019c4e7c8875157a4dc25ca0: double
{
}

public abstract class Table_f8f9042231a64563aea53ee8049fe941
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public abstract class Type_7364afe56dc049258a06ecadb687e6f6: double
{
}

public abstract class Type_8d6306c74fff4f8492c6be4209225544: double
{
}

public abstract class Table_3f1f6a36282f4bcd95cd34727289f81d
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public abstract class Type_59d8c45f757b46519d62cadbc91a4f7f: EnemyEvolutionMapSettings
{
}

public abstract class Type_afde2729335b46e0998ce8b51628f61d: EnemyExpansionMapSettings
{
}

public abstract class Type_edb3076677624e9d98ab392f1a7c8acf: uint
{
}

public abstract class Type_b7f17ad1e47f42ee980f811c9123dcc7: PathFinderMapSettings
{
}

public abstract class Type_857d5d02f24149baadd1d031aa55f6d3: PollutionMapSettings
{
}

public abstract class Type_7e56224a19fc4c18b120202f12541712: SteeringMapSetting
{
}

public abstract class Type_fd483c20c18b4129b2632e2e1f8a66f6: UnitGroupMapSettings
{
}

public abstract class Type_5fb867f7352840e3b4c2321673157ad1: bool
{
}

public abstract class Type_351f7c8d8b4f40838cd1e6562b2fb2e1: bool
{
}

public abstract class Type_3b8ced250ced4ee9aa81127995d4e6cb: bool
{
}

public abstract class Type_e8eeb73faf3745a788a31a153eab6ab7: bool
{
}

public abstract class Type_be76613f79fe463496851d9cd12409ee: bool
{
}

public abstract class Type_cdba247a3f6946fea8b19d1a6be229fa: bool
{
}

public abstract class Type_b70e1ce9e6094a78aa1eca4638dcbb52: bool
{
}

public abstract class Type_f76b5ae1441a4a73ab1e791485e76a4a: bool
{
}

public abstract class Type_7d918bd2c9134f8e9c0830bfb7ea0ce7: string
{
}

public abstract class Type_fab77a5fad994390bd6f0ce2e77efd7c: string
{
}

public abstract class Type_d0ae3d6612c54f81b950fb9d550e8f50: int
{
}

public abstract class Type_12e780749cc3444ba4232d77f055d923: double
{
}

public abstract class Type_effe2b91ca264a47986eb1943071ac13: bool
{
}

public abstract class Type_18aecb65952244c783fae65b9a7c54b1: string
{
}

public abstract class Type_bc30ede6868f4ad38a6c222858df7232: Color
{
}

[GenerateOneOf]
public abstract partial class Union_7dae5421dcdf4e3393ebacae55f87ddd: OneOfBase<int, double, bool, string, Color>
{
}

public abstract class Type_28685ed692f94eedad3ebb7c991b834e: string
{
}

public abstract class Type_7d879c51e4594919ae5c6dfd578c74a3: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_879f658a4f9c49629f1ff292facc779c
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_da40b020ba504275be4c16ae001953f1: string
{
}

public abstract class Type_ad78f291082e4879821ae68813163766: string
{
}

public abstract class Type_d53948c5af844aad9430a3189978586f: string
{
}

public abstract class Type_5ae446bea5194814b0d15bbaa3cb8245: string
{
}

public abstract class Type_994fa4f8a39f4ce0b727a337eff1b072: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_b0eace84fc86415da71c2ef3fa4755e5: OneOfBase<string, List<string>>
{
}

public abstract class Type_975ff64ef2404937882d4b4c57139a3f: float
{
}

public abstract class Type_99f310f2b9bd4509acf484877aa891bf: ModuleEffectValue
{
}

public abstract class Type_028b303d743d4ee3a661e2ff42d91f0f: ModuleEffectValue
{
}

public abstract class Type_2173aa188d584573bf0d923d9f2221e2: ModuleEffectValue
{
}

public abstract class Type_506c1a10f20e4056907db665e477b434: ModuleEffectValue
{
}

/// <summary>
/// Union of literals:
///   - left
///   - right
///   - middle
///   - button-4
///   - button-5
///   - button-6
///   - button-7
///   - button-8
///   - button-9
/// </summary>
public enum Literals_c1b9e6b754d54cd4ae28c3f6f44471b7
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

  /// <summary>
  /// Literal value: middle
  /// </summary>
  [FactorioRconDefinitionValue("middle")]
  Middle,

  /// <summary>
  /// Literal value: button-4
  /// </summary>
  [FactorioRconDefinitionValue("button-4")]
  Buttonsubtract4,

  /// <summary>
  /// Literal value: button-5
  /// </summary>
  [FactorioRconDefinitionValue("button-5")]
  Buttonsubtract5,

  /// <summary>
  /// Literal value: button-6
  /// </summary>
  [FactorioRconDefinitionValue("button-6")]
  Buttonsubtract6,

  /// <summary>
  /// Literal value: button-7
  /// </summary>
  [FactorioRconDefinitionValue("button-7")]
  Buttonsubtract7,

  /// <summary>
  /// Literal value: button-8
  /// </summary>
  [FactorioRconDefinitionValue("button-8")]
  Buttonsubtract8,

  /// <summary>
  /// Literal value: button-9
  /// </summary>
  [FactorioRconDefinitionValue("button-9")]
  Buttonsubtract9,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_444920086e0c4ea5b72f50afdd16c1e6
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_294881e910064c4db8292578e4668dd5: string
{
}

public abstract class Type_0efda68826ab4ab9a226fd910e10e7d9: uint
{
}

public abstract class Type_178a6a0c41994f63b61487b061f6fa2b: uint
{
}

public abstract class Type_a0c9a6abffef4ca8bf8e573f98cd479d: TechnologyModifier
{
}

public abstract class Type_2b342e4f17814e4e84b4024e27b682e1: Ingredient
{
}

public abstract class Type_d923aef068e944db93742171f021103d: List<Ingredient>
{
}

public abstract class Type_1809fc6355a145cb8b121635fa7fcf33: LuaTilePrototype
{
}

public abstract class Type_439869ca9d66455ba3f1f3337cb0f036: TilePosition
{
}

public abstract class Type_8622fa73404e49978d91b090484ca3b2: double
{
}

public abstract class Type_5bef968cff184949b6cbe296dc331a29: double
{
}

public abstract class Type_22d9861682eb461daaeddb60b84b3642: uint
{
}

public abstract class Type_cb3f842f2e8543708cd01be0a7acfa33: double
{
}

public abstract class Type_0437f3562bc04ac89a6bc19d2a6340a0: double
{
}

public abstract class Type_9852409f4b074603a9b6f92ff5cfe51f: uint
{
}

public abstract class Type_95f151e52bf14c2ea030b943b43f6bd6: double
{
}

public abstract class Type_ea9d4f8d0329425b965f669fa517f126: double
{
}

public abstract class Type_eac73668952d4fb797fc9829e11809e1: uint
{
}

public abstract class Type_cd897a07af07496f8a64618fcd242e61: double
{
}

public abstract class Type_f349ee71314e476ea19283f692c87e18: double
{
}

public abstract class Type_867cff25bdb340f7acb8205ab50cc26c: double
{
}

public abstract class Type_3f99fd4a606345f0851eb4c1db1da8b6: double
{
}

public abstract class Type_857512094d6d494c948d7ccdf664d7a0: double
{
}

public abstract class Type_43b246cefd024ccf847cad7804902a2e: uint
{
}

public abstract class Type_471642f5daf64230b2246a61322006ce: uint
{
}

public abstract class Type_00aab2eca4264221a5d7c08fadd4c729: uint
{
}

public abstract class Type_04297fb37567483a8e5bb5ae8d0f4e96: double
{
}

public abstract class Type_eaffa79f61364b56a51c8cf2d65c045b: uint
{
}

public abstract class Type_9438f6e73c7744809a57a69387277186: uint
{
}

public abstract class Type_cbcaf30a6bbe405085184d7523e939e6: double
{
}

public abstract class Type_6456bef45ff1447885e93e099125e152: double
{
}

public abstract class Type_f636103b0ae14842b178798e2b1d202c: uint
{
}

public abstract class Type_d44ab5e902054b3195a853bfa3abc21a: uint
{
}

public abstract class Type_155294c690c94556bee4e0b6d1a0fd86: List<uint>
{
}

public abstract class Type_1dedf9829f5e48a292b78837663f276c: double
{
}

public abstract class Type_dc6e7943fdc746db959520bfa8918954: List<double>
{
}

public abstract class Type_d3fe7241eac14733ad1581ae8f94c4ce: uint
{
}

public abstract class Type_884fddec639348cbb013fbdf2c6af0aa: double
{
}

public abstract class Type_e424ad72c9d7450e98952f5410832ec5: uint
{
}

public abstract class Type_adb0539402294f9e9edaed6d5c9e65bf: uint
{
}

public abstract class Type_6c68159b976e4f17b0aa6e4e97b199cb: double
{
}

public abstract class Type_5c86b08ffcdd4794a7b71b70f6ff7165: double
{
}

public abstract class Type_ffd5e74517114b62a40c5f0693e9f2f8: double
{
}

public abstract class Type_69a3ad989dd640578070e273e669fec4: bool
{
}

public abstract class Type_a3eba905efe443379d077e30e463a684: bool
{
}

public abstract class Type_bf7972dd41b04bbe8e69cdaa66148766: bool
{
}

public abstract class Type_5724a7575ade4fd08835c93887c4e13b: bool
{
}

public abstract class Type_11d362bcea8747f6ba7e4417b5be1cc6: bool
{
}

public abstract class Type_ed1daf14a8724fe0a0687de2551cc573: bool
{
}

public abstract class Type_a3a6f952d64a4180b1b94a0410e44812: bool
{
}

public abstract class Type_45bc34ad149d48219af4dc383e8b0036: bool
{
}

public abstract class Type_c8728ce6bf164c66934bcb8e6edeb83e: MapPosition
{
}

/// <summary>
/// Union of literals:
///   - normal
///   - underground
/// </summary>
public enum Literals_0f73af583ccb428e881bad62de68cc92
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconDefinitionValue("normal")]
  Normal,

  /// <summary>
  /// Literal value: underground
  /// </summary>
  [FactorioRconDefinitionValue("underground")]
  Underground,

}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals_51df30810b73402b9ab89e682375fe6d
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  Inputsubtractoutput,

}

public abstract class Type_790491371dc24bfbacc3e9ddf5d3beb5: MapPosition
{
}

public abstract class Type_20a031c41fd347ef81e2e8db60b6c26f: LuaFluidBox
{
}

public abstract class Type_021b5122156a4fd0a35c17267e4bfb3d: uint
{
}

public abstract class Type_da24e7de2cd4428cb6aaa54b98526ccb: uint
{
}

public abstract class Type_70f8c2f71759488ebd46924fb85e5cda: MapPosition
{
}

public abstract class Type_50792653ce8548158cbf4c821b761d30: CollisionMask
{
}

public abstract class Type_5b6d14f67a214219b000e0e31e5e221e: uint
{
}

public abstract class Type_c98af195fb724189acd8c174317e19e1: LuaTilePrototype
{
}

public abstract class Type_d9808b92c98e4fe6b31984b1d0c6df26: uint
{
}

public abstract class Type_bd31290b79ee4e468cfe6932009ff267: string
{
}

public abstract class Type_50f9e4c5569540ec9ee7561d9ceaa570: LuaPlayer
{
}

public abstract class Type_d43c5fba0c884da99d466f0c219034fb: double
{
}

public abstract class Type_3c000043eff84e8699c1b71201296a1f: double
{
}

public abstract class Type_416b5a575f9c4016882ec67223f69957: bool
{
}

public abstract class Type_d73eed7369aa4a0f9c3d6ff003930b89: double
{
}

public abstract class Type_692de77d192f4bcebe0feeb3e643c67a: double
{
}

public abstract class Type_2622a6bfdc0949c983cd222e0dd102b8: double
{
}

public abstract class Type_811423fba4494cb0a7cf0746561fa956: double
{
}

public abstract class Type_a663ac340f934ed78d62c3b67e297f03: double
{
}

public abstract class Type_78b38a9d8fb944328ad3a42de4a4978c: double
{
}

public abstract class Type_bc8c87d8f8a84e0e83cda6c036d91058: double
{
}

public abstract class Type_2bbc4b216ffc4421a7f80047736c6061: double
{
}

public abstract class Type_36c7a4cad40f448496305d7666eda323: double
{
}

public abstract class Type_fd930cc9948246c89fafd68f1caec081: Color
{
}

public abstract class Type_0db71a78624c4aad9abd8554a6aada72: bool
{
}

public abstract class Type_f663d77c8e7d44dea4893960d4c47c74: PrintSkipEnum
{
}

public abstract class Type_b622f219e4524be59b1fae2f721e9209: PrintSoundEnum
{
}

public abstract class Type_64511864b9954a16b3c7ce2048d42c1d: SoundPath
{
}

public abstract class Type_2da0bce61d1242aeb095b57d4c6de8b7: double
{
}

public abstract class Type_33485df53e354e6683c92f053c10d5f6: double
{
}

public abstract class Type_6bc29a3117cd4d619ea00f380a4946dc: uint
{
}

public abstract class Type_dde2908a78dd45cea328575e1b675a93: double
{
}

[GenerateOneOf]
public abstract partial class Union_fec29e92639543aca3841937d716a5a9: OneOfBase<uint, double>
{
}

public abstract class Type_5130c414b5384b4f87929e00e155b86e: uint
{
}

public abstract class Type_3c8aada0ac5f42609b34f3ad571cd1f5: double
{
}

[GenerateOneOf]
public abstract partial class Union_2d9031c826144ad8975193bcf53b4a24: OneOfBase<uint, double>
{
}

public abstract class Type_9db9f63fb00a41e4badf5030e16278bb: uint
{
}

public abstract class Type_6894f73b94d6491d95693c73a416a203: double
{
}

[GenerateOneOf]
public abstract partial class Union_de908da6c66c47529d8abef63a8c7ec1: OneOfBase<uint, double>
{
}

public abstract class Type_fba5e110e6fa42ccb3c3feff22d17b30: string
{
}

public abstract class Type_d3ae7c50a8cb40c69f105cc4a7dd73b5: double
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals_4955dbd0fee64c0f985e497b4ba694ab
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

}

public abstract class Type_540e581b3e7e4bb59f08c97e21e9bb7d: double
{
}

public abstract class Type_7937bf3f37bd49abaec47da6f4b5c41a: string
{
}

public abstract class Type_7601860eeaee4b03b8461b6f39f5f774: SignalID
{
}

public abstract class Type_e807dcb622fe40be891475019451136c: bool
{
}

public abstract class Type_d839b83454954f2d8f6dbffa2d42fc68: bool
{
}

public abstract class Type_8173388609c84cce951d836b01483b61: uint
{
}

public abstract class Type_b9001542c1fe4acb87d3d628c598da63: uint
{
}

public abstract class Type_a86a904af907472da475711c32b62fd3: bool
{
}

public abstract class Type_43c7c2983ca04777b84b925f17708a60: string
{
}

public abstract class Type_a35eac4c22754200895ec9db38296819: string
{
}

public abstract class Type_d5113aeb90274d34ba5b24c9c9851b99: List<string>
{
}

public abstract class Type_f57d2aa1f11c4828ba8b62d5f4abded3: bool
{
}

public abstract class Type_8bc7c4dca9c74795bff7e5d249d729a7: bool
{
}

public abstract class Type_2afd04ae3d484a91a14ba98211055bce: double
{
}

public abstract class Type_73cb7964fc074795992c87e68b61f834: ItemPrototypeFilter
{
}

public abstract class Type_7e9aaeb91ced40beab44c8a4ba684995: TilePrototypeFilter
{
}

public abstract class Type_c86a65c0d305444f8986c7746d62546f: EntityPrototypeFilter
{
}

public abstract class Type_9fce62f5ba264350a6163588013ffabd: FluidPrototypeFilter
{
}

public abstract class Type_b4fd16a5e1f148d9bedb687943c055e0: RecipePrototypeFilter
{
}

public abstract class Type_7fb1338b364f485488bb7c863224fdbe: DecorativePrototypeFilter
{
}

public abstract class Type_7aa47be98099487ab513ee872ee4598f: AchievementPrototypeFilter
{
}

public abstract class Type_f05817c03565493c90e10e48767ef4fd: EquipmentPrototypeFilter
{
}

public abstract class Type_8c4bc358d11b4ac09abf2dfe322954f6: TechnologyPrototypeFilter
{
}

[GenerateOneOf]
public abstract partial class Union_29b3eb1830f5456fa8c9e56d4906ad03: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

public abstract class Type_f098331d31924817a934620d749e1307: string
{
}

public abstract class Type_23982870380544f6b272c5097d36dcd0: List<string>
{
}

public abstract class Type_9152c9e59983472fa363952fe2a1f28d: string
{
}

public abstract class Type_d394cadfaf494020834669f863b5d602: double
{
}

public abstract class Type_c40cb0288c9f40d78541fdbaa88e17d8: bool
{
}

public abstract class Type_e41d2aed027c42a5a060e1ffcbd47ade: bool
{
}

public abstract class Type_6e60d275549b4b11a19200050770fbe0: Vector
{
}

public abstract class Type_32b5b223cee2478b80f97f30f57eafd6: RailDirectionEnum
{
}

public abstract class Type_510c38128a864e5d8b9da14970570a0d: LuaEntity
{
}

public abstract class Type_39cde9d5b2d34636ba68e0d76c4c80b0: string
{
}

public abstract class Type_93c05cbe310f4956aa347ede71461f0a: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_5a1329134fbb4819b599dad8bec834db
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_0891c3f2f80f436e8d3ddb3a67f2e621: string
{
}

public abstract class Type_ab0350037469437d876992ea6cc7bc7d: ComparatorString
{
}

public abstract class Type_662715c2ca124f7b9f8724ca1fa43446: double
{
}

public abstract class Type_724b9b8238aa48cfb53a4c4150620369: ComparatorString
{
}

public abstract class Type_e35832f0b5f84a9896e7da5b01973e6e: double
{
}

public abstract class Type_4d5ead5a07e54e96aca3f1637b5810e9: FluidPrototypeFilter
{
}

public abstract class Type_cda0ae8064484de896e0546f228ea93e: List<FluidPrototypeFilter>
{
}

public abstract class Type_98d98288de534baea6b56e55313aecd4: ItemPrototypeFilter
{
}

public abstract class Type_d30b4a295bcd453fa7b841739fdc29d5: List<ItemPrototypeFilter>
{
}

public abstract class Type_c3d58501abbe44d5a23d68b0f993418e: FluidPrototypeFilter
{
}

public abstract class Type_56abb99a7a874445bdd012530703b072: List<FluidPrototypeFilter>
{
}

public abstract class Type_bf134527cd7b4e939b3f81aa6982a174: ItemPrototypeFilter
{
}

public abstract class Type_7c07d3ab9ee248c5a8f9f9f5f727981c: List<ItemPrototypeFilter>
{
}

public abstract class Type_dbf9ee1a599a4dab9976910b52240b77: ComparatorString
{
}

public abstract class Type_a9da323d33604b168b9a16e4c3c82c76: uint
{
}

public abstract class Type_aec5cf7881e4450288ef63f4bd043404: ComparatorString
{
}

public abstract class Type_878a72c9e6bd4ec795a2e96995c52c12: uint
{
}

public abstract class Type_6f24a9ea8a6d4b9a94f1362220af8383: string
{
}

public abstract class Type_e34e5ac7621d48519ab61111a1b967ca: string
{
}

/// <summary>
/// Literal value: water-tile
/// </summary>
public enum Literal_854c7401d83744afa926277c6ced9eef
{
  /// <summary>
  /// Literal value: water-tile
  /// </summary>
  [FactorioRconDefinitionValue("water-tile")]
  Watersubtracttile,

}

/// <summary>
/// Literal value: ground-tile
/// </summary>
public enum Literal_bc834b0dbf3845e79c3b2766abed663f
{
  /// <summary>
  /// Literal value: ground-tile
  /// </summary>
  [FactorioRconDefinitionValue("ground-tile")]
  Groundsubtracttile,

}

/// <summary>
/// Literal value: tile-transition
/// </summary>
public enum Literal_1fb867fee3c2493a849efb6640777c81
{
  /// <summary>
  /// Literal value: tile-transition
  /// </summary>
  [FactorioRconDefinitionValue("tile-transition")]
  Tilesubtracttransition,

}

/// <summary>
/// Literal value: decals
/// </summary>
public enum Literal_bd1203d54ef94986843991dcb5edd69c
{
  /// <summary>
  /// Literal value: decals
  /// </summary>
  [FactorioRconDefinitionValue("decals")]
  Decals,

}

/// <summary>
/// Literal value: lower-radius-visualization
/// </summary>
public enum Literal_0f75461c85134d62890b6ac9fb38d6ad
{
  /// <summary>
  /// Literal value: lower-radius-visualization
  /// </summary>
  [FactorioRconDefinitionValue("lower-radius-visualization")]
  Lowersubtractradiussubtractvisualization,

}

/// <summary>
/// Literal value: radius-visualization
/// </summary>
public enum Literal_40f4734888314f809b5d4e565dce5205
{
  /// <summary>
  /// Literal value: radius-visualization
  /// </summary>
  [FactorioRconDefinitionValue("radius-visualization")]
  Radiussubtractvisualization,

}

/// <summary>
/// Literal value: transport-belt-integration
/// </summary>
public enum Literal_6f723ac4083043bd9310a7c4e250a006
{
  /// <summary>
  /// Literal value: transport-belt-integration
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-integration")]
  Transportsubtractbeltsubtractintegration,

}

/// <summary>
/// Literal value: resource
/// </summary>
public enum Literal_57840b4512c147c5a4d8df1f79c2a581
{
  /// <summary>
  /// Literal value: resource
  /// </summary>
  [FactorioRconDefinitionValue("resource")]
  Resource,

}

/// <summary>
/// Literal value: building-smoke
/// </summary>
public enum Literal_8555ec907e66408ab107d6d8eef4ec81
{
  /// <summary>
  /// Literal value: building-smoke
  /// </summary>
  [FactorioRconDefinitionValue("building-smoke")]
  Buildingsubtractsmoke,

}

/// <summary>
/// Literal value: decorative
/// </summary>
public enum Literal_027b6416dd3b4893bd432dede0b5a825
{
  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconDefinitionValue("decorative")]
  Decorative,

}

/// <summary>
/// Literal value: ground-patch
/// </summary>
public enum Literal_98889bd2202c4748beeb7d952743088d
{
  /// <summary>
  /// Literal value: ground-patch
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch")]
  Groundsubtractpatch,

}

/// <summary>
/// Literal value: ground-patch-higher
/// </summary>
public enum Literal_4d965df2efb44304951188fd853efb35
{
  /// <summary>
  /// Literal value: ground-patch-higher
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch-higher")]
  Groundsubtractpatchsubtracthigher,

}

/// <summary>
/// Literal value: ground-patch-higher2
/// </summary>
public enum Literal_16b57c1e29244966b13491e61a772ddd
{
  /// <summary>
  /// Literal value: ground-patch-higher2
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch-higher2")]
  Groundsubtractpatchsubtracthigher2,

}

/// <summary>
/// Literal value: remnants
/// </summary>
public enum Literal_d2ba0a5ce808468391b24bcfa339d80d
{
  /// <summary>
  /// Literal value: remnants
  /// </summary>
  [FactorioRconDefinitionValue("remnants")]
  Remnants,

}

/// <summary>
/// Literal value: floor
/// </summary>
public enum Literal_65686481c1bb4534b3d34bc3c5d783b3
{
  /// <summary>
  /// Literal value: floor
  /// </summary>
  [FactorioRconDefinitionValue("floor")]
  Floor,

}

/// <summary>
/// Literal value: transport-belt
/// </summary>
public enum Literal_29739d2758314a6f873edaf138e2eb1c
{
  /// <summary>
  /// Literal value: transport-belt
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt")]
  Transportsubtractbelt,

}

/// <summary>
/// Literal value: transport-belt-endings
/// </summary>
public enum Literal_f4ac762cd1b64404a984a94a0c061d8c
{
  /// <summary>
  /// Literal value: transport-belt-endings
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-endings")]
  Transportsubtractbeltsubtractendings,

}

/// <summary>
/// Literal value: floor-mechanics-under-corpse
/// </summary>
public enum Literal_fed8ab5de7c244b1aae91ac3272425a8
{
  /// <summary>
  /// Literal value: floor-mechanics-under-corpse
  /// </summary>
  [FactorioRconDefinitionValue("floor-mechanics-under-corpse")]
  Floorsubtractmechanicssubtractundersubtractcorpse,

}

/// <summary>
/// Literal value: corpse
/// </summary>
public enum Literal_9fcff235288b4600833a1391dfd38e91
{
  /// <summary>
  /// Literal value: corpse
  /// </summary>
  [FactorioRconDefinitionValue("corpse")]
  Corpse,

}

/// <summary>
/// Literal value: floor-mechanics
/// </summary>
public enum Literal_68569f5b9b7f4e0cb2ca280fab147fcb
{
  /// <summary>
  /// Literal value: floor-mechanics
  /// </summary>
  [FactorioRconDefinitionValue("floor-mechanics")]
  Floorsubtractmechanics,

}

/// <summary>
/// Literal value: item
/// </summary>
public enum Literal_346fb3ba9dc9427585fe52a4621c5dba
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

}

/// <summary>
/// Literal value: lower-object
/// </summary>
public enum Literal_78498ac0551343db88e36c608c7a8eca
{
  /// <summary>
  /// Literal value: lower-object
  /// </summary>
  [FactorioRconDefinitionValue("lower-object")]
  Lowersubtractobject,

}

/// <summary>
/// Literal value: transport-belt-circuit-connector
/// </summary>
public enum Literal_40585427e51e45d0b6ec79da40bc62b5
{
  /// <summary>
  /// Literal value: transport-belt-circuit-connector
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-circuit-connector")]
  Transportsubtractbeltsubtractcircuitsubtractconnector,

}

/// <summary>
/// Literal value: lower-object-above-shadow
/// </summary>
public enum Literal_2b37fa1d31404da8a3d4a3e83d9a2442
{
  /// <summary>
  /// Literal value: lower-object-above-shadow
  /// </summary>
  [FactorioRconDefinitionValue("lower-object-above-shadow")]
  Lowersubtractobjectsubtractabovesubtractshadow,

}

/// <summary>
/// Literal value: object
/// </summary>
public enum Literal_5423f65e446a434c934dcc3f242f9cca
{
  /// <summary>
  /// Literal value: object
  /// </summary>
  [FactorioRconDefinitionValue("object")]
  Object,

}

/// <summary>
/// Literal value: higher-object-under
/// </summary>
public enum Literal_485883cc3d984b4ca378d6ac0956a4ab
{
  /// <summary>
  /// Literal value: higher-object-under
  /// </summary>
  [FactorioRconDefinitionValue("higher-object-under")]
  Highersubtractobjectsubtractunder,

}

/// <summary>
/// Literal value: higher-object-above
/// </summary>
public enum Literal_f5bbf8d9528048f6af551c0982c4a2c3
{
  /// <summary>
  /// Literal value: higher-object-above
  /// </summary>
  [FactorioRconDefinitionValue("higher-object-above")]
  Highersubtractobjectsubtractabove,

}

/// <summary>
/// Literal value: item-in-inserter-hand
/// </summary>
public enum Literal_b1231053ccd943c1a61438d02afad9ea
{
  /// <summary>
  /// Literal value: item-in-inserter-hand
  /// </summary>
  [FactorioRconDefinitionValue("item-in-inserter-hand")]
  Itemsubtractinsubtractinsertersubtracthand,

}

/// <summary>
/// Literal value: wires
/// </summary>
public enum Literal_82680a0359d0419da654e77a1fbc85da
{
  /// <summary>
  /// Literal value: wires
  /// </summary>
  [FactorioRconDefinitionValue("wires")]
  Wires,

}

/// <summary>
/// Literal value: wires-above
/// </summary>
public enum Literal_38e4b3a79a7240b79d64fbdea6b5128a
{
  /// <summary>
  /// Literal value: wires-above
  /// </summary>
  [FactorioRconDefinitionValue("wires-above")]
  Wiressubtractabove,

}

/// <summary>
/// Literal value: entity-info-icon
/// </summary>
public enum Literal_ab98d645836843db8d70d14d14cf99ee
{
  /// <summary>
  /// Literal value: entity-info-icon
  /// </summary>
  [FactorioRconDefinitionValue("entity-info-icon")]
  Entitysubtractinfosubtracticon,

}

/// <summary>
/// Literal value: entity-info-icon-above
/// </summary>
public enum Literal_2323e7279347415a93233627e8d32da8
{
  /// <summary>
  /// Literal value: entity-info-icon-above
  /// </summary>
  [FactorioRconDefinitionValue("entity-info-icon-above")]
  Entitysubtractinfosubtracticonsubtractabove,

}

/// <summary>
/// Literal value: explosion
/// </summary>
public enum Literal_99edaca56f4d4571a3f65678ab3e9572
{
  /// <summary>
  /// Literal value: explosion
  /// </summary>
  [FactorioRconDefinitionValue("explosion")]
  Explosion,

}

/// <summary>
/// Literal value: projectile
/// </summary>
public enum Literal_fdee85cbfac740b8a43fc45281acb2e5
{
  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

}

/// <summary>
/// Literal value: smoke
/// </summary>
public enum Literal_d98925351f3d41288a2d6664f70baf12
{
  /// <summary>
  /// Literal value: smoke
  /// </summary>
  [FactorioRconDefinitionValue("smoke")]
  Smoke,

}

/// <summary>
/// Literal value: air-object
/// </summary>
public enum Literal_c4d7ec32c3e246daa1094430f0203d2f
{
  /// <summary>
  /// Literal value: air-object
  /// </summary>
  [FactorioRconDefinitionValue("air-object")]
  Airsubtractobject,

}

/// <summary>
/// Literal value: air-entity-info-icon
/// </summary>
public enum Literal_c8ca9227c14b4565b7c69ad082c4a13c
{
  /// <summary>
  /// Literal value: air-entity-info-icon
  /// </summary>
  [FactorioRconDefinitionValue("air-entity-info-icon")]
  Airsubtractentitysubtractinfosubtracticon,

}

/// <summary>
/// Literal value: light-effect
/// </summary>
public enum Literal_317cdfe54cdb42268c635bfddc4bf158
{
  /// <summary>
  /// Literal value: light-effect
  /// </summary>
  [FactorioRconDefinitionValue("light-effect")]
  Lightsubtracteffect,

}

/// <summary>
/// Literal value: selection-box
/// </summary>
public enum Literal_03989350516643e08a52ee39102fd282
{
  /// <summary>
  /// Literal value: selection-box
  /// </summary>
  [FactorioRconDefinitionValue("selection-box")]
  Selectionsubtractbox,

}

/// <summary>
/// Literal value: higher-selection-box
/// </summary>
public enum Literal_6c86ce0ff5e1477ea35ec8783684fa27
{
  /// <summary>
  /// Literal value: higher-selection-box
  /// </summary>
  [FactorioRconDefinitionValue("higher-selection-box")]
  Highersubtractselectionsubtractbox,

}

/// <summary>
/// Literal value: collision-selection-box
/// </summary>
public enum Literal_c1cda313b7aa4f7d9d05ed07fd7da5c3
{
  /// <summary>
  /// Literal value: collision-selection-box
  /// </summary>
  [FactorioRconDefinitionValue("collision-selection-box")]
  Collisionsubtractselectionsubtractbox,

}

/// <summary>
/// Literal value: arrow
/// </summary>
public enum Literal_da1553e186c147e5b7c00e0bcca4ccbd
{
  /// <summary>
  /// Literal value: arrow
  /// </summary>
  [FactorioRconDefinitionValue("arrow")]
  Arrow,

}

/// <summary>
/// Literal value: cursor
/// </summary>
public enum Literal_285cb1c65cef45968943525db202bf07
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

public abstract class Type_12091fcb92054bc48f925c8c9ee08523: float
{
}

public abstract class Type_2ce724978e024d7f8183e380537ced2e: float
{
}

public abstract class Type_7021ff1677c24986b7d42c3582f14423: RidingAccelerationEnum
{
}

public abstract class Type_762e8217256b4a0ab3f554061c8c6b0d: RidingDirectionEnum
{
}

public abstract class Type_d49c627513694e83983db1d7086e4b29: RealOrientation
{
}

public abstract class Type_c60fd0842ddc478cb4277567efe20778: MapPosition
{
}

public abstract class Type_98f81ee50f644712bd98c4fc8906d161: BoundingBox
{
}

public abstract class Type_e484f07d85a645d48872a0839fd53c0d: Color
{
}

public abstract class Type_60ea00d8a7bf4d248cb6fae364ca7ef3: uint
{
}

public abstract class Type_32c6ec90a2d248e18763ba03cc5376c5: string
{
}

public abstract class Type_bfb6442e96484cd192fe376a05d7dbbe: Color
{
}

public abstract class Type_dd91e97a0139401b904ff3f11621a2b4: uint
{
}

public abstract class Type_d0cb033427994779b41dea3ac3d8ab76: string
{
}

public abstract class Type_dfe15bef96a341a69afb30574d91b89a: MapPosition
{
}

public abstract class Type_866974994e6c4157a62975ce112f64ec: LuaEntity
{
}

public abstract class Type_52be8b97d90546fc8cb26146527b944e: Vector
{
}

public abstract class Type_90502d9a4116480f83dad3d4cb5d021e: MapPosition
{
}

public abstract class Type_f8107c284e604fc9b10ff0643332e83d: MapPosition
{
}

public abstract class Type_520139a25d8e4becabcbbaf4bf331b78: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_af2e13f9dba34acaa26aba00de557b09: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_a1cfd2e4a14d49fc8e5d265f2901bc9a: Vector
{
}

public abstract class Type_f3922f9463fb43ba96209128bbd22a5a: string
{
}

public abstract class Type_1d4e5d88cb7a47d9ae60d1f54b341355: string
{
}

public abstract class Type_6ce5a3304a254323b19b2cb52bfda6f6: string
{
}

/// <summary>
/// Union of literals:
///   - blueprint
///   - deconstruct
///   - cancel-deconstruct
///   - items
///   - trees
///   - buildable-type
///   - nothing
///   - items-to-place
///   - any-entity
///   - any-tile
///   - same-force
///   - not-same-force
///   - friend
///   - enemy
///   - upgrade
///   - cancel-upgrade
///   - downgrade
///   - entity-with-health
///   - entity-with-force
///   - is-military-target
///   - entity-with-owner
///   - avoid-rolling-stock
///   - entity-ghost
///   - tile-ghost
/// </summary>
public enum Literals_d5ef5bb9181343d58bc0dcdcde5b0027
{
  /// <summary>
  /// Literal value: blueprint
  /// </summary>
  [FactorioRconDefinitionValue("blueprint")]
  Blueprint,

  /// <summary>
  /// Literal value: deconstruct
  /// </summary>
  [FactorioRconDefinitionValue("deconstruct")]
  Deconstruct,

  /// <summary>
  /// Literal value: cancel-deconstruct
  /// </summary>
  [FactorioRconDefinitionValue("cancel-deconstruct")]
  Cancelsubtractdeconstruct,

  /// <summary>
  /// Literal value: items
  /// </summary>
  [FactorioRconDefinitionValue("items")]
  Items,

  /// <summary>
  /// Literal value: trees
  /// </summary>
  [FactorioRconDefinitionValue("trees")]
  Trees,

  /// <summary>
  /// Literal value: buildable-type
  /// </summary>
  [FactorioRconDefinitionValue("buildable-type")]
  Buildablesubtracttype,

  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  /// <summary>
  /// Literal value: items-to-place
  /// </summary>
  [FactorioRconDefinitionValue("items-to-place")]
  Itemssubtracttosubtractplace,

  /// <summary>
  /// Literal value: any-entity
  /// </summary>
  [FactorioRconDefinitionValue("any-entity")]
  Anysubtractentity,

  /// <summary>
  /// Literal value: any-tile
  /// </summary>
  [FactorioRconDefinitionValue("any-tile")]
  Anysubtracttile,

  /// <summary>
  /// Literal value: same-force
  /// </summary>
  [FactorioRconDefinitionValue("same-force")]
  Samesubtractforce,

  /// <summary>
  /// Literal value: not-same-force
  /// </summary>
  [FactorioRconDefinitionValue("not-same-force")]
  Notsubtractsamesubtractforce,

  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconDefinitionValue("friend")]
  Friend,

  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconDefinitionValue("enemy")]
  Enemy,

  /// <summary>
  /// Literal value: upgrade
  /// </summary>
  [FactorioRconDefinitionValue("upgrade")]
  Upgrade,

  /// <summary>
  /// Literal value: cancel-upgrade
  /// </summary>
  [FactorioRconDefinitionValue("cancel-upgrade")]
  Cancelsubtractupgrade,

  /// <summary>
  /// Literal value: downgrade
  /// </summary>
  [FactorioRconDefinitionValue("downgrade")]
  Downgrade,

  /// <summary>
  /// Literal value: entity-with-health
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-health")]
  Entitysubtractwithsubtracthealth,

  /// <summary>
  /// Literal value: entity-with-force
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-force")]
  Entitysubtractwithsubtractforce,

  /// <summary>
  /// Literal value: is-military-target
  /// </summary>
  [FactorioRconDefinitionValue("is-military-target")]
  Issubtractmilitarysubtracttarget,

  /// <summary>
  /// Literal value: entity-with-owner
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-owner")]
  Entitysubtractwithsubtractowner,

  /// <summary>
  /// Literal value: avoid-rolling-stock
  /// </summary>
  [FactorioRconDefinitionValue("avoid-rolling-stock")]
  Avoidsubtractrollingsubtractstock,

  /// <summary>
  /// Literal value: entity-ghost
  /// </summary>
  [FactorioRconDefinitionValue("entity-ghost")]
  Entitysubtractghost,

  /// <summary>
  /// Literal value: tile-ghost
  /// </summary>
  [FactorioRconDefinitionValue("tile-ghost")]
  Tilesubtractghost,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_f6960d22c0b44f97ac3cf344c0ba0f83
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_04264a8d9b384329b043b4b029e1f64e: int
{
}

public abstract class Type_87fc32454ff64d3da279b28205c47dd6: SignalID
{
}

public abstract class Type_8b11b898c0174f2884df2b9b95c0ef1f: string
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
///   - virtual
/// </summary>
public enum Literals_100d15e3f9ab4fcfa415a97c690641e7
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

  /// <summary>
  /// Literal value: virtual
  /// </summary>
  [FactorioRconDefinitionValue("virtual")]
  Virtual,

}

public abstract class Type_f1a31646fc11499b965edaaaeadd4123: string
{
}

public abstract class Type_1410aa5ace2749bfa73fbba9b75cc995: ItemStackDefinition
{
}

public abstract class Type_384a992bf7854389b9386a15d2a9b504: MapPosition
{
}

public abstract class Type_d0251629d47a4a7597832b8b3e29270a: Vector
{
}

public abstract class Type_6124d5b78f4b42f5b53ae04857ac759e: double
{
}

public abstract class Type_5b8ceb39c8c84d58ba81f9643abe546d: float
{
}

public abstract class Type_cae0e6f9b06f4e1baf455c249b136765: float
{
}

public abstract class Type_a0bf0313bdc746e1a2c828907ec6febc: string
{
}

public abstract class Type_3b99a3aaa56048cfb2daaf676b1140d9: Vector
{
}

public abstract class Type_318f01cf0cf545b0832dab373dffa6e2: double
{
}

public abstract class Type_287ab5efe5a6455b88af932badfe2156: Vector
{
}

public abstract class Type_f29e54710952415695e420904749dc9d: byte
{
}

public abstract class Type_c066d4a0fc6f45b5b5323a7b4ee3612c: Vector
{
}

public abstract class Type_21c36b8999984e258745e6a8bf7a2752: ushort
{
}

public abstract class Type_451558b87033436e8ec9e3342b5a35cc: double
{
}

public abstract class Type_d40589d4d6a84080bd8ce3f308ca774d: ushort
{
}

public abstract class Type_6218d89e65f6408a8244a4c0f208db69: double
{
}

public abstract class Type_3fbf8f7e8e6e4db39e0082c36a706f10: float
{
}

public abstract class Type_bb2c37e2259f49c6a3016f9e856c4c95: float
{
}

public abstract class Type_c4132dcfab9948b18fc1db2cb9ecb15d: float
{
}

public abstract class Type_e16917d4805b4ae8b2a52d6f03b9effd: Vector
{
}

public abstract class Type_55b351537bbe43c2877c3b92ca648a0d: double
{
}

public abstract class Type_55676b4b6d0145d4830d8c8a1b7f51b0: double
{
}

public abstract class Type_53ca14625af34246809f949d612cd097: bool
{
}

public abstract class Type_4e864647ae3f4632a738049165c84a12: double
{
}

public abstract class Type_1f3a20ba1a4d485285c048a3f0a9edeb: double
{
}

public abstract class Type_4dc752e3d0a34d03a9d2063e7121651d: double
{
}

public abstract class Type_a68f5ec7077441b4ad79dda108809148: SteeringMapSetting
{
}

public abstract class Type_e5530d720b1b409a912b2d2967f18ddb: SteeringMapSetting
{
}

public abstract class Type_f2a8c0ea6df74fa384293cafb84dab4b: uint
{
}

public abstract class Type_5158b21f4a9a4f6584a90bd266ff5379: string
{
}

public abstract class Type_37f0ac57530c4db180807422eff51cfe: LuaSurface
{
}

public abstract class Type_2910f7893ae842cb92a0541713f44cad: LuaGuiElement
{
}

public abstract class Type_3b70f9745aaf4ee7ab12dc20f1e6e7f9: LuaGuiElement
{
}

public abstract class Type_3f4758c9141a4a7e8fc440327a85a67e: string
{
}

public abstract class Type_3a827c7c4f4f4656be54045597f0cfb7: AnyBasic
{
}

public abstract class Type_bca14290a3a04f48893f0684b5d2ed24: string
{
}

public abstract class Type_b21e0263d30642128fee9a75a179e6fa: LuaTechnology
{
}

public abstract class Type_880a3dcacb7f4d8e96a51420adba80de: LuaTechnologyPrototype
{
}

public abstract class Type_853855168a884bc98dc635bcee2934ff: ModifierType
{
}

public abstract class Type_ec472dabc49f421aa0edc8f25ce6c4ce: double
{
}

public abstract class Type_358bab39c45e4e2cbd25c00846c636a5: string
{
}

public abstract class Type_cd5da44f16284d38af0c644ed0c9ee26: double
{
}

public abstract class Type_16da980a8f304a12b096530dc6bc181e: uint
{
}

public abstract class Type_855639418ebf437980372f7334b1849e: string
{
}

public abstract class Type_8a92c57157584ec29f5a1c85bff0dfb6: string
{
}

public abstract class Type_d3b6cc66562a471497cc9f37a25176fe: double
{
}

public abstract class Type_5b0762d0007d45b18c835aef7a3fe0ff: LocalisedString
{
}

public abstract class Type_d8dd869b8f734b34a916b3e614b21575: double
{
}

public abstract class Type_96a4c4565eff4529b8a4c2c2906e6787: string
{
}

public abstract class Type_61e8a2b15ac143aeafdef9db8243b27a: string
{
}

public abstract class Type_583bd3d54f50456fad73b6914b36c9f8: string
{
}

public abstract class Type_e65dbd25c1ca4dea8a6702af80bb9dbb: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_be4dab2acbfb484bb8ea0bce14518c12
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_4d11824a6edf4110ac4bb4cb944355a9: ComparatorString
{
}

public abstract class Type_0a40eb9fe2c047ddbd56a847f08c51c4: uint
{
}

public abstract class Type_3790c76e490842f5820431aa31022962: ComparatorString
{
}

public abstract class Type_9e17c2317b7e440296220bc3f3383b30: uint
{
}

public abstract class Type_bcf88e187ea34685bbed78bb3d4c3d42: string
{
}

public abstract class Type_82a9c2c7ad074af584b1ad3ec71c0d27: ComparatorString
{
}

public abstract class Type_f2d4fa9004cd49b091d694f76f3d0902: uint
{
}

public abstract class Type_60be5c0d21c743cf8b8e363b00245ebe: string
{
}

public abstract class Type_37bf8bccc50547d492955c8b13eb2b5b: string
{
}

public abstract class Type_5581b9c191674d0f831ec14494000ea3: TilePosition
{
}

public abstract class Type_f48385ff61844af3b5084813b3a48f59: int
{
}

public abstract class Type_6787238e1b78445ba96202b60de01429: int
{
}

public abstract class Table_89b513c0669747959020560ba9f54e2b
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_46b0064f70bd4e08801ce390e4fb5a11: int
{
}

public abstract class Type_5735a24b5ab944b8bc242ddac0b63827: int
{
}

public abstract class Table_9cc09f0fd418492a89b81c8cb0e30231
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Type_e9c211b54d0e4863860cbb5c038471a2: string
{
}

public abstract class Type_7a4ccb64da5a460e86c8567c212a670a: bool
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_bf0203115acd4e52b0ea37763ec851fb
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

public abstract class Type_c8aa9c7cf82a4498bb04ad7915d9a55c: CollisionMask
{
}

public abstract class Type_9ff73f5f5aa6431391fc9cec9b06de60: CollisionMaskWithFlags
{
}

[GenerateOneOf]
public abstract partial class Union_83fa1f1cfb7a4399a26b8bb20b262fe2: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

public abstract class Type_99752775825c4c3cb9d60c2862494026: string
{
}

public abstract class Type_aece46ac7d3649b995024ce9f2502ccc: ComparatorString
{
}

public abstract class Type_f915f9e67bc84845a487decd53ed7011: float
{
}

public abstract class Type_e3e72567bda044879b5ae4bf42f1ff75: ComparatorString
{
}

public abstract class Type_b366aeb14c8a4e5ab1eccc7c54b8f80c: double
{
}

public abstract class Type_50f635eb79b44012b13e31924dacb56a: ComparatorString
{
}

public abstract class Type_22f13b93fa874c328246b6f8d0b12cf6: double
{
}

public abstract class Type_d8f09f3c52314ac3af0ec8561c02721e: ComparatorString
{
}

public abstract class Type_f05574623d644b28a79b3aa0c7e9ac19: double
{
}

public abstract class Type_ddabf56882214278852a0758efe6af88: bool
{
}

public abstract class Type_efd9e35d06fe48f48db7df1881b06dd7: List<bool>
{
}

public abstract class Type_aaf7d07b3edd4a3ba714896f9aae2f21: uint
{
}

public abstract class Type_bd6bcaa4427d44c6a039de3efbb63825: double
{
}

public abstract class Type_9f7c23721fec48ee94149e3e02876fc2: List<double>
{
}

public abstract class Type_97de92f966b14ca1a619b35b74b0dcdf: uint
{
}

public abstract class Type_06647c1c90e14ea5ac2a2d0090152ae8: bool
{
}

public abstract class Type_aafc7ebc1f79450aba3b6d6f658a8588: uint
{
}

public abstract class Type_b5351c5cc56642fc997b826e7cf46657: double
{
}

public abstract class Type_773ca07f9620486cb2b20766215bd1a0: uint
{
}

public abstract class Type_c08b197d08c74fe7a91d054dc749b264: bool
{
}

public abstract class Type_70bc1f9cf2c94697a1c0e02203e2c98d: uint
{
}

public abstract class Type_5bac943a421346d3987d0836275efd66: bool
{
}

public abstract class Type_8938b28f4328468bb853353c27770827: LuaEntity
{
}

public abstract class Type_f8785315ff7047b78932e4b71c99e3db: List<LuaEntity>
{
}

public abstract class Type_f6062d6b28e84ed78e969fc1dcf9261f: double
{
}

public abstract class Type_638610397f4b4b3ebc8323fb5289d361: uint
{
}

public abstract class Type_ace34020688f44af95e7f8bfe597a84e: double
{
}

public abstract class Type_b4290ad87bc748bcb158bbeeb9fb866b: uint
{
}

public abstract class Type_5b10f1ec92044e5ca3302f16158cc017: TrainScheduleRecord
{
}

public abstract class Type_af61a063a1e14070bd0f6f2ae57bfcb6: List<TrainScheduleRecord>
{
}

public abstract class Type_4afcba7a294d440684b18776c392552c: LuaEntity
{
}

public abstract class Type_a4c20f472a904275bba3dab3d0ef92b1: RailDirectionEnum
{
}

public abstract class Type_9cf182a03a9840a5b034502fe4e94848: string
{
}

public abstract class Type_93c54bfeec1c4b6db5bcc287aadbbe7b: bool
{
}

public abstract class Type_8e18ad86a1504e858e4c032423fe2f35: WaitCondition
{
}

public abstract class Type_d4a2cce05c854c3588abfe4ba4b1ac37: List<WaitCondition>
{
}

public abstract class Type_65b77558d0f84c3e8fb4c947c5e15bd4: LuaEntity
{
}

public abstract class Type_0b43f94fd5fe44b4986d964e4ea2fb5b: TriggerEffectItem
{
}

public abstract class Type_945a1567a1f74978808b1c25d9819512: List<TriggerEffectItem>
{
}

public abstract class Type_d0b90eb4353f41c09c124014e9cc60e4: TriggerEffectItem
{
}

public abstract class Type_686592cdfe1a41ada2bccadb955684d9: List<TriggerEffectItem>
{
}

/// <summary>
/// Union of literals:
///   - instant
///   - projectile
///   - flame-thrower
///   - beam
///   - stream
///   - artillery
/// </summary>
public enum Literals_9a4f2baa1d5e4851af03a0ea3831a448
{
  /// <summary>
  /// Literal value: instant
  /// </summary>
  [FactorioRconDefinitionValue("instant")]
  Instant,

  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

  /// <summary>
  /// Literal value: flame-thrower
  /// </summary>
  [FactorioRconDefinitionValue("flame-thrower")]
  Flamesubtractthrower,

  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconDefinitionValue("beam")]
  Beam,

  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconDefinitionValue("stream")]
  Stream,

  /// <summary>
  /// Literal value: artillery
  /// </summary>
  [FactorioRconDefinitionValue("artillery")]
  Artillery,

}

public abstract class Type_3839f549a50643078b3e424a16f38865: bool
{
}

public abstract class Type_b6a824beb785431faa43f5378538e047: DamageTypeFilters
{
}

public abstract class Type_4c484af53f4744798a7d5a32d18bdf47: float
{
}

public abstract class Type_c87be6468e094d3aaf1b487e91e56862: ushort
{
}

public abstract class Type_2cd0f0a6e9224060ac4b89a3c3176256: ushort
{
}

public abstract class Type_e50bb0808f8f4e2cb767429af0671d7e: bool
{
}

public abstract class Type_65f7b5c35acc42daa428c2d6165a3959: TriggerEffectItemType
{
}

public abstract class Type_a290deba3366422782b9288f70740684: TriggerDelivery
{
}

public abstract class Type_1887ee771e2a473a982a287f795bff21: List<TriggerDelivery>
{
}

public abstract class Type_508c9f8282174e5da1b986b95e01d4f0: CollisionMask
{
}

public abstract class Type_eb7dfb2818fd43a283ce1f778923ff62: EntityPrototypeFlags
{
}

public abstract class Type_c095974e71984f4f88282391b36ac3cf: ForceCondition
{
}

public abstract class Type_9ca807fea071466197468aca42581175: bool
{
}

public abstract class Type_43efea57423e4628a5f96289f2492c97: float
{
}

public abstract class Type_02bb00802ec64b26a628397fb6d3033c: uint
{
}

public abstract class Type_6c54c101974346c591737030a712e409: TriggerTargetMask
{
}

/// <summary>
/// Union of literals:
///   - direct
///   - area
///   - line
///   - cluster
/// </summary>
public enum Literals_afbcfa74606342c6848e28b7fd37cdc6
{
  /// <summary>
  /// Literal value: direct
  /// </summary>
  [FactorioRconDefinitionValue("direct")]
  Direct,

  /// <summary>
  /// Literal value: area
  /// </summary>
  [FactorioRconDefinitionValue("area")]
  Area,

  /// <summary>
  /// Literal value: line
  /// </summary>
  [FactorioRconDefinitionValue("line")]
  Line,

  /// <summary>
  /// Literal value: cluster
  /// </summary>
  [FactorioRconDefinitionValue("cluster")]
  Cluster,

}

public abstract class Type_b7457a8149644c4c93056483ef2bb372: string
{
}

public abstract class Type_3f4e0df365aa4185be03f0b28f8ebf30: bool
{
}

public abstract class Type_c8097a0feebf41a6a445cf047168a509: uint
{
}

public abstract class Type_ba75b599e9664031a104e5a0a0b0c591: uint
{
}

public abstract class Type_744b47aef3ef412390e9768a6af5e295: double
{
}

public abstract class Type_7e63b3e881c342009347cfa4f8f634de: double
{
}

public abstract class Type_07649f1e0ac9477cbeaeb666ef9078f7: double
{
}

public abstract class Type_e9412e80974c4b2fb39dbd7f2b7bbf76: double
{
}

public abstract class Type_756c76d659384911b1c3e7b05ad15cb8: double
{
}

public abstract class Type_e4867284ef294ff1afcc4a34c3eae415: uint
{
}

public abstract class Type_9a79dd0fd48c43ec9e582d5f7c5a89ac: uint
{
}

public abstract class Type_5dfabaf15072493fbba13351d5d90cb7: double
{
}

public abstract class Type_b050d63e8fc3438daf527e8b66a9e1ad: uint
{
}

public abstract class Type_6a86308c1cf349078366a871c6ec43f4: double
{
}

public abstract class Type_ca3862a99406400aaf98e40dfd364eb9: uint
{
}

public abstract class Type_1971089fd4af42d58a8bb2b9f34cf45e: SpawnPointDefinition
{
}

public abstract class Type_dd2e11435cf148499eae29ca5f76ec5b: List<SpawnPointDefinition>
{
}

public abstract class Type_519dc2cedae546bfb7e43aa6e68a02d2: string
{
}

public abstract class Type_76c8293c76804414843397f7f3dc4dd8: string
{
}

/// <summary>
/// Union of literals:
///   - item
///   - entity
/// </summary>
public enum Literals_ea751ba860af4958ad5d4f7db9c40b28
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

public abstract class Type_90ba27da49e94da4a6f21b279e887031: float
{
}

public abstract class Type_f91d1ae56722477e83b00b32d3140c46: float
{
}

public abstract class Table_005cb6565fb7484286215fbff996f278
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public abstract class Type_1a3ea289eac54c2190ba5e8b49f7b496: float
{
}

public abstract class Type_7468350ab61c45c58db092d4d8be1f7e: float
{
}

public abstract class Table_7784678ae1184e25b7378a29ed7300c6
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public abstract class Type_47e0481b9ead44088a5e93eada00978e: bool
{
}

public abstract class Type_4fc3b6e9f0474b85b04669c0cc396b26: bool
{
}

/// <summary>
/// Union of literals:
///   - and
///   - or
/// </summary>
public enum Literals_425054c199004d61a974be9604663d1a
{
  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

}

public abstract class Type_9c2473cac6f14f7891b1f5f4b17bc56b: CircuitCondition
{
}

public abstract class Type_d02396f37367479c8ba371b02c53606d: uint
{
}

public abstract class Type_aa5d2ff6ee50429596b869e586f6772c: WaitConditionType
{
}

public abstract class Type_4cc4ae962e2c4894882059d258b11115: CircuitConnectorIdEnum
{
}

public abstract class Type_8d4bfe345fd94f3fbd6958d8b4649bfb: WireConnectionIdEnum
{
}

public abstract class Type_837e8980d0ad4e9b9bf65bcd90ade0a8: CircuitConnectorIdEnum
{
}

public abstract class Type_02a40eeebfa0463582f8e434a06eb9f9: LuaEntity
{
}

public abstract class Type_8e027f714cd14afeaeea2153b00c8824: WireConnectionIdEnum
{
}

public abstract class Type_40d3a5452f06423b926ae3a904508354: WireTypeEnum
{
}

public abstract class Type_20e5c15d96b542169bf00520f80240ba: bool
{
}

public abstract class Type_7f185c178ac54d488cda7bde6c91bed9: bool
{
}

public abstract class Type_6d411d568c734905bb24df445217d6c6: bool
{
}

public abstract class Type_b6e003322f8e48a58d97c9116351e13a: string
{
}

public abstract class Type_a2764cdae8d04a22a78293ad89b960d7: sbyte
{
}

public abstract class Type_6a59b9ad00934ff3bf7d50a7e6bf8554: bool
{
}

public abstract class Type_ef6cb8473e1c4eadb64f663b02fcbd57: string
{
}

public abstract class Type_e20bff47774f486aaffae64a2f9a1cbe: string
{
}

public abstract class Type_1fe4998b92b0430a96b4b16fa7bf2376: SignalID
{
}

public abstract class Type_71579f9684b6496782f2f13e3f6f3670: bool
{
}

public abstract class Type_25e345777f3a4f1cafc799a4c03425f9: string
{
}

public abstract class Type_ce72f868ab4d4ee694fa530677d4ba33: bool
{
}

public abstract class Type_4c3bf59f42b84b95a1fc35d4efedd853: bool
{
}

public abstract class Type_db9c723a837540c2bdf330caf6294df9: LocalisedString
{
}

public abstract class Type_1cbdc556277d473a8d147d8288ae1821: LocalisedString
{
}

public abstract class Type_a1ffcaaba2764206a3a1804962fcbb0b: string
{
}

public abstract class Type_7bb90e98105c40c78164e09e8018c395: string
{
}

public abstract class Type_b327fcb399e7480185c74f6afe9bb60c: string
{
}

public abstract class Type_46aa00f331a8445c9e4336c91d0ce562: bool
{
}

public abstract class Type_bff540196db048e9b7533475601e4178: string
{
}

public abstract class Type_3b0eda25e0c947dd917a4a317b21ba7d: string
{
}

public abstract class Type_b89df13c958148d4931676c1cb39a896: LocalisedString
{
}

public abstract class Type_1e4f712f164646819f410ac44efe6692: LocalisedString
{
}

public abstract class Type_11e1a4c0f83e436898d100350d5ba1d4: string
{
}

public abstract class Type_fcfefb9cd47b495585cda2e8504b62b1: string
{
}

public abstract class Type_4b2e2888c80a4a5297d3b181ec83476e: string
{
}

public abstract class Type_547e0522a2194b56a11646b27a54dc6c: bool
{
}

public abstract class Type_dd2b32d67f3e4892b8874e76d906f3fe: string
{
}

public abstract class Type_8cb672e058e141cda7cfdab7b81195a9: string
{
}

public abstract class Type_4f1f8bc485154fc99dd51055b818a1a9: ArithmeticCombinatorParameters
{
}

public abstract class Type_428b4e2ee6cc46938e391ab26bdce27b: bool
{
}

public abstract class Type_384fec23a29348a3bbb0eac37062946f: string
{
}

public abstract class Type_9414b641d18e43d5be04722bc1076b55: bool
{
}

public abstract class Type_7f6c974c761a4f7d9f9b3422e1ed87cd: string
{
}

public abstract class Type_5b1794e2a7d7408481a4d382f942aca4: string
{
}

public abstract class Type_6fcca16f6db2454bb639a2204f2665ce: LocalisedString
{
}

public abstract class Type_cf7aab5d40d349c1bc4ced2c0064ff55: LocalisedString
{
}

public abstract class Type_fcfbdb569980431db0214b0d23235ceb: string
{
}

public abstract class Type_e3ce6e32d91b4caaaf273036abea39e2: string
{
}

public abstract class Type_bfa8ea64863d49378214b36b4a1c9fb6: string
{
}

public abstract class Type_17330c564a1c479ebf8a778fc4bc3053: bool
{
}

public abstract class Type_c4022b13932c4cbb90c5fd82fbc76144: bool
{
}

public abstract class Type_f0005565f47740f1a3ac611b76d4252e: string
{
}

public abstract class Type_7515aa6226a54375a08d18e5915d74c2: string
{
}

public abstract class Type_ccb993525cb340f0b64fe542373bf00f: string
{
}

public abstract class Type_a324f3fced6c45f8b7e2acfc49181422: Dictionary<string, string>
{
}

public abstract class Type_784e8f87ff0942c0aeef0acd5cbccf0b: string
{
}

public abstract class Type_86f9b77ab0b34d72bfc4cd4894f82df4: bool
{
}

public abstract class Type_3be3ccce5f90407c9e617d7ea97ab1ac: bool
{
}

public abstract class Type_937228b971b24461ad18620800e1f684: string
{
}

public abstract class Type_6fa86c65b6eb48f880dd1228a4cc27c7: string
{
}

public abstract class Table_a7bcf7fce3e74f4e8c4361e2ae3d640a
{
  /// <summary>
  /// Is this level a simulation? (The main menu and 'Tips and tricks' use simulations)
  /// </summary>
  [FactorioRconAttribute("is_simulation")]
  public bool IsSimulation { get; set; }

  /// <summary>
  /// Is this level a tutorial?
  /// </summary>
  [FactorioRconAttribute("is_tutorial")]
  public bool IsTutorial { get; set; }

  /// <summary>
  /// The campaign name if any.
  /// </summary>
  [FactorioRconAttribute("campaign_name")]
  public string CampaignName { get; set; }

  /// <summary>
  /// The level name.
  /// </summary>
  [FactorioRconAttribute("level_name")]
  public string LevelName { get; set; }

  /// <summary>
  /// The mod name if any.
  /// </summary>
  [FactorioRconAttribute("mod_name")]
  public string ModName { get; set; }

}

public abstract class Type_26d405b18ea24fb9a5def1b1fa653022: string
{
}

public abstract class Type_fdb5314acbb04a3c8929f4673fad117b: string
{
}

public abstract class Type_0a0caf975c64493cbd8f0e45fa36900a: uint
{
}

public abstract class Type_0baa8dc847144d8da3af9ba6d560dac2: uint
{
}

public abstract class Type_af68081f7e75496a9464195b136571b8: EventFilter
{
}

public abstract class Type_1f0fffc9e6544b2eb7299067b1afc6a4: uint
{
}

public abstract class Type_c6a125a148f84acdabe9b37d75d406a1: EventData
{
}

public abstract class Type_640bc561b2bb4308bf61fd4d2b6e6ec8: Action<EventData>
{
}

public abstract class Type_36cbd14f7e09415cbe731f4f96bc4c06: string
{
}

public abstract class Type_095889f0cb52475986436390eef00576: string
{
}

public abstract class Type_3ff58b3326f547daa149c0d71ed4b869: string
{
}

public abstract class Type_b674dd64b65c49adb5fc05f8d1ccdc93: PrototypeHistory
{
}

public abstract class Type_dff29aa0b1c441d1b294d849b4699cfc: ConfigurationChangedData
{
}

public abstract class Type_0674dcd7f44d42bc8d9cc28932f9fdbe: Action<ConfigurationChangedData>
{
}

public abstract class Type_04ff53696a084c2cb2918ce6dddc8a74: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_d10e6436ca9c4ef4a9610e1d073c18d3: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

public abstract class Type_afd20e4ab21346a5ac224d7a95e9d430: EventsEnum
{
}

public abstract class Type_054f02b5ce3e4c398d617f2ec17a9742: string
{
}

public abstract class Type_b6b8facb2e8c4ce68991ec0559ec2013: EventsEnum
{
}

public abstract class Type_933f04828deb4e3e985a3e145281b402: string
{
}

[GenerateOneOf]
public abstract partial class Union_dc535a3e373440f5bfb5fbbf1339608e: OneOfBase<EventsEnum, string>
{
}

public abstract class Type_67c10665d1d34a019181405387c47e4e: List<Union_dc535a3e373440f5bfb5fbbf1339608e>
{
}

[GenerateOneOf]
public abstract partial class Union_c3fc47f8c0d742cb9fd7569d48b6fa8c: OneOfBase<EventsEnum, string, List<Union_dc535a3e373440f5bfb5fbbf1339608e>>
{
}

public abstract class Type_60c7defce608430696baa4f1ccb62ffb: EventFilter
{
}

public abstract class Type_ad05fb80d33e4a83a65981f9eead7980: EventData
{
}

public abstract class Type_46d84ca76ad543f189b6cf4c39383d0d: Action<EventData>
{
}

public abstract class Type_97abcf558bfa4dccaf2d27cc87fdc9df: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_ea5cf87449214096ac98dfabc987a854: OneOfBase<Action<EventData>, LuaNil>
{
}

public abstract class Type_f3a382a4c3214f68acd6ef138ee5cf05: Action
{
}

public abstract class Type_fce324fccf9e4515aa0951aad90d9d98: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_1d64fb148e544df59d90910bf978046b: OneOfBase<Action, LuaNil>
{
}

public abstract class Type_8e2f731873a3420c8b3d5506ab485b8b: Action
{
}

public abstract class Type_c36340e2d11349debd6e3d64f7156550: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_45ef2df347f54e4a984439994e18b34c: OneOfBase<Action, LuaNil>
{
}

public abstract class Type_3ed3054ebb6d4667b22d2f01373e770c: NthTickEventData
{
}

public abstract class Type_36e2aa325f0b4514bddb88374cc24bbd: Action<NthTickEventData>
{
}

public abstract class Type_7c49004fb88743f598a9ae11769326e5: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_337ad96fc50947f8988001bd43aa61e1: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

public abstract class Type_96a0514896b9455d99fe551ebb0a2d88: uint
{
}

public abstract class Type_87fb05df17514055bb72a5a4b82c5573: uint
{
}

public abstract class Type_9708c504da0346fe8fa58113d62f5c73: List<uint>
{
}

public abstract class Type_856ed46613814bf9940569095e3e8061: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_921a8fd49d8c4c77acbb7c1e8f6def72: OneOfBase<uint, List<uint>, LuaNil>
{
}

public abstract class Type_b7bb53c37269479990cd9fe6b204b4df: LuaEntity
{
}

public abstract class Type_9eba17fabca6430c895d2001298c6ebe: string
{
}

public abstract class Type_698194a9ba0a4b308bd14ceb796e3815: uint
{
}

public abstract class Type_c2f33945714b4151b48b131702f41f2c: LuaTable
{
}

public abstract class Type_f53dfd2fd84f442a98b244fceb1d0d93: uint
{
}

public abstract class Type_46e4447ce5b64dbbb41ba45b821ce2e1: uint
{
}

public abstract class Type_1bc338444b2e448eb77149d86cb57ba9: LuaEntity
{
}

public abstract class Type_0f8d6612b8654db08a91c4cd5ad63745: uint
{
}

public abstract class Type_d5b04556ba474aef9724007c05b17c6d: uint
{
}

public abstract class Type_3cd9114e6da04c15af164ffa5085bb9b: LuaItemStack
{
}

public abstract class Type_cfed1d418acb49869efdb6858a4ad1d4: uint
{
}

public abstract class Type_20d3793572a747fb8c01b5e4b1730089: LuaRecipe
{
}

public abstract class Type_2a35c5e714ef4506a703aea49a75d58c: LuaEntity
{
}

public abstract class Type_2da23853bac44ed0b013ad3ffbd3d04d: bool
{
}

public abstract class Type_8d332b32235e4e78b3ad52293bc09f57: bool
{
}

public abstract class Type_2915f7f6b40f4e9897518b37e266e4a2: uint
{
}

public abstract class Type_e0dbb3f816cf47b596d7bbf5c8316c3f: LuaEntity
{
}

public abstract class Type_d9bc68eda1e44e4290f45a5278c02c1d: LuaEntity
{
}

public abstract class Type_6ffcfff8adbe49659cb9dcbd63a9168b: LuaEntity
{
}

public abstract class Type_9142631681de45479061fd49d64d7b91: Tags
{
}

public abstract class Type_b2182c7a0a6948fba47f67c226ee8562: uint
{
}

public abstract class Type_34e5bbd336d04a04a3203bea944be768: Tile
{
}

public abstract class Type_2c9c23e58c7a42b998c5a140842fd79c: List<Tile>
{
}

public abstract class Type_4ad23d584b434cef9f2901e4790a5c83: LuaEntity
{
}

public abstract class Type_9a2ca2669edc40fbb8f93bbd3354c658: MapPosition
{
}

public abstract class Type_fbb21f246f694766a4acbb9c384471f3: byte
{
}

public abstract class Type_0079cc18874b4b8cbcf6c125e72d33bf: LuaTable
{
}

public abstract class Type_4ba989286afb42668e236e0ad236cbed: string
{
}

public abstract class Type_53ea1504c5484145934feda73e989410: LuaEntity
{
}

public abstract class Type_f13cab856aca4497973c91d5a94435b4: ulong
{
}

public abstract class Type_13a918aec2a74f0996378a2ebf37547f: uint
{
}

public abstract class Type_5861948cdc0b4754ad1af0fe32500331: EventFilter
{
}

public abstract class Type_0ccbe3e1e3a34cdf8c45471b4c5a238b: LuaInventory
{
}

public abstract class Type_2d4fa93e2d43456da03df634e9570d29: LuaItemPrototype
{
}

public abstract class Type_e615f7e908e34bad92044aaa10deab7a: string
{
}

public abstract class Type_cbe2c36756964c2c88b22be771f24a76: bool
{
}

public abstract class Type_e31ee313a78c4e57978d6d1d8a574377: Dictionary<string, bool>
{
}

public abstract class Type_65973f743a2140a8a35eb08b91f7d283: double
{
}

public abstract class Type_4f14656b7d984412b268be9567a7ee5d: double
{
}

public abstract class Type_7cfeec57093d42fcb03266782b9dec7e: LuaInventory
{
}

public abstract class Type_de88ba1f43da4f0caa021feda7c06dd1: string
{
}

public abstract class Type_bed027b6c785415f9ac7814d069219fd: LuaEntity
{
}

public abstract class Type_243ef482e6de42479f4488f1ed3c80d1: LuaEquipment
{
}

[GenerateOneOf]
public abstract partial class Union_22248c083705454fbdfa7125a8bdbf7f: OneOfBase<LuaEntity, LuaEquipment>
{
}

public abstract class Type_12bd5f2c02374bb3b734b9ff8242671a: double
{
}

public abstract class Type_335288339be64e0b967b423060a8d882: bool
{
}

public abstract class Type_2ed438cd70fb4450bbe4e56803c59f72: string
{
}

public abstract class Type_34dae306dba94d3793672591fec000db: uint
{
}

public abstract class Type_c2fad53a5549426bb9b5c94a315f86ca: double
{
}

public abstract class Type_55621a583e8d49248af089a13df8a839: double
{
}

public abstract class Type_765750d3b7394280b447df28a616bf6c: string
{
}

public abstract class Type_0050834554b94c91b4e69c8acd73fc47: bool
{
}

public abstract class Type_a388ca9e2a94411bb9fec871d99d57e2: Dictionary<string, bool>
{
}

public abstract class Type_731ff26b255340c3be8d65bade1e79e9: uint
{
}

public abstract class Type_3a0eb9b2a8a64ddda9771622c9fb3eca: float
{
}

public abstract class Type_bcc20ce52c1240c2bc01577ece22668e: Color
{
}

public abstract class Type_a9184e42f66c45508b7598948dd8daac: float
{
}

public abstract class Type_fae04c8426f040c3be1f04083b0bf197: float
{
}

public abstract class Type_942ba4032d1f492aa332e718e0d126ab: float
{
}

public abstract class Type_b01c0bf105184093a3d156a2f490560e: float
{
}

public abstract class Type_eca531ea9edf44678f51f027e99cc8a7: float
{
}

public abstract class Type_b3f010bf5f614f71b87afd717aa316af: float
{
}

public abstract class Table_f9f71e6b0e3c446794114f916c9de91d
{
  [FactorioRconAttribute("minimum_intensity")]
  public float MinimumIntensity { get; set; }

  [FactorioRconAttribute("maximum_intensity")]
  public float MaximumIntensity { get; set; }

  [FactorioRconAttribute("derivation_change_frequency")]
  public float DerivationChangeFrequency { get; set; }

  [FactorioRconAttribute("derivation_change_deviation")]
  public float DerivationChangeDeviation { get; set; }

  [FactorioRconAttribute("border_fix_speed")]
  public float BorderFixSpeed { get; set; }

  [FactorioRconAttribute("minimum_light_size")]
  public float MinimumLightSize { get; set; }

  [FactorioRconAttribute("light_intensity_to_size_coefficient")]
  public float LightIntensityToSizeCoefficient { get; set; }

  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

}

public abstract class Type_2f099b3780ab43938445c09736b2186d: string
{
}

public abstract class Type_c3e7986a0382465cad888fe7e7cffb1e: bool
{
}

public abstract class Type_a9aed6d1d2684621bf695c30f2fa8ecb: bool
{
}

public abstract class Type_b7e0f8c4e35143f480506b2511b24233: SmokeSource
{
}

public abstract class Type_6be024e759de4a6696a1b98a99f2149d: List<SmokeSource>
{
}

public abstract class Type_730a787fbf304bc892235798f9cdcb48: bool
{
}

public abstract class Type_eed4f84b59ea417e87a5634377871ef4: string
{
}

public abstract class Type_93a7b68e89dc4880bd494b23c3ac5f9b: string
{
}

public abstract class Type_ed2165d97e57412d8c1a3fd821e80b44: bool
{
}

public abstract class Type_a247ef5eb02b49e887a947827517fcd0: string
{
}

public abstract class Type_c37db86530cb4101adc9f100aae557e4: CircuitConnectorIdEnum
{
}

public abstract class Type_ea75896a139d41e5a63a3d4985abf563: uint
{
}

public abstract class Type_99488da64a3e44919714921a99c81b63: LuaEntity
{
}

public abstract class Type_44e1660eb65f4f4aa1877184dfd4b138: uint
{
}

public abstract class Type_0bac3c87335a43dab5ef86851f2c3914: string
{
}

public abstract class Type_65e8522ba3234672b844f56331dc6da3: Signal
{
}

public abstract class Type_d815ee6c23f94400815f979728db5428: List<Signal>
{
}

public abstract class Type_1b318c8731f447ffb15b0ac05ec0c1ae: bool
{
}

public abstract class Type_c86dce9798104fec908d8b4e94588212: WireTypeEnum
{
}

public abstract class Type_30322421a1864ace8c903a306f6f383a: SignalID
{
}

public abstract class Type_4fa07e7ec76a48d4b5cecae8c2b63b02: int
{
}

public abstract class Type_f25c5a717c54460692b4479d0da44afd: string
{
}

public abstract class Type_9874fc75a5d44025835c2da63169253a: Signal
{
}

public abstract class Type_cd031188d27a4570a1f6424774d5afa2: List<Signal>
{
}

public abstract class Type_de04b5deeb8a458fb4f1b4451c7b9a29: SignalID
{
}

public abstract class Type_9741374e3b8f48f4bcb6c7c98e3bfb09: int
{
}

public abstract class Type_a2aa1818881447d2bccf94906b37bef5: string
{
}

public abstract class Type_2609e665b90f438ebcbb672e7e4e1873: LocalisedString
{
}

public abstract class Type_fa75b141043648e4aaa2e05613cf6e33: Dictionary<string, LocalisedString>
{
}

public abstract class Type_366f3ae44ab3462e90a6ce5b29bbc181: string
{
}

public abstract class Type_e2bbe38d0dc045a384a06dc18d0dd08f: LocalisedString
{
}

public abstract class Type_e8b503c377324035a4e5a11585f5f5c6: Dictionary<string, LocalisedString>
{
}

public abstract class Type_207104bc16a04dd997722b0baf982531: string
{
}

public abstract class Type_27de0dc0fe0b4a0e8efdbfa5ee990efa: CustomCommandData
{
}

public abstract class Type_b84615f0279241c3b06aea40127da437: Action<CustomCommandData>
{
}

public abstract class Type_984354f571a04554af7180bf2dd67de2: LocalisedString
{
}

public abstract class Type_cd0d46f319cb4b23898e2fe1500deec9: string
{
}

public abstract class Type_527d7e3d6c804a6e8edcda36b5e05f29: string
{
}

public abstract class Type_99204a1e88934bbf8d37d89f1f82db61: bool
{
}

public abstract class Type_f42b3d66d7a64ab09962a14d978e2e6e: bool
{
}

public abstract class Type_0b996499707341849f4b22ebf89f5fc5: string
{
}

public abstract class Type_e4339aac14c1495f8e010db3f39c02a8: ConstantCombinatorParameters
{
}

public abstract class Type_293b599d98d94ecb8b89fa5c2906cb61: List<ConstantCombinatorParameters>
{
}

public abstract class Type_0625ec8e2aee4db7a6705db7cead125e: uint
{
}

public abstract class Type_cab7e29969fa429984cd697750efe5bc: bool
{
}

public abstract class Type_68a376319eba423e9736cb14958c7012: uint
{
}

public abstract class Type_5114e991f60a450aa755f49a52225908: Signal
{
}

public abstract class Type_4f6b91cba7c94d2bb0ad028b4792d72b: string
{
}

public abstract class Type_4102f54295e94a078c88985be96a3f70: uint
{
}

public abstract class Type_1befa7f0acef4d72a3d331eee25accdb: Signal
{
}

public abstract class Type_33ad1846aa4d43e1b55c89d2d4ba33d2: string
{
}

public abstract class Type_17e7df6829834984881f1981bfed31de: bool
{
}

public abstract class Type_da415bce38a849d68ca918803b15b077: string
{
}

public abstract class Type_3c4f809ea8764290901c3db0ba9be1f8: uint
{
}

public abstract class Type_8f86d028cf5b4e67a14d082632c42f89: string
{
}

public abstract class Type_c8db894c6eb9455e8614fc2acbf75c48: List<string>
{
}

public abstract class Type_63f0112ee7884d4d87cd01781309608d: uint
{
}

public abstract class Type_a1f10f00bce64c18ac2496157b6cf453: double
{
}

public abstract class Type_8bec4446556d47e3a60a3466ba42ef8d: float
{
}

public abstract class Type_528f448f75b640a097e119b36eaf3c90: uint
{
}

public abstract class Type_3cdd82a2de77450fa5c28385d0a29770: uint
{
}

public abstract class Type_091b3ee394094f2f86bd19a97c21753d: uint
{
}

public abstract class Type_47ef1b991d8d46388e6439005bb4af37: uint
{
}

public abstract class Type_9386cba0fdb84af39a8952dbd8884f19: uint
{
}

public abstract class Type_e2af1f96dfb8447483263305201e94b2: double
{
}

public abstract class Type_a1ddc3cbb79747d192a0198585c7f049: double
{
}

public abstract class Type_bc1ddf182e53479d9b0acbabe5d8bacf: bool
{
}

public abstract class Type_9f711128caf541aa82d0b5dc6cfd964e: uint
{
}

public abstract class Type_0fd83912bdb8406a89f5ce4096e629ce: uint
{
}

public abstract class Type_fa93eb907cdc472e8209348cb13c6df1: double
{
}

public abstract class Type_b42ee22cc3a94571ba61e2a90207baad: double
{
}

public abstract class Type_3145799ac940432690b315d9b67089c7: uint
{
}

public abstract class Type_5df449cf88a34279a66cb5c3ab6f0e98: bool
{
}

public abstract class Type_9434e3c9002748b49571de5d5c110eb7: CraftingQueueItem
{
}

public abstract class Type_c809f832eded4679948af76284c2f760: List<CraftingQueueItem>
{
}

public abstract class Type_8f595b8533ca4d68ba5659d0c03cc19f: double
{
}

public abstract class Type_134d9ab56e4e4bd5980a51a71cd252a8: uint
{
}

public abstract class Type_2a5b0e5889134c6096290698228711d5: ItemPrototypeIdentification
{
}

public abstract class Type_a33274f527b9409f934096d9f93c0db9: LuaItemStack
{
}

public abstract class Type_6df655e466b94917b4e6249b76b9dee4: bool
{
}

public abstract class Type_e617f064833e4d7d8541b6406eb9d220: uint
{
}

public abstract class Type_72a8553b463246179ff0f5ee2e1fc635: LuaEntity
{
}

public abstract class Type_cb54b8a2ec9a4b74a91a0f481f733a30: List<LuaEntity>
{
}

public abstract class Type_aa291cf180494f53bce3353af019640a: ForceIdentification
{
}

public abstract class Type_a07c8b82962f49a5997c1857d99126c5: uint
{
}

public abstract class Type_6f456a73c3d34303b1134ab4dccf62fc: bool
{
}

public abstract class Type_c21b5905d39644ea9d98cff888b7f843: double
{
}

public abstract class Type_00502ab3582c4b7b8a0c51f98f2cd558: double
{
}

public abstract class Type_62ac7ca11dde4db8afc34057817e15b1: bool
{
}

public abstract class Type_cb2e9924949a4e03b439a12bcd208d5d: MapPosition
{
}

public abstract class Table_ce673fef899945c1bc60003e7c3d7bd7
{
  /// <summary>
  /// Whether the player is mining at all.
  /// </summary>
  [FactorioRconAttribute("mining")]
  public bool Mining { get; set; }

  /// <summary>
  /// What location the player is mining. Only relevant if `mining` is `true`.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

}

public abstract class Type_b972cb3e0e0a4d97ac358740e389e046: LuaEntity
{
}

public abstract class Type_7d7d8c59b348492e9a2631f8bb698400: LuaItemStack
{
}

public abstract class Type_3c896611ca5c4de0af66a03ca134ba91: LuaEquipment
{
}

public abstract class Type_9c2f6d75f54e473598f7721da0155731: LuaEquipmentGrid
{
}

public abstract class Type_bf5c6af58f1b440bb265dbb85e4de2b7: LuaPlayer
{
}

public abstract class Type_a4f24b4d2be54c4381549a014edfc862: LuaGuiElement
{
}

public abstract class Type_9c6e076cc03645fc96febdcced15ee04: LuaInventory
{
}

public abstract class Type_965b7f0479574aeab9350a70dfca39d2: LuaTechnology
{
}

public abstract class Type_4a887628e292430b829523eefb7d361c: GuiTypeEnum
{
}

[GenerateOneOf]
public abstract partial class Union_552c3a3b36ff40ad9296c23cc9126d72: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public abstract class Type_a22f5e295e4c44369f86b484d9666e60: GuiTypeEnum
{
}

public abstract class Type_338d5fad302146a1b822f01cf4abf95e: bool
{
}

public abstract class Type_bd118fbead08417680ad1d1cd990005c: MapPosition
{
}

public abstract class Type_5eeff82b2e994a01bed909b402ca96ae: uint
{
}

public abstract class Type_797945560f3543c29910325aedede897: MapPosition
{
}

public abstract class Type_f1be24f72f044b618bf79cf4aaae7457: bool
{
}

public abstract class Table_3db650697a804652ab01647b33cadbb6
{
  /// <summary>
  /// The current state
  /// </summary>
  [FactorioRconAttribute("repairing")]
  public bool Repairing { get; set; }

  /// <summary>
  /// The position being repaired
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

}

public abstract class Type_811545a4811d461788d171a9632c32e9: double
{
}

public abstract class Type_bb6e1aa6712746b0a88b6f8f20a6d388: RidingState
{
}

public abstract class Type_b06cceed69bf4e649494e03277401437: LuaEntity
{
}

public abstract class Type_e21c01a2d03d44609a4af0034fd68455: MapPosition
{
}

public abstract class Type_6dfc7e7b095c418b89ed238da1c16573: ShootingEnum
{
}

public abstract class Table_542e3bc776aa4b9a86502c7d408e8a34
{
  /// <summary>
  /// The current state
  /// </summary>
  [FactorioRconAttribute("state")]
  public ShootingEnum State { get; set; }

  /// <summary>
  /// The position being shot at
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

}

public abstract class Type_8ad393bb025340d4a77762312b91e17e: LuaSurface
{
}

public abstract class Type_ab4d9904861d4f0c97fd69f219715c9b: uint
{
}

public abstract class Type_e336bce1bed34f1ea511dc3402a10c91: LuaEntity
{
}

public abstract class Type_a2adff067e324cff9f4016cd1921cb3c: bool
{
}

public abstract class Type_865ce942379f48e48fa09e21810ed615: DirectionEnum
{
}

public abstract class Type_ed8d26826fcf4042a6e18b5b87c301ba: bool
{
}

public abstract class Table_18065982f36f4cfb976a275fd2df409d
{
  /// <summary>
  /// If `false`, the player is currently not walking; otherwise it's going somewhere
  /// </summary>
  [FactorioRconAttribute("walking")]
  public bool Walking { get; set; }

  /// <summary>
  /// Direction where the player is walking
  /// </summary>
  [FactorioRconAttribute("direction")]
  public DirectionEnum Direction { get; set; }

}

public abstract class Type_68f41d8a73c54735953a3957e097d575: uint
{
}

public abstract class Type_00313314e39c44888e25554003b43944: string
{
}

public abstract class Type_953e221fd84e486eab867761581a6f6c: LuaRecipe
{
}

[GenerateOneOf]
public abstract partial class Union_04469ceb014746c7aa6313455e286380: OneOfBase<string, LuaRecipe>
{
}

public abstract class Type_b66cef0db1be44b49416e5eabe3ff31c: bool
{
}

public abstract class Type_e65451871a574dffa217098ae0d9b723: uint
{
}

public abstract class Type_0da5f5be21f04a51bbd0c16fe0cffee2: ItemStackIdentification
{
}

public abstract class Type_1a5e4ab62ff74675b305b231024942f9: bool
{
}

public abstract class Type_2ba918fcb0494cedb5784a252bbec0b5: LuaEntity
{
}

public abstract class Type_d52852b4abdc4388993ce0e02869a579: bool
{
}

public abstract class Type_abd0f34e1efc4cf595c784090d0ebb69: uint
{
}

public abstract class Type_a188994ec1ce4187bbe6e7fb67057300: uint
{
}

public abstract class Type_7f829dae1a784c28b893e17d0bc3abc8: uint
{
}

public abstract class Type_a35c98bacfd94e52aaa853732e0029b5: uint
{
}

public abstract class Type_d0c10f28486f4478ad8e1daa47ccafc1: BlueprintEntity
{
}

public abstract class Type_04402b98ba6f43939eb5ae9b2be8c524: List<BlueprintEntity>
{
}

public abstract class Type_23c588041996458cbdf31921b8191c0b: string
{
}

public abstract class Type_4adc9e242be945ca860352444aff2d07: LuaRecipe
{
}

[GenerateOneOf]
public abstract partial class Union_8a185aea1f7246c0ab504f5bc6d4ec3c: OneOfBase<string, LuaRecipe>
{
}

public abstract class Type_129a2d6878984cf592d344360df27d90: uint
{
}

public abstract class Type_17d789120dbd4bedb9af781113667f5f: InventoryEnum
{
}

public abstract class Type_acfbdfeb9a6b466d8b528acbf4882e2f: LuaInventory
{
}

public abstract class Type_acfad68d0e234c90bfd3697c17395251: string
{
}

public abstract class Type_8b26e40e7b574b62bbb839018c22e64b: uint
{
}

public abstract class Type_8f510e51e5bf477cbbc363088e257a9e: LuaInventory
{
}

public abstract class Type_d5b41508879c4abfba680fcdfed5769e: InventoryEnum
{
}

public abstract class Type_dbc91d8a039b4e15842a4a6a4f1a3a51: uint
{
}

public abstract class Type_a37633edc1a842b289ad21a0147dad8e: LogisticParameters
{
}

public abstract class Type_feb13aaa982344e28db60b6a16a5b97d: uint
{
}

public abstract class Type_f251950d8c7f4cffa2befc6fa563ac93: LogisticParameters
{
}

public abstract class Type_74d92305cf614201b2225e22fccb7f1f: bool
{
}

public abstract class Type_631dbe169efd4225b0bd04ddba360461: ItemStackIdentification
{
}

public abstract class Type_7e1442481e5d4915898d40134f457b07: uint
{
}

public abstract class Type_9b9137d6cdb847fb98b9ba388e27f53e: bool
{
}

public abstract class Type_932da61c184f4eebb1ff5a8a8a072fb8: bool
{
}

public abstract class Type_abf1a91f4f13464782221122a7dd93a3: bool
{
}

public abstract class Type_62636f1aaaea4708ab6b6a5690e83520: bool
{
}

public abstract class Type_84d52302198d4a37a63d77d1315ebdcb: LuaEntity
{
}

public abstract class Type_c51888fb942e44dfa4ed59f0bc09c36e: bool
{
}

public abstract class Type_ace390d0f3d247979cd565f53c4ed9a4: bool
{
}

public abstract class Type_14ed8b3557af4824a7720028ba8fc32b: LuaTile
{
}

public abstract class Type_28fe31fef48a42809f40655739ccc8bc: bool
{
}

public abstract class Type_2b6f6a9afa7949e6bc3ae7913ce403ad: TechnologyIdentification
{
}

public abstract class Type_982cb2a2091a4decaa9654f8e34dd8e4: ItemStackIdentification
{
}

public abstract class Type_a86c3e46146c4f858542ea8c052a735f: uint
{
}

public abstract class Type_828ebd017c794f73b10ac87fe00ec16b: uint
{
}

public abstract class Type_08aba32bcb93466484aee1c77707233d: GuiArrowType
{
}

public abstract class Type_debd7f0deec945bf852de04c046f6120: uint
{
}

public abstract class Type_628d20f9aa7143e7890e591d6198ba92: LogisticParameters
{
}

public abstract class Type_997d0454c75346d4a6eeffdb23588c17: bool
{
}

public abstract class Type_afee7f10601e4ee9998d90275809a210: uint
{
}

public abstract class Type_dd144c57c4cd41fca99a6e35dec8c49f: LogisticParameters
{
}

public abstract class Type_8fb4549ff5a34116981409396abe1a71: bool
{
}

public abstract class Type_c8d81d0290504fe8bd676976f0aa820a: MapPosition
{
}

public abstract class Type_c46c71b72ec8411da1230fab463bd8b5: bool
{
}

public abstract class Type_94fffcaafa2e4804bfe23024e439606c: SurfaceIdentification
{
}

public abstract class Type_eeecfd919bf54cdaa3f216007fe7aefd: bool
{
}

public abstract class Type_edad5537c63543eba41628428a7f8fc2: MapPosition
{
}

public abstract class Type_ebba7734ab834c5c9d91dee89558b40f: LuaEntity
{
}

public abstract class Type_60cb3b3592814c8ca37ff76802bf478b: ControlBehaviorTypeEnum
{
}

public abstract class Type_b870cdfd5bff47b7992063618cd5bd6a: CircuitConnectorIdEnum
{
}

public abstract class Type_97a52b540e0340b4be0782c3e048f95e: WireTypeEnum
{
}

public abstract class Type_91799283b19e462eb01dd643865dcd26: LuaCircuitNetwork
{
}

public abstract class Type_e44ee6625b884c97adb0a94c0148ca9b: LuaForce
{
}

public abstract class Type_a2b231552ba141cab0df158696595f83: SignalID
{
}

public abstract class Type_4f7b33fe7a2f4686aba12552e1cf9b84: LuaPlayer
{
}

public abstract class Type_3a6c8134ee03459bba1e0550e754519a: string
{
}

public abstract class Type_624da5e962db4ee7a5b2397f582224ca: MapPosition
{
}

public abstract class Type_b82e49c5c3344088b067e9ba9d672d0f: LuaSurface
{
}

public abstract class Type_64d6ba5926e94d5387b57abf72c4e00c: uint
{
}

public abstract class Type_53e4c08c1d8046a6a2a27901b79e6d65: string
{
}

public abstract class Type_63130dcac5ae404783f36616eb7e8008: bool
{
}

public abstract class Type_f14ff705afff42a88be53de28c2a622f: string
{
}

public abstract class Type_5414b20bca784ff2996dc4dcc26bf2f0: string
{
}

public abstract class Type_66de25afc2c349b29bfc59683ac780f2: string
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals_eb6caa392a0d44a4b2c3626f79106841
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

  /// <summary>
  /// Literal value: game-only
  /// </summary>
  [FactorioRconDefinitionValue("game-only")]
  Gamesubtractonly,

}

public abstract class Type_e11670cb9e024278a72f52d55544b469: string
{
}

public abstract class Type_a6e6ba7fbe6d409e87e23055e4169840: string
{
}

public abstract class Type_5f769282a72949418c954ff972e88782: bool
{
}

public abstract class Type_56d800c539ea46e99b507bc16a0fb3c8: bool
{
}

public abstract class Type_dc7c703834ed45218800a572b94d715b: bool
{
}

public abstract class Type_3ee913acdc2b46968dd85a252da53edd: bool
{
}

public abstract class Type_2d65119156884c0a8afea4ed17381db7: LuaItemPrototype
{
}

public abstract class Type_cb380c183f2e4075afaf61c770adccf0: string
{
}

public abstract class Type_5fb8dca0d9674540a8ad998a79a4ea5a: string
{
}

public abstract class Type_fd7ae8e086d0497680f9659af99ac9dd: LocalisedString
{
}

public abstract class Type_81eaa460e39140a59b15ffd854b8194f: LocalisedString
{
}

public abstract class Type_09ba50bc0fbb4c90953071f7b4cf020d: string
{
}

public abstract class Type_cfbdf3ee6dfa47a6b8a5a9ea72666096: string
{
}

public abstract class Type_b39d164884bc4da0beb3080878203446: string
{
}

public abstract class Type_26fb9877a240483b8346c6627c1b9bc8: bool
{
}

public abstract class Type_584611c9c5684875a0b3816b7245a5ca: string
{
}

public abstract class Type_1810b4e7f90e440d990f3658d877783d: string
{
}

public abstract class Type_a338c4c5113347eebd3e72c1d2cc4d48: bool
{
}

public abstract class Type_cec8b04b9c4f4964bb5d2fe9a8ff847d: Any
{
}

public abstract class Type_523771f58f7b4404b08265c6efcf3554: uint
{
}

public abstract class Type_2a5302e2a18449ada3b28b328fcd8b9b: string
{
}

public abstract class Type_e18811a37c5f4f74848857a3e98fbfc1: bool
{
}

public abstract class Type_f35cbba467f54839b0127365abecbb27: LocalisedString
{
}

public abstract class Type_b68f2f004f4646ca8af1457bcbafd275: LocalisedString
{
}

public abstract class Type_337f7aeb0e684912a1f7575524f2449e: string
{
}

public abstract class Type_c2767290bd734b92b052d6aa6a8efd08: string
{
}

public abstract class Type_bf06caf4c8524e8eb081e0c24e5c96d0: string
{
}

public abstract class Type_78bf15ffc15f453a9a66579ee52af09c: bool
{
}

public abstract class Type_fe5c1977cecf41b686e8fc9f93f8b393: string
{
}

public abstract class Type_887e029e01154ab7a696d67ea1f89b9e: string
{
}

public abstract class Type_a4179f8acd5943a4bb648b4dbea04e5e: DeciderCombinatorParameters
{
}

public abstract class Type_bd7d30b450144b14b41b708942e9aaa8: bool
{
}

public abstract class Type_ea61ea7c4a9e4859a80f10014b6d0a1e: string
{
}

public abstract class Type_96761d74013448fbbd44d3c7340f36c6: AutoplaceSpecification
{
}

public abstract class Type_ca904314059c4d7fada2f6daeee176a9: BoundingBox
{
}

public abstract class Type_4373f2c4829c47dab71ed6303ce88bad: CollisionMask
{
}

public abstract class Type_2b04d452e16f4a8db63bd528daeb5547: CollisionMaskWithFlags
{
}

public abstract class Type_bcc8eee4cc904ca38f38360831acba5e: LocalisedString
{
}

public abstract class Type_5071983b37d54461b8ecf6242d96d6a0: LocalisedString
{
}

public abstract class Type_e091b0139e3e4d798c3c26b9df57eb35: string
{
}

public abstract class Type_9252fad7e1704a7eb2ef9596e0af745c: string
{
}

public abstract class Type_c1b4eddb14234fd6a3be3654717fedfc: string
{
}

public abstract class Type_46493e12bb5448fe98088a7dccf501b4: bool
{
}

public abstract class Type_ad31aa1536af493090d33c5d13cb37d1: string
{
}

public abstract class Type_e40f2c6aeb824601997abffbf26425a9: double
{
}

public abstract class Type_2a9af888de534ba193dc3831f03c2c05: double
{
}

public abstract class Type_73084e2d6c6b4d049e1c1013cdad8ad0: double
{
}

public abstract class Type_5e0f3f84be9d44e088062c70bc2ca967: double
{
}

public abstract class Type_8b6c0f152e07487887ca45b63462e071: string
{
}

public abstract class Type_fc213a78d227408e856846c6534381dc: double
{
}

public abstract class Type_6e759735a25d4b2ab3ea81ff988d1468: bool
{
}

public abstract class Type_93c795e498e3449e975f2714db8bf744: bool
{
}

public abstract class Type_ec5ceb25a8824f3db71926ba51d38efc: string
{
}

public abstract class Type_bbe592fdbdf348a9ac83a4876fecaafb: bool
{
}

public abstract class Type_5874fe1d76f145dfa65f18a76786dcba: string
{
}

public abstract class Type_4d30229968cc451690a23945f82fc4c0: double
{
}

public abstract class Type_f789a611707b42aab211938c24efd0ce: bool
{
}

public abstract class Type_7c980a2d54c04449aa55241565a0cac6: LuaAISettings
{
}

public abstract class Type_23fafefdaad3473ca509d4e12acb9750: ProgrammableSpeakerAlertParameters
{
}

public abstract class Type_b89c78536e474458a36360d62228ed14: bool
{
}

public abstract class Type_854fdf70e35849c4a14dfe03069cb329: uint
{
}

public abstract class Type_fb343385afa940cd81c32d9ebbd013ee: bool
{
}

public abstract class Type_028983aeaf1840e1b4d79e5fc90308b1: LuaPlayer
{
}

public abstract class Type_6e6dfe8b3fe9473c94d8ebbb6acd5450: PlayerIdentification
{
}

[GenerateOneOf]
public abstract partial class Union_5985c939bcb94860b56a9def6f63452c: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Type_9eac781711004cdea0e94a119fe5a12c: bool
{
}

public abstract class Type_539553cbf07b4462a1c9b9257d298a74: MapPosition
{
}

public abstract class Type_1b9161fbe5ca4eaf978705b435a22459: MapPosition
{
}

public abstract class Type_63583bf764f740449d4d2ce01283ba7b: List<MapPosition>
{
}

public abstract class Type_42835284a15e4cfd84a2be802ea6be61: string
{
}

public abstract class Type_e014489c7fd146b3aa5b69ceaf816bee: uint
{
}

public abstract class Type_8165b4ea95044524b028fe51ac62c6b5: LuaEntity
{
}

public abstract class Type_353d4a1c8e5741988074378bf01c05eb: List<LuaEntity>
{
}

public abstract class Type_5c0a311249fc4cbd9db87869af144fb0: LuaEntity
{
}

public abstract class Type_88c518f36325461189357b42847ad7e6: List<LuaEntity>
{
}

public abstract class Table_d199bc275a174ef09c5efa546bac6e5d
{
  /// <summary>
  /// Array of transport belt connectable entities.
  /// </summary>
  [FactorioRconAttribute("inputs")]
  public List<LuaEntity> Inputs { get; set; }

  /// <summary>
  /// Array of transport belt connectable entities.
  /// </summary>
  [FactorioRconAttribute("outputs")]
  public List<LuaEntity> Outputs { get; set; }

}

/// <summary>
/// Union of literals:
///   - straight
///   - left
///   - right
/// </summary>
public enum Literals_3c92d9684029435ea52f6653ba82da11
{
  /// <summary>
  /// Literal value: straight
  /// </summary>
  [FactorioRconDefinitionValue("straight")]
  Straight,

  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

/// <summary>
/// Union of literals:
///   - input
///   - output
/// </summary>
public enum Literals_d851c3862e5f4206b9728d34e5feb81d
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

}

public abstract class Type_9b852f50bd5148f1a3a2054f7a70b6e4: double
{
}

public abstract class Type_c27ddf45484e4ac5b670f2789a3c5397: double
{
}

public abstract class Type_484d6d122aad48128059baa902b3e961: BoundingBox
{
}

public abstract class Type_885d3d4163e54520b6a6a9b0fd6d300f: LuaBurner
{
}

public abstract class Type_e7d5d221742a434aad6c8b6c009e5131: ChainSignalStateEnum
{
}

public abstract class Type_8946f908ab1946308e9fe8248bf7cd9d: LocalisedString
{
}

public abstract class Type_c8efe04295b64449b1a3493c1e263e3f: uint
{
}

public abstract class Type_038527ba7a4f4caea21029e622aa030c: uint
{
}

public abstract class Type_3747acb188674eeea9a2be35aea41b86: LuaEntity
{
}

public abstract class Type_1f5ef17afadf494b8dde81c87350f557: List<LuaEntity>
{
}

public abstract class Type_13d6121452644058b3a85f7b9a9dcc40: LuaEntity
{
}

public abstract class Type_cdb7a5a74ac148febb699919656bac66: List<LuaEntity>
{
}

public abstract class Table_c0b2dfe40b994d7288b359f156686514
{
  /// <summary>
  /// Entities connected via the red wire.
  /// </summary>
  [FactorioRconAttribute("red")]
  public List<LuaEntity> Red { get; set; }

  /// <summary>
  /// Entities connected via the green wire.
  /// </summary>
  [FactorioRconAttribute("green")]
  public List<LuaEntity> Green { get; set; }

}

public abstract class Type_b56150235df140849fc9c9d2e00beaaf: CircuitConnectionDefinition
{
}

public abstract class Type_9d387592471344ae83932d4409fb52fe: List<CircuitConnectionDefinition>
{
}

public abstract class Type_2ae9386efe6840898b8474ce813e3ddb: CliffOrientation
{
}

public abstract class Type_b9649d8af5f542209dc5fe900b2e0b0f: Color
{
}

public abstract class Type_5a12e7d9b0394abc9d47b47644b6c187: LuaEntity
{
}

public abstract class Type_13bbebefcec3480f84a4b849ad2bfcab: Command
{
}

public abstract class Type_c0aa11338f4045a08f16549033713c16: LuaEntity
{
}

public abstract class Type_56410f676f26423f95fb43fb042cb9a9: RailDirectionEnum
{
}

public abstract class Type_662208d1a456444186aff60d96bc2823: double
{
}

public abstract class Type_391bfecfba0f46c28fdd2e7ebc0c0baa: float
{
}

public abstract class Type_16e3e037eb054c4ab1618cb73fc2a577: CopperConnectionDefinition
{
}

public abstract class Type_f8b853edbdc0426c9c9adb2d857ede33: List<CopperConnectionDefinition>
{
}

public abstract class Type_1003a1cc80954e01a72326256d0e03e7: bool
{
}

public abstract class Type_3ca58ee46bf34a63bdbd10a18daa1676: bool
{
}

public abstract class Type_f12c1423a89d4c07a30492436e744706: float
{
}

public abstract class Type_3231eafa3b5f481bb6e6ea1f35c2415f: double
{
}

public abstract class Type_c2f2827f2a534c379441e3c7f54eeb56: double
{
}

public abstract class Type_a2358e77c726434980fc6f7e0fbc1df1: bool
{
}

public abstract class Type_779131ed1af44fcd93a2ea14feafea3b: DirectionEnum
{
}

public abstract class Type_442e93e431b042f38db33f5e5b8e1175: Command
{
}

public abstract class Type_3b05b3741fe24723b6423bc2f6b85dc2: RollingStockDrawData
{
}

public abstract class Type_5cfe59b5bb5846efadd81ee8f0eba28f: bool
{
}

public abstract class Type_9267328ff4c54016afd391b97cc047d7: MapPosition
{
}

public abstract class Type_d7a4ced29276448ea68aa35a5976caec: LuaEntity
{
}

public abstract class Type_6725a57de32f4ce69befe3e14be71535: float
{
}

public abstract class Type_a15a7c79d6724bf082c520df4cb3720a: float
{
}

public abstract class Type_9a7a9a5337cc40cfb3d262e4734d0777: ModuleEffects
{
}

public abstract class Type_785a18b3e6f040b489056df563d1500a: double
{
}

public abstract class Type_e3cca72698d443b38f14756432223406: double
{
}

public abstract class Type_fbb712a61ad543b2ba90c10e538a4d29: double
{
}

public abstract class Type_dcaeabd00b8a461eb0a8be9480219d73: double
{
}

public abstract class Type_95e46a3e81364a95ab584b2bed9513a1: uint
{
}

public abstract class Type_bd67cf891783427fa05eb7280ba48038: LuaFlowStatistics
{
}

public abstract class Type_4620dd593bee429980f35cf30f1705e9: double
{
}

public abstract class Type_33a93a35b4c44609822fb6db5f239a4c: bool
{
}

public abstract class Type_f3f07150b05046228695a8cfcbb6e43c: double
{
}

public abstract class Type_23531547339f4c87b4e4fb4cf46092c5: double
{
}

public abstract class Type_644add0a96534f67ba46187383e95371: string
{
}

public abstract class Type_20054321ed3746a798fc9201e7fb0e48: uint
{
}

public abstract class Type_7b2051638271435bae762cab12383ad2: LuaFluidBox
{
}

public abstract class Type_e3478b995f36471c9e9d82d6d8e7dc5f: Vector
{
}

public abstract class Type_0599df30848a4ae192b830d010a3b107: LuaEntity
{
}

public abstract class Type_169dcb17d13a4d23b55e9f84f02a6a87: float
{
}

public abstract class Type_0335ed9020bd4d929a33a5441a28102c: LocalisedString
{
}

public abstract class Type_6015fc8cebec4db0af92791d2677c635: LocalisedString
{
}

public abstract class Type_0dc0e93dbc5c45e692aaae0822a503e8: string
{
}

public abstract class Type_cd7dbb3c0ef84a52ae4adf612a16d463: LuaEntityPrototype
{
}

public abstract class Type_38e2036c5dd7416ebefc33025e048421: LuaTilePrototype
{
}

[GenerateOneOf]
public abstract partial class Union_c5d891e6c5844d829b2a30557498b483: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

public abstract class Type_6cd680757f654c44aa9c4413800cf35e: string
{
}

public abstract class Type_ec62152a987a4229bf95f138eef54ba4: uint
{
}

public abstract class Type_4009226fdfc3452aa3363e402322404c: string
{
}

public abstract class Type_7bf9ac3089a045bfb5eaf13ae9bb83dc: byte
{
}

public abstract class Type_1c8490b9356043a3ab39870af62448c7: LuaEquipmentGrid
{
}

public abstract class Type_046e947d490a4d37b0c2aa771c04c15b: float
{
}

public abstract class Type_8e398b5db20543d2a092dc44c546db3f: LuaItemStack
{
}

public abstract class Type_0eb1d4dfb26a41fc907d7e2b5a2193a9: MapPosition
{
}

public abstract class Type_610d113c64fe4e7aa6250905f1ec56bf: uint
{
}

public abstract class Type_f7ef95f4bfe1467681fa08c0a93dc256: CursorBoxRenderType
{
}

public abstract class Type_e35809d98b2f4a578f03c1d39cd1d621: InfinityInventoryFilter
{
}

public abstract class Type_69a42d52fa3b47b28fe2de7894997968: List<InfinityInventoryFilter>
{
}

public abstract class Type_71e0625da54542b2a1b29279d26ee852: uint
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals_41e65fa6736f4902b8b0e740a74436b5
{
  /// <summary>
  /// Literal value: whitelist
  /// </summary>
  [FactorioRconDefinitionValue("whitelist")]
  Whitelist,

  /// <summary>
  /// Literal value: blacklist
  /// </summary>
  [FactorioRconDefinitionValue("blacklist")]
  Blacklist,

}

public abstract class Type_660de453ef624d2c80f9282ac651b511: uint
{
}

public abstract class Type_4baa8d5d53574b59880e54f3f53d4b2d: uint
{
}

public abstract class Type_0dc56ee870ae4d9895e2f334e89fc5df: bool
{
}

public abstract class Type_b6202f9cfb334f9991ad85ff038c8668: bool
{
}

public abstract class Type_246edd396b81441c9c784e90be63666d: bool
{
}

public abstract class Type_50df6d2a5e4c49f0916d43a01c4dec8b: bool
{
}

public abstract class Type_8ad4b4c2214045a28b7ad3f5654b78ae: bool
{
}

public abstract class Type_faf53952618e473aa882353acebd32b1: string
{
}

public abstract class Type_68378fe01bf14230a96a742fe00636dc: uint
{
}

public abstract class Type_0746a2d5047e477b8309418eb02035a1: Dictionary<string, uint>
{
}

public abstract class Type_2cb3b797a5f24239b9ce52d41e2595c9: uint
{
}

public abstract class Type_a4804431fc9e4f1d8374269e2f12ed3f: LuaPlayer
{
}

public abstract class Type_0856aa549e144602aae90b6ffaeb84e1: PlayerIdentification
{
}

[GenerateOneOf]
public abstract partial class Union_c2de4e200d824bafbc1f5e5920469682: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Type_1801015827a64a9ba79c14e7851cf2a4: uint
{
}

public abstract class Type_0697e0c353e4458f87ad5c1ff85efa47: LuaEntity
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
/// </summary>
public enum Literals_f1ea50de20374848ae0e65bd5fec10f1
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

}

public abstract class Type_33faad1bd5a54d63bf2088167bcd4397: LuaEntity
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
/// </summary>
public enum Literals_e94bc7583aae45f1b4892547a8b4d078
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

}

public abstract class Type_4b056dff3332436fb15f3cdccdcec6ee: LocalisedString
{
}

public abstract class Type_bd807fb99f994de980d5f70c19624cd9: LocalisedString
{
}

public abstract class Type_ab1f42100b384602b234d2c89427080c: LuaLogisticCell
{
}

public abstract class Type_944652c0f854493786118b620ae69355: LuaLogisticNetwork
{
}

public abstract class Type_9fae0851b53341879d537171cc57c403: bool
{
}

public abstract class Type_2707514ff1b34ea0b89f9549e4ca8086: double
{
}

public abstract class Type_334b4204a1e546fc8747d43227b5bf30: LuaEntity
{
}

public abstract class Type_9cbe40ac3d9c4cfba6f7005db0eb2598: bool
{
}

public abstract class Type_4fc23f53035c4a59a24a6c27a3a7fbda: string
{
}

public abstract class Type_d5d08bbb370748cd8c7dd2f96c74c0c5: double
{
}

public abstract class Type_5bb6486fd5ac40579d773952e9a1ffe7: string
{
}

public abstract class Type_0ead7579239942269cb5de650da95ac0: LuaEntity
{
}

public abstract class Type_cc3fddd1c9aa44558dfe570c379f1dcc: List<LuaEntity>
{
}

public abstract class Type_358c6ca9b7d347cda54fc0e88a5339b6: Dictionary<string, List<LuaEntity>>
{
}

public abstract class Type_0d529de7498e4f4aa608ef1b68848eab: LuaEntity
{
}

public abstract class Type_b7353f1caa7a43f78fad9cccf409cc1e: List<LuaEntity>
{
}

public abstract class Type_5db11fab8b614302811d62ee80cc8c15: List<List<LuaEntity>>
{
}

public abstract class Type_f968dc913d604c559705a15dd78f5286: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_ac22e763c31f47a49959318aedff13e5: OneOfBase<Dictionary<string, List<LuaEntity>>, List<List<LuaEntity>>, LuaEntity>
{
}

public abstract class Type_cf6930dd41c84c5dbe97475beeb48bff: string
{
}

public abstract class Type_b1a1864a73934f75a4354299e0ba417c: bool
{
}

public abstract class Type_1ba1def9144a477b83ae9f2054afcd60: RealOrientation
{
}

public abstract class Type_bd9494c85d694091ae395fab49787f1c: ProgrammableSpeakerParameters
{
}

public abstract class Type_0c0fcd89ccc443fa95dc20e2281526d4: MapPosition
{
}

public abstract class Type_e8d3d4a250584bc9bacb8f77ba183236: LuaEntity
{
}

public abstract class Type_a3b64fa62c10421ea3dfde81017459ec: LuaPlayer
{
}

public abstract class Type_491b8b55dd274f1b90e7de12d75f14de: double
{
}

public abstract class Type_f9de4ff34d4a49e6b9c93bb62ba85d3f: double
{
}

public abstract class Type_2366e4eb3fe148ada63684ff03397378: bool
{
}

public abstract class Type_785825a83afc4002bba48976fa12b3b0: double
{
}

public abstract class Type_ea44a2f2b6d946e898d8eb28723bcbf1: LuaRecipe
{
}

public abstract class Type_3eac0e2ecbe44be2a2e8a43f88434a17: double
{
}

public abstract class Type_37c94fed30c64391a6c3e4e80de208a5: uint
{
}

public abstract class Type_60211d49cfa44cecae72de9c6e96f9c6: LuaEntityPrototype
{
}

public abstract class Type_51837d926d66446f87793c28d148fda4: LuaEntity
{
}

public abstract class Type_a31668337d894afcbb781294ab1128dc: LuaEntity
{
}

public abstract class Type_24b8928216564ca791e31bb18017a99b: float
{
}

public abstract class Type_8c4dc6abef1c428e820bf822947d4d56: bool
{
}

public abstract class Type_e011ce2bb297436bb98346fa58e487b1: RealOrientation
{
}

public abstract class Type_1588de3a436c4ef88af59c4012259dbc: bool
{
}

public abstract class Type_d7b76ff9d5e842268c721cfc59bc1836: LuaPlayer
{
}

public abstract class Type_7b324491e5214078837b352ec510de7b: PlayerIdentification
{
}

[GenerateOneOf]
public abstract partial class Union_2d7c5c9d467e4106830096cb0dc66440: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Type_3bfc9458b3444ed397b4814eb53409b2: ForceIdentification
{
}

public abstract class Type_068f2f7ada14418da4d8ebefe100d5df: List<ForceIdentification>
{
}

public abstract class Type_96a65fb7055d4894bb2a1f2ab0af4740: bool
{
}

public abstract class Type_8fdc45641554456da427ba6fff030cdc: uint
{
}

public abstract class Type_a37f146243124a82ae0cdf850d04e887: uint
{
}

public abstract class Type_27437343a79d475f9a49d8cf5eb2393e: RocketSiloStatusEnum
{
}

public abstract class Type_f2999bf197954cdd9b7caabb7deb413f: bool
{
}

public abstract class Type_21c8e78637d542e199766cbe9924ecf9: BoundingBox
{
}

public abstract class Type_58f266d174f14ebda488d1aa66315e87: BoundingBox
{
}

public abstract class Type_d19e4a0898924b1ea7422caa8eb38265: uint
{
}

public abstract class Type_044a0c0e698a444689c6175fe06eb0b6: BoundingBox
{
}

public abstract class Type_00cac8033f38418a84c986f05fbbe9b0: LuaEntity
{
}

public abstract class Type_58306e7592c4467b9a57ca2bcfc22810: SignalStateEnum
{
}

public abstract class Type_0e20371ab08c4ca1ae5e7fa197e23b47: double
{
}

public abstract class Type_69b148e0af6a472aa4510532f5809d54: LuaEntity
{
}

public abstract class Type_034c1d9979394f9b97c1fca69aa3941d: double
{
}

public abstract class Type_d233a7b835a34c7fb58fa5d380d51f5a: float
{
}

public abstract class Type_09415de365ca452b8434bd39d3579e1a: double
{
}

public abstract class Type_276e3ec868094e64b21a53d5e4f028ea: LuaItemPrototype
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals_59122b05d72347569bcd3b3e708e7f62
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals_aad899b0093d4065912f34182f1c42e8
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

public abstract class Type_5932ed2fdbc74d7ca18175fd87c94b7b: LuaItemStack
{
}

public abstract class Type_8aafb2c6cb2346cb9444f3ee040fc9b2: EntityStatusEnum
{
}

public abstract class Type_5a7276c0bffb49fbad15fc27ab679990: LuaEntity
{
}

public abstract class Type_59b840c8e1974a78b52c541814648758: double
{
}

public abstract class Type_a91f3a2c5abf4f2191dca82f1f4c3f09: double
{
}

public abstract class Table_ec80ed56edc042d2868c3a806cd501b2
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

public abstract class Type_e310493c4360400dad9eff18540874bb: LuaEntity
{
}

public abstract class Type_ef9e8d26211e4c8792f6d25766e583dd: List<LuaEntity>
{
}

public abstract class Type_65a6eb294dec454ea11d8b1d842cb82e: LuaItemPrototype
{
}

public abstract class Type_9d4d364e80564aafaa98fcaadc54a5a3: bool
{
}

public abstract class Type_dc6d0654f5ba46a7a7a3574fb23eebef: Tags
{
}

public abstract class Type_0510bb4a6aac4f799b9da01331658dc1: double
{
}

public abstract class Type_bed163319721436d8367a17264adf22c: LocalisedString
{
}

public abstract class Type_0e32b21455584f46b63cca621abf59ca: uint
{
}

public abstract class Type_3568250c3ddf4daba00dc2c6f16a70ce: uint
{
}

public abstract class Type_525c95c7c8824616b71d8a69708617e8: uint
{
}

public abstract class Type_4b829e9798b94e13ae755be6fe316976: uint
{
}

public abstract class Type_bb3904e10db9409aa4f68115bcb2aa69: uint
{
}

public abstract class Type_4a1c0b25c6ea46fdbc0fb650b8fd557c: uint
{
}

public abstract class Type_8e48c39d0a3248cf93b35a2eebd0d1bc: uint
{
}

public abstract class Type_b2faa4a436de40cb8fff2f2f0ba4619b: bool
{
}

public abstract class Type_5dfd3c044ec4460398b799bfcd200892: RealOrientation
{
}

public abstract class Type_723b3ce2f0634dadb51a2b3d46ea48f9: LuaTrain
{
}

public abstract class Type_47bec2e7e54244b097b08f47c84e450b: uint
{
}

public abstract class Type_094d241ffacd4c4a803b3ea0e32896cc: uint
{
}

public abstract class Type_430c6320652d43ea99184559714cf21e: uint
{
}

public abstract class Type_e7a0583420ad4bf791414176bc58dbe1: byte
{
}

public abstract class Type_d9221539545240a895a737848debf0c7: byte
{
}

public abstract class Type_9682fe0970d248fea2e5f48fe0ea3f7b: byte
{
}

public abstract class Type_2827ccafbd4c410db1787a42cd037dab: byte
{
}

public abstract class Type_a9166e1ebec2463cb15095c0a1558038: byte
{
}

public abstract class Type_fb3976484538410e96825d5fa38ee469: byte
{
}

public abstract class Type_90abe80449284987ad050fc6e094b767: string
{
}

public abstract class Type_aafb7bb7a6974362a1528b58de9e0d58: LuaUnitGroup
{
}

public abstract class Type_b51ee81b4afd44cda0d11fc1f7319940: uint
{
}

public abstract class Type_00f05fc2f9e74b4f90c429d8b22629e7: LuaEntity
{
}

public abstract class Type_55bb486055664a25adbd84cfcfb2f7ef: List<LuaEntity>
{
}

public abstract class Type_a5e582b86fed4126ba8a0f75db394f36: bool
{
}

public abstract class Type_d169484759ba45a1882acfd280c74126: VehicleAutomaticTargetingParameters
{
}

public abstract class Type_8e3f2c670eaf41f6bd18ab781e239c2a: MapPosition
{
}

public abstract class Type_6f76ddbd12f34212ba1995ecd8d7891a: Offer
{
}

public abstract class Type_a9943a8069284203be52feeacf0142db: bool
{
}

public abstract class Type_8096334c47f04ea4a9d6e4c045367ecb: MapPosition
{
}

public abstract class Type_29cc5a9665b04f988924606e9d1a8617: LuaEntity
{
}

public abstract class Type_aec2276f32b94b3995b684de6c2c3490: bool
{
}

public abstract class Type_6479a4e8aa4a4c09b1ceb55968cb09ba: LuaEntity
{
}

public abstract class Type_14c427d274f64eea91ea4a05cc91acbc: bool
{
}

public abstract class Type_6f90ec056db245e799c46c9d7b577ffb: ForceIdentification
{
}

public abstract class Type_ab71c2d927f84492a4081b666c343630: PlayerIdentification
{
}

public abstract class Type_16f35e4f7b21413e89f38b5e7062c286: ForceIdentification
{
}

public abstract class Type_4d135e5ec5d24d508ce51b57a44ce1aa: PlayerIdentification
{
}

public abstract class Type_41719ecd31934b0383b8172c86fd4f07: bool
{
}

public abstract class Type_1f1f59db774047969efab4d61b8a863c: uint
{
}

public abstract class Type_1acf6ffa13f241e8a573d85ac5debd61: bool
{
}

public abstract class Type_5bc40f7634c64eedb87a6bc38639de7d: ForceIdentification
{
}

public abstract class Type_2ae0ff72fc734c5093a6386b673f12d6: MapPosition
{
}

public abstract class Type_a821921b9d6c44188184f9d4f8f43065: LuaSurface
{
}

public abstract class Type_89bc0c162664453787338a2cf60445e0: LuaEntity
{
}

public abstract class Type_c34b8068876f41e4957ee217e050105e: LuaEntity
{
}

public abstract class Type_ddba85642dde4bdcb1c74eaa89b0783f: LuaEntity
{
}

public abstract class Type_aecfbf4c7a5144048d930405945211e2: WireConnectionDefinition
{
}

[GenerateOneOf]
public abstract partial class Union_1db514b4e61d44b1be6a698fb6506e5b: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

public abstract class Type_82b32988a31348489e5e24eee38392fd: bool
{
}

public abstract class Type_974295b725e242f8a18a38b4293bc961: RailDirectionEnum
{
}

public abstract class Type_8f3f84f8c6a64a21902c11291767fc3b: bool
{
}

public abstract class Type_74d042a15f354e2196607c64075a8344: PlayerIdentification
{
}

public abstract class Type_e4b7064229c24128abcbf1ffc2683189: LuaEntity
{
}

public abstract class Type_d4c90c458f61481e810b6c2a6e64fb02: string
{
}

public abstract class Type_0438f1eb6778426da29c6f53b2d5ab9c: uint
{
}

public abstract class Type_15f3c520c8a44592a802602e1d9a66a4: Dictionary<string, uint>
{
}

public abstract class Type_bb02228e335e46dda640b69ae00e8132: float
{
}

public abstract class Type_01cc59d812c24e649c738ad7aaedf440: LuaEntity
{
}

public abstract class Type_5d50b3d3d18b46ff9780d7816afa6070: ForceIdentification
{
}

public abstract class Type_2d7694623ddc4c9a90ac3fdc56eeb9b4: string
{
}

public abstract class Type_45832aa68ce746019e1d717384a4793c: float
{
}

public abstract class Type_8f7e7387a4b74a4a852b2a4cd59180e0: bool
{
}

public abstract class Type_7b10749451e04ac486b30bdbca54b6c8: bool
{
}

public abstract class Type_d80cb5bc5c944da0983c5f9c5f598b16: bool
{
}

public abstract class Type_52ad4b37be5a49cdb6497fc00d6f83b3: LuaEntity
{
}

public abstract class Type_186aad38f27d4e6bb4c230b1e6e50453: ForceIdentification
{
}

public abstract class Type_2360b847b3f94e9f90ad168ab7ccea67: bool
{
}

public abstract class Type_6bd57a29974b4dd2b99fb920903ef524: WireTypeEnum
{
}

public abstract class Type_9a507b116f9c4c65b60c238a2f8482fa: LuaEntity
{
}

public abstract class Type_6adc7f64e7bb43208c64619895696da8: WireConnectionDefinition
{
}

[GenerateOneOf]
public abstract partial class Union_af0d65e5634f44a5b2daca9e3ad0d1ba: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

public abstract class Type_645e9b5c978e4773b9b6c62dd7f23bea: RailDirectionEnum
{
}

public abstract class Type_a84adc5c73e44b6b97c56438a18a990f: bool
{
}

public abstract class Type_36546c5776054fa78971bcf349c3c7f1: LuaEntity
{
}

public abstract class Type_98a353f6b3d340cf87e3b6ce69900445: List<LuaEntity>
{
}

public abstract class Type_227f4d0a4f554dbcb20aacd31d513282: LuaEntity
{
}

public abstract class Type_c8fae12ddda5465eb29ec13c82dcdb69: List<LuaEntity>
{
}

public abstract class Type_e66c94552ab749719a0a217f4834f956: BeamTarget
{
}

public abstract class Type_7ed7442f59db48228ea5bfb482636c7c: BeamTarget
{
}

public abstract class Type_32f0dbd73009428199f64b69aacf9c10: LuaInventory
{
}

public abstract class Type_d4ff5237d8e04323b521b391478b3dbb: LuaEntity
{
}

public abstract class Type_d27de1e5f6314cc784e20532e0413ba8: List<LuaEntity>
{
}

public abstract class Type_20b9f6b6fedb41e987548f3e76765628: CircuitConnectorIdEnum
{
}

public abstract class Type_faef28eba0014289b7460b374d599e5d: WireTypeEnum
{
}

public abstract class Type_2924ec09643b474995a4dd578d6856d2: LuaCircuitNetwork
{
}

public abstract class Type_63fecad62b664426bb7b85fa34dc7aab: RailConnectionDirectionEnum
{
}

public abstract class Type_30b07620a872429b8fe94fc4ec7042aa: RailDirectionEnum
{
}

public abstract class Type_836a9a74b3884779824551326a84790e: LuaEntity
{
}

public abstract class Type_ea68d9e830dd486985654f5456174f18: RailDirectionEnum
{
}

public abstract class Type_7cc27cb1da4146838c7e50cef03df76e: RailConnectionDirectionEnum
{
}

public abstract class Type_a7a87343964e426a96055f22114585f0: LuaEntity
{
}

public abstract class Type_badbc8124a0749b292d3c0b0e20a3cb8: List<LuaEntity>
{
}

public abstract class Type_a15743d092ec450da2ab86eb49fd4d02: RailDirectionEnum
{
}

public abstract class Type_1ae21e7219f84eaaae829bc7af65f48c: LuaEntity
{
}

public abstract class Type_f12062349d6148299fec1b10400c9985: RailDirectionEnum
{
}

public abstract class Type_847e5a988d014d5faa229d5df9a5e87c: LuaControlBehavior
{
}

public abstract class Type_209a83cb6a2849f1b0a304ce812d674c: float
{
}

public abstract class Type_b034110377eb45859113c724dd2e43f2: LuaEntity
{
}

public abstract class Type_efb186b464664414950aac9fa62d7d49: LuaPlayer
{
}

[GenerateOneOf]
public abstract partial class Union_544db4cf725844b89fa015a73050f500: OneOfBase<LuaEntity, LuaPlayer>
{
}

public abstract class Type_06a1ce260c924901ae04755397533099: uint
{
}

public abstract class Type_0321942f81e848b5bea4bad2a3d1510b: string
{
}

public abstract class Type_10a053e37d7944e89b6e0af9dd019d66: string
{
}

public abstract class Type_85665d59124b4df6992fb70e72436ad0: double
{
}

public abstract class Type_db0a3e07911047b180bf579b547df5cf: Dictionary<string, double>
{
}

public abstract class Type_9ae66371b6434ff19c722b084ef9c626: string
{
}

public abstract class Type_8ac4856828fe406ebf59388f73244ef8: double
{
}

public abstract class Type_79963ba145e24de8922f78b5e08dbe34: LuaInventory
{
}

public abstract class Type_d6becaadba194341aafd673d183c2fd4: float
{
}

public abstract class Type_5dee60f17c4447faa270a5d58a9d0762: HeatSetting
{
}

public abstract class Type_4a06da17f3ae42c7a117212c63e452b1: LuaEntity
{
}

public abstract class Type_9902b4dea57f4f058b88ea941be6439c: List<LuaEntity>
{
}

public abstract class Type_1e15ccf5cc534db2af13bfada0219c8b: uint
{
}

public abstract class Type_7c5612680f1943869cf6f05b75bb3b24: InfinityInventoryFilter
{
}

public abstract class Type_d9a61119627745b4b18fa2f6402fdf4f: InfinityPipeFilter
{
}

public abstract class Type_b8e1e034447c4aaba1a05778001fa798: LogisticMemberIndexEnum
{
}

public abstract class Type_ffef1bd06a3d431aa5e6943c2f826d7c: LuaLogisticPoint
{
}

public abstract class Type_e02d7040fa684bbba48b7396ef7d82b7: LogisticMemberIndexEnum
{
}

public abstract class Type_654b9f6e703b4b58af5d53d75825e402: LuaLogisticPoint
{
}

public abstract class Type_681955d1be7940f8a720a7bbde5e9f31: Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>
{
}

[GenerateOneOf]
public abstract partial class Union_f4c9c7af11e8407e9c0c957d8a9d77c2: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

public abstract class Type_714d798e7b9d462a83e470b90123596c: Offer
{
}

public abstract class Type_3355cd2ac7f94669b1ce988eda2bdf57: List<Offer>
{
}

public abstract class Type_f61690d825e94744aa3b398dcb76aea4: uint
{
}

public abstract class Type_394800cb8f2e48f28fb793f773a8f3e0: CircuitConnectorIdEnum
{
}

public abstract class Type_f3f4d73e9d9d468ea179866e4f624025: SignalID
{
}

public abstract class Type_700fd59ef4144d9ebecb98065753b467: int
{
}

public abstract class Type_0e08c1da630f4fd6bf7ac39b17c179e0: CircuitConnectorIdEnum
{
}

public abstract class Type_8d0c2f6f36bc482c8e57b73c0aae99ef: Signal
{
}

public abstract class Type_8117d7ed29964c379c10b0104218dee9: List<Signal>
{
}

public abstract class Type_420e1474644f4b1e98c756e32e3b1730: LuaInventory
{
}

public abstract class Type_8834e60b3fd74854ba542b81839e766b: LuaControlBehavior
{
}

public abstract class Type_17aac5d31a4847a18b5ab9f3ec350284: LuaEntity
{
}

public abstract class Type_549c0a192ef04d93a69e5fd6ac2da12c: List<LuaEntity>
{
}

public abstract class Type_35356fc39b5d4760b4228e293bc67200: LuaInventory
{
}

public abstract class Type_fa83851ab36145a2b7e8c1601556ea3b: LuaEntity
{
}

public abstract class Type_2e133dcb59a24e6a9c0ac62cc103d81b: List<LuaEntity>
{
}

public abstract class Type_345a4bd220b74c6fa5a65fe68450c320: LuaEntity
{
}

public abstract class Type_d45c7ca8b1c548879bc5fc2a54772f87: LuaPlayer
{
}

[GenerateOneOf]
public abstract partial class Union_959438970ecc4fd1a56bfbb1da3da2d8: OneOfBase<LuaEntity, LuaPlayer>
{
}

public abstract class Type_719d584eff1b4bbb82a5e429be1fde36: double
{
}

public abstract class Type_64650fcf635249cba80a71de0abcdd1b: RailDirectionEnum
{
}

public abstract class Type_edb3278afd094f658c0b9f0fdf6e22df: LuaEntity
{
}

public abstract class Type_8a0220af800a4b7ca2bce56846c5f55f: RailDirectionEnum
{
}

public abstract class Type_cb31600096264107a026950d82be668e: RailDirectionEnum
{
}

public abstract class Type_9e215b4b338f47c185310b0ab9fd984c: bool
{
}

public abstract class Type_ea4dfcbecd0a49fd8a9bb56785fea714: LuaEntity
{
}

public abstract class Type_58ef17c7fdc14073adf7cbfbc139bead: double
{
}

public abstract class Type_677f566a57e54b7b92c34241b0f3829b: LuaEntity
{
}

public abstract class Type_0bf4be41513a406b891a96d9772af3b0: List<LuaEntity>
{
}

public abstract class Type_d0929ff1338549bc9677b38fd23ef258: RailDirectionEnum
{
}

public abstract class Type_980f2de4a4054614b414e404ad13e22f: LuaEntity
{
}

public abstract class Type_13cac9b323cd465abafdb735cc7453a5: List<LuaEntity>
{
}

public abstract class Type_68a5f94ea7044a0e97e0a4285a0e6d1d: LuaRecipe
{
}

public abstract class Type_d36fedb5205a4f79b7b70a4699c74961: uint
{
}

public abstract class Type_e329eb6e93a14e7aa4c79e7b4513be3d: SimpleItemStack
{
}

public abstract class Type_6fa6d868abdf46d9ac017c78000a7e4b: LuaEntity
{
}

public abstract class Type_6c9ae46601bd442aa421ac2e199dfb18: List<LuaEntity>
{
}

public abstract class Type_0032dbd160cb41e2b8c8e65b59d09176: LuaTrain
{
}

public abstract class Type_c24b4f7619a14655b94118da96e21a6b: LuaTrain
{
}

public abstract class Type_10ec96dcc3024ee18638ba162a0cbee8: List<LuaTrain>
{
}

public abstract class Type_f4835c0bf87e4607a638155db2896653: uint
{
}

public abstract class Type_f5011c0dce52417eb67f7a3ceba01b47: LuaTransportLine
{
}

public abstract class Type_aec7814c2be94d77aed49e881f138177: DirectionEnum
{
}

public abstract class Type_8ca42ae107fe4ac1ac5c3c8c42e7d6c5: LuaEntityPrototype
{
}

public abstract class Type_908dd54ef97b48559994b79e55cfd50a: EntityPrototypeFlag
{
}

public abstract class Type_f3daed10e27b49f29041b04c6f91aaae: bool
{
}

public abstract class Type_15bfe197672e4bc1a8d0f4814d5ee1f8: bool
{
}

public abstract class Type_6da0701227134da8b4cc71d5fe3cdc07: EntityPrototypeFlag
{
}

public abstract class Type_695c621e0e4044a5a4714e532a1a8086: bool
{
}

public abstract class Type_aeca005c0a584d028c6b967712dd3786: string
{
}

public abstract class Type_34cf0d64e1ed4fee97bc9689c827ac71: Fluid
{
}

public abstract class Type_8ce532977ecd4d818ef15b0a522b82df: double
{
}

public abstract class Type_5dce4faba8794628b7a4a56f832cb22b: bool
{
}

public abstract class Type_5a25d6ad016a4f6681e4e68ee6536ba3: bool
{
}

public abstract class Type_2f17d7ddf8d14ccf943baf13c1bb31af: bool
{
}

public abstract class Type_92d8c4afb74242a2bc362420722b065d: bool
{
}

public abstract class Type_96cf61f670b949e69155a68758125dc1: bool
{
}

public abstract class Type_85d5c0071bee43f8bd8bb21fe5b91fbd: bool
{
}

public abstract class Type_e128a65d85ab405bbe9a386558409d56: LuaEntity
{
}

public abstract class Type_29652a8ca9d245218599b3f727e23aa9: bool
{
}

public abstract class Type_53c48fd7b39c44758f2b47208d900543: LuaEntity
{
}

public abstract class Type_bd97c3cc8c264d0d8ee80f0296707d87: bool
{
}

public abstract class Type_10f2a5f659b34644b2a09b46c8e15e2f: bool
{
}

public abstract class Type_cb3bd575c79d4db98b7b398a301dbb88: ForceIdentification
{
}

public abstract class Type_10e83c59c3ae471bb6c7464437cf0cc8: bool
{
}

public abstract class Type_0cefcba5d81e40f582a8e2264a3de0b3: bool
{
}

public abstract class Type_48771406dc5f40c5bc037a888539f3ca: bool
{
}

public abstract class Type_71f2bbb09d4145fa9455249d7c90cb07: bool
{
}

public abstract class Type_30c77b1a51164478bcf6fecadb6a5f02: bool
{
}

public abstract class Type_99f927cdbdc2434f8ac9d3fc4aa5f4b0: bool
{
}

public abstract class Type_09252f8ecc5a42f09e10c318a14e98ed: LuaInventory
{
}

public abstract class Type_4520b0423f764dd9889aa8ee5bc774b9: bool
{
}

public abstract class Type_34bc1b52e5204217a8b476264d4a2cd5: bool
{
}

public abstract class Type_d8472b776bf64502866aab415dc7a7a1: ForceIdentification
{
}

public abstract class Type_4c3570336ed543989f07fdfa098acfac: PlayerIdentification
{
}

public abstract class Type_22adbee9092a49ae950463bc8dfd9499: bool
{
}

public abstract class Type_2973a00aa00d42a29ae9c16b71d7ad45: DirectionEnum
{
}

public abstract class Type_3c369b3396054a22a5c251ac90e01b73: ForceIdentification
{
}

public abstract class Type_a06cb29e25674387a79f924e91780944: PlayerIdentification
{
}

public abstract class Type_881cec22f3444f7bbba0a53f95c79239: EntityPrototypeIdentification
{
}

public abstract class Type_47f720ee33f84952a49c1b10035cda7f: bool
{
}

public abstract class Type_c25fe9adf178432d821287d31b5c5ec1: uint
{
}

public abstract class Type_bebd22f4e9574849943b3af6efa25885: uint
{
}

public abstract class Type_7c25a2a2db4a4325960e75559d5fbd0f: bool
{
}

public abstract class Type_cc03ee06a0984c6ebf35ad7491114132: double
{
}

public abstract class Type_0f4dd25b8dc54ab4a7a5cd4fb3568376: double
{
}

public abstract class Type_2d547a763b32497eb3fc37d0c00466b5: double
{
}

public abstract class Type_7c65e95d0de6449e8de125c2c7753764: string
{
}

public abstract class Type_f7687ed8fa9248d7a7feb30327b1bb99: double
{
}

public abstract class Type_6ed3cc4b0a2441d4a21505b682e4460c: double
{
}

public abstract class Type_a559e0c05dd740c7824e882e43ed7772: uint
{
}

public abstract class Type_d70d8ba5a4d249b086d0cd19a50d04ff: bool
{
}

public abstract class Type_05d883a7d4a1421e812ac213d6a4237b: ForceIdentification
{
}

public abstract class Type_eaa4af7aed284a18bcf5c2e141e7d785: uint
{
}

public abstract class Type_0bdb577882c8453f9351c2eb798af864: ForceIdentification
{
}

public abstract class Type_84d7b5280c874b9ea3ff51ec0dea45fa: bool
{
}

public abstract class Type_5f1c53bfa5bd47ce9b6f8646a2c8ee7a: bool
{
}

public abstract class Type_9d3a029019284c0bbe51ce9766245e30: string
{
}

public abstract class Type_ffb760a28a0b4299aa6b9dcc7e28faa3: uint
{
}

public abstract class Type_142d6817e31841859296ae66d6049968: Dictionary<string, uint>
{
}

public abstract class Type_8db0c61ca8e64214bb39af0f69099e7f: LuaEntity
{
}

public abstract class Type_28ad993bf95f4306b2a0f5aebe54dac5: LuaEntity
{
}

public abstract class Type_507c27f7724548e38b0bbb4a937e92c3: PlayerIdentification
{
}

public abstract class Type_7f0802fb7eb04e73a1bdf7bb76e1f834: bool
{
}

public abstract class Type_84f03f4914424660a5d7b02d053b25e5: ForceIdentification
{
}

public abstract class Type_4d49e50ccaef480bb64d0a492269a566: bool
{
}

public abstract class Type_1d9a800be16c4dceb6bfdc0e1ea442b2: bool
{
}

public abstract class Type_dba7f12e315b41b9989bd7cbab8d758f: bool
{
}

public abstract class Type_ef7b3631b3f2469dbb955d737305b9f3: string
{
}

public abstract class Type_71d6721e3a464034a36522bdef43fdf3: uint
{
}

public abstract class Type_6ab0e553897f4eb79d70ea7a81c0e50d: Dictionary<string, uint>
{
}

public abstract class Type_fa7548ab58b64c8ab48e6b4e76d1ba71: LuaEntity
{
}

public abstract class Type_c455f64ed07741e2810172ddcc460d9c: MapPosition
{
}

[GenerateOneOf]
public abstract partial class Union_9f4e91236fa14677b45d04fe7b3076d0: OneOfBase<LuaEntity, MapPosition>
{
}

public abstract class Type_8501ce1fcca943968c2cb20bdd1ea2e5: LuaEntity
{
}

public abstract class Type_6db94b9b29474068a232d085184a868f: MapPosition
{
}

[GenerateOneOf]
public abstract partial class Union_3f2f75972e6045c785a5aeabc4e37650: OneOfBase<LuaEntity, MapPosition>
{
}

public abstract class Type_668b1cb925e5475088481c966702e4c7: Command
{
}

public abstract class Type_633a4f291a3f413fbb1a7a088587310f: Command
{
}

public abstract class Type_7d3ad87beacb47aca54deb5a101959da: LuaEntity
{
}

public abstract class Type_c62ff930c82d4f8aacaa446c4cfe38c8: PlayerIdentification
{
}

[GenerateOneOf]
public abstract partial class Union_9c15812314f1471889506e506b768287: OneOfBase<LuaEntity, PlayerIdentification>
{
}

public abstract class Type_cfbd2ef81c744ed3bac68f08edff2449: string
{
}

public abstract class Type_af0208870c4b4c20b77f53cd143654be: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_8aa1ef04a1054b3a9ce7deb79648f8af: OneOfBase<string, LuaNil>
{
}

public abstract class Type_52225dcec49240519591c61735196acc: uint
{
}

public abstract class Type_9e641f0fa26a49688f525ef416961ae4: HeatSetting
{
}

public abstract class Type_5c982fc96f5f487da7c7467561b7f199: InfinityInventoryFilter
{
}

public abstract class Type_50f352469aa94890be29f7d0e2d4e411: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_7b59d7b4660b429499eec6cbb72eaa75: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

public abstract class Type_3b59a5315ea8474689d1dc7ad1fbd590: uint
{
}

public abstract class Type_57dc87eaa09d43a2aaf6d3f937a7faeb: InfinityPipeFilter
{
}

public abstract class Type_fb54a958294e4b24b4fb22f94f169a77: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_88b31d48aa8948e7a124fe61cd10cefd: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

public abstract class Type_0c72ce59d0184f0abd97bef512bab56c: LuaEntity
{
}

public abstract class Type_7c2d6b51c9d040a3a2c6bd4b86cc21e6: PlayerIdentification
{
}

[GenerateOneOf]
public abstract partial class Union_cd7dce5d8bec4b6bb3912006971c0406: OneOfBase<LuaEntity, PlayerIdentification>
{
}

public abstract class Type_1969dee190c24f9a859cf9685852ebd6: string
{
}

public abstract class Type_b21ad4f651e3467980ee4f9e9681123e: LuaRecipe
{
}

public abstract class Type_886b0b3ae3884e47a0c1d244933c7958: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_45a5c2b6d29243f0ad1f9837629e44d0: OneOfBase<string, LuaRecipe, LuaNil>
{
}

public abstract class Type_cb29a87fcfe7436fa577e8c4fd633c4a: string
{
}

public abstract class Type_05226272ff8a478aaa6bb068d29cff16: uint
{
}

public abstract class Type_4a9f57bc9fa544e2859005f7ff26300d: Dictionary<string, uint>
{
}

public abstract class Type_7b75665169344a518b167e3c399aad86: ItemStackIdentification
{
}

public abstract class Type_3c2c47aaf3e1476da0721b86fd107bbf: uint
{
}

public abstract class Type_2f4f8de36e3c4a6a9d87ba3d1f633dd3: bool
{
}

public abstract class Type_426e4883ab2c4eb19678349bf3bd11cf: bool
{
}

public abstract class Type_cd564c05257c4404b857736985fcb432: bool
{
}

public abstract class Type_17a4b3ecc55f44cb8e63bc8f56608128: string
{
}

public abstract class Type_66957555cfd1479eaefad19969333897: uint
{
}

public abstract class Type_d0684c7cb1e6460ba8002a150d2034ff: Dictionary<string, uint>
{
}

public abstract class Type_7a06df8848274fab8fa09fc540c870bd: LuaEntity
{
}

public abstract class Type_d3af3f0ab5ef440eb5782ebce99be17c: LuaEntity
{
}

public abstract class Type_e4d467dcb5bc4ef08c4ed1a0594ff374: bool
{
}

public abstract class Type_3c205d87ac5641788fb927f0491d4f4a: bool
{
}

public abstract class Type_17a9bd67e373465d8fd2ec71c928d13b: bool
{
}

public abstract class Type_12b49a5f5e4b4b9e8bd30935c1283430: double
{
}

public abstract class Type_90eb6cad81994845a915c09a1900c72c: LuaEntityPrototype
{
}

public abstract class Type_604521e2473c4c76917d964efa123949: List<LuaEntityPrototype>
{
}

public abstract class Type_71e0f8e62a484a7ea545daacd4b0c67d: BoundingBox
{
}

public abstract class Type_6127de0595c2474b9deae0439799983a: CollisionMask
{
}

public abstract class Type_372047f1cc4d4de3a0a16a29f4770db8: CollisionMask
{
}

public abstract class Type_9dc50c1b0b614603b80209df9d2f3fc6: bool
{
}

public abstract class Type_5011d32e8c1a41ba909d3137740c4203: double
{
}

public abstract class Type_b91c7195f0114841b9d422ff0e98843c: float
{
}

public abstract class Type_4ad567174f034c919c608bd0e8090d53: Vector
{
}

public abstract class Type_6e47b0e85cba4998abf4e14a387cbe3d: bool
{
}

public abstract class Type_74731f58f40247daa140f00a5a5d74bc: bool
{
}

public abstract class Type_f52da15b12124c72afc4596caf010cc1: bool
{
}

public abstract class Type_6a635de1bd084e0dbf429293dbf13933: bool
{
}

public abstract class Type_41a16fc5a66240329d71fc472ca85a3c: bool
{
}

public abstract class Type_9c6ad6b5152944ac9fcb60552e8d10bf: bool
{
}

public abstract class Type_3ea50c3361e34983a7fae7035ac7baae: bool
{
}

public abstract class Type_051a938e6dfb41aba8eb5d3f64e43765: bool
{
}

public abstract class Type_cf0e1b11b5f7407facd139e38300e587: string
{
}

public abstract class Type_f6af87d33cd64d1db922de42ae6d714b: bool
{
}

public abstract class Type_53601f5e7dd248c796fb420b99f8f839: Dictionary<string, bool>
{
}

public abstract class Type_adf018fdf1d24b2782c9cb26fbb86c60: bool
{
}

public abstract class Type_2092a0cbc4264713ac1f27eb009d0add: string
{
}

public abstract class Type_425a6c401f814826b0948fdd32311fcf: double
{
}

public abstract class Type_37b6c22519064116bbb3d8b20d1ee808: AttackParameters
{
}

public abstract class Type_bea8b6d4058a4a92995060615cd6052b: TriggerItem
{
}

public abstract class Type_e1d1697c180e4b91ba7c0e3f1555daf4: List<TriggerItem>
{
}

public abstract class Type_7d43b0087f8b43b0bf342aeec72ab24b: uint
{
}

public abstract class Type_a5ec1016f40b4974bfb002ebd4bcfd85: bool
{
}

public abstract class Type_b1203c69c89143f6a54fe0efc39260b6: AutoplaceSpecification
{
}

public abstract class Type_013380b911724a81bb1ba8f5d23ca6cb: double
{
}

public abstract class Type_eafa8a162d9b4e7fb4b5c7f2ad6173d4: double
{
}

public abstract class Type_3d05e2e8dee54fdbb85c0b174d300ccd: double
{
}

public abstract class Type_7cb58f8b01414d1cb94454203097eb52: double
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals_ff1cfc40e9a34ff3bd27ab9c067a9837
{
  /// <summary>
  /// Literal value: heat-water-inside
  /// </summary>
  [FactorioRconDefinitionValue("heat-water-inside")]
  Heatsubtractwatersubtractinside,

  /// <summary>
  /// Literal value: output-to-separate-pipe
  /// </summary>
  [FactorioRconDefinitionValue("output-to-separate-pipe")]
  Outputsubtracttosubtractseparatesubtractpipe,

}

public abstract class Type_f34331b8a6254a41b0a58902e097660a: double
{
}

public abstract class Type_76e4f59da078428d847b98f3cb139562: double
{
}

public abstract class Type_523277e373e74b64826d5fe50b8d23fa: uint
{
}

public abstract class Type_dc36e7d150484e31b173b01714ce072a: uint
{
}

public abstract class Type_861ccd28cf3e4b50b50fe7a7133c2261: LuaBurnerPrototype
{
}

public abstract class Type_50069456ea3b4b729a8a9e2b5938cb88: bool
{
}

public abstract class Type_29a7b3312afa4c71bc7c91e934124a3a: double
{
}

public abstract class Type_0241feb2d9d9498e96bb4a529eedf93a: bool
{
}

public abstract class Type_fc62a5695f284de4a850a16e10f8bd41: CollisionMask
{
}

public abstract class Type_e98cf07816844736a16df3ebcc7ffbc1: double
{
}

public abstract class Type_08dd80a0885c4b9db2b5f81ad2e8f4f4: LuaEntityPrototype
{
}

public abstract class Type_5e1fea2d70b8440eade1d8d89b4332ff: double
{
}

public abstract class Type_b45649ab8c944d4c9a08e6551cf74ad9: string
{
}

public abstract class Type_b97d818b525344d7be82df59b62909ee: BoundingBox
{
}

public abstract class Type_0a27d79bb48f4e8ba84a475eb7bd92e6: CollisionMask
{
}

public abstract class Type_a44f9ad5b6b14008ad5dd5613373c651: bool
{
}

public abstract class Type_2678468075b34ef2a785b64901f05c6e: bool
{
}

public abstract class Type_79cc9aeab00746a39a2845cad0a210be: bool
{
}

public abstract class Type_f09f1d4056c947fab18da120239c4556: CollisionMaskWithFlags
{
}

public abstract class Type_8ea21a2f8f6a4198a669f74010c590fa: Color
{
}

public abstract class Type_f54838a94d6546c5b88ae2a111725ddb: double
{
}

public abstract class Type_ab498a4c35314ea7b040b3faf9fd0215: double
{
}

public abstract class Type_b22afc99e93b450780d0e1d4054847e6: double
{
}

public abstract class Type_e9c752eafb8a4783bbf2c6c6083f316c: double
{
}

public abstract class Type_09b9f4106ae7475880125741d5523131: string
{
}

public abstract class Type_cfd3a7a1640345a1926f7aa9b5d3190c: LuaEntityPrototype
{
}

public abstract class Type_b606490ba3844c3e9a35089d6f93ce82: Dictionary<string, LuaEntityPrototype>
{
}

public abstract class Type_52aeb39661fc49bfb5a1f05c4f8cd62b: bool
{
}

public abstract class Type_cfa14d7594b74f369de04636b75458e1: string
{
}

public abstract class Type_02d07471c61440b793fcc56b2b34bd44: bool
{
}

public abstract class Type_82c0d79263dd44c697a59cc6b307d279: Dictionary<string, bool>
{
}

public abstract class Type_30b58c078cfd4cf5a4d173ebdf9cbbae: double
{
}

public abstract class Type_2065f6c34f344bf8a0b18ecb2c6d265a: bool
{
}

public abstract class Type_4be9ffb58955471f85052952427feffe: TriggerItem
{
}

public abstract class Type_2d6f69b8096d4b7495510747a9b7b818: List<TriggerItem>
{
}

public abstract class Type_afb17ddeead0479b809d6d3ea9d9b2fd: float
{
}

public abstract class Type_452955bd8bc84d1cb03ad6c99393b071: float
{
}

public abstract class Type_dba4ae59da2d429abb83c80d3598b394: BoundingBox
{
}

public abstract class Type_e616fcde149d4c0dbb3bc5699bd5788f: Vector
{
}

public abstract class Type_66940f86fae74565aa2a8ead2d353d32: List<Vector>
{
}

public abstract class Type_6f174533f39a4016906d502add77b764: string
{
}

public abstract class Type_18d7c606e4484b7fa40cac3cc464892c: Vector
{
}

public abstract class Type_015c5f6ee34f4843bb5cfe8b96796671: float
{
}

public abstract class Type_46406625967a498b9d68d3569a3129a9: float
{
}

public abstract class Type_afcfa3eca1b8411d903dad48d4455762: float
{
}

public abstract class Type_9baed08cd5fd4529a8eb5ca0b1709571: float
{
}

public abstract class Type_ca385f96dca140bdae41bf45f838700f: float
{
}

public abstract class Type_9e0103dc48b947a59ba337d611f7fc9c: float
{
}

public abstract class Type_552a407b3fc845359c840e089d2c6fd0: float
{
}

public abstract class Type_48fe4449ca104b26b971302315589e39: float
{
}

public abstract class Table_b3c0bbc1a7004c2bb46848b2758eae97
{
  [FactorioRconAttribute("smoke_name")]
  public string SmokeName { get; set; }

  [FactorioRconAttribute("offsets")]
  public List<Vector> Offsets { get; set; }

  [FactorioRconAttribute("offset_deviation")]
  public BoundingBox OffsetDeviation { get; set; }

  [FactorioRconAttribute("initial_height")]
  public float InitialHeight { get; set; }

  [FactorioRconAttribute("max_radius")]
  public float MaxRadius { get; set; }

  [FactorioRconAttribute("speed")]
  public Vector Speed { get; set; }

  [FactorioRconAttribute("speed_multiplier")]
  public float SpeedMultiplier { get; set; }

  [FactorioRconAttribute("speed_multiplier_deviation")]
  public float SpeedMultiplierDeviation { get; set; }

  [FactorioRconAttribute("starting_frame")]
  public float StartingFrame { get; set; }

  [FactorioRconAttribute("starting_frame_deviation")]
  public float StartingFrameDeviation { get; set; }

  [FactorioRconAttribute("starting_frame_speed")]
  public float StartingFrameSpeed { get; set; }

  [FactorioRconAttribute("starting_frame_speed_deviation")]
  public float StartingFrameSpeedDeviation { get; set; }

  [FactorioRconAttribute("speed_from_center")]
  public float SpeedFromCenter { get; set; }

  [FactorioRconAttribute("speed_from_center_deviation")]
  public float SpeedFromCenterDeviation { get; set; }

}

public abstract class Type_95f0e385b32d41e1975b08382f0264e2: Color
{
}

public abstract class Type_60d4549d66f3451c8b89f428cdab567c: float
{
}

public abstract class Type_bf220913f2b3484a8644626c4695f78f: float
{
}

public abstract class Type_fa3b7fbe923b43c19661130a46a838b7: CollisionMaskWithFlags
{
}

public abstract class Type_b449bba463c2480ea2e3d36316911eca: bool
{
}

public abstract class Type_2a2e353a326947e19ac89c3010e6bfb8: uint
{
}

public abstract class Type_589d57deb60b4f8b8e3e8ee3e3c754ee: double
{
}

public abstract class Type_545fcf37d73b4a2694ad70cd40686b09: double
{
}

public abstract class Type_553e327dbf2c4c23bcc6d97bdd12c4c8: bool
{
}

public abstract class Type_c93bfbc9db194108817bec7de357ef25: BoundingBox
{
}

public abstract class Type_dc6d8b26bba04df681f00709b4445a9c: uint
{
}

public abstract class Type_d60778dec7874ee2a1c4708df4e51c78: float
{
}

public abstract class Type_b9c7b74b768a4a658418c9c05a553ce6: double
{
}

public abstract class Type_8c8370d42f20406facdd941a44d677a2: LuaElectricEnergySourcePrototype
{
}

public abstract class Type_4422d5f894254c2280ea2b2563abdb05: double
{
}

public abstract class Type_df2bd6b9c7c044df9a351f728840252d: Color
{
}

public abstract class Type_0717c6c0b1024d4c9a2d8084012f1b7a: double
{
}

public abstract class Type_729ad49f173d48e5aabadd45bf8fc9df: double
{
}

public abstract class Type_79768bbe54de451aa745d7b067934c9c: double
{
}

public abstract class Type_e418388a37c64719bf6525fd776ca037: double
{
}

public abstract class Type_09975e455a2d412b86ed72e4f479f274: double
{
}

public abstract class Type_b634785c3d1940cb8356a1f09212e5c6: double
{
}

public abstract class Type_7bd0f77a0dc444eeb1bfae698fdb8735: double
{
}

public abstract class Type_380a89660dd6459db5b6ee0d4c5aeccc: double
{
}

public abstract class Type_66584ce31bed4f04a1a499970567a269: string
{
}

public abstract class Type_c2e494ee096740f6966d957b406306bd: uint
{
}

public abstract class Type_a518d953c92e482da8abc5136841df4d: TriggerItem
{
}

public abstract class Type_20d6d162592841ab82aa712db89b4cdf: List<TriggerItem>
{
}

public abstract class Type_c886ff584ea940de9a56f7990df80d75: string
{
}

public abstract class Type_c7b73178efbb46aaab8efe0e53c3367e: EntityPrototypeFlags
{
}

public abstract class Type_3ddc808dd5b64b3db33e609b0475a853: LuaFluidPrototype
{
}

public abstract class Type_a8a020b407d1428682c33190e2856b9e: double
{
}

public abstract class Type_134e6959a44b4f4ba9a62460ee64ae15: LuaFluidEnergySourcePrototype
{
}

public abstract class Type_cf3e2de953f44e8089f73a4f5704f895: double
{
}

public abstract class Type_f9f9fefc76194a48a1d2127b39edb9ca: LuaFluidBoxPrototype
{
}

public abstract class Type_62aa3a1ade4147a991f6b20341908e69: List<LuaFluidBoxPrototype>
{
}

public abstract class Type_5902713f55804c4db8cd7f24abe85952: double
{
}

public abstract class Type_5d5176b0ff564c618ccfb8ff665de585: double
{
}

public abstract class Type_30094ff8c1804d8c89a45a86a16f0497: double
{
}

public abstract class Type_2122ebf1eb8d4f86875a7ec14646c3f0: Color
{
}

public abstract class Type_a6e27eb251e6467aafc8e8fc2031b136: LuaEquipmentGridPrototype
{
}

public abstract class Type_824283c68b0e484d93be2ea37f114e8c: LuaGroup
{
}

public abstract class Type_74451fcc355b49e3864b5d3faaddb318: string
{
}

public abstract class Type_48b4a1e699764f55a6e1405dad4c0dac: LuaItemPrototype
{
}

public abstract class Type_74b1bea456d2476387c759d11b9dd129: Dictionary<string, LuaItemPrototype>
{
}

public abstract class Type_3642040021f44b59a9ed7578094a9915: bool
{
}

public abstract class Type_20d566173d124cca88f6cb1e312e8c03: float
{
}

public abstract class Type_0f14446e3bf04e2fa8783264508d6d28: LuaHeatBufferPrototype
{
}

public abstract class Type_a0f5f494769146ed9f5934892880b6cf: LuaHeatEnergySourcePrototype
{
}

public abstract class Type_fbd81781aeea4325a1d7db1b1cf54ad1: double
{
}

public abstract class Type_313269617d854eb5bf41d493be3372cd: LuaItemPrototype
{
}

public abstract class Type_30292642a89d4400859fb5a554f9eb9d: List<LuaItemPrototype>
{
}

public abstract class Type_7aad223e031c4cfea1b0e803e6139e34: uint
{
}

public abstract class Type_716e7d78335e492c95480780d47f2413: bool
{
}

public abstract class Type_d9bb45c52823477b8f91bd69c4748dc3: uint
{
}

public abstract class Type_d4b2833af79c4f3dba839d1ed78caacc: bool
{
}

public abstract class Type_5d2921bc72d24ae49b7da618994bbe38: Vector
{
}

public abstract class Type_5048c390e8284ca991ba21b75f358f4a: double
{
}

public abstract class Type_d696af97596e48598fc466fe2a43d476: Vector
{
}

public abstract class Type_b9a13436d8bc449283697f26791cdb8e: double
{
}

public abstract class Type_e152eb13aab144db8518c12a6b63f518: double
{
}

public abstract class Type_3940eed496cf42fcb85610ace3b943c2: ProgrammableSpeakerInstrument
{
}

public abstract class Type_76142e39383d4f3a8200f6e76d9358f5: List<ProgrammableSpeakerInstrument>
{
}

public abstract class Type_dac5c346585e4f4b80d537da5b96d7ec: bool
{
}

public abstract class Type_6ac5964e27574d4fba86391c657c4f2e: bool
{
}

public abstract class Type_a889bf6d1153435a8c62f484e0f4248a: bool
{
}

public abstract class Type_c652a639b3ce4f378a643dbf3e9ded31: double
{
}

public abstract class Type_04356e8875cc485798dc0807e30c96cf: uint
{
}

public abstract class Type_e5cd4be19fde466eb1065ef5382ade24: ItemStackDefinition
{
}

public abstract class Type_914276889c714350aa7bbc16bee4531d: List<ItemStackDefinition>
{
}

public abstract class Type_17ffd2b22f6b405c94b08cc25b49b653: double
{
}

public abstract class Type_28efc12756a04a39bbc45a9bebc5cc77: string
{
}

public abstract class Type_ff746a539c814363be788e8e29d0d7a0: List<string>
{
}

public abstract class Type_169e160bc52f439e8bbefbf30792427c: double
{
}

public abstract class Type_c28e2ea773db4abeade392c949e5f67c: byte
{
}

public abstract class Type_bd130e2e9f8643e9b04649455644eb37: double
{
}

public abstract class Type_fa81d201ec394020806f6699d39b84c3: LocalisedString
{
}

public abstract class Type_d53adef5f4b742c5bab149b26394eebc: LocalisedString
{
}

/// <summary>
/// Union of literals:
///   - requester
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
///   - none
/// </summary>
public enum Literals_a9e6da9aad8b497f9612797396d4c208
{
  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconDefinitionValue("requester")]
  Requester,

  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  Activesubtractprovider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  Passivesubtractprovider,

  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconDefinitionValue("buffer")]
  Buffer,

  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

}

public abstract class Type_21da0f63dade4f27bf7ea39c8c7da725: float
{
}

public abstract class Type_4bee041591c843a69390e38660c6a546: float
{
}

public abstract class Type_e251b4c10fb34c35ae6ae1d4cba455a9: double
{
}

public abstract class Type_47944f26d4a74f9a871e411f3427c858: uint
{
}

public abstract class Type_65e7d4e811cd45de9505124f990a3bf7: Vector
{
}

public abstract class Type_8506d00bc9874b67a68847a8c1ec1f2b: float
{
}

public abstract class Type_f26e0282811c49a7976f3c6282452dc7: float
{
}

public abstract class Type_6f7de3423ab84600a19d9b39a27451de: float
{
}

public abstract class Type_e568f14bcc3c46bda5b4f55a19b4cd06: float
{
}

public abstract class Type_38034a336af449b3bf6e1ce00145c9a2: uint
{
}

public abstract class Type_444f6d1b737d438e9401f610d82518f3: float
{
}

public abstract class Type_17f5c8fb2d23400b978f44ee6020e0cf: bool
{
}

public abstract class Type_b73140e5433a4cd48ab3f924b216de32: float
{
}

public abstract class Type_dab65e136ace47cd915b52f4f1b80ddb: float
{
}

public abstract class Type_094b9253d2b54721b04c1d49f552cb7b: Vector
{
}

public abstract class Table_3e7f4e51f92f48d99a5f58b35c68961a
{
  [FactorioRconAttribute("spawn_and_station_height")]
  public float SpawnAndStationHeight { get; set; }

  [FactorioRconAttribute("spawn_and_station_shadow_height_offset")]
  public float SpawnAndStationShadowHeightOffset { get; set; }

  [FactorioRconAttribute("charge_approach_distance")]
  public float ChargeApproachDistance { get; set; }

  [FactorioRconAttribute("logistic_radius")]
  public float LogisticRadius { get; set; }

  [FactorioRconAttribute("construction_radius")]
  public float ConstructionRadius { get; set; }

  [FactorioRconAttribute("charging_station_count")]
  public uint ChargingStationCount { get; set; }

  [FactorioRconAttribute("charging_distance")]
  public float ChargingDistance { get; set; }

  [FactorioRconAttribute("charging_station_shift")]
  public Vector ChargingStationShift { get; set; }

  [FactorioRconAttribute("charging_energy")]
  public double ChargingEnergy { get; set; }

  [FactorioRconAttribute("charging_threshold_distance")]
  public float ChargingThresholdDistance { get; set; }

  [FactorioRconAttribute("robot_vertical_acceleration")]
  public float RobotVerticalAcceleration { get; set; }

  [FactorioRconAttribute("stationing_offset")]
  public Vector StationingOffset { get; set; }

  [FactorioRconAttribute("robot_limit")]
  public uint RobotLimit { get; set; }

  [FactorioRconAttribute("logistics_connection_distance")]
  public float LogisticsConnectionDistance { get; set; }

  [FactorioRconAttribute("robots_shrink_when_entering_and_exiting")]
  public bool RobotsShrinkWhenEnteringAndExiting { get; set; }

}

public abstract class Type_c6617a6b952c4b3991681c344a118b08: double
{
}

public abstract class Type_b10a8f4dfddd425488b7d9be0f075522: Loot
{
}

public abstract class Type_bcbc37f9527e4a57ad225bbc51985b74: List<Loot>
{
}

public abstract class Type_d28a48391afa4ff68939abc586d471fa: double
{
}

public abstract class Type_984d65bdddfc41da9893b1a79760bd7b: double
{
}

public abstract class Type_907ea6a3c0ee4311907b6bf3b2c54dd2: Color
{
}

public abstract class Type_6e8282b599a54ad3a8797791ad263951: BoundingBox
{
}

public abstract class Type_c8c9184a231a4a798c597fe197557940: double
{
}

public abstract class Type_68eea1ece76d424f9854c429b7ba9fa1: double
{
}

public abstract class Type_8d58832565bc49ea87fc54ef4ba9e44b: float
{
}

public abstract class Type_d0f0c56f20ad4a04b99af4dffc6eb933: uint
{
}

public abstract class Type_87f94699e09c4b9aab84a8637b0ae1db: uint
{
}

public abstract class Type_a3d2318c26f14052b7bc9d67e33708e1: double
{
}

public abstract class Type_6a5b6b035eda416586b0bf32ca0161fa: double
{
}

public abstract class Type_e2ed9e626295408b89845faf81e51993: double
{
}

public abstract class Type_6317bc4192da4c31821f641b08f9d651: double
{
}

public abstract class Type_fa0f0ef129544cadbca175485fd4dd6a: float
{
}

public abstract class Type_468e898ae78342199d7b437f9c79eb58: uint
{
}

public abstract class Type_8921458f195e477592a4425d7573d544: uint
{
}

public abstract class Type_28701a757211499ea80e7cd3d4488472: double
{
}

public abstract class Type_8366d2596231437ab12f41b3936d09ee: double
{
}

public abstract class Type_2cde7dea622645b88976d0abd0a60f2e: double
{
}

public abstract class Type_cda2148b90634441b9cc09fcc7ae0071: float
{
}

public abstract class Type_2d1b69cab4884323ba4c52df0ccac149: byte
{
}

public abstract class Type_78e6def0cf2f4dfbab66ad659127d388: double
{
}

public abstract class Type_e882d315073140b49a247fe23e34ef72: double
{
}

public abstract class Type_7ff3b9a94259477097d00c9b52e21422: double
{
}

public abstract class Type_8276baea402b4fdcb982bfa148eb41b3: float
{
}

public abstract class Type_9eb48775ad7f4ac5adde167e64eebe80: uint
{
}

public abstract class Type_95f8de09998f4aa39ffd0f7a545ea1db: float
{
}

public abstract class Type_04f16bff2cfd4c319f7928542569fc7a: double
{
}

public abstract class Type_56d0de9bac4c4bbc9a929f3bdfa6157c: bool
{
}

public abstract class Type_c208468e35b74b5d9fee94ccfbdf48a5: string
{
}

public abstract class Type_6fb1974a9bcc42b6ae82539b8e326130: double
{
}

public abstract class Type_94d9c45718164329acf4944993ef50cf: TriggerItem
{
}

public abstract class Type_552a46f63d074a2da5b596b6378a72ba: List<TriggerItem>
{
}

public abstract class Type_64df9a478e144ca1b0d06f041f1f5aa4: Product
{
}

public abstract class Type_3c69b6afb794427db78911db03fed4d0: List<Product>
{
}

public abstract class Type_aaf568acc77149df8efe89cf2b129ae9: string
{
}

public abstract class Table_7b9f9ba053c1464a9d0af3683ba6ff8e
{
  /// <summary>
  /// Is this entity mineable at all?
  /// </summary>
  [FactorioRconAttribute("minable")]
  public bool Minable { get; set; }

  /// <summary>
  /// Energy required to mine an entity.
  /// </summary>
  [FactorioRconAttribute("mining_time")]
  public double MiningTime { get; set; }

  /// <summary>
  /// Prototype name of the particle produced when mining this entity. Will only be present if this entity produces any particle during mining.
  /// </summary>
  [FactorioRconAttribute("mining_particle")]
  public string MiningParticle { get; set; }

  /// <summary>
  /// Products obtained by mining this entity.
  /// </summary>
  [FactorioRconAttribute("products")]
  public List<Product> Products { get; set; }

  /// <summary>
  /// The required fluid amount if any.
  /// </summary>
  [FactorioRconAttribute("fluid_amount")]
  public double FluidAmount { get; set; }

  /// <summary>
  /// The prototype name of the required fluid if any.
  /// </summary>
  [FactorioRconAttribute("required_fluid")]
  public string RequiredFluid { get; set; }

  /// <summary>
  /// The mining trigger if any.
  /// </summary>
  [FactorioRconAttribute("mining_trigger")]
  public List<TriggerItem> MiningTrigger { get; set; }

}

public abstract class Type_c643f306fb944d69993c4822dfc1d669: uint
{
}

public abstract class Type_9ddbca128b734296a1bcd23eb7fc8bd3: double
{
}

public abstract class Type_c78d37f6f401490bb10850a5572320ed: double
{
}

public abstract class Type_6c54668210e24c06a300a79aff73c223: uint
{
}

public abstract class Type_1794a2a69ccb43f491b7e15d8112bfc9: bool
{
}

public abstract class Type_2180768b4b2e4ba3a22b370f70412b18: string
{
}

public abstract class Type_51bcbc165b1c4e139cb987c7be5643d2: double
{
}

public abstract class Type_6926af618bc142e09f421bc05b74bcf5: LuaEntityPrototype
{
}

public abstract class Type_6d1bf04e081b48c7b38619e1809f2644: uint
{
}

public abstract class Type_6dd6f9d82b5642fe9a43f0f59e9984b4: string
{
}

public abstract class Type_eeefbe4cbf0b4c919fc19938782e0d9d: string
{
}

public abstract class Type_2aa6b63900054a128ec20ec447485541: float
{
}

public abstract class Type_a773330b45ae404298ee636a087e8123: bool
{
}

public abstract class Type_76ad32ebaf02459ea37da64fb86a1486: double
{
}

public abstract class Type_32e60728beee45d7aedac47936350c29: uint
{
}

public abstract class Type_4fc7a97a47e7455ca91887d9b6cb0415: double
{
}

public abstract class Type_554d72dbf9554611a4c34d07a1fb7b5b: RadiusVisualisationSpecification
{
}

public abstract class Type_3ce29ee722f440cba263bc18db019440: uint
{
}

public abstract class Type_a59ce5236b5149c79fff31febd4f8fc1: double
{
}

public abstract class Type_5f2f7d9cc6c045619f9eea9bb4877cef: LuaEntityPrototype
{
}

public abstract class Type_608c27df392c4334908f3ec927863b6c: LuaEntityPrototype
{
}

public abstract class Type_f278f800c1824284b835b0c564412558: List<LuaEntityPrototype>
{
}

public abstract class Type_50ac66e33a534814a0ff626786dd6564: string
{
}

public abstract class Type_804d2dd14cd343ad9f5fcdfa9950b069: uint
{
}

public abstract class Type_f0f562705fc64916b62fd1bbbc38e817: double
{
}

public abstract class Type_6960f2720c1e4f30a9bd01259962da53: string
{
}

public abstract class Type_a9d3b16f59fe4c05bfab1605e63ebbd6: Resistance
{
}

public abstract class Type_9b49674a43ae49df946632a60f7eb062: Dictionary<string, Resistance>
{
}

public abstract class Type_b7385af130c847699a31a1f337699360: string
{
}

public abstract class Type_8c4bf8d7b6b14bcb8621b135b0b39873: bool
{
}

public abstract class Type_e7850b43939c48bb8037f398c5de56c7: Dictionary<string, bool>
{
}

public abstract class Type_b9b160136da3464882f086e4b67be629: string
{
}

public abstract class Type_51877c7b2cbc4b589ee4e4049e4732ae: uint
{
}

public abstract class Type_da4874c405e741df8e94f6b8fe5282fd: UnitSpawnDefinition
{
}

public abstract class Type_7d575f0391604a96bf5bcf17972d6955: List<UnitSpawnDefinition>
{
}

public abstract class Type_11406b31137e4817969784562ac0d0ed: double
{
}

public abstract class Type_f400800f4a3c4fd688a8440801353783: LuaEntityPrototype
{
}

public abstract class Type_f3dfd918739d4a8a9310cdce11db47f7: uint
{
}

public abstract class Type_38cc5621b1e2481f9a9eece5a0b8b22b: byte
{
}

public abstract class Type_c15d0e5a0c7142429ae2a2e223f2d215: double
{
}

public abstract class Type_afdbdb5a41ba4f039181767c461bd677: double
{
}

public abstract class Type_77fb03ea197c48dcbfd5bdd455dcc024: bool
{
}

public abstract class Type_3855b6422d5e49b6864bae94bfb3588d: BoundingBox
{
}

public abstract class Type_6810106bd89f4ab1b50da6efac8f48af: bool
{
}

public abstract class Type_b0d14769671340708ca0846ebcd02290: BoundingBox
{
}

public abstract class Type_191051f7839441bbb4f887dc5bf62931: uint
{
}

public abstract class Type_a844b8aff3a6426faccd869a32e6b76d: float
{
}

public abstract class Type_03567e99f7c44eada1abbcef0555f8cd: double
{
}

public abstract class Type_9277dfbfa4cf4dba86fd135c4b03b824: double
{
}

public abstract class Table_a8353115ef9f485a8461477f6f0958b0
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public abstract class Type_54704c7729d140c18cb052d70d32c553: TriggerEffectItem
{
}

public abstract class Type_8307736bd59b46e38c08d9dc7a45c698: List<TriggerEffectItem>
{
}

public abstract class Type_cf284f6c45624cd1bf4afc23a11a1c2d: bool
{
}

public abstract class Type_21e60e080f0e4c45b81bf69e471dbd6d: double
{
}

public abstract class Type_feb653857c5d4886832dc20031891179: double
{
}

public abstract class Type_6fa63c5861e448d28652993dc56b08b8: double
{
}

public abstract class Type_fb75fd1dc42a4f65987daa7bbc65f432: double
{
}

public abstract class Type_541c0453a35c4ed4b7840dbe3227a87b: float
{
}

public abstract class Type_72a24e2293a64daaaebb3e87ccec64cf: bool
{
}

public abstract class Type_34a73653dfd04910a92ff7b1f87d8307: BoundingBox
{
}

public abstract class Type_8fd18dae93ae433aa25ac2c31802fa9f: LuaGroup
{
}

public abstract class Type_2fa0f94fadbb48ddb420ca7cb56f53a3: double
{
}

public abstract class Type_52b539ddf775455e9c2dcc93d84dc933: bool
{
}

public abstract class Type_04b7828482c64bd4826693715e38dc5c: bool
{
}

public abstract class Type_2a7ec9d51f9f4a7f8416a9f7a90ca7e0: double
{
}

public abstract class Type_7c1fd02655994ce88a081259ab7f933c: float
{
}

public abstract class Type_5516d02f2190492ca648fbf0b00ecb39: uint
{
}

public abstract class Type_9e5fb941f2364ab2900750c8e80f2a44: uint
{
}

public abstract class Type_f28ccb96fac542cf880c342f8c268b67: uint
{
}

public abstract class Type_7020ebd1641d4348a3586f958a5a5a03: uint
{
}

public abstract class Type_f831aa97b8c048319fd4d280a4b8bb6a: uint
{
}

public abstract class Type_3a09bbed30134ad58be69bfc61d54039: uint
{
}

public abstract class Type_63f122dfa17248ae9d61951aa77c8a3e: uint
{
}

public abstract class Type_e96d6360c74c44a5b75913aac726a0bc: double
{
}

public abstract class Type_cb81329ead944245a31467d9452151ac: double
{
}

public abstract class Type_eeee09f8fdac4e0e95d711369d6b548f: byte
{
}

public abstract class Type_40868e8fc25a4962bdb14141a9fbff60: CollisionMaskWithFlags
{
}

public abstract class Type_69318e4371544262a785d57fa74a5a14: uint
{
}

public abstract class Type_936a06b61c784568894efe6cd0a4b314: float
{
}

public abstract class Type_22fde76e95294c9f992e693b258dd131: string
{
}

public abstract class Type_bc89d5f8c82749718bb9a616c4f971bc: bool
{
}

public abstract class Type_8abd536d001e4d9fbe036fd6692581e7: bool
{
}

public abstract class Type_d25309c445374d19892ffb07324b2f5a: double
{
}

public abstract class Type_51af2f1b2a75425db807d149bab97e03: double
{
}

public abstract class Type_92dc25586a384542a7daf9269e228e53: LuaVoidEnergySourcePrototype
{
}

public abstract class Type_83a0019d77b54c44af165eeee0543e72: double
{
}

public abstract class Type_c518f90defd643159208a3e6f12fbfab: InventoryEnum
{
}

public abstract class Type_a241dab34f5e477a9e0fb3ec274b145b: uint
{
}

public abstract class Type_4bc7ee70e1bb4ab392a5d3ac3b6d049d: EntityPrototypeFlag
{
}

public abstract class Type_3f05102d9bdd4b64a7d7b177fd78d5c3: bool
{
}

public abstract class Type_e2e1c98760d34306b2cbd3f5d7401cf6: string
{
}

public abstract class Type_104a85f41ad14de8b2e85c759880e0e1: LuaBurner
{
}

public abstract class Type_e4412e585150442cba126c81b82e682f: double
{
}

public abstract class Type_da15025e7f394cc0b6da703e16ff919f: double
{
}

public abstract class Type_464e943360ae47deae5c60337477cfd8: double
{
}

public abstract class Type_82ca63f728784f9ab15d125b78676473: double
{
}

public abstract class Type_b98c30f280ee43eaa3ef5379a52d6be3: double
{
}

public abstract class Type_024e6b8f1c4f47079efe5a02bf1babcc: double
{
}

public abstract class Type_5f136780ac4545098bb7dc14fb3f7d41: string
{
}

public abstract class Type_6b38070e7ec44a5ea8d19ac0cc358489: string
{
}

public abstract class Type_5455f0633d524f01aacef6dc63c6f629: EquipmentPosition
{
}

public abstract class Type_87a4935f3a134ba4a659e520669b3486: LuaEquipmentPrototype
{
}

public abstract class Type_bb4b56b771724a7da1534234dba2aef4: uint
{
}

public abstract class Type_dc1c6258d6054b3293a7c3720438ccc3: uint
{
}

public abstract class Table_5377fe3907fb418f8adb00cbe03f66e2
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public abstract class Type_994ad9d5bdd24b11935d985bc38e64d7: double
{
}

public abstract class Type_350800f44baf4846b91bd803ca3be0c4: string
{
}

public abstract class Type_6c782ac2f68f4a7cb37988b14c60b83b: bool
{
}

public abstract class Type_202839633a994c35a6f50717b6ad81b1: string
{
}

public abstract class Type_f9cb646800a54d74abcc00ccc9ae6062: LocalisedString
{
}

public abstract class Type_de177f3e89e44befac6c4820dc8bc536: LocalisedString
{
}

public abstract class Type_fa90fe2abd9f465da479f5336e39f9d4: string
{
}

public abstract class Type_30c4629424fd49d780d145cd3ca3a895: string
{
}

public abstract class Type_daee37ad7c90464a844acfda240426ba: string
{
}

public abstract class Type_a4d2e11bb101402c84421b9aa13d1790: bool
{
}

public abstract class Type_396b5dd1f001456bbedd743610182d90: string
{
}

public abstract class Type_d803cca29fce4e1c9c4bd731f6364605: double
{
}

public abstract class Type_1fe901e09400420e9520dac43fffa3a1: double
{
}

public abstract class Type_5501c7bd9c32488292f2d64a3aba165b: LuaEquipment
{
}

public abstract class Type_d27e8b0a337a4c53b3b9f679363a03bb: List<LuaEquipment>
{
}

public abstract class Type_844731ad7b644978a5524847783d7901: double
{
}

public abstract class Type_140c27116dcf4daabe7fd61e604d2ab5: uint
{
}

public abstract class Type_b49839babe5747d3b505ae81530ff375: bool
{
}

public abstract class Type_d0ceb7e626464596a76474a977e65c31: float
{
}

public abstract class Type_08d42f721e2b47ecaee07cbbc0ebc097: double
{
}

public abstract class Type_4bd3c7da80d54a46ae6b4638ee8f0c65: string
{
}

public abstract class Type_5e4aaf240a0246b7b2003267b139b05e: LuaEquipmentGridPrototype
{
}

public abstract class Type_a6f6efc28ffb40e0bec71d5320193eb6: float
{
}

public abstract class Type_3f8945af7ea441268407c419ba54af6d: uint
{
}

public abstract class Type_8d55c804538142e49257d281a957f2e1: bool
{
}

public abstract class Type_53340a0143a24453a72ec2fd19b10670: uint
{
}

public abstract class Type_680c1495cdd04d24965de8b71ff654a4: LuaEquipment
{
}

public abstract class Type_fbab1e2e25994442abef6ff8cde48ed4: EquipmentPosition
{
}

public abstract class Type_19b1284efa5c44d682706af61ae7b32e: bool
{
}

public abstract class Type_6790db3fe1894421952d1e544cac9d0b: PlayerIdentification
{
}

public abstract class Type_853871465c9f4d2b96c6fe6f171bca09: string
{
}

public abstract class Type_0e4945be921e466787041c8daf253c79: uint
{
}

public abstract class Type_5a939991c5a34af9960718cab7b9c434: string
{
}

public abstract class Type_516e2b4710b74dcc98eb17c8796560ad: LuaEquipment
{
}

public abstract class Type_b82d03a5291248f5a2b7bdb301a04982: EquipmentPosition
{
}

public abstract class Type_d3d4d716f41348e1bc2f9819e91b77bd: LuaEquipment
{
}

public abstract class Type_cdf4a8877c8f44f9b874b03b344f5bfd: string
{
}

public abstract class Type_88475f9127f840e399ad11bb4bf8ac8c: uint
{
}

public abstract class Type_521017f1980345cf828be215ff85d206: Dictionary<string, uint>
{
}

public abstract class Type_5480b3135cea45abb2fa90e3987e403f: string
{
}

public abstract class Type_8eb10f1d280448b7a8bd8e88976554e3: LuaEquipment
{
}

public abstract class Type_982d903f5c164220802d31cba4e0ff12: EquipmentPosition
{
}

public abstract class Type_5f607888ac174303a5c91244c6bd4b8a: bool
{
}

public abstract class Type_6814eb64212f461c9debc26a4b8faf56: PlayerIdentification
{
}

public abstract class Type_a4e6b635d1f44a09abadd39a6284b43d: string
{
}

public abstract class Type_5e9213ff7b184f1b94fcb42713507001: EquipmentPosition
{
}

public abstract class Type_9e5d5399bc11436dbc2fea9a1d4fedbf: LuaEquipment
{
}

public abstract class Type_659d68355b18474e92412257288577ea: PlayerIdentification
{
}

public abstract class Type_e968fb2399b64db59d3dd34eafc85894: LuaEquipment
{
}

public abstract class Type_c685790725f147e0b4fdc8475ed57480: EquipmentPosition
{
}

public abstract class Type_29adbcf35b484a94b6ca0f5b8fdd8698: SimpleItemStack
{
}

public abstract class Type_b4e3ec51f11642829a8e0f0ff547213a: PlayerIdentification
{
}

public abstract class Type_33dc1cc542114a958fe859566ea346ca: string
{
}

public abstract class Type_7f5e90178f6c4350a722fd77457ff9db: uint
{
}

public abstract class Type_0da003db1ad64398a2d06ae7ae5882cd: Dictionary<string, uint>
{
}

public abstract class Type_67e1fa222e134089a17c5ec623378afa: string
{
}

public abstract class Type_7c4d43b640884317b9c6424f29b3cabc: List<string>
{
}

public abstract class Type_20dd0b0225654b3484143ae3820c46d0: uint
{
}

public abstract class Type_6e8d403b56f343ccb3aba194e6734f36: LocalisedString
{
}

public abstract class Type_5c381351fe9a46d5857a0b13e192af46: LocalisedString
{
}

public abstract class Type_c52b1626b3224de2bfbfbf6eca96821c: bool
{
}

public abstract class Type_c1fccea5373b4a2ea381996c3828a0a9: string
{
}

public abstract class Type_3003900f700043cb86407bbb49363d93: string
{
}

public abstract class Type_f623a682f4604790ab2e9eeb94832b37: string
{
}

public abstract class Type_bddddcfce59e455882cce8a08d521773: bool
{
}

public abstract class Type_2ded7b08da284384990ec5202dd1cbf4: uint
{
}

public abstract class Type_c2634b4081384be19633eb19f427927b: string
{
}

public abstract class Type_6e689a816737425999525dabf5974fe2: AttackParameters
{
}

public abstract class Type_7d9ca4eb0d4e4559ac3d7f8ff1fe57f1: bool
{
}

public abstract class Type_430af33923ab489280cb354112b55360: Color
{
}

public abstract class Type_2ea01fb74782494c93a926c37e11cf99: LuaBurnerPrototype
{
}

public abstract class Type_c64aaf5a8e88412eb31ba0a700aeb05c: LuaElectricEnergySourcePrototype
{
}

public abstract class Type_94b2f5ba61a945b98ff350bf7b22788e: double
{
}

public abstract class Type_f4106e1aa14f4b858c6a186b8e060222: double
{
}

public abstract class Type_a4ba42f709704a7280c6091c09f3d42d: double
{
}

public abstract class Type_7b2508e6ba0c40048365c2854cc6171f: LuaElectricEnergySourcePrototype
{
}

public abstract class Type_f8fef1cb3fca45efacb47e871c6e21bb: string
{
}

public abstract class Type_b14e7b5e080e40629c7349aca831677e: List<string>
{
}

public abstract class Type_8949acf8a3f148f6ae1aae926f45d7f5: LocalisedString
{
}

public abstract class Type_be25d2e4b4a743e9bbfbb0f6cfae0f98: LocalisedString
{
}

public abstract class Type_a06010343cb249b6b77a254fe00b75da: float
{
}

public abstract class Type_fb1a6b1be9d949ae99b18b9ba8b560b7: float
{
}

public abstract class Type_a0a13acfe00f4500bf1e0c29faaed764: double
{
}

public abstract class Type_92870ed43af54915b03f68f46dc249f1: uint
{
}

public abstract class Type_47907636fd2d452b98a4d8e2c1de027a: Vector
{
}

public abstract class Type_d3a660739c764cd29ac664b062c7a0d2: float
{
}

public abstract class Type_7480d3db7b9247a28059e8a5f5f3add5: float
{
}

public abstract class Type_dad8d6408d5042b6a50e79d97416d75c: float
{
}

public abstract class Type_b91f98dc66b145c7bc9d6c5c12fb36ef: float
{
}

public abstract class Type_9c0e939e212d4737a01f9f0ee6e10756: uint
{
}

public abstract class Type_98138b58b2f547889134cd6b0612532e: float
{
}

public abstract class Type_a43c82a11a2d4476b673b92cb24ff50a: bool
{
}

public abstract class Type_86410e39799747c884238fe9345ad053: float
{
}

public abstract class Type_bf40b3cff7c14203b65a092396372bf0: float
{
}

public abstract class Type_9e5db706cc004cdab36a74eb6347df95: Vector
{
}

public abstract class Table_44698373797f477e821ad81ec01893bb
{
  [FactorioRconAttribute("spawn_and_station_height")]
  public float SpawnAndStationHeight { get; set; }

  [FactorioRconAttribute("spawn_and_station_shadow_height_offset")]
  public float SpawnAndStationShadowHeightOffset { get; set; }

  [FactorioRconAttribute("charge_approach_distance")]
  public float ChargeApproachDistance { get; set; }

  [FactorioRconAttribute("logistic_radius")]
  public float LogisticRadius { get; set; }

  [FactorioRconAttribute("construction_radius")]
  public float ConstructionRadius { get; set; }

  [FactorioRconAttribute("charging_station_count")]
  public uint ChargingStationCount { get; set; }

  [FactorioRconAttribute("charging_distance")]
  public float ChargingDistance { get; set; }

  [FactorioRconAttribute("charging_station_shift")]
  public Vector ChargingStationShift { get; set; }

  [FactorioRconAttribute("charging_energy")]
  public double ChargingEnergy { get; set; }

  [FactorioRconAttribute("charging_threshold_distance")]
  public float ChargingThresholdDistance { get; set; }

  [FactorioRconAttribute("robot_vertical_acceleration")]
  public float RobotVerticalAcceleration { get; set; }

  [FactorioRconAttribute("stationing_offset")]
  public Vector StationingOffset { get; set; }

  [FactorioRconAttribute("robot_limit")]
  public uint RobotLimit { get; set; }

  [FactorioRconAttribute("logistics_connection_distance")]
  public float LogisticsConnectionDistance { get; set; }

  [FactorioRconAttribute("robots_shrink_when_entering_and_exiting")]
  public bool RobotsShrinkWhenEnteringAndExiting { get; set; }

}

public abstract class Type_f46a9501e29d404cb1dab4c09b806e80: float
{
}

public abstract class Type_f4cd43879c9645e29163768fa9c8a36b: string
{
}

public abstract class Type_65a3bc4a101f46a5ad2b2f6144f3092d: string
{
}

public abstract class Type_c6450291861c477ca9c71276daec7580: string
{
}

public abstract class Type_9c982c043c3346258d8b74b0e3951bcc: uint
{
}

public abstract class Type_05ac477314084052b3adb1787e2c1d8c: EquipmentPoint
{
}

public abstract class Type_98de2583526f4a0f9f6cbd37df9afa7d: List<EquipmentPoint>
{
}

public abstract class Type_c0e73a85990a48c1bcfa62c2faf08776: uint
{
}

public abstract class Table_24ce6eb44e9c4310898c77c8a21805fb
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

  /// <summary>
  /// Only set when the shape is "manual"
  /// </summary>
  [FactorioRconAttribute("points")]
  public List<EquipmentPoint> Points { get; set; }

}

public abstract class Type_f430446d957a4b559642f24cc7207a88: float
{
}

public abstract class Type_d82e5128d8b84195b02708161698dd22: LuaItemPrototype
{
}

public abstract class Type_6cc2f5f277b84830a6625939644a182f: string
{
}

public abstract class Type_a0fa364c48674bd0abfb82b5163a308c: bool
{
}

public abstract class Type_6843f4490eaf4ad3bce4ca8857fe59c6: string
{
}

public abstract class Type_683578ce5a814f68867da884696a09e2: LuaForce
{
}

public abstract class Type_24b83297ac334fe1b02da698a0543929: string
{
}

public abstract class Type_113190663851498980efe401fa98d136: ulong
{
}

public abstract class Type_eeae5c5385844ea9a309886ff3df558b: double
{
}

[GenerateOneOf]
public abstract partial class Union_7f2acb5ecf4c4b7894b1c049e829bef1: OneOfBase<ulong, double>
{
}

public abstract class Type_7cbff3bc58f6468cbdc8ac0ea78902d9: Dictionary<string, Union_7f2acb5ecf4c4b7894b1c049e829bef1>
{
}

public abstract class Type_32db9234ec954c29b3ebd276db1c6a2d: string
{
}

public abstract class Type_0945bf8b5c464f2bb342eb0e238d7f00: string
{
}

public abstract class Type_ee23a7c3154e4e13a1f7f12531915826: ulong
{
}

public abstract class Type_69e9fb7f41c94ce2849d125792fb9305: double
{
}

[GenerateOneOf]
public abstract partial class Union_1d82e214d8d2465db8d29bf16e451b0c: OneOfBase<ulong, double>
{
}

public abstract class Type_b8abdd9d159e405e882fa8c3a3e91bc6: Dictionary<string, Union_1d82e214d8d2465db8d29bf16e451b0c>
{
}

public abstract class Type_a43447fc3a6a4b23b1fb73fd9bf72956: bool
{
}

public abstract class Type_0e807ea04a73488494e71ed61283f774: bool
{
}

public abstract class Type_4d78c839e9d447a183775f95118a4dd8: bool
{
}

public abstract class Type_ef9107efd77e4a8c839731ba6166ce21: string
{
}

public abstract class Type_a71dfe04d04240eba61033627dc838c4: FlowPrecisionIndexEnum
{
}

public abstract class Type_b981cdde4a7144d78608162b6d6fad44: ushort
{
}

public abstract class Type_e1aaaf5b7aaa4ece899d49225e6c2320: double
{
}

public abstract class Type_03635e766915457e81f4d638196fe219: string
{
}

public abstract class Type_cc05ac51615d4d229a122006648c1c36: ulong
{
}

public abstract class Type_54bcfab4f0ae491d9ee592e67be1aa0a: double
{
}

[GenerateOneOf]
public abstract partial class Union_4a7c4bf6944a4f51833fb041e70f4eac: OneOfBase<ulong, double>
{
}

public abstract class Type_cd004a492d90427596c4e75816ead532: string
{
}

public abstract class Type_d8c6f9bd7edb46b4a69406e0c33ee2ba: ulong
{
}

public abstract class Type_095c0349eb2443558c491dd2ba8c0d98: double
{
}

[GenerateOneOf]
public abstract partial class Union_96f81cfc91c743dabf8bff8bfbf5f347: OneOfBase<ulong, double>
{
}

public abstract class Type_fcebba0afce148a39173296685cfccb6: string
{
}

public abstract class Type_451bc8759e0442fca5ca7792f6022f56: float
{
}

public abstract class Type_721f2658cfbe40968d3cf9d086921b2a: string
{
}

public abstract class Type_1664fa0ca74e4876ab37061c9a190bfc: ulong
{
}

public abstract class Type_5447a3a4688b44df8f9c29809c76bfd2: double
{
}

[GenerateOneOf]
public abstract partial class Union_7d0a4c7ae8744892a236820804b2d322: OneOfBase<ulong, double>
{
}

public abstract class Type_bf30e6cff24a4a49984dca7d3d95401e: string
{
}

public abstract class Type_97298535ca444d3097bb849c88dcbdae: ulong
{
}

public abstract class Type_e39cd69785a941c9b67c216c2428c9a1: double
{
}

[GenerateOneOf]
public abstract partial class Union_de884d253b974a02806de77bc378f2ab: OneOfBase<ulong, double>
{
}

public abstract class Type_7f005a606bb04c3fa48012b4b14caa1e: string
{
}

public abstract class Type_867a1f72456d4b8c99e065f6b5196187: string
{
}

public abstract class Type_1eea7d9935bd43a19a55aefe1b03f2e5: LuaEntity
{
}

public abstract class Type_3f7e6475455645ed8dca26e8b431beef: bool
{
}

public abstract class Type_6613a7c2b55e439cbabd591597731271: Fluid
{
}

public abstract class Type_46006ec4dfb54b64bf103c1b05b0fa8e: uint
{
}

public abstract class Type_421bf12c42bc4d06a3b7faf9a3acd949: FluidIdentification
{
}

public abstract class Type_b217c06e2a584d50b5fe13dc0622a439: uint
{
}

public abstract class Type_50908b0d33a949f4a19054f26e5e1e65: string
{
}

public abstract class Type_514a9aea5022462b95c094292dfdaf5d: float
{
}

public abstract class Type_1c25b9d8510542dab2b947b217dc857e: Dictionary<string, float>
{
}

public abstract class Type_45ebdd1cf02545898a284ba46c454651: uint
{
}

public abstract class Type_0748cdc71ff84337b7072e8a293901e4: double
{
}

public abstract class Type_2c9deacebdce4605bd85063191885baa: uint
{
}

public abstract class Type_a8be556037b34758af380855b903b4bc: LuaFluidBox
{
}

public abstract class Type_17df89a8c5fb4faeb35d2f1a569a578b: List<LuaFluidBox>
{
}

public abstract class Type_3aff00d3a6564f88839b5fb29c27113d: uint
{
}

public abstract class Type_2bdba060bd4b49888d00810ef4f8c163: FluidBoxFilter
{
}

public abstract class Type_47ba7643660246749b9cb8435404f69e: uint
{
}

public abstract class Type_7a21d5a5c9974ac3abfec014caefbfae: double
{
}

public abstract class Type_e4062fc1ce4b410d8b575b1fdba0ce41: uint
{
}

public abstract class Type_93757341920245928f4b47b93bd361df: string
{
}

public abstract class Type_c0181cefc9584fc284904f187696099a: uint
{
}

public abstract class Type_c46ad45daec9412a8efe27d561be7fdc: Dictionary<string, uint>
{
}

public abstract class Type_c5a3f0d18de5430482dfb893c9d49e85: uint
{
}

public abstract class Type_615c979cec9e40d7a07aaca2068cb1d5: uint
{
}

public abstract class Type_3a5b908ab0994707a006e001bd303663: uint
{
}

public abstract class Type_00381d0218b44f39b4c22422ca1afcfc: string
{
}

public abstract class Type_cb9f6fce791348d4bd87f329d7ceeeca: uint
{
}

public abstract class Type_c3600fda1ca74836bee08f1dc1df1c66: PipeConnection
{
}

public abstract class Type_8a8fca8a3b1746f5b33b3ef06fd17894: List<PipeConnection>
{
}

public abstract class Type_80327a7252b54f91a1f27eeb5b3071c0: uint
{
}

public abstract class Type_b3049aa7624947c4ab280cbb04cbd927: LuaFluidBoxPrototype
{
}

public abstract class Type_6ccdc89e3d9b4802af011563a0e2b316: LuaFluidBoxPrototype
{
}

public abstract class Type_9ecc64e439d146f29607c65504679ebe: List<LuaFluidBoxPrototype>
{
}

[GenerateOneOf]
public abstract partial class Union_2acc94ae5b734984b05b87b642fcf96b: OneOfBase<LuaFluidBoxPrototype, List<LuaFluidBoxPrototype>>
{
}

public abstract class Type_d1c148580da747849a6757517ae7b368: string
{
}

public abstract class Type_05232f214e854fe59c162b306dcc070d: FluidBoxFilterSpec
{
}

public abstract class Type_9112fbff8ea14c3caee99e7ff7820c15: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_5c2b4d726ca64fbcb7f58729bb013fc6: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

public abstract class Type_aac3620046c349cda025e33309908a4f: uint
{
}

public abstract class Type_eb5d632d2a174ee08c957a34cad68d98: bool
{
}

public abstract class Type_ee8ed80e9697447aa5ec1bb5bf36ce01: double
{
}

public abstract class Type_0a8dbb5024494d4cb0b6ef4f747905a0: float
{
}

public abstract class Type_397d2c9670644b838271a59f91913349: LuaEntityPrototype
{
}

public abstract class Type_0d94a9c1ee2741c58a04680a5fc0e9cf: LuaFluidPrototype
{
}

public abstract class Type_43fb213577cc4f72b90c581ee7a42856: double
{
}

public abstract class Type_8dd394590005402ba0879b7dfd6b1839: uint
{
}

public abstract class Type_0f1d0e8a2dde4783aa51e05eeb79a658: double
{
}

public abstract class Type_c0a3f9e9aaf34085a5c0e842160f2c20: double
{
}

public abstract class Type_e4b3e944af394d46b7bedf2ee7e60542: string
{
}

public abstract class Type_855ccac31c43494d8fa97a4e1bdef3a1: FluidBoxConnection
{
}

public abstract class Type_cb37ea9e0f4140a793b90cfb899f0146: List<FluidBoxConnection>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals_d0e4b0b2c95a475a9dc10cd4c24b47c9
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  Inputsubtractoutput,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

}

public abstract class Type_09a72aa321654e3cadf433609f092322: string
{
}

public abstract class Type_f1367df3b6604e59be86df174a7f7187: int
{
}

public abstract class Type_564d6693d2e04b598ad844638e486472: List<int>
{
}

public abstract class Type_2b8bd910ea7648978bbae844182febb8: bool
{
}

public abstract class Type_59025cbb51614470b7901c147eb29cfa: double
{
}

public abstract class Type_654b59303b35419ab23670a6e2cc4b18: string
{
}

public abstract class Type_c47e2b15f7164048b9cc47c224db8f39: bool
{
}

public abstract class Type_82fab65b6192458797798b2142991d02: bool
{
}

public abstract class Type_2a315bdeeee047d586a375910c8bbfc4: double
{
}

public abstract class Type_2dd37876faae4997a0576212706776f4: double
{
}

public abstract class Type_fca1ca2f980e42ea98d53f6088e9214c: LuaFluidBoxPrototype
{
}

public abstract class Type_3a980375a0b744b8acb60fc4a670f947: double
{
}

public abstract class Type_f16ee732af654604a854f078befcd2d3: double
{
}

public abstract class Type_423a640709f34aca8b4e843f1787dcba: string
{
}

public abstract class Type_614fa7c1d322499b8593636c004b9897: bool
{
}

public abstract class Type_c30db33726ef4f108b0c233eae0e859d: bool
{
}

public abstract class Type_04aa3ddd7ace41c197a671ea3eb112f7: bool
{
}

public abstract class Type_79ed9de012124a97bd724189303e905c: SmokeSource
{
}

public abstract class Type_dffdfd5fd98440afa096dc2fc56ac62c: List<SmokeSource>
{
}

public abstract class Type_aa9aa850cca845f19296e32838c4fd37: bool
{
}

public abstract class Type_188ae07ae3c1498bb7bafb5a41ed19a2: string
{
}

public abstract class Type_48f0a3cdd7504cec88bdd29e9e25272c: Color
{
}

public abstract class Type_815380921c024b1a9e5522ac61927a28: double
{
}

public abstract class Type_15f7f436df1e4382a49e64924e4c84f4: double
{
}

public abstract class Type_19eada90a43645e8954617349a89aeb9: Color
{
}

public abstract class Type_877ba52df28341d5a5439850dbf2e127: double
{
}

public abstract class Type_e6ccc50cfe5f427fb71356045dbeca3a: double
{
}

public abstract class Type_0f6900f43dcb40419078535ea9d03166: LuaGroup
{
}

public abstract class Type_fe66d47e2dd74155bffc7412c7fddd55: double
{
}

public abstract class Type_1dd0465fe4d94f479cb90fbc6ba08959: bool
{
}

public abstract class Type_aa175a6fa8734c0b81f75fcc7cf9d41b: LocalisedString
{
}

public abstract class Type_b504f4a9e7cb4d9f90b8e50edcee46df: LocalisedString
{
}

public abstract class Type_f2151b1f4e9f4b8ebe62499b39986e81: double
{
}

public abstract class Type_ec196e546df84be4918f8f78a25fa431: string
{
}

public abstract class Type_9221afbb374f4f0dbc8cd0a90e8453a5: string
{
}

public abstract class Type_eba975ef017c483485fc30a25ff84d1e: string
{
}

public abstract class Type_b2b8050beeef4edca62ca2427e71d71b: LuaGroup
{
}

public abstract class Type_e14af9f65570431d8b6b8cc7d4786fa2: bool
{
}

public abstract class Type_4c1c72bfc7d847a1959845225b78970c: string
{
}

public abstract class Type_ac997cd1d8ea4a5a916e0d05c25472b2: bool
{
}

public abstract class Type_a0a9845275ce4e92baaf9d1214dc69a6: Color
{
}

public abstract class Type_e58611a10da5422f91246653b11b0e00: bool
{
}

public abstract class Type_e534c69a53e640da9491fc35d47e6c56: string
{
}

public abstract class Type_54f1e9b3f09b4dd2934095433df01b59: string
{
}

public abstract class Type_d7b3ccef7c2e4d129f1092d043c8f069: string
{
}

public abstract class Type_fd630a4f080146ee916919bf508c3eb7: int
{
}

public abstract class Type_d46a17b9e04c4a0993d7bb78a3567720: float
{
}

public abstract class Type_8c5c7fce65fe492da364766356640c48: bool
{
}

public abstract class Type_5029051dde71474f9c5e086383a8e73a: string
{
}

public abstract class Type_848d795c9381423e8683ef9c71873fc6: bool
{
}

public abstract class Type_196864cd7a9b4c348ff351c2ce8b763d: double
{
}

public abstract class Type_2d9a533a2a6c400aa28505137d872d32: uint
{
}

public abstract class Type_e85ceeeac39d4ddbb42dd56b2df43e88: double
{
}

public abstract class Type_854d3870d3ae4de7a3cf3084b7fbccd0: uint
{
}

public abstract class Type_f8896c4524c843d5b5fbb87d592cc547: uint
{
}

public abstract class Type_0144831a4edc4c61803987e6c3032b7d: double
{
}

public abstract class Type_89460d200bdc410d9279f3bfef679538: bool
{
}

public abstract class Type_6dcc7b94aef74957bcc7030fa378132e: double
{
}

public abstract class Type_225984c6d921492980f9021f154ff14e: uint
{
}

public abstract class Type_bf956dad3b8e48d88adb77a7286da389: double
{
}

public abstract class Type_d260a4ac4daa4bde94af262bceb0c53c: double
{
}

public abstract class Type_0912b2f5874f4f0fbf18b26715e367a1: double
{
}

public abstract class Type_725d3bba2e984c1ba7458c270f88724a: Color
{
}

public abstract class Type_13896309301d4422a13dfdd4d3eacbad: LuaPlayer
{
}

public abstract class Type_c5214a17a9654c15b5f7535705d3e254: List<LuaPlayer>
{
}

public abstract class Type_5cd8f294b7f844c3880e8dc22efacd12: LuaTechnology
{
}

public abstract class Type_7f85275b05cf44478f3b86253ea84371: Color
{
}

public abstract class Type_fc3307dd3a7e45a9b05836ab3ca20f82: uint
{
}

public abstract class Type_48ca933d468345c7b1bce4a5939a1d3f: LuaFlowStatistics
{
}

public abstract class Type_b10bad6f4cca4c80b2ede9dcb5ec9881: double
{
}

public abstract class Type_8c61b60317a744db8b8973bd1b6940da: double
{
}

public abstract class Type_5e6e2ca8194740bf85bfb8a15ca8c928: double
{
}

public abstract class Type_d26ff7e24e2046918a3ac31bd6b24f57: double
{
}

public abstract class Type_f6a58a08f32b489c80f168cc96ddbf95: LuaFlowStatistics
{
}

public abstract class Type_21f119ed06d444d390146bb8e0572a03: double
{
}

public abstract class Type_8390ebc77ef94e5587150fd1aa026af9: bool
{
}

public abstract class Type_bd9bb8ac779f41eea0673fd1a314f0d0: uint
{
}

public abstract class Type_521dda08cca54f92836d4d026779e680: uint
{
}

public abstract class Type_b28cc3df3c0042e282fcc26548246fe1: double
{
}

public abstract class Type_a1955898bd2c483ca9e9996c3db0a11d: LuaFlowStatistics
{
}

public abstract class Type_21a7e610e82744b3a09cfb418ba837fb: string
{
}

public abstract class Type_f5ab0a45bf9d45ea82f6050ba1f6286d: uint
{
}

public abstract class Type_188d23cbb6124dc29b40286f8e63e195: Dictionary<string, uint>
{
}

public abstract class Type_76dfcecb721f457a884910ba6c4e0ecf: LuaFlowStatistics
{
}

public abstract class Type_9cc0a8614234454a872c0c98a0d21150: double
{
}

public abstract class Type_18f677775826498792a6bdeebb1782b3: double
{
}

public abstract class Type_f0f0d8cfb1fe4d69adcf886901bc36fe: string
{
}

public abstract class Type_46ed74c586e84f19bff650c7852716e3: LuaLogisticNetwork
{
}

public abstract class Type_556535a5353c46008c5a319c1c6d01f2: List<LuaLogisticNetwork>
{
}

public abstract class Type_6dad92cc520d458490d97a54de393492: Dictionary<string, List<LuaLogisticNetwork>>
{
}

public abstract class Type_ff062f4cfb6641259157c47d2fd0edb7: double
{
}

public abstract class Type_a95c33bd07a14d60b7d910fd85548610: double
{
}

public abstract class Type_2ee8206f4be348eba92f23054da88e19: uint
{
}

public abstract class Type_7f04bd3e69c2416f969888b52b76adbe: uint
{
}

public abstract class Type_162bd58a2e664ddaae9b68d6e3e17cc6: uint
{
}

public abstract class Type_56cdb6540b7e4f63bd062b53a1bf673a: double
{
}

public abstract class Type_e17ea0324b6a4288979d876fb752244a: string
{
}

public abstract class Type_f9e08fa8fdd24ed587d5142a1e36d97f: string
{
}

public abstract class Type_64b56122d2604d399f40589ac85c39e8: LuaPlayer
{
}

public abstract class Type_0143744fc5e94c7984f998077632678c: List<LuaPlayer>
{
}

public abstract class Type_6e21e885f36643388cd66e283c2afce3: LuaTechnology
{
}

public abstract class Type_a46e731557e042039f5d17741a8c4354: string
{
}

public abstract class Type_d3c4c3cd704d4ccebf0c287500604b02: LuaRecipe
{
}

public abstract class Type_9e479e73cb15474b93129602af1841cd: LuaCustomTable<string, LuaRecipe>
{
}

public abstract class Type_83c145813f994f25a86626dd21a76586: bool
{
}

public abstract class Type_f2a6a19d81eb477990ce35f2944694c7: double
{
}

public abstract class Type_f2775bd2ede04b62bff994661e441a8c: TechnologyIdentification
{
}

public abstract class Type_ab8394045c124715a93f925e6825614c: List<TechnologyIdentification>
{
}

public abstract class Type_a89e00082e33435b9bdb97f4c6ac7e34: bool
{
}

public abstract class Type_33bb913432754003b5a2799c0498583d: uint
{
}

public abstract class Type_4b1affb51e3c4e2ca1a783917f7552e3: bool
{
}

public abstract class Type_1dac47bedf274677992d0f1b849cae04: uint
{
}

public abstract class Type_1a9469cdbe7e4829be8aa57a8c101006: string
{
}

public abstract class Type_cbdf02bd1f464469966633d2e5996680: LuaTechnology
{
}

public abstract class Type_79ba39d2ad344f6f9275e00d791921de: LuaCustomTable<string, LuaTechnology>
{
}

public abstract class Type_65ac97d4f73f4cdaa411c5bc8007db24: double
{
}

public abstract class Type_610644921be140ae94c3b82d9286a70c: bool
{
}

public abstract class Type_1ef87aae729c49aaa02029d917000c1f: double
{
}

public abstract class Type_05efa32b2c43406d99153f51e7d2cc3c: double
{
}

public abstract class Type_b89b767b0d514d59ac41cec75b699ed0: double
{
}

public abstract class Type_038ccc1f0b6d41a38baa85b099ac86da: bool
{
}

public abstract class Type_8f62304864f14485be6134fc3e5b2d65: bool
{
}

public abstract class Type_5e8473d99aae452db9fcbd3809047365: bool
{
}

public abstract class Type_feb23f1933bc4816b8fc480223c0d793: bool
{
}

public abstract class Type_39aa81dbd6a44a568f88d1c8e1caea34: bool
{
}

public abstract class Type_7a5d9a8fa58842ddb890e7e29c72b36a: SurfaceIdentification
{
}

public abstract class Type_3de25a68466b496d82f8dcaf790f1d21: ChartTagSpec
{
}

public abstract class Type_6f76cdabab0249a8845fd163553f7071: LuaCustomChartTag
{
}

public abstract class Type_046e677791b74f65907879062a4133fa: TechnologyIdentification
{
}

public abstract class Type_edc9195aa4ab4747982be3683ac1c029: bool
{
}

public abstract class Type_664ac71ec66749b0a29eef354c3d87c9: SurfaceIdentification
{
}

public abstract class Type_a21532486164494fa77d14a281bcf016: BoundingBox
{
}

public abstract class Type_e5fff170d31944c984a2329dfdbe7cce: SurfaceIdentification
{
}

public abstract class Type_d3a95d849de34c719252a054c8025923: SurfaceIdentification
{
}

public abstract class Type_b9eedb39466140e2b17b6482b0dcb89f: SurfaceIdentification
{
}

public abstract class Type_32c1ce2be0154d56a49b8ccb5e23d995: BoundingBox
{
}

public abstract class Type_99c45d0a28164f82b92714268aadd731: SurfaceIdentification
{
}

public abstract class Type_e50b51172080422ea17e81b8f9b82c2e: LuaCustomChartTag
{
}

public abstract class Type_b030920ff32d46d782f42e5b89d27c7f: List<LuaCustomChartTag>
{
}

public abstract class Type_30f59b59c38c4697b1e672bf38d1fba1: MapPosition
{
}

public abstract class Type_f68de27082bf4676983def1d9d62aae6: SurfaceIdentification
{
}

public abstract class Type_f01b3ed429be43aeac4a584be4b1eb7d: LuaLogisticNetwork
{
}

public abstract class Type_84849403069c428eb75dbf8a4de5d221: string
{
}

public abstract class Type_c96e5198302c49f6a939816dd146eec5: double
{
}

public abstract class Type_6d898fef02f04517846d92d38af36954: ForceIdentification
{
}

public abstract class Type_dd5587b50845446db707bb619943f2fb: bool
{
}

public abstract class Type_b7d8f7df7db148ffbfa3000b13b2fbf9: string
{
}

public abstract class Type_0b4cae88312b4668ab0904567244859c: uint
{
}

public abstract class Type_3fce068cbfcf4e7982c57cf0f14b327f: ForceIdentification
{
}

public abstract class Type_e58cdee71f894466bb5d2b6db93b3c56: bool
{
}

public abstract class Type_6783ffc8211d4145adc841dd96520a34: string
{
}

public abstract class Type_9bd298d5afab4c7cb47869dbd1a5d7cc: double
{
}

public abstract class Type_a1bd4ac9ca80451ea7d0e68e870e5cd5: string
{
}

public abstract class Type_588eed3a65b443d480dc473efe88da8e: LuaRecipe
{
}

[GenerateOneOf]
public abstract partial class Union_7b60a42b6ef64ab4a92d40965b300174: OneOfBase<string, LuaRecipe>
{
}

public abstract class Type_a46b3ea8f3e4447fa738a26c0cb10b15: bool
{
}

public abstract class Type_52d8bf088b55410abe9b6a7602bcb93a: string
{
}

public abstract class Type_a90cdc10f0864220bc241319dd6aaf90: uint
{
}

public abstract class Type_be2b0b7788bb4cc4818b708dffc1d34b: uint
{
}

public abstract class Type_f93a855dff6c4593bcca9a5c0bfc1987: EntityPrototypeIdentification
{
}

public abstract class Type_612132ffba8c476c956b4edfd5b0ad5c: LuaInventory
{
}

public abstract class Type_dbcac580402a4284826c790f6a80b42b: TechnologyIdentification
{
}

public abstract class Type_a3baca0da617408dbef14f5ceff3706e: double
{
}

public abstract class Type_aa85914839c14cba8b191842af5727bf: SurfaceIdentification
{
}

public abstract class Type_a083035c6ace4f91839305148a90a3ee: MapPosition
{
}

public abstract class Type_5fef5a494c0541edabed372ead39be47: string
{
}

public abstract class Type_6618128562e9448da266729e55078555: string
{
}

public abstract class Type_e18b1fce7a0e481c83a04b4162183712: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_893d854c568b4e87b9d9ab51a403ee4f: OneOfBase<string, List<string>>
{
}

public abstract class Type_ea3d3ba0950347b48a683f334ab0fbef: SurfaceIdentification
{
}

public abstract class Type_84c2b089deea4949a783f074cb226f38: LuaEntity
{
}

public abstract class Type_eff659fa76864f9e805ba30b0c7dfcde: List<LuaEntity>
{
}

public abstract class Type_122e142f6e4d44c08490388b3855396f: SurfaceIdentification
{
}

public abstract class Type_0f1efe434db545d1be09261cc88c480c: LuaTrain
{
}

public abstract class Type_2eabc203d7794dc08dbcd8e600140375: List<LuaTrain>
{
}

public abstract class Type_14b493878a354334949fb603ff61251c: string
{
}

public abstract class Type_194a0f19f08f4827ba00ebbbbcfa9086: double
{
}

public abstract class Type_bfd3922a6f7a4d6697fdc6afc920962c: string
{
}

public abstract class Type_2b3a10dcd3d44160b5d016d87228a156: ChunkPosition
{
}

public abstract class Type_826e3a2106ac4e6286c2db326b2ca241: SurfaceIdentification
{
}

public abstract class Type_4a982afad9b94ddeaeda41b700ddafea: bool
{
}

public abstract class Type_47ab8a40ef0f44789cec74f2ae01891d: ChunkPosition
{
}

public abstract class Type_35cf72d647aa496d8bc96a883a173685: SurfaceIdentification
{
}

public abstract class Type_b7651c12ade5482a9a40afe7c0764eab: bool
{
}

public abstract class Type_944f0921540b441fa256de4ebe47e1d0: ChunkPosition
{
}

public abstract class Type_3f81cb742de944bfbab9dea37b6da2c5: SurfaceIdentification
{
}

public abstract class Type_1aa93185a1a04681aac5ba0736c0495a: bool
{
}

public abstract class Type_b13c5bbaa3d644ad9b83a154bdbecb84: ForceIdentification
{
}

public abstract class Type_d7480a6c455e4ab7a938e548bcad9683: bool
{
}

public abstract class Type_9f75942eb23f492eadd5f99cde0cd9a4: ForceIdentification
{
}

public abstract class Type_d1f724e4e79744ccb72b364c164faaea: bool
{
}

public abstract class Type_09c380180f004681a05ffc7fb35ccbf7: bool
{
}

public abstract class Type_bacc1282066941fe8ca20b668717a979: SoundType
{
}

public abstract class Type_a66aad91fa9f4fd2bad54d9b71b59a83: SoundPath
{
}

public abstract class Type_d9371dc630e74594ab042632d0444400: MapPosition
{
}

public abstract class Type_b6a29b9b90b44beb905a5eef8d5020c3: double
{
}

public abstract class Type_7a520c311a1a4d258ac917c279800198: LocalisedString
{
}

public abstract class Type_e7213d2330b84408bd5214db059d7512: Color
{
}

public abstract class Type_abed3ef9097b4f52b38cadcf21a8a463: PrintSettings
{
}

[GenerateOneOf]
public abstract partial class Union_a9c9df53297e4f3eb1791cccfcf4563a: OneOfBase<Color, PrintSettings>
{
}

public abstract class Type_0dfd9c741d7a43a28f9271f69107a414: SurfaceIdentification
{
}

public abstract class Type_dcb7af8c58ce4261b4cb711125272f72: bool
{
}

public abstract class Type_16ffe5e8b0204192aa3f419c03db77ef: string
{
}

public abstract class Type_111d4ef6cabf4080aa1bc5365c9615f0: double
{
}

public abstract class Type_37f298eab15b48ce814bda2faccddb9f: bool
{
}

public abstract class Type_2e955f99421b4de7b3be032927fcb809: ForceIdentification
{
}

public abstract class Type_dfdfd212d73c42789658b7e371358388: bool
{
}

public abstract class Type_954bf2eb1fc745b5b496bc958bdff221: ForceIdentification
{
}

public abstract class Type_aec3b9a5a89341f2afe636b703eb57d0: string
{
}

public abstract class Type_07f611ef21b04662bd0501b2418bfbaf: double
{
}

public abstract class Type_9301584e6395440aaf0df80d1b757ec0: bool
{
}

public abstract class Type_6c2df43e02ba48978983e47518303fc0: string
{
}

public abstract class Type_f2cbbf651b704e139581f2ff66292034: LuaRecipe
{
}

[GenerateOneOf]
public abstract partial class Union_325174f4690c4dda833b2b2ae238dc14: OneOfBase<string, LuaRecipe>
{
}

public abstract class Type_a6c039dbe1fd41a2861e3728af7af1be: uint
{
}

public abstract class Type_2e19313bb2f24ed4bf3885c3505c1786: string
{
}

public abstract class Type_d36b55cb42c641bda2e9664379090206: double
{
}

public abstract class Type_d9e50a0acc09487f86b976793c13979b: TechnologyIdentification
{
}

public abstract class Type_e159ecec4f274f0aa3eb989c60687efb: MapPosition
{
}

public abstract class Type_fbe82b9e742c40738648477396bd31e8: SurfaceIdentification
{
}

public abstract class Type_295d96e59dc543d19e42aec8ba938cfa: double
{
}

public abstract class Type_75155b78c992484ea673963f3f2d06ff: string
{
}

public abstract class Type_5e37faf412ff4d5ca64d40798becd511: ChunkPosition
{
}

public abstract class Type_dc7af5c9657f47078420702ce7304e77: SurfaceIdentification
{
}

public abstract class Type_b9171d0a91af464f91f182cc66f7156f: LocalisedString
{
}

public abstract class Type_1f8dae8f756b4775a38f43309e897fb3: LocalisedString
{
}

public abstract class Type_8afc0f6e49e642329ee1f3e4464991ed: string
{
}

public abstract class Type_515d22ab9e9c4a149b8fde6e6eabf0d2: string
{
}

public abstract class Type_837dfcce30e4425a971fcb066372a830: string
{
}

public abstract class Type_ac2971f75d5146e9997d34f74f4cf646: bool
{
}

public abstract class Type_b28fa0770818423cad566588afd208aa: string
{
}

public abstract class Type_c61c905e9c6f4fc9b58b69eb899b2f4e: string
{
}

public abstract class Type_30ec3a761672402c8ed8f7c9e303d304: LuaAchievementPrototype
{
}

public abstract class Type_704117c7d23342729068b5dcb8eb7141: LuaCustomTable<string, LuaAchievementPrototype>
{
}

public abstract class Type_10cc39f6606149968148876e6bbb537c: string
{
}

public abstract class Type_c5c8659ff1b64b0e8e72b74e970ee4ff: string
{
}

public abstract class Type_71feb4dda1b0438fa9bee8f3400298a1: Dictionary<string, string>
{
}

public abstract class Type_a0748173314c4d38b2af945057159791: string
{
}

public abstract class Type_807c63a89b17423c898ad1f84f58ec90: LuaAmmoCategoryPrototype
{
}

public abstract class Type_eb30e429c3394b2782a21839e12b1526: LuaCustomTable<string, LuaAmmoCategoryPrototype>
{
}

public abstract class Type_6c8e1197234245d1919dafc647957895: string
{
}

public abstract class Type_df4e2b49dd0a498da048b64d9ab8f7e6: LuaAutoplaceControlPrototype
{
}

public abstract class Type_c7bd5013fa8c479490245d52d71c6b3e: LuaCustomTable<string, LuaAutoplaceControlPrototype>
{
}

public abstract class Type_a305afcdb9624b18b3b6ae43d4edf5f5: bool
{
}

public abstract class Type_01df7dd77b3b44fcac0176f2988d1639: uint
{
}

public abstract class Type_04f21bbb6bc0457c90fc42d363dc761c: string
{
}

public abstract class Type_c3e7068dcbca4212a2a341fd89e89b67: LuaCustomTable<uint, string>
{
}

public abstract class Type_d18a45c74fee49149dc8cefb24ae2edf: LuaPlayer
{
}

public abstract class Type_6fd450b2e9f242a3a29f5eaec00bea78: List<LuaPlayer>
{
}

public abstract class Type_a49458d0d31d4f21ac986090d35826c6: bool
{
}

public abstract class Type_3cd05cdb4fda403383fe1bed94c20534: string
{
}

public abstract class Type_4d0ca75d11a24cd38229c42e1d4122b6: LuaCustomInputPrototype
{
}

public abstract class Type_07fa01f9fc744cdfabd00427ebe17b41: LuaCustomTable<string, LuaCustomInputPrototype>
{
}

public abstract class Type_fb80667bfbb643c0b9d5fc5611f90477: string
{
}

public abstract class Type_a6b84a663dee4d25b76690687dfa3458: LuaDamagePrototype
{
}

public abstract class Type_ef26201d0dbc48d49a1ce9b945dce05b: LuaCustomTable<string, LuaDamagePrototype>
{
}

public abstract class Type_c488d73e9ed04f90b03decd8380d7f2d: string
{
}

public abstract class Type_675becfbcd424b06ba0972a4c0a3d994: LuaDecorativePrototype
{
}

public abstract class Type_2db16b6116b44b26a6b1ed1417492286: LuaCustomTable<string, LuaDecorativePrototype>
{
}

public abstract class Type_5b593952096b4dce81e6bce4482b9a2d: MapGenSettings
{
}

public abstract class Type_3c2cb918171c4f6ea151a8fb4ae1d9ff: DifficultyEnum
{
}

public abstract class Type_177c91dd5b72461e82d17bb1a9609936: DifficultySettings
{
}

public abstract class Type_f78a51cdbe8c48c982b7a4fa807da300: bool
{
}

public abstract class Type_bc74ddc706234d00ad49f6d491b94451: bool
{
}

public abstract class Type_576be352f5ac42cd8d6250486119ae3f: string
{
}

public abstract class Type_2fd6805f39cf4854a7195456d2a8e633: LuaEntityPrototype
{
}

public abstract class Type_90cb8b83adb84ee98e225c9f274d3407: LuaCustomTable<string, LuaEntityPrototype>
{
}

public abstract class Type_7573c18efb8f4e4d855f5fe8b2abb3ab: string
{
}

public abstract class Type_39657ddaa9d34542a7da27a9b8c3d4c8: LuaEquipmentCategoryPrototype
{
}

public abstract class Type_dd1a205036584039885ae9a2377c19e2: LuaCustomTable<string, LuaEquipmentCategoryPrototype>
{
}

public abstract class Type_d11a48997ed0499eb4b1d9cd10a7863d: string
{
}

public abstract class Type_dd1d3d78790e49918834b68cad3f4f7b: LuaEquipmentGridPrototype
{
}

public abstract class Type_a8e5ba9e0af244b3b3a6140d809d1310: LuaCustomTable<string, LuaEquipmentGridPrototype>
{
}

public abstract class Type_54ce80a94f97487e93dc56494397c367: string
{
}

public abstract class Type_09bded2e96bc48a984b0fbf5bdfa81a7: LuaEquipmentPrototype
{
}

public abstract class Type_9d21b7084251434ab9ebf0ea8ee3279c: LuaCustomTable<string, LuaEquipmentPrototype>
{
}

public abstract class Type_763cb48c743340459f2c79eb27f83074: bool
{
}

public abstract class Type_cadad3ac3c0d4d6297c3a98de7ea05f0: bool
{
}

public abstract class Type_877ca5cd66ac4dfe9af62839da6d18f5: string
{
}

public abstract class Type_1c2612431243411ba0c34d46caebebdb: LuaFluidPrototype
{
}

public abstract class Type_26a571a2692d4a0dac7a5573e62b37bf: LuaCustomTable<string, LuaFluidPrototype>
{
}

public abstract class Type_e92bd1fd78e148009c0137936f95c660: string
{
}

public abstract class Type_dca02a0ceb534b279a6dcd477c6f90b0: LuaFontPrototype
{
}

public abstract class Type_de6669a23e0848dcadcbf0d7270e7769: LuaCustomTable<string, LuaFontPrototype>
{
}

public abstract class Type_7f2faa588e6d4a6e8e6034e78badaf27: uint
{
}

public abstract class Type_60d9aedc11554c7cbe21d2c42bf3954a: string
{
}

[GenerateOneOf]
public abstract partial class Union_930c8c529d8c4ce1bb3845f82bed844b: OneOfBase<uint, string>
{
}

public abstract class Type_4ba5a369514d41ee8f22d3fbb70c627f: LuaForce
{
}

public abstract class Type_9a9ed17c2adc4e1eb8b51aad4185f734: LuaCustomTable<Union_930c8c529d8c4ce1bb3845f82bed844b, LuaForce>
{
}

public abstract class Type_6a4b8e8b45664be7939169681941fd48: string
{
}

public abstract class Type_4239ff1f3b4d490c836f113bb269a192: LuaFuelCategoryPrototype
{
}

public abstract class Type_fd2283d024a94f8cbb1b920ef3178f6d: LuaCustomTable<string, LuaFuelCategoryPrototype>
{
}

public abstract class Type_cfefa4febf6a475f8a596be48b0b08eb: string
{
}

public abstract class Type_571449411624484eb98a21e1420e0f40: LuaGroup
{
}

public abstract class Type_271a4fb38f1b4c099087aa2d480237c4: LuaCustomTable<string, LuaGroup>
{
}

public abstract class Type_4a32cbd9e7fd4b32891360dead4731f2: string
{
}

public abstract class Type_1eef594fbde34becb4e35629075e0944: LuaItemPrototype
{
}

public abstract class Type_33c60c1608a743a9ae96872ed3026be2: LuaCustomTable<string, LuaItemPrototype>
{
}

public abstract class Type_f1b378235b7b43398b0f05bef351eba8: string
{
}

public abstract class Type_f35660ddcb44491aa27be0af1fb89af9: LuaGroup
{
}

public abstract class Type_495d25752f8e414ba5e673000daf0594: LuaCustomTable<string, LuaGroup>
{
}

public abstract class Type_e00f3b9789714c06866e643fe61032f0: string
{
}

public abstract class Type_b4639bf4c64941ce95b4917c9c3bc5a4: MapGenPreset
{
}

public abstract class Type_5bea7dadafae4bfe8646b40efd690f69: LuaCustomTable<string, MapGenPreset>
{
}

public abstract class Type_0ef0e14c80f143d688b1cc19a3e5ff4c: MapSettings
{
}

public abstract class Type_0291f40fddb44f9990a8ba9e4ccf7eec: double
{
}

public abstract class Type_df5be2d7571d47be8c95930768e5a563: double
{
}

public abstract class Type_46a83c5f1cf64cdfb97cf119e6313ae2: float
{
}

public abstract class Type_545df43d39f5435fb1f39f468b18c78e: uint
{
}

public abstract class Type_70d2528c5d274ee0aa88e84c1fcdf70c: double
{
}

public abstract class Type_5b908ac57629425fa29d1d3a38bff651: double
{
}

public abstract class Type_b71008b45a6b46d3bdfc9bdc54fcb620: double
{
}

public abstract class Type_fd4ee4bdcf0b4f7f91bfc0410dd6e6db: byte
{
}

public abstract class Type_da8f4df7808047c4adb70b29e56a285e: byte
{
}

public abstract class Type_d05e82b9c83b43bf8b2e4976d6ee83bc: string
{
}

public abstract class Type_2b851044034145e98b26ec15011d69da: LuaModSettingPrototype
{
}

public abstract class Type_b0f2e0cda4914b2ea685b6ce2733f2cf: LuaCustomTable<string, LuaModSettingPrototype>
{
}

public abstract class Type_461576ca20554f9cafbd1948b2b64447: string
{
}

public abstract class Type_6d04e98125f24d0cb384fe343622dc76: LuaModuleCategoryPrototype
{
}

public abstract class Type_6021dcd8836c4fd4abb9e7dc8d43267e: LuaCustomTable<string, LuaModuleCategoryPrototype>
{
}

public abstract class Type_d060b3dc1f8b49aa871868d41e0a1220: string
{
}

public abstract class Type_8d0c120fbd8c45bb812edb76932028cc: LuaNamedNoiseExpression
{
}

public abstract class Type_83bb14e9fe5d4e688a1b786478b34582: LuaCustomTable<string, LuaNamedNoiseExpression>
{
}

public abstract class Type_bcda00a2351747d1a521c8e94697f81d: string
{
}

public abstract class Type_6cb3dc6854254757be38d8a91bd324cb: LuaNoiseLayerPrototype
{
}

public abstract class Type_8666b2f567d14a0484caab420b282f72: LuaCustomTable<string, LuaNoiseLayerPrototype>
{
}

public abstract class Type_3e4ffb66786b4be59fb9ef5329335956: string
{
}

public abstract class Type_6f15419fc53a44ad85e97842c477c47a: string
{
}

public abstract class Type_b935728351e54a63b03aa164665c8fce: LuaParticlePrototype
{
}

public abstract class Type_4533f7da18c0473ca98eec9651db8b33: LuaCustomTable<string, LuaParticlePrototype>
{
}

public abstract class Type_db97cae521fc48729069695b32c86781: LuaPermissionGroups
{
}

public abstract class Type_b50ba6099f814494bf15c1439806d299: LuaPlayer
{
}

public abstract class Type_2f2d4fcea8ac440f96d6211416e16623: uint
{
}

public abstract class Type_51934a50a4bc44c9aa711e023d1ac08e: string
{
}

[GenerateOneOf]
public abstract partial class Union_1699451198db4fbdb682fb13b6226073: OneOfBase<uint, string>
{
}

public abstract class Type_854fac63305e44ca8fae9d534045fbba: LuaPlayer
{
}

public abstract class Type_707376d9a6794f24b9355d40b2038990: LuaCustomTable<Union_1699451198db4fbdb682fb13b6226073, LuaPlayer>
{
}

public abstract class Type_47b1c7d68ac542e6bea25b4ce2d9b7bf: LuaFlowStatistics
{
}

public abstract class Type_c70061d07ca7481a9c2f08dcd6df50c5: string
{
}

public abstract class Type_4fddbadfac934f3b851ebf4f7d2d682e: LuaRecipeCategoryPrototype
{
}

public abstract class Type_3a11c8dc97e341c096e98d0ef69e071b: LuaCustomTable<string, LuaRecipeCategoryPrototype>
{
}

public abstract class Type_9ed3b41bd44c457ba5b7dd9ee94800e8: string
{
}

public abstract class Type_f607475bf8f14ab788f8241dbd95fadd: LuaRecipePrototype
{
}

public abstract class Type_764e48852aa84fb39b67c7ac48334fec: LuaCustomTable<string, LuaRecipePrototype>
{
}

public abstract class Type_886013df29564c6bafa8336b5799ed69: string
{
}

public abstract class Type_57e797c974224c1c802133e1642d53c5: LuaResourceCategoryPrototype
{
}

public abstract class Type_5f6ec8643c6e4c03bbb4a2d636f378e5: LuaCustomTable<string, LuaResourceCategoryPrototype>
{
}

public abstract class Type_78f1f984c5e04a259d46f631cfe436ce: string
{
}

public abstract class Type_a9b74ed4a4d147ffa1474c373330f6f1: LuaShortcutPrototype
{
}

public abstract class Type_1bdde3e01a8041448f95f7eec4dab3ce: LuaCustomTable<string, LuaShortcutPrototype>
{
}

public abstract class Type_63f6988b40e044d7b71319a3d6810454: float
{
}

public abstract class Type_5e03c363150a4ab89a10ef2fa10fdd5c: string
{
}

public abstract class Type_bd0f8aaba38d4acf897fe66e502f7c1e: string
{
}

public abstract class Type_ea024acc7a2f453b95aae7c5152b9f10: LuaCustomTable<string, string>
{
}

public abstract class Type_18561f842b9149e59fb609be4a2648e8: uint
{
}

public abstract class Type_1e1c8e4f130045e2bb4306f12ec4d3a0: string
{
}

[GenerateOneOf]
public abstract partial class Union_acce915211b94f7da536b089afecac37: OneOfBase<uint, string>
{
}

public abstract class Type_381ffee7f32d4b95b12aceae0ac3d88b: LuaSurface
{
}

public abstract class Type_afd686a0ab4c49e9b1a6b9899d8a2164: LuaCustomTable<Union_acce915211b94f7da536b089afecac37, LuaSurface>
{
}

public abstract class Type_e3e99471846240ccb2fb44db528bade9: string
{
}

public abstract class Type_3d72e6030f5e480286808ff86ec73465: LuaTechnologyPrototype
{
}

public abstract class Type_bd74daf7048e4e189fbf0cd9ca487000: LuaCustomTable<string, LuaTechnologyPrototype>
{
}

public abstract class Type_80c5ef8590dc4dda85d27bd64b8066bd: uint
{
}

public abstract class Type_5bd101af71744e1485ea8cace57910e9: bool
{
}

public abstract class Type_388278eafd294e3cba5eb9c186705750: uint
{
}

public abstract class Type_63eac8517355491ba0a4b67e3eff3b0a: uint
{
}

public abstract class Type_b39a546c64e14529ad250b05c4668b66: string
{
}

public abstract class Type_726695140e204fb6a2215c619eaa6395: LuaTilePrototype
{
}

public abstract class Type_d1da5fedd3604d3cbd7fc51242f66a45: LuaCustomTable<string, LuaTilePrototype>
{
}

public abstract class Type_a40449e68e2249959bc3a6f6b589f992: string
{
}

public abstract class Type_ba1ae8ef1ffa4fef9f648e5c7d264e49: LuaTrivialSmokePrototype
{
}

public abstract class Type_67a39c6ab2844ff182a5c301f7b6e0ea: LuaCustomTable<string, LuaTrivialSmokePrototype>
{
}

public abstract class Type_31169af05bb349d9af61918ee9a915ac: string
{
}

public abstract class Type_8770cd140c984390b5585566c40bd5e7: LuaVirtualSignalPrototype
{
}

public abstract class Type_724744438f46441d875c3564a46341df: LuaCustomTable<string, LuaVirtualSignalPrototype>
{
}

public abstract class Type_7b5c57a1e3934331afa223204bbd6ec8: string
{
}

public abstract class Type_d19fcc3a8f404fb9b04db6ee2ce630bb: PlayerIdentification
{
}

public abstract class Type_c9f8ea5c74fd4e22895505df7c2d0aa9: string
{
}

public abstract class Type_834c8c2b2e7b497190f3521b39fc6e8b: string
{
}

public abstract class Type_8c3552a26ad044fc939703630ff3d5e5: LuaForce
{
}

public abstract class Type_b05dee3c57194a33a6d976a45d4af3d7: ushort
{
}

public abstract class Type_5c8fc06d74d14b8f8669e0881f140756: LuaInventory
{
}

public abstract class Type_4d9f85449e45465f91dbf9418f6e471a: bool
{
}

public abstract class Type_9a7823774fa4447f944f19182534e88e: LuaProfiler
{
}

public abstract class Type_64cf7e2223d84e7f8014b0a8714ee4ed: uint
{
}

public abstract class Type_ced5597fb529449291de8708b5df5010: LuaRandomGenerator
{
}

public abstract class Type_aa89e3aca92b406fb6496ed6bbff7869: string
{
}

public abstract class Type_8d5154e665b2471f9a0b52b6e700a34e: MapGenSettings
{
}

public abstract class Type_803a674b01eb4caabc29676bedebba31: LuaSurface
{
}

public abstract class Type_689fcbef48ac422687669d959499559c: string
{
}

public abstract class Type_81880987484449448525c727042411b0: string
{
}

public abstract class Type_017d75c5eddf44da8c30ec68fb999996: SurfaceIdentification
{
}

public abstract class Type_dc37f597ac1c40c5ac1d7d593b943133: DirectionEnum
{
}

public abstract class Type_350d57802b924b0696668d9cce9f6420: string
{
}

public abstract class Type_153093b7cc9e4318a816ddf926856ce4: string
{
}

public abstract class Type_d2b89f5d27f8440fad6b91bb5128602c: string
{
}

public abstract class Type_2a5059b147164670be3ffb395f98a7d1: string
{
}

public abstract class Type_4eddd4aaabab476e9eefbd02dc2643b5: double
{
}

public abstract class Type_3b150d48ce384934bd7545346f966833: Dictionary<string, double>
{
}

public abstract class Type_bfc45220027e48e3942cb51b0feb6fb8: double
{
}

public abstract class Type_415297b9bc7c4495bd5908e67ab8f7fe: SurfaceIdentification
{
}

public abstract class Type_a58d394d5a9549b8b27035eadc348d55: uint
{
}

public abstract class Type_69189e23c9ac46cc9045d0ff96c2d66f: string
{
}

public abstract class Type_04b1c4029f53497da8c55c45501435b0: LuaEntity
{
}

public abstract class Type_767724d952fb442d91454a93a72cd1d1: AchievementPrototypeFilter
{
}

public abstract class Type_13beaaed28d94bb6835ad54583eec08d: List<AchievementPrototypeFilter>
{
}

public abstract class Type_465b7601b30c4979a516fa2ea7ebc64a: string
{
}

public abstract class Type_e4186fcf466a4429b2aac7c3364ba94f: LuaAchievementPrototype
{
}

public abstract class Type_3d8c57f904e1430fa2676ff6a97e4cca: LuaCustomTable<string, LuaAchievementPrototype>
{
}

public abstract class Type_09fa7c5a4a764898a315ff3948f3190e: DecorativePrototypeFilter
{
}

public abstract class Type_552032befd9044e78e61ccd044153a9c: List<DecorativePrototypeFilter>
{
}

public abstract class Type_04917c45c1c5450e9f81a09c5911cc67: string
{
}

public abstract class Type_ff198ce9606342b0a1bf267218a2e144: LuaDecorativePrototype
{
}

public abstract class Type_f3ffe298025f4c3f927e96eaabab15d8: LuaCustomTable<string, LuaDecorativePrototype>
{
}

public abstract class Type_da0f86084af14867b0952341aa2badc1: EntityPrototypeFilter
{
}

public abstract class Type_67063db7a328477186ab54826858da03: List<EntityPrototypeFilter>
{
}

public abstract class Type_5d10652a9fa54f2eb25da4de874939a9: string
{
}

public abstract class Type_c71d4a22648e416caf7eb8b2c9d4d0dd: LuaEntityPrototype
{
}

public abstract class Type_ec94625f86544fb5b576a81ab1ac4648: LuaCustomTable<string, LuaEntityPrototype>
{
}

public abstract class Type_cd7609051a7a44adbeef2b4506ebbbd2: EquipmentPrototypeFilter
{
}

public abstract class Type_3f555c17ff9745f7bc287132bf45e5c2: List<EquipmentPrototypeFilter>
{
}

public abstract class Type_53e24a4807fa4802aac87e1875c26f7b: string
{
}

public abstract class Type_3db9e490eba44b4c8002bd45cd8b54f5: LuaEquipmentPrototype
{
}

public abstract class Type_81296f19d3e543ce8320daa483701abb: LuaCustomTable<string, LuaEquipmentPrototype>
{
}

public abstract class Type_b5306260e7b84ebabb3d7cd56305fe17: FluidPrototypeFilter
{
}

public abstract class Type_0ed671643a4e488aa8c32aeb99190f1c: List<FluidPrototypeFilter>
{
}

public abstract class Type_0dc48a829c8744b591cb1b68ca85507f: string
{
}

public abstract class Type_56d2fda767994b9bba2f50d30993db45: LuaFluidPrototype
{
}

public abstract class Type_2035b62ae0ad4d3eb22684ff47e88d59: LuaCustomTable<string, LuaFluidPrototype>
{
}

public abstract class Type_f6162ab643174ff7937cc418787205cc: ItemPrototypeFilter
{
}

public abstract class Type_f058581128fa41ef9ff04c6e20eda4ce: List<ItemPrototypeFilter>
{
}

public abstract class Type_4d844c6be8b64db486f7f0f362eba9b2: string
{
}

public abstract class Type_7c0fa560f36f48efbbb497b8db9a0141: LuaItemPrototype
{
}

public abstract class Type_6e0066bc4bc24550a923a5765f0e7c02: LuaCustomTable<string, LuaItemPrototype>
{
}

public abstract class Type_cab1b063fd054f78ab659c2b14d27362: ModSettingPrototypeFilter
{
}

public abstract class Type_92f7741d48fc489a94a3d96039201485: List<ModSettingPrototypeFilter>
{
}

public abstract class Type_d767309ff1ba41b2a63bd5c6d45f514f: string
{
}

public abstract class Type_d15fb276fd62454fa7ad36b5a4324c84: LuaModSettingPrototype
{
}

public abstract class Type_76de8b0f87dc48b1adf3a83ef69095d9: LuaCustomTable<string, LuaModSettingPrototype>
{
}

public abstract class Type_18061ff9f66241c6be425af01b569fc8: RecipePrototypeFilter
{
}

public abstract class Type_14eaafa85ff54c18b5c654afeb8d9926: List<RecipePrototypeFilter>
{
}

public abstract class Type_c35d32452c314f3aaebf3e33184670ca: string
{
}

public abstract class Type_832ec2dc5a314fd6ae0573e3411684b8: LuaRecipePrototype
{
}

public abstract class Type_3cc760f51f4b4347950905070dea5e41: LuaCustomTable<string, LuaRecipePrototype>
{
}

public abstract class Type_64cad4a349d143909b54517d73846ae6: TechnologyPrototypeFilter
{
}

public abstract class Type_7c16dcd116104a14aa5ec2ad5e44f124: List<TechnologyPrototypeFilter>
{
}

public abstract class Type_6297a7f5a66b486287a2d9f8f5614f19: string
{
}

public abstract class Type_9c119b34bd734f6ea9c35f99a6621dce: LuaTechnologyPrototype
{
}

public abstract class Type_7b1209da12d243f68a9ac44081af0512: LuaCustomTable<string, LuaTechnologyPrototype>
{
}

public abstract class Type_4cfd08f7835b40f080ec938cf6b21e62: TilePrototypeFilter
{
}

public abstract class Type_30713d7c7ccb4a668189a3fbf05b73c3: List<TilePrototypeFilter>
{
}

public abstract class Type_99d099477f9a42909fe0925d737c3020: string
{
}

public abstract class Type_955d595b7b21407e9ec11c871d0dbe2c: LuaTilePrototype
{
}

public abstract class Type_6bac2b65863448e1b9abc5ecdabbaf70: LuaCustomTable<string, LuaTilePrototype>
{
}

public abstract class Type_d6fa6ab8591a4a3f802691b21b76fc93: string
{
}

public abstract class Type_d627956908ab451da8e66170481ce599: uint
{
}

public abstract class Type_db3f6645164c4de8a102da13135ef263: string
{
}

[GenerateOneOf]
public abstract partial class Union_8750c793bc1c4d8bbbef74a8103b343e: OneOfBase<uint, string>
{
}

public abstract class Type_24a0c2b64e97475185ac279aff9ce11f: LuaPlayer
{
}

public abstract class Type_8da2b55119b341588d945e0fd3b47075: string
{
}

public abstract class Type_197a74691bf04c64a0a6303616d5e265: string
{
}

public abstract class Type_a2f99a2878684249b9cc8b13d72c4538: LuaInventory
{
}

public abstract class Type_db64a44b4bd24cfdaca56fa6c25870bc: List<LuaInventory>
{
}

public abstract class Type_7502abeb6e5649f6a09c4768dfda2d3c: Dictionary<string, List<LuaInventory>>
{
}

public abstract class Type_fb60b3d48f174af985d1822c11adf60d: uint
{
}

public abstract class Type_567b1477374a407ab13b0117649bf059: string
{
}

[GenerateOneOf]
public abstract partial class Union_72e646f5f76b4278988b0fbbde5e8819: OneOfBase<uint, string>
{
}

public abstract class Type_ae38e437ddf343038449fcff262d181c: LuaSurface
{
}

public abstract class Type_d86d66950b614b07b49b66ba8465ef4b: uint
{
}

public abstract class Type_fc67cd67d987440db5357d6a3acc5361: LuaTrain
{
}

public abstract class Type_973a39add75e4f01a27fe6c44557a3ff: ForceIdentification
{
}

public abstract class Type_1760e3b3dac847678f6d0e03f82529ae: string
{
}

public abstract class Type_36b70d884c2b46aebef32b7cf22d0c65: string
{
}

public abstract class Type_efbe664fa5e44940ba30805e52a736cc: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_535cc367a45f49408058e9ec8b1c23db: OneOfBase<string, List<string>>
{
}

public abstract class Type_b2522bbc25644add950d1af17ec85f7d: SurfaceIdentification
{
}

public abstract class Type_f6d35ec4dcb9447aadb3807aca85f80a: LuaEntity
{
}

public abstract class Type_7a1f1e541faf4a6eb0bd820740fa6ff0: List<LuaEntity>
{
}

public abstract class Type_b648ff33c7604407bd7671d9d4416bdc: bool
{
}

public abstract class Type_b1b64bb055ee4aa5827513a60f10df70: bool
{
}

public abstract class Type_21f828a8b0384685b7c32b592a243af3: SoundPath
{
}

public abstract class Type_ff53bbd664e94a038d322150cbfec50d: bool
{
}

public abstract class Type_93cdee35e1cf44fe9cb73ac02af8d0b6: SpritePath
{
}

public abstract class Type_bff96c50648d42f5918efb96ba6cb1e9: bool
{
}

public abstract class Type_b89d0267d38b4b40851e244cfa37320a: string
{
}

public abstract class Type_9587f35e4b134a5c919f269bbae1faac: AnyBasic
{
}

public abstract class Type_7cd5437790ef4923bc46bd961af1c4bc: PlayerIdentification
{
}

public abstract class Type_a24ae8d13ff24ba7a3ff95aca5fe5347: string
{
}

public abstract class Type_d4823b1f72234c42a9910e4821b7f190: ForceIdentification
{
}

public abstract class Type_e80c2e3a79874ca1915558dacebc4251: ForceIdentification
{
}

public abstract class Type_b51f55aa0de74649a72cb48f034dfa9a: PlayerIdentification
{
}

public abstract class Type_5257d2c9a49f4c2aa6247aac48d65cfd: string
{
}

public abstract class Type_a7e98c9c6d8c48eeb0ccd9bc3709cc16: MapExchangeStringData
{
}

public abstract class Type_f849d2f6b7914788b28ff3c01225d719: SoundType
{
}

public abstract class Type_d5fc88fc1b7f454ab66790334a08c05a: SoundPath
{
}

public abstract class Type_d1d7a38c06c348129172a4df990f14ca: MapPosition
{
}

public abstract class Type_4f74341707314f9783f72f3c5c4da8e3: double
{
}

public abstract class Type_e35e40a2a3104b63a6fc3472097bf9a4: LocalisedString
{
}

public abstract class Type_11f4debd42424697892fe9e77b3c2956: Color
{
}

public abstract class Type_f05f0691c61944be8fc13b6808f04ec5: PrintSettings
{
}

[GenerateOneOf]
public abstract partial class Union_dcc6809a646a45eeadffb4537ce0f9b6: OneOfBase<Color, PrintSettings>
{
}

public abstract class Type_0a545752899f47fc82facfd639a8766e: PlayerIdentification
{
}

public abstract class Type_d0b475e9232f4e8b800eaf5dd2fdf772: string
{
}

public abstract class Type_9fda028fa1334fe1a5845022caed1f78: string
{
}

public abstract class Type_3ae02921eed24a87b5a3f1a2d7d55be1: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_8725f835c5e4452499294bbdc65b85ea: OneOfBase<string, List<string>>
{
}

public abstract class Type_81472d4b548d44558e447421d18c9b34: PlayerIdentification
{
}

public abstract class Type_8fc789bbda5b41bfa9dc58e851561a2f: List<PlayerIdentification>
{
}

public abstract class Type_10976bd172304eb48a1770cf5ad7c905: string
{
}

public abstract class Type_32ab48dad53c4184927eea16b4261f63: bool
{
}

public abstract class Type_0779d3b8ee554f0981210a1bf2a1c3cf: bool
{
}

public abstract class Type_6651446eda75459ab080390004b24229: RailEnd
{
}

public abstract class Type_737ee3b2aa084b6d856dbf212c5f28b4: RailEnd
{
}

public abstract class Type_4ff7d0636bae4704b4d79d1e5b1418e3: TrainStopGoal
{
}

public abstract class Type_7c46763e3d424ccc8e98744c359c4f71: RailEnd
{
}

[GenerateOneOf]
public abstract partial class Union_ddab613ba5784cc0831203e6b62e0245: OneOfBase<TrainStopGoal, RailEnd>
{
}

public abstract class Type_2ef849fa8ca54254857b0198cd7d51e8: List<Union_ddab613ba5784cc0831203e6b62e0245>
{
}

public abstract class Type_6161db0b1a584f3eabe5dd080e15e484: bool
{
}

public abstract class Type_fe3c63d1ae1844f28d9108dd767d48a1: bool
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals_03dfa939161c451e87ecb7698992df9f
{
  /// <summary>
  /// Literal value: respect-movement-direction
  /// </summary>
  [FactorioRconDefinitionValue("respect-movement-direction")]
  Respectsubtractmovementsubtractdirection,

  /// <summary>
  /// Literal value: any-direction-with-locomotives
  /// </summary>
  [FactorioRconDefinitionValue("any-direction-with-locomotives")]
  Anysubtractdirectionsubtractwithsubtractlocomotives,

}

public abstract class Type_48038a2101da479a96a033cf7b4d52c3: uint
{
}

public abstract class Type_0d037a2fd7334f9d84e00f287d12ffdc: LuaTrain
{
}

public abstract class Type_fc8a5fdce11240508e03b08953a35ed6: TrainPathRequestType
{
}

public abstract class Type_802e7b3779e5498aacc233406fa3d9ed: TrainPathFinderPathResult
{
}

public abstract class Type_56fda151ff5d43d2a033c919577bc244: TrainPathAnyGoalResult
{
}

public abstract class Type_05b723e800024b5dbf750d546507e285: TrainPathAllGoalsResult
{
}

[GenerateOneOf]
public abstract partial class Union_865ff91e0a7b4c548022f8c9029d0feb: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

public abstract class Type_d034b8f5a1204b39860ca97dde3c02b5: string
{
}

public abstract class Type_b07ecd776f8745739b1cb6e514a25a5d: bool
{
}

public abstract class Type_5a6ca325bd3d4a9ea2d8a32490f1a60c: bool
{
}

public abstract class Type_6b918f9c61404be2829b1fcb7c225c31: string
{
}

public abstract class Type_acfc623652be4a6086d3d3de69df9d40: bool
{
}

public abstract class Type_874a8ea6b1304dd697975d970d71ff74: ForceIdentification
{
}

public abstract class Type_1e80b8157d8547ff9c60923561d048db: string
{
}

public abstract class Type_93a956a840fd4689adb73314cabddbf4: GuiArrowSpecification
{
}

public abstract class Type_8c1bce06908a4410a7f65854519b0071: string
{
}

public abstract class Type_323538d1c8bf45a9819bdbe1541187dd: LocalisedString
{
}

public abstract class Type_6893bf64d2af4d9b805ecfc049d9841e: string
{
}

public abstract class Type_ce4182f6d71949458fd94831ef71e628: LuaTable
{
}

public abstract class Type_ec212a86cfc44bb8aba4b1dfc0a7f4b6: string
{
}

public abstract class Type_f902c3de4f0a44dcaf83098985967b18: bool
{
}

public abstract class Type_0fdc805078cd40dab780a6bc6b2c87d0: bool
{
}

public abstract class Type_f618e40eb86a4ccc818f6371b698e805: PlayerIdentification
{
}

public abstract class Type_f5d913179fbc4994bcf3e1aaa08917ba: double
{
}

public abstract class Type_781c6528691f478ba9b6f8441d9a3d87: bool
{
}

public abstract class Type_c1a6efe0301d499bb0c3e5be9faf2e9c: string
{
}

public abstract class Type_98c0c19f8f5f42bd86811a27a3207ca3: PlayerIdentification
{
}

public abstract class Type_2cb5fac772fc4b43b68b04539bc0fcbc: MapPosition
{
}

public abstract class Type_e8947211431a4de387270b0961f000c8: int
{
}

public abstract class Type_7ffed32da22343048942c542ef7345ea: TilePosition
{
}

public abstract class Type_ac7883fb28c648769bd985ebeedbe5a3: bool
{
}

public abstract class Type_c0f29a83e40c4af39af8b10a51755735: bool
{
}

public abstract class Type_30ed687018744f41a6d190b06b269623: bool
{
}

public abstract class Type_0302b5ce65da4b8da47542330e928ac3: SurfaceIdentification
{
}

public abstract class Type_d034d1c98eec4abf91bba32b5a2e5436: uint
{
}

public abstract class Type_80d1070a38e24731b06a7fcc67058d08: double
{
}

public abstract class Type_91f642b5a4f641e8a03452d0a57853a9: PlayerIdentification
{
}

public abstract class Type_8e26c5181b464108bea202fd2e7d7c3d: ForceIdentification
{
}

public abstract class Type_6579362df5fb40e19e80acb01c880316: string
{
}

public abstract class Type_34735096a2bd4801965edf28b0472d65: int
{
}

public abstract class Type_1bbf6a2910ec4db99cd27e068ae50349: TechnologyIdentification
{
}

public abstract class Type_aa6faad1bb734ecda5525b92f871f0bd: bool
{
}

public abstract class Type_4b447b6180f84d67b908142774719701: PlayerIdentification
{
}

public abstract class Type_2a21e0a572e647809c960203570ed005: PlayerIdentification
{
}

public abstract class Type_07750c3bcbf844f3ae9c043fe8f7aac3: bool
{
}

public abstract class Type_119c8e5e07734fb7ae5dd2a3ebf55902: LocalisedString
{
}

public abstract class Type_836d4726ed07487caa27ced8c5058414: string
{
}

public abstract class Type_60527b7616e44fcf83235eb262142e5a: uint
{
}

public abstract class Type_ee83dd3bba9c4278844f97b5a6a03685: CircuitConditionDefinition
{
}

public abstract class Type_38ba4c4eb6b04e919293f976d44ab83d: bool
{
}

public abstract class Type_681d83ba62064459897a111cf8a43a5e: bool
{
}

public abstract class Type_c01ff36b62bd4d68baa425b5520e9b52: CircuitConditionDefinition
{
}

public abstract class Type_d2dc7e44a01d406dbff898bc899fa1d7: string
{
}

public abstract class Type_3ca47b5ea180475ead59bc0cf87087f6: bool
{
}

public abstract class Type_ccffd9d7bea34ff78c900b1a86dac000: string
{
}

public abstract class Type_8697bcdeadd44840aa1930373b9da71b: LuaGroup
{
}

public abstract class Type_b9d4ab76acc04ad7843d4728d8402560: LocalisedString
{
}

public abstract class Type_6ae6182e5528470297097f609b8413f1: string
{
}

public abstract class Type_8fe65bb7b5384de9951bda4bff8ac0c0: string
{
}

public abstract class Type_dcfa11e3a2ed4e0cb385f6ff94f664cd: string
{
}

public abstract class Type_e81921a48bb34b8a937a0a05d20c9588: string
{
}

public abstract class Type_a876744f417143b9b27e540fd58d6381: LuaGroup
{
}

public abstract class Type_5a1d0475664543759abb59a9abbd2b43: List<LuaGroup>
{
}

public abstract class Type_b83add5a7022480981ae80b2bd3bf2d5: string
{
}

public abstract class Type_125eb39367ad400f986ac37bb87c2d7c: bool
{
}

public abstract class Type_4d819978e72341458ca994c96856e736: string
{
}

public abstract class Type_3cbdfd1b27c14e43add264a8ce859ca3: LuaGuiElement
{
}

public abstract class Type_2751ce43039141e0af3b6902e5cc8352: string
{
}

public abstract class Type_9a6aaf75d85a4a378f28b137a211c78e: LuaGuiElement
{
}

public abstract class Type_5dc1b5b3835f4230b04b17293f8715e3: Dictionary<string, LuaGuiElement>
{
}

public abstract class Type_8af4438677074fc9b7c8fb463e8eec40: LuaGuiElement
{
}

public abstract class Type_e6c331540dc3427f89ae8c71fe51d6f1: LuaGuiElement
{
}

public abstract class Type_32daba540e3a4a1ca06882afe8ec5ada: string
{
}

public abstract class Type_8739a47f9bc94173860b81186be2cb22: LuaPlayer
{
}

public abstract class Type_230d6ddbf3fc49e28d5d5aa9b00d4bf0: LuaGuiElement
{
}

public abstract class Type_1861a4f5a72d414c97e7140ea00ef13d: LuaGuiElement
{
}

public abstract class Type_86965d702d514f7d9529a97e82cd9509: LuaGuiElement
{
}

public abstract class Type_92bfc74a1def4538b1e592da5d128d2d: bool
{
}

public abstract class Type_c88431218f1e4b88a77b479ab1bf5eb7: string
{
}

public abstract class Type_8841070307ba437f9d1bb9b93e166ab1: SpritePath
{
}

public abstract class Type_cd5cd15d8e334ed2841baeae84803fc9: bool
{
}

public abstract class Type_9095640275fa43c49d3f1f8b35673a4f: bool
{
}

public abstract class Type_cebc5edbe78f458099f5712e03ea5830: bool
{
}

public abstract class Type_bff55fdcdbad46bbab254ad35a9910a1: bool
{
}

public abstract class Type_be9e7c3bcebf47609a5c42b271782e52: GuiAnchor
{
}

public abstract class Type_d1de34aefd6948429e84d8b58bf9d520: bool
{
}

public abstract class Type_f1f4166af80a4cb9bdddd6673a409ad9: bool
{
}

public abstract class Type_2880385fdb44491fb420c894ffe1fefb: LocalisedString
{
}

public abstract class Type_ff153c48a3bf46eeb500b33b3c06729b: LocalisedString
{
}

public abstract class Type_cdf58dd0f5bd4b77a32b8768a7abce3d: LuaGuiElement
{
}

public abstract class Type_d6fa3129dd7a43b894b5b1bbae4d98cb: List<LuaGuiElement>
{
}

public abstract class Type_e6a3f3d4236f4f59b0031a05b4f4b17b: string
{
}

public abstract class Type_089c32276de14f48aeac4e82a2f765c0: List<string>
{
}

public abstract class Type_156c2afae8764c2bb0f7a132b54ad7b6: bool
{
}

public abstract class Type_1242b45e07c847d5818ae894ef3c53c2: SpritePath
{
}

public abstract class Type_2de61580d32745379c84a6c9298922d2: uint
{
}

public abstract class Type_db4139e8f0954470b9ff2e780c36173d: GuiDirection
{
}

public abstract class Type_a20a3914077741819d05b9ca4a969fbd: LuaGuiElement
{
}

public abstract class Type_8510388e2e1547fbb65ac46be85b6e09: bool
{
}

public abstract class Type_6599706b225b4abbab6a9144d4b53dcf: bool
{
}

public abstract class Type_9e333ac058c24cf280ab741de17f9246: bool
{
}

public abstract class Type_6159ec51b35e483db51a142e8cb45d77: PrototypeFilter
{
}

public abstract class Type_0f3e41130a6549b4b089b958ec1f6eb9: ElemID
{
}

public abstract class Type_1bcecde1541847d98784dc2fc4c61357: ElemType
{
}

public abstract class Type_180e6fbbfddf4eb39cd004bd71b1b135: string
{
}

public abstract class Type_051de06ba8cc4af78a0457efe685d547: SignalID
{
}

[GenerateOneOf]
public abstract partial class Union_7d4e842a2e174568a5c915047e95d661: OneOfBase<string, SignalID>
{
}

public abstract class Type_95bfc775647d418caa3bd8bee62dd751: bool
{
}

public abstract class Type_84fd01bf7bc844c8a69b5a306df69c20: LuaEntity
{
}

public abstract class Type_ea6292d051d8468dbf3902aaf25b8cde: string
{
}

public abstract class Type_1528d0e36c5e4b84893a2166eae5bca8: GameControllerInteractionEnum
{
}

public abstract class Type_dde86b96770843799ecd32e70120f248: LuaGui
{
}

public abstract class Type_34f830dc29d34266ab888992bab2ea27: ScrollPolicy
{
}

public abstract class Type_b5e0d2ba4c0e4a909d8da3791d9b7411: SpritePath
{
}

public abstract class Type_5a651991ec844e48b821e49959039cc8: bool
{
}

public abstract class Type_5ff2d98af0e9454486ebc6f688f5f6d3: uint
{
}

public abstract class Type_bb8bae984a60471183903bb96baad773: bool
{
}

public abstract class Type_c05d83fa0a134070b50cb4b3691d0f41: LocalisedString
{
}

public abstract class Type_e1ab47bddfa84fa7bbaef843b1a1df3e: List<LocalisedString>
{
}

public abstract class Type_6feae31d8795411b99b095188fcfe9bc: LocalisedString
{
}

public abstract class Type_90214609167241229beadd67155e50cf: LocalisedString
{
}

public abstract class Type_1d7c4c0a4901413abd6ec733bea25275: GuiLocation
{
}

public abstract class Type_3f507e470a3140d5b059327f747fdcb1: bool
{
}

public abstract class Type_bf041b86c063404693c9fff04a334663: bool
{
}

public abstract class Type_5b2d879192b24981a119644ec8b5ac39: uint
{
}

public abstract class Type_1d660994928643f99e4f5b2c552795d3: MouseButtonFlags
{
}

public abstract class Type_681ecf147ee6451fa52e1b6263abf38b: string
{
}

public abstract class Type_a8a503d6a27f48b0ae82a770fc074f06: double
{
}

public abstract class Type_fb4dfa7e577d411d92af2352fbe4d0bf: bool
{
}

public abstract class Type_7cf72bdc180440cd95fa0ffac517e00c: string
{
}

public abstract class Type_fcc78006aa444b02b9cc78c19dc17592: LuaGuiElement
{
}

public abstract class Type_d37339072981441797f00ca3b277925f: uint
{
}

public abstract class Type_792da7df211f4e44bf247c9ec2343284: MapPosition
{
}

public abstract class Type_c5c04d73fa564554b1583543302e2fec: bool
{
}

public abstract class Type_aae6fdf9a38141a6aaaeaf61a9dbde51: bool
{
}

public abstract class Type_8ba7520747864a7ba225a6869fbee7bc: bool
{
}

public abstract class Type_4023d21585ee40cf8e874557a89c1a1a: LocalisedString
{
}

public abstract class Type_23a069ea0a9c4dc69c7a7f7669275e05: LocalisedString
{
}

public abstract class Type_d57821ca608341babe6db692dfcbeacd: bool
{
}

public abstract class Type_8190c20721c04eaa9c0468f9e64eac90: uint
{
}

public abstract class Type_f6c150683c764bca8c51236ebb47f101: uint
{
}

public abstract class Type_ba6dd036e10c4eda958e6682e07e83c2: bool
{
}

public abstract class Type_f3f9196012dd46b99db655bfa6e553d7: double
{
}

public abstract class Type_abf4d4adaaa44504a6d883440dead996: SpritePath
{
}

public abstract class Type_c6a88b91803f496d80b08663e7122671: bool
{
}

public abstract class Type_520b3c0ea87f47d1b1fd4264889551d6: LuaStyle
{
}

public abstract class Type_63d1fc7fe945438c8f788b0069618a96: string
{
}

[GenerateOneOf]
public abstract partial class Union_de6ec3e0beb44d9fbbea30fc3537ad26: OneOfBase<LuaStyle, string>
{
}

public abstract class Type_671e66304e90446082a5d04b446afe64: uint
{
}

public abstract class Type_3e667977b1dd4904b463d4c66485c6ad: SwitchState
{
}

public abstract class Type_dadcfb78f4cc4ec88115004826c06173: TabAndContent
{
}

public abstract class Type_ebe22eeb557d43aa8f88f65fd18164d1: List<TabAndContent>
{
}

public abstract class Type_61873f37de3944f791bbcf1ae4578a02: Tags
{
}

public abstract class Type_8a7fdfbf94e6407689798c766f5367b9: string
{
}

public abstract class Type_8b1f9cff45e54333b3868915090bbfcd: bool
{
}

public abstract class Type_736a882174a94353a4cdd8f259e2c5b3: LocalisedString
{
}

public abstract class Type_8f054bfc381742368530df615e14b56b: string
{
}

public abstract class Type_24654a34db02499eb202c59116865157: bool
{
}

public abstract class Type_3f7515d931b84ba7b75da8424c43cb19: double
{
}

public abstract class Type_1b5f407005864ac6a6f812214acf9ea0: bool
{
}

public abstract class Type_a1d7bcb07e754dacae23d0577508954c: ScrollPolicy
{
}

public abstract class Type_38de27a917694cef80744338d2dda267: bool
{
}

public abstract class Type_1f180483954a43b5b756eb7946cef211: bool
{
}

public abstract class Type_2643d026db9b4c5daba57f9ebcc15615: double
{
}

public abstract class Type_34cca55e1d184fa4bba6acd24163efdf: LuaGuiElement
{
}

public abstract class Type_cb92290832374047a73677b0879f0769: GuiAnchor
{
}

public abstract class Type_3170f73f35b2447794581afb83dfe615: LocalisedString
{
}

public abstract class Type_a945ae28b8884b7a9cdcc86b5735e7d7: ElemID
{
}

public abstract class Type_8fc601a84f2b49deba7f4122a099b378: bool
{
}

public abstract class Type_dd5b625f806f4d69a28dd902533235de: GameControllerInteractionEnum
{
}

public abstract class Type_8b042c4a3fdc4275bb63d9213f3ee736: bool
{
}

public abstract class Type_a61f9c0b16bf4edfb02189ff3137669c: uint
{
}

public abstract class Type_5e1fd4f6ebdc49b9882d786ec5dce17d: string
{
}

public abstract class Type_6f2f03ab51224af9815bc825a2d0edad: bool
{
}

public abstract class Type_e92ea826a94d429a916da044fe88c3a1: string
{
}

public abstract class Type_32aa7479a8604134b19f432a70edfcb4: Tags
{
}

public abstract class Type_1588d89fe17a49b4a23660a5ca98108d: LocalisedString
{
}

public abstract class Type_73bdc318b17c4a569a9c86077ce66fef: GuiElementType
{
}

public abstract class Type_f2f90eed10ae4c50bce811fa598ce694: bool
{
}

public abstract class Type_a03180ea5c62429fb9f012e03db184a9: LuaGuiElement
{
}

public abstract class Type_61318e6f80ba4e199de5d85f33443994: uint
{
}

public abstract class Type_deed779800034aacaf6cacb5c5449e4b: LocalisedString
{
}

public abstract class Type_3183ec604f654264b43ebca491803f04: LuaGuiElement
{
}

public abstract class Type_a06155b4e6cf4c92986aed5a4bb56a2c: LuaGuiElement
{
}

public abstract class Type_57e92659ce794af8b1c5a8c33adb217b: uint
{
}

public abstract class Type_e8e5e80997e445c5b4a2783a6fa8592e: uint
{
}

public abstract class Type_950d51ea56bb4d6abe9c35904a3d1cc0: LocalisedString
{
}

public abstract class Type_0d229be56d124ac690788107ea8a7cea: string
{
}

public abstract class Type_1b06b5ade0c24d539b486f5ce9312c06: bool
{
}

public abstract class Type_21897487c7d948869ca9df5e049ab4e1: bool
{
}

public abstract class Type_bb7d1abd54b04e9ea7cd92b10dad105d: double
{
}

public abstract class Type_4542f7cf193b4e75830c5cb900aac597: double
{
}

public abstract class Type_92616394415546c78f9c35d5f3713fde: double
{
}

public abstract class Type_b5342af805fd4e5c8b0e7bffef1aad3f: string
{
}

public abstract class Type_25156c8e627041c8b4100ee304101084: uint
{
}

public abstract class Type_8f3da9b291544de0ae19bfe7ad31638b: LuaGuiElement
{
}

public abstract class Type_5fe129620c1c4cafa43d14c9b3c816eb: LuaGuiElement
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals_c46e8cec55494de882552bbc4089713d
{
  /// <summary>
  /// Literal value: in-view
  /// </summary>
  [FactorioRconDefinitionValue("in-view")]
  Insubtractview,

  /// <summary>
  /// Literal value: top-third
  /// </summary>
  [FactorioRconDefinitionValue("top-third")]
  Topsubtractthird,

}

public abstract class Type_2724763e625c4ec281238513dfeadc93: int
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals_64b6337bb40740ca8cd4ef966b32f5e4
{
  /// <summary>
  /// Literal value: in-view
  /// </summary>
  [FactorioRconDefinitionValue("in-view")]
  Insubtractview,

  /// <summary>
  /// Literal value: top-third
  /// </summary>
  [FactorioRconDefinitionValue("top-third")]
  Topsubtractthird,

}

public abstract class Type_b7217268955a4d06a6ccd2c370cd29e8: int
{
}

public abstract class Type_5e3f6f5b34454a7192dea1587c140c9e: int
{
}

public abstract class Type_3821fcf154a9470c84f667e5bb35722d: uint
{
}

public abstract class Type_128f4f77215d4b719c8156402207ca1c: LocalisedString
{
}

public abstract class Type_e143e3c8cc11443394865cc8cde305ee: bool
{
}

public abstract class Type_a9cc67d6677d4b009878bbef62d4474f: bool
{
}

public abstract class Type_420366331088449191535bfc58f71c84: double
{
}

public abstract class Type_20a674b7a92a4bf1ae14074028bb4c8b: double
{
}

public abstract class Type_3844de609d354e4dbd3c7cd3258662f1: double
{
}

public abstract class Type_7a1cb61f407d4868bf216ce30cd8556e: uint
{
}

public abstract class Type_bf4e7ffbcdb74026a9ed459ea32d8319: uint
{
}

public abstract class Type_15d6a2fa4cc0425eb72e17029cc923a0: HeatConnection
{
}

public abstract class Type_1c9c0691f6fe43cc81c90807e9392275: List<HeatConnection>
{
}

public abstract class Type_d8d9346693af4b44b20a33cb83dc5255: double
{
}

public abstract class Type_20f21d07ba9a4b60a00cb8bbbdf99b02: double
{
}

public abstract class Type_34a374a0365f4358845f67669e64616e: double
{
}

public abstract class Type_bbc56f65fcab4e2d91cbd088d63add6e: double
{
}

public abstract class Type_6a19f01265f94f5683c50d74e4e69e49: double
{
}

public abstract class Type_44e3893968d64c96ba2cdbeba9ac2ccf: double
{
}

public abstract class Type_506273f75efa4c0b8e3f12ed9563af3d: string
{
}

public abstract class Type_dab133759bfd424089ebf0907e01d98e: double
{
}

public abstract class Type_fe1faf44e4a24f77b2f073f38c004949: bool
{
}

public abstract class Type_63554e5d17ab491585a78a1e9cbec62b: string
{
}

public abstract class Type_467b8a8c28ae4b7aaa8443de2dca5cba: HeatConnection
{
}

public abstract class Type_a82d97fb30414c848a7b5019d1988887: List<HeatConnection>
{
}

public abstract class Type_63a7a639c5434dd8945ea15f19620600: double
{
}

public abstract class Type_878970a3ef7d426f9831bd3c11f184f5: double
{
}

public abstract class Type_c584ae44af5b45da90e4c752264e3fe7: LuaHeatBufferPrototype
{
}

public abstract class Type_bd91c270456147f9af7679d9730c4d3c: double
{
}

public abstract class Type_f68313692b0c41ea9dbca54e35d2abc0: double
{
}

public abstract class Type_dcc8c87267c04e61b226680efaf6e44f: double
{
}

public abstract class Type_29d1a0e1f64a4dceaf9eed9ca26a7bf2: double
{
}

public abstract class Type_8998a5a9eb1e45a19d5e7fbedd642204: double
{
}

public abstract class Type_328393d2b52f42c683baa9c55fba1ce7: string
{
}

public abstract class Type_5b4bc94587f04ac58ea8ae470fee3b56: bool
{
}

public abstract class Type_c12764812ca847b8b7bd6645081982cb: bool
{
}

public abstract class Type_4a46f8e10c724fefbd469b3d83c77472: double
{
}

public abstract class Type_ec74b12fda00454cb67123d2a7846b23: bool
{
}

public abstract class Type_1359fa1b31cb48cea6e03798f2e5ee9c: string
{
}

public abstract class Type_4334a484d2fe47b8a56404043762b34a: ControlBehaviorInserterHandReadModeEnum
{
}

public abstract class Type_e835d55f8f5c4359941593becf3009aa: ControlBehaviorInserterCircuitModeOfOperationEnum
{
}

public abstract class Type_9908ea5764794ed8b1d9c2b0bfff0fac: bool
{
}

public abstract class Type_abd872a7b45741e8970e42695280d2b8: bool
{
}

public abstract class Type_82160637962745238e76379bf15aae9f: SignalID
{
}

public abstract class Type_3a448d2199e04771b7929aeb47ce179a: string
{
}

public abstract class Type_a276b44a454f49688b58cf24b573880a: bool
{
}

public abstract class Type_37eb379c38894f8596a3586175a465af: string
{
}

public abstract class Type_c541684955e64759bfa129a9683fdc75: LuaEntity
{
}

public abstract class Type_390c2345836c4a0a8dae9c8f5e065f3d: LuaEquipment
{
}

public abstract class Type_cbebb7db484c475296791504c0b58c6c: InventoryEnum
{
}

public abstract class Type_7c3c2670c7d543e5913460d3047d3238: string
{
}

public abstract class Type_c9b152be6b4840e0bf096b5de421781b: string
{
}

public abstract class Type_e26f64b817d443dc96beba6b749ae8ca: LuaPlayer
{
}

public abstract class Type_e82d61d25371455e8d77fbc73cc7c019: bool
{
}

public abstract class Type_1d5b74ade0ea4938aaa61d458d1cac39: LuaItemStack
{
}

public abstract class Type_e6df870721fb4da4ae3dbcb49341e5bf: uint
{
}

public abstract class Type_590c3d2eccd1406aa8536d2d5426ab46: ItemStackIdentification
{
}

public abstract class Type_3688e4eb04e141039df767c90b72bb02: bool
{
}

public abstract class Type_afe5e704b0814f16ad518865c7d21e4c: string
{
}

public abstract class Type_aa2c9cb1e2164f5fa1c39546e168be30: uint
{
}

public abstract class Type_a2082149cbac41d38ffc927c591ced17: bool
{
}

public abstract class Type_b1195cf793a84c52bc66cd5f9fca3f66: bool
{
}

public abstract class Type_2b32fae6a66a41509380b13369759124: bool
{
}

public abstract class Type_3f26458bc1a7488285cc771326573d42: uint
{
}

public abstract class Type_7b538de38dcc4e60857efcbf54d113ae: string
{
}

public abstract class Type_fe8bcd5ca88f4f86a121cf57228be6df: LuaItemStack
{
}

public abstract class Type_0d3423c2c0e342658d187080802d685d: uint
{
}

public abstract class Type_a64de0f6a7c6438cae113e1ae2cdec2f: string
{
}

public abstract class Type_f5da1d26717a42e8b13f5891c2141590: LuaItemStack
{
}

public abstract class Type_697b9f250ed6407998921d0f3680f685: uint
{
}

public abstract class Type_415331cfa9b54ab3ab86ad839d57fa17: uint
{
}

public abstract class Type_0e07564e96eb498bb9337b6653ed481d: string
{
}

public abstract class Type_ce1f90a1b49d4912a95ad2f2c1bccf3c: uint
{
}

public abstract class Type_57c43f1603ed43b5a025bb33266272e6: Dictionary<string, uint>
{
}

public abstract class Type_5ecb8c4d344c4931bd7cb0f3a0fdff7d: uint
{
}

public abstract class Type_bdaf835ad6614bd28ab1088ecbd026af: string
{
}

public abstract class Type_9c737e5bda384fc89b494522b455dd60: string
{
}

public abstract class Type_6bf3bb8fe83849cdb21265e140c7c111: uint
{
}

public abstract class Type_9e1ee714dc8e40d6b61b4add147b69cf: string
{
}

public abstract class Type_f4f13366f52b4db78a886b06c14849e4: uint
{
}

public abstract class Type_3f86da240478455d916f0117618f0d05: string
{
}

public abstract class Type_20b868e239034bfdb041ab556905a469: ItemStackIdentification
{
}

public abstract class Type_c0ca548eae5c41598200843e15e310a6: uint
{
}

public abstract class Type_e1a5f7e32fc348a7b31122a0f41195a8: bool
{
}

public abstract class Type_7693d93a49f44875afd070822da14d36: bool
{
}

public abstract class Type_afa5ef5d208d4bf9b951e7e4ced54371: bool
{
}

public abstract class Type_8e579a7426e040c3b1af9e526017a296: ItemStackIdentification
{
}

public abstract class Type_9a5cce568f554d10bed69a6a99feb7d7: uint
{
}

public abstract class Type_260e7272093040ffa23f21eea8a9f5d8: ushort
{
}

public abstract class Type_bba18398870349f692cc254c073d8bf8: uint
{
}

public abstract class Type_7aeb2fafa35241be87ac26b5810f57a4: string
{
}

public abstract class Type_4bcefd3e9f9e4c0cba42e4bafc2e1318: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_5fa77c7d2fce495195c2cadaa3ea2591: OneOfBase<string, LuaNil>
{
}

public abstract class Type_28a6f40dc05443d5ac6008e1232a5676: uint
{
}

public abstract class Type_de1accb1778e4b7a94d30935885173b9: bool
{
}

public abstract class Type_f80867737040439dbf3c576af4a2c071: bool
{
}

public abstract class Type_8e522d17ca494df1b20047298486717a: bool
{
}

public abstract class Type_12e449c590214e27b3ea497dad1bcacb: PrototypeFilterMode
{
}

public abstract class Type_64325be0beb8489ea4d651e40f2e13e2: string
{
}

public abstract class Type_dba138d137c944a2a466637d00eae13f: LuaEntityPrototype
{
}

public abstract class Type_4cf6f303068b4fbdb00f852a95300880: Dictionary<string, LuaEntityPrototype>
{
}

public abstract class Type_ea51d693d74c482a9a7f8bb7c2d7380a: string
{
}

public abstract class Type_02b6d7259a2d4cb286707fc09c74afdf: bool
{
}

public abstract class Type_b9153637556f4397828118d7e975c2a2: Dictionary<string, bool>
{
}

public abstract class Type_2019fefef45a4100b1620461b90d6bf2: PrototypeFilterMode
{
}

public abstract class Type_97d0e56c222f4d64b6443330041db38a: string
{
}

public abstract class Type_3ea3c7dc8edd407ab05da3cf3ad3045d: LuaEntityPrototype
{
}

public abstract class Type_e72d546ff36e4216b11f32ff88846c88: Dictionary<string, LuaEntityPrototype>
{
}

public abstract class Type_649e67e529a84d598ad8254c1ddbe2ae: string
{
}

public abstract class Type_dc15d45e82964821b0fae9f776dbf5f6: bool
{
}

public abstract class Type_1ec64b258eb04fcda8fabe765abf829b: Dictionary<string, bool>
{
}

public abstract class Type_9d00971a3530402a90b6ea716170b754: Color
{
}

public abstract class Type_68b5df715ea9469798a51bc522aae385: CursorBoxRenderType
{
}

public abstract class Type_df29b59c318a45b6b66283b2f3c75129: SelectionModeFlags
{
}

public abstract class Type_c6f32bdd9a704f82b9b0a4a999fd077f: PrototypeFilterMode
{
}

public abstract class Type_3e88877bc4f6471b913213c5564220ad: string
{
}

public abstract class Type_a6cb00673f10486290c84b321223865a: LuaTilePrototype
{
}

public abstract class Type_29702a90afca424498a30d2718ad1ed9: Dictionary<string, LuaTilePrototype>
{
}

public abstract class Type_bac9919e708449e088ea5a5e9e1b86bb: Color
{
}

public abstract class Type_1fb9629177f1451ca2ad2f2f70fecd68: CursorBoxRenderType
{
}

public abstract class Type_decf8239dfb14269b2314e1d7825bb61: SelectionModeFlags
{
}

public abstract class Type_06dd4e3fbb6644819b110bba45edf2c9: PrototypeFilterMode
{
}

public abstract class Type_b915c06b688f4505a53449fd8f303a3b: string
{
}

public abstract class Type_96223fe791724c5aadeda83029fb6391: LuaTilePrototype
{
}

public abstract class Type_e1f906ed20494cc4a50950bfe0d24feb: Dictionary<string, LuaTilePrototype>
{
}

public abstract class Type_b914dac8239b4f4088a3ddb21331ff4d: bool
{
}

public abstract class Type_c4aeb9ed4af24e148be92c01886671fd: AttackParameters
{
}

public abstract class Type_314f2cafa2ff42b5be88728caee38125: LuaItemPrototype
{
}

public abstract class Type_47c35306b76b4450bd67a794b3e6d7b2: bool
{
}

public abstract class Type_afcde06838484b12ad449150d7c9841f: CapsuleAction
{
}

public abstract class Type_85fd9b6370014ef58885a37545e6924f: string
{
}

public abstract class Type_f4d23a336615462080aa14e00d8b2c52: LuaEntityPrototype
{
}

public abstract class Type_53f09b90b4604b2681bca6b657acb555: Color
{
}

public abstract class Type_4ac3a503727749818afaca444ff7ffc6: uint
{
}

public abstract class Type_19472eee596a430db9e11079ee221cd4: bool
{
}

public abstract class Type_ee156019087f4fef89de1e9aab497f89: double
{
}

public abstract class Type_ba22221f8c6742a5ac58ea4a09f8b662: string
{
}

public abstract class Type_a53d3cbdcb53467caa003bed0daa393a: PrototypeFilterMode
{
}

public abstract class Type_55b5d7e091e145ce8c793364e04e46ae: uint
{
}

public abstract class Type_f8b7d426d50f44479aefd5f9adf518df: string
{
}

public abstract class Type_b79e6bea786546c1a961354ea6880846: LuaEntityPrototype
{
}

public abstract class Type_a37c0a1dba6547d998bb427e75806c09: Dictionary<string, LuaEntityPrototype>
{
}

public abstract class Type_92b1e7c7cc7b4f99a98c31b69d5bab60: string
{
}

public abstract class Type_1d61d1bbf7104943b0174616bbd843d2: bool
{
}

public abstract class Type_7bb40f1543be46edac909cef10021abd: Dictionary<string, bool>
{
}

public abstract class Type_7515ae700b4d4dd3b2d8f372af8ee205: LuaEquipmentGridPrototype
{
}

public abstract class Type_9a5f80f9268a409d9924ff0155b7ee95: bool
{
}

/// <summary>
/// Union of literals:
///   - none
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals_7b7e130f642946eaa33991d4700e1e12
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

  /// <summary>
  /// Literal value: whitelist
  /// </summary>
  [FactorioRconDefinitionValue("whitelist")]
  Whitelist,

  /// <summary>
  /// Literal value: blacklist
  /// </summary>
  [FactorioRconDefinitionValue("blacklist")]
  Blacklist,

}

public abstract class Type_fee10ded50e54ae5978630225dcc1568: ItemPrototypeFlags
{
}

public abstract class Type_599c33fe56b44543b15ff5f3e4cecb2f: double
{
}

public abstract class Type_c9477689afed419596df4f98fa2b2a1a: string
{
}

public abstract class Type_dc74a9446ea645119b55c5917a24148b: double
{
}

public abstract class Type_c7e0a2564b02421db387edce9b33a150: double
{
}

public abstract class Type_df0aacb2bdd04a8b95d9a00ce1e47c26: float
{
}

public abstract class Type_bc5e69db86cf4c3096fd99eaa608d299: LuaGroup
{
}

public abstract class Type_1a054cdb3d564936bc40755a1ffb429f: bool
{
}

/// <summary>
/// Union of literals:
///   - default
///   - never
///   - always
///   - when-manually-filtered
/// </summary>
public enum Literals_1ef57fbdb65843c68504558fb829b388
{
  /// <summary>
  /// Literal value: default
  /// </summary>
  [FactorioRconDefinitionValue("default")]
  Default,

  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: when-manually-filtered
  /// </summary>
  [FactorioRconDefinitionValue("when-manually-filtered")]
  Whensubtractmanuallysubtractfiltered,

}

public abstract class Type_85de2f3e83e748d7bb0e185d42d3e499: uint
{
}

public abstract class Type_2121b07e6443464b876ee171276c7552: uint
{
}

public abstract class Type_5162032ac2c24d61a9e60e35a6246145: string
{
}

public abstract class Type_e3defd3cc07346ce8d1befaf770e6588: LuaItemPrototype
{
}

public abstract class Type_0668de85e8eb4ed88b0f47deb55c4c1d: Dictionary<string, LuaItemPrototype>
{
}

public abstract class Type_bdc55b1ad4a64e149f3335e132446b3a: string
{
}

public abstract class Type_32688dbd5f5048c896fe09248f7cd9a0: LuaGroup
{
}

public abstract class Type_1b6a42bdf01b4e7d9fe993d53e1bb3c1: Dictionary<string, LuaGroup>
{
}

public abstract class Type_2616b710047146e69af330cb4e16df17: string
{
}

public abstract class Type_9ed2569ffb4a4db3b4bf9a32cef2bb3b: LuaGroup
{
}

public abstract class Type_02aa3118cf4748f98f2b2856e19c2b96: Dictionary<string, LuaGroup>
{
}

public abstract class Type_2253363877c2419cad50324a99bcd2c2: string
{
}

public abstract class Type_04061fc89a6a4d218eb2f381275202eb: string
{
}

public abstract class Type_4ff085e377e44dd8abb1ba37e51648c3: List<string>
{
}

public abstract class Type_8b8360ad33ef4b5aa9ef7f481bf72792: LocalisedString
{
}

public abstract class Type_9c60d0be9a3444ab91d4272e424d4a8e: LocalisedString
{
}

public abstract class Type_c646b01e34ec4ae29e9ca8bb5f766496: LocalisedString
{
}

public abstract class Type_67063ccf138e463db2c886d8088bacca: float
{
}

public abstract class Type_e553d53233d94ef0a2547df09f7cdad1: uint
{
}

public abstract class Type_5cbd68f2197d4c5ea1594d4d80ba7e06: ModuleEffects
{
}

public abstract class Type_83bd4bb225914f0788310e9215af1600: string
{
}

public abstract class Type_5503ca34254c40f09f180cbab7ee80c8: string
{
}

public abstract class Type_291af578e88e46cfa5088890cce1cbef: string
{
}

public abstract class Type_3c4935c5defb4c079716a0866ce4d809: LuaEquipmentPrototype
{
}

public abstract class Type_3b709e2e2bcd40f08afc6b5a4c167c8d: PlaceAsTileResult
{
}

public abstract class Type_8a3a1fb3a8e841918fd6f1116e84f7ca: LuaEntityPrototype
{
}

public abstract class Type_fd40b432155b4e0086097bf39338b701: float
{
}

public abstract class Type_26d5af2cbf36474297adee08a2d4e0f7: TriggerItem
{
}

public abstract class Type_c18e008eab754e9db427a8f019c106f4: List<TriggerItem>
{
}

public abstract class Type_4c67332c8a1f44ff886537f8da94f46a: string
{
}

public abstract class Type_82e4d3d202fc4875a5c095ac9c85e716: Resistance
{
}

public abstract class Type_62adb845c83141da81da5650505ac9f0: Dictionary<string, Resistance>
{
}

public abstract class Type_d62482bfecdd45389c1f8d5411d1afd0: PrototypeFilterMode
{
}

public abstract class Type_64c455835e0b4f33b303e15a6e1f022d: string
{
}

public abstract class Type_83e276418eb549c5befd84cbc2cb7714: LuaEntityPrototype
{
}

public abstract class Type_8dde087c95fc43a9972ab0548d16de19: Dictionary<string, LuaEntityPrototype>
{
}

public abstract class Type_a21daca4842b4be08d6ccc13c30f80c9: string
{
}

public abstract class Type_a5420578ec9e40a0965fc3761883178e: bool
{
}

public abstract class Type_166a267d3c534012bc39066621af4c46: Dictionary<string, bool>
{
}

public abstract class Type_e6a5c74e8531489781c7b266b12f7172: Color
{
}

public abstract class Type_152fa7cc633b43b086f38240da28aff2: CursorBoxRenderType
{
}

public abstract class Type_3d7038b7e1a04d2ba14e6f1adb8a7fb6: SelectionModeFlags
{
}

public abstract class Type_4863232e88dc4a8785f6bad891d8c696: PrototypeFilterMode
{
}

public abstract class Type_2cdb191c38944d5fb8d44bf28449243d: string
{
}

public abstract class Type_1e1f07aded5e489da5c635ebe55a4efb: LuaTilePrototype
{
}

public abstract class Type_57a26ca24f2445f78dfc64cfacf9bac9: Dictionary<string, LuaTilePrototype>
{
}

public abstract class Type_6da122f727594f8083a0709fc208674b: Product
{
}

public abstract class Type_c8d5424bc586436facf1e5884819ecf8: List<Product>
{
}

public abstract class Type_d8f2a54b11d245ba99f97f8164394410: Color
{
}

public abstract class Type_22712084945842d38cae7355e7d91a2c: CursorBoxRenderType
{
}

public abstract class Type_dfe207ac47264dafad289644cbfd64b1: SelectionModeFlags
{
}

public abstract class Type_206a44e7b7194b58b58e0f689d68818d: float
{
}

public abstract class Type_261a9f61b2d24632a6ad5d7d5309dc45: uint
{
}

public abstract class Type_b22874137d404cdda5d9d7fe236afd8d: bool
{
}

public abstract class Type_6f4e5923bdfd411ea5aa4b31eb532e1c: LuaEntityPrototype
{
}

public abstract class Type_5bb9edd9682a464bb04122b9a100ea64: LuaGroup
{
}

public abstract class Type_ecf2238c966f41faaa41a631584cbb6e: uint
{
}

public abstract class Type_378a885d275c44cf9d8878b61125a213: PrototypeFilterMode
{
}

public abstract class Type_ab9d8d2286cb4b65bd7c331f665d4cd5: uint
{
}

public abstract class Type_c33f5f86ac884c61bbd50f5e06e4e6b5: string
{
}

public abstract class Type_4aa3b07d09d94f03b5b93510039363de: LuaTilePrototype
{
}

public abstract class Type_4a8c42009c62473aaf9dcc1de83fee2e: Dictionary<string, LuaTilePrototype>
{
}

public abstract class Type_7d4e198a990c4fddafed751d0789f5ef: string
{
}

public abstract class Type_f690d89545a64dc89bb76b0b5c37e78c: bool
{
}

public abstract class Type_28b399923e12493a8170c48b6178c804: uint
{
}

/// <summary>
/// Union of literals:
///   - default
///   - player
///   - turret
///   - vehicle
/// </summary>
public enum Literals_50eaf5159f134e6ea87f214e548223c5
{
  /// <summary>
  /// Literal value: default
  /// </summary>
  [FactorioRconDefinitionValue("default")]
  Default,

  /// <summary>
  /// Literal value: player
  /// </summary>
  [FactorioRconDefinitionValue("player")]
  Player,

  /// <summary>
  /// Literal value: turret
  /// </summary>
  [FactorioRconDefinitionValue("turret")]
  Turret,

  /// <summary>
  /// Literal value: vehicle
  /// </summary>
  [FactorioRconDefinitionValue("vehicle")]
  Vehicle,

}

public abstract class Type_73dd9a197b98482cb204b8eb5d26aa45: AmmoType
{
}

public abstract class Type_ef8e1e613c224bc19ae9159abd6f2aef: ItemPrototypeFlag
{
}

public abstract class Type_3d120ed232864721a0a7b0c790878aa7: bool
{
}

public abstract class Type_aff95650594f4c24949337962a57143a: string
{
}

public abstract class Type_e26dbf8c49fd4cf6bdb80e1396268481: uint
{
}

public abstract class Type_5fcbbb2ffdf34a089e25fada3359fbc8: bool
{
}

public abstract class Type_38072f382f0d428ab0db1e3319212dec: uint
{
}

public abstract class Type_98604f0db33848d0a59781b92d3f1867: bool
{
}

public abstract class Type_2b0a6deaaf134141a93aad92ea70ec83: BlueprintSignalIcon
{
}

public abstract class Type_16d454d439b24a12b64c32cac8c31986: List<BlueprintSignalIcon>
{
}

public abstract class Type_5a706a455b094beba1d58d9fc5c0433c: TilePosition
{
}

public abstract class Type_9909e7c630bc429e8305c801228fd836: TilePosition
{
}

public abstract class Type_6443df0215334082974a3f97f090706a: LuaEntity
{
}

public abstract class Type_9de0d90b16c8431cae17559efd3d96eb: string
{
}

public abstract class Type_da0d85b693f841799e2f00a675d5f0a9: uint
{
}

public abstract class Type_977116e465204059ad8211fb59a589b1: Dictionary<string, uint>
{
}

public abstract class Type_2fcaaa5e45a241189b570999069e43e2: uint
{
}

public abstract class Type_a295253ec91546f7a6b0f5c9bd52c89b: LocalisedString
{
}

public abstract class Type_888ffa239a4a45a398a0afdd783b9a84: BlueprintSignalIcon
{
}

public abstract class Type_af5a5a9e4431410b8256f3b74b5cd2ec: List<BlueprintSignalIcon>
{
}

public abstract class Type_3b2ba2abf2a14b14b03c33283c8200ca: double
{
}

public abstract class Type_cab0c9f7150b467fab4a87a39288cdfd: Color
{
}

public abstract class Type_82599047eb284893b3659888fb58b79e: uint
{
}

public abstract class Type_ad7783278933447ba90f747546d9e478: DeconstructionItemEntityFilterModeEnum
{
}

public abstract class Type_527285bb27c143c3ae119a9bbb44ced4: string
{
}

public abstract class Type_dc1c2970e6514d26b7d45d8cdb29edf1: List<string>
{
}

public abstract class Type_0bcf3951bcf5446e82fbebe65ac33886: string
{
}

public abstract class Type_2803e618f6d1430c9f7ec0dda17c581d: bool
{
}

public abstract class Type_d131b8dd1f094b5fb7c26bff9117dec8: LuaEquipmentGrid
{
}

public abstract class Type_522da8e88a704b1aa08c9b272740f478: float
{
}

public abstract class Type_6ab202832851479da58328c11c2dca71: bool
{
}

public abstract class Type_dc3f073646a94cb0bd352cb7615400a7: bool
{
}

public abstract class Type_c59ad7c57e8d4f63a1889b078d8c3bce: bool
{
}

public abstract class Type_fa6ec871e2a34b3e884ff17b4471ac3f: bool
{
}

public abstract class Type_eb3a87e5d7544a67b4bb1475b1a70cd8: bool
{
}

public abstract class Type_dd38243b8272491d93f506e7f101a008: bool
{
}

public abstract class Type_7449fea597fd41578d90cebe20dd7cbf: bool
{
}

public abstract class Type_94cc7fb224b54bb886ea40b7b25fe35f: bool
{
}

public abstract class Type_afbd518fc7474ca0b13b71ab075edc43: bool
{
}

public abstract class Type_2755eb6d126d400286320c3b8d27e131: bool
{
}

public abstract class Type_b77c802fa6a5499a96ba4c1a7f76cca4: bool
{
}

public abstract class Type_5979c5110e9942c1b54a721172715892: bool
{
}

public abstract class Type_110b1e574c1a46c38e96d94fd890e136: bool
{
}

public abstract class Type_2653b5a6e5eb43048aa9825359e1b923: bool
{
}

public abstract class Type_3e0ed5d10a0c4554aea1f369965e22df: uint
{
}

public abstract class Type_7e7f90f14a324750bd8b615ac1511d13: string
{
}

public abstract class Type_17b9b4ad31c1491ca75a17f3fa5bb6f5: Color
{
}

public abstract class Type_cdd45b62283c4327a36c8950c0fb9221: string
{
}

public abstract class Type_abbec312a9594737b74abefa005c8644: string
{
}

/// <summary>
/// Union of literals:
///   - default
///   - never
///   - always
///   - when-manually-filtered
/// </summary>
public enum Literals_01e878eaecfc4ee8b4b4637ac593b825
{
  /// <summary>
  /// Literal value: default
  /// </summary>
  [FactorioRconDefinitionValue("default")]
  Default,

  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

  /// <summary>
  /// Literal value: when-manually-filtered
  /// </summary>
  [FactorioRconDefinitionValue("when-manually-filtered")]
  Whensubtractmanuallysubtractfiltered,

}

public abstract class Type_2e1f2b10335c403fa38807621c28a35e: LuaItemPrototype
{
}

public abstract class Type_85ec89a5eca349f1bc8d9f426836d39c: Tags
{
}

public abstract class Type_c1e00c13340e4c39b151ca3f67949066: uint
{
}

public abstract class Type_27cccf8cf8694e269c91e9dc823c6b14: DeconstructionItemTileFilterModeEnum
{
}

public abstract class Type_49eca17340b4436ab670a207a08b9635: string
{
}

public abstract class Type_a4ccbeb0b2f5444c95c914c299a61198: List<string>
{
}

public abstract class Type_096e9e6fa52d4063a1f8698b9533676d: DeconstructionItemTileSelectionModeEnum
{
}

public abstract class Type_113f6b10f97a4616bea7e0b15cafcb45: bool
{
}

public abstract class Type_6ebde0b2d5ed47b6bc5eabdf34b7c9e5: string
{
}

public abstract class Type_e678a998c14c4041809452f0908a5cea: bool
{
}

public abstract class Type_ddd7bad75beb4d0c9ec8d9691fb9594f: bool
{
}

public abstract class Type_3dd2e55723ee4ea4936792e9be63d7cb: float
{
}

public abstract class Type_52a4e2b089984a2cb0e1d375165ec7f2: double
{
}

public abstract class Type_f7a98efc7bd34b209badc5f2382ce3b5: PlayerIdentification
{
}

public abstract class Type_c60c11e045ae47afa63bed115f1d02fd: DirectionEnum
{
}

public abstract class Type_fcb5d963ae304b0b94bfb79c610d8dbb: ForceIdentification
{
}

public abstract class Type_adcd5da8bcff4c23a887e65d2bbc3276: bool
{
}

public abstract class Type_276f46e0b9604eb692bc072b5dd03493: MapPosition
{
}

public abstract class Type_0f01c609ea7741f2a78bbcb0d62c151c: bool
{
}

public abstract class Type_9f5ca4a3c38b48aebe8416e97e683635: bool
{
}

public abstract class Type_2ddfa0b032664a0395cba6e6712a094c: SurfaceIdentification
{
}

public abstract class Type_797380b4c60f49ffb01db467a932fd9d: LuaEntity
{
}

public abstract class Type_f021ab191db5465a8d4ff0185099f361: List<LuaEntity>
{
}

public abstract class Type_b493c4193c764be3adca64ff62855295: ItemStackIdentification
{
}

public abstract class Type_a09cbee151574a979597bcdb4f94aca0: bool
{
}

public abstract class Type_b7ebdf57f5bd4d3dbf02930e6fcb86a3: BoundingBox
{
}

public abstract class Type_99192ddfc30b42919aa44437778510f0: PlayerIdentification
{
}

public abstract class Type_a2cc2918347f48dd93968cb12a58cacc: ForceIdentification
{
}

public abstract class Type_edca79667f374e71805263f14a4ecd1b: bool
{
}

public abstract class Type_d0e154515eb442a19855e87c08216e5e: SurfaceIdentification
{
}

public abstract class Type_5d61a4dd6c2b4a6b80ab9f7769eb566c: bool
{
}

public abstract class Type_b6d65c3d803043cebef81a21619b4d93: BoundingBox
{
}

public abstract class Type_5f945f7065b440a7bbb2eae792cb1972: ForceIdentification
{
}

public abstract class Type_5abe68b57dcd4b73b3f16c04c55dadff: bool
{
}

public abstract class Type_1ba15352352f4f40a3c7997dcd26e7b6: bool
{
}

public abstract class Type_181b95acf8864816b925c06c1bfc33e1: bool
{
}

public abstract class Type_400f4faf96654c61b23ed4687fddba1f: bool
{
}

public abstract class Type_978aae3ce03a4d64a7cbedfaf7839ffd: bool
{
}

public abstract class Type_772907a166544cd48505646d4ef4a242: SurfaceIdentification
{
}

public abstract class Type_fd83a14f64174be2b5ca502144cef40f: uint
{
}

public abstract class Type_27442f1474644681b5541a184323a65d: LuaEntity
{
}

public abstract class Type_2e1c6f0fe8ab427d8fba5fd418de4612: Dictionary<uint, LuaEntity>
{
}

public abstract class Type_b6de0ab5b74140d896bb8137a0c46083: LuaEquipmentGrid
{
}

public abstract class Type_29bc2ebbb707496c8098a18785852e86: BoundingBox
{
}

public abstract class Type_4368c7017b0843569ef364e7a783060d: PlayerIdentification
{
}

public abstract class Type_255ea81f7caf43f9a7cb9950082fb9f0: ForceIdentification
{
}

public abstract class Type_135c7d8c6cc644d68f6df04e12598569: bool
{
}

public abstract class Type_5559bcc2a86d4ec5801972527531bc6e: SurfaceIdentification
{
}

public abstract class Type_453916f2d74244bfb0ebe1e338e11b38: float
{
}

public abstract class Type_e13a301a65e149c8b585643eef11361f: double
{
}

public abstract class Type_e008e75ec24b483a85cc19a921551807: string
{
}

public abstract class Type_714d2c0f0f4447439da936dfdf52053e: BlueprintEntity
{
}

public abstract class Type_2b0be0fb8c294bda8f9b018f7f5b6148: List<BlueprintEntity>
{
}

public abstract class Type_8c5ba55ec9f04524b459b02bbd751051: uint
{
}

public abstract class Type_8c650f4208224c9585e20b4db2a47160: uint
{
}

public abstract class Type_d3803c1d37a84477affb89cdba7abb96: string
{
}

public abstract class Type_3f2a457d87d7480c80bfa182ce084f63: AnyBasic
{
}

public abstract class Type_faad87f7281f48d8a46bb9c4ce4f8d0f: uint
{
}

public abstract class Type_0b0f6cdb10714cad861f4798f5facfe3: Tags
{
}

public abstract class Type_18f6e3e1e26f48f7a6521902092ab8fd: Tile
{
}

public abstract class Type_b079fc5c0c774aefbb5786199b749053: List<Tile>
{
}

public abstract class Type_0c090d5631b1460490b4fbf954582726: uint
{
}

public abstract class Type_57acf6d767314998a4b8f942f69fba04: string
{
}

public abstract class Type_feb0d75c87fc456b8e22db42619318f7: InventoryEnum
{
}

public abstract class Type_8f46e248b92f48d2925c40b792056c45: LuaInventory
{
}

public abstract class Type_69f6f8d0172e4978a3666ea163a8a722: uint
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals_efc3c35cef8146d8be9e84aa2e730e9e
{
  /// <summary>
  /// Literal value: from
  /// </summary>
  [FactorioRconDefinitionValue("from")]
  From,

  /// <summary>
  /// Literal value: to
  /// </summary>
  [FactorioRconDefinitionValue("to")]
  To,

}

public abstract class Type_67a345c49d3548e8ae719d7ce1177d7c: UpgradeFilter
{
}

public abstract class Type_cc2646d0648447b7a36e28d89ac86cca: string
{
}

public abstract class Type_6a8981ddd42547d28ac538efbe61a0e4: AnyBasic
{
}

public abstract class Type_a1bd2edd71fa4a5c8b6cab1668dc5f35: uint
{
}

public abstract class Type_a38d55f117fc4eb69b4fad12231a5195: string
{
}

public abstract class Type_df7f2938f6dd4b3892350b5566cfcd57: string
{
}

public abstract class Type_eaec4c92d7cd4576bd2b2521fabc3722: string
{
}

public abstract class Type_d5dcc934cbc74716963997edd4ce384d: int
{
}

public abstract class Type_9c95160d2b7f41b3bdeb80015a06521f: bool
{
}

public abstract class Type_2a66a632c87a4a28b7593c5280962088: string
{
}

public abstract class Type_fb791a32c7e74d1bab32d60f52e1acac: bool
{
}

public abstract class Type_fedd74c8575f4601895ff1fa54c3eacc: BlueprintEntity
{
}

public abstract class Type_2357e18e652b40bea2442cd2a5944d31: List<BlueprintEntity>
{
}

public abstract class Type_2e75c49dfcf04655a0256dd9a4c26a27: uint
{
}

public abstract class Type_139b986197da441188a6fa7250312fdf: string
{
}

public abstract class Type_45439b942a4d4123bbde7a0b4d372eee: AnyBasic
{
}

public abstract class Type_7c46367a7f514d78a0682f136c842988: uint
{
}

public abstract class Type_856a4b712ec34a10aaa8788317802c9a: Tags
{
}

public abstract class Type_66d668be10e44f1fb899ef4f629418ca: Tile
{
}

public abstract class Type_fca883137bee4c09916d1e9ff7e22dcc: List<Tile>
{
}

public abstract class Type_f1c2935d92b24fb68a190d3f3383e9d0: string
{
}

public abstract class Type_aa8e02c213a64a6d808435b4df697a1e: LuaEntityPrototype
{
}

public abstract class Type_04fd890f8745400eb372ca256d9d2461: LuaEntity
{
}

public abstract class Type_142193be360747a78e9a95081bf28528: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_c094c0e50f5941408488c8c97bc9236c: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

public abstract class Type_796261cac24e430897b7be6b8798718f: uint
{
}

public abstract class Type_04b00b1bc969431689ab9e5ea83495be: bool
{
}

public abstract class Type_4b4625a7e7f34c3faa80a698d3f62d61: UpgradeFilter
{
}

public abstract class Type_fbff8c29a7094ee7badf574b30dd6771: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_cfe9425c0f5649689314873474b45bb2: OneOfBase<UpgradeFilter, LuaNil>
{
}

public abstract class Type_932f1afd18e947e28b6e44e9e1c3b386: uint
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals_5c5de377b71741329d8cdab8f3995b80
{
  /// <summary>
  /// Literal value: from
  /// </summary>
  [FactorioRconDefinitionValue("from")]
  From,

  /// <summary>
  /// Literal value: to
  /// </summary>
  [FactorioRconDefinitionValue("to")]
  To,

}

public abstract class Type_1470c701fbc84c20b3b148287975591e: ItemStackIdentification
{
}

public abstract class Type_9fefbb8ab95f499a910441de74de0c88: bool
{
}

public abstract class Type_a2b8a570bd054777b0f088225ddd1dab: AnyBasic
{
}

public abstract class Type_3739447cf2bc4c048dbf5e28108a5496: string
{
}

public abstract class Type_d2a09575863a4a01aeb44161a384cfe2: string
{
}

public abstract class Type_33f8f48ae6fe4b91add146408df7b95a: LuaTilePrototype
{
}

public abstract class Type_0a9a381e3af343d3a433a239632c9687: LuaTile
{
}

public abstract class Type_9512c7464223472ea739ff0dab4a8ca8: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_822cc430ee0a42148315cfa49314224e: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

public abstract class Type_53745a64ec544ed4bf4e6ee2aef96bc3: uint
{
}

public abstract class Type_1ea04d12c4f64df487d91a4651357cd3: bool
{
}

public abstract class Type_2330c8c1d3e94b74b6ba2d8a3d87a0a5: LuaItemStack
{
}

public abstract class Type_b42272e3dfd4402eb4882eb95b7163b3: bool
{
}

public abstract class Type_869ace4785dd40ba8587435f7f114012: ItemStackIdentification
{
}

public abstract class Type_8c588241bd4f43798e51de308edd7ac4: bool
{
}

public abstract class Type_d073cc5f000b437396f7b606242160cf: LuaEntity
{
}

public abstract class Type_e25fd1803a8e449f86c25eca153e3c03: MapPosition
{
}

public abstract class Type_23162ed43fdd435d83a10ab565ac3598: LuaEntity
{
}

public abstract class Type_961dad8418de4eda85cdabaf8ba431f5: List<LuaEntity>
{
}

public abstract class Type_c24c3909c874481bae2192332b2f3684: Color
{
}

public abstract class Type_8c5c1bfadc3f43579abd9188c05a9405: string
{
}

public abstract class Type_639a5a29523841969b6af5946cee45fa: bool
{
}

public abstract class Type_9c9daac5b86e49d3867d73925bcefcb6: bool
{
}

public abstract class Type_7e2e50d8860841a5a0f3fbe8427f73de: string
{
}

public abstract class Type_b0125b5f01e34d71aa2f2456fa48b5c1: string
{
}

public abstract class Type_1d5419fc81da4615840b1dce3e6b367e: bool
{
}

public abstract class Type_bdc306f2f4804b72b96fa76dd8811659: Any
{
}

public abstract class Type_6fd1d375d1aa4b59b98290e16095f5fc: string
{
}

public abstract class Type_1a55a301745745fd9830cca67f129208: float
{
}

public abstract class Type_19fb90cf1c9f4f17ab376b7787282442: uint
{
}

public abstract class Type_3afcb90be7ce44c7a3df28c70cf11b55: LuaEntity
{
}

public abstract class Type_8f943f3fe0c14848b44dd4b13c07309f: List<LuaEntity>
{
}

public abstract class Type_4b903b38d52e4ba5ad2d6ba78a9ab4b4: float
{
}

public abstract class Type_536be33e2fc3421ab397bbb000d1fccf: LuaLogisticNetwork
{
}

public abstract class Type_e2af43464b5f4813b29c7acda9afc58d: float
{
}

public abstract class Type_5c954adebf0f43419361ee66d70babb8: float
{
}

public abstract class Type_4f638e990cec4b4986fc0fd6c4243326: bool
{
}

public abstract class Type_2067ff7545ef4aefbec7434dacd8ee6b: LuaLogisticCell
{
}

public abstract class Type_02441b1eb1a14b25bed2a8898a42f6f5: List<LuaLogisticCell>
{
}

public abstract class Type_4d687500b82a45f1b77cf33553c81d2b: string
{
}

public abstract class Type_e4a4855ad2c949628e61f9cf8a802ab3: LuaEntity
{
}

public abstract class Type_1d80ef4245da4673befd33994dcfd89a: uint
{
}

public abstract class Type_75d8b1f027e740c685e3cc6e61b0b05a: uint
{
}

public abstract class Type_1a310d6e85244b74877610bb40d38ffa: uint
{
}

public abstract class Type_3014645b56eb40de9fd4cec14cc91a38: LuaEntity
{
}

public abstract class Type_7087939c174e4fd68943dd00f62f7597: List<LuaEntity>
{
}

public abstract class Type_50f7d8811fdf4034a03430ce71e18c7e: bool
{
}

public abstract class Type_5a935241fdcb4c14ad47ec6d1c804afd: bool
{
}

public abstract class Type_9f444d8c79ca4afb9d2b212e693a3603: string
{
}

public abstract class Type_51d8c339790140d8aa59f44de3238446: MapPosition
{
}

public abstract class Type_c0d3da97d1d84f3b8f9ec39cc9e3aa80: bool
{
}

public abstract class Type_5e28bf82a6144a5391c98eb7d61b1506: MapPosition
{
}

public abstract class Type_e6831a7be2d749babbb6fa4b370bfb80: bool
{
}

public abstract class Type_dc80a5f6d76a4755a60acdc384af89fd: LuaLogisticCell
{
}

public abstract class Type_684255b5809a42fdba13f53670c3b79e: bool
{
}

public abstract class Type_f7810a4abbc1483199a987612f787034: ControlBehaviorLogisticContainerCircuitModeOfOperationEnum
{
}

public abstract class Type_0564b086e2524f688c264536e8ac81ae: string
{
}

public abstract class Type_83d8a850b5af48b88339f08820765e48: bool
{
}

public abstract class Type_e587c82b634e4fda8cb17a48000690e2: string
{
}

public abstract class Type_06b0d65b21da4238a47e6041ff7c2877: LuaLogisticPoint
{
}

public abstract class Type_d0e6bc923e8541e595bc18081a025233: List<LuaLogisticPoint>
{
}

public abstract class Type_2a2699601b8e44838d7015e93e04e59a: uint
{
}

public abstract class Type_c9e97ec455df485cbd949bd9d5db03bc: uint
{
}

public abstract class Type_292503f5daad4464906171e9a8ee1a6c: uint
{
}

public abstract class Type_0e59b601dfaf41dc84f693b909477212: uint
{
}

public abstract class Type_0f77413d417646acb2176c3c63d7bc06: LuaLogisticCell
{
}

public abstract class Type_49beb07d152a455fa6ec115f82c78763: List<LuaLogisticCell>
{
}

public abstract class Type_52d42aaf363c44d3be56c2b2569dfec9: LuaEntity
{
}

public abstract class Type_e1b9e60bf9864813a4003eb4a7fb7afd: List<LuaEntity>
{
}

public abstract class Type_2f1307f780ef460b92565783aa6e4949: LuaLogisticPoint
{
}

public abstract class Type_e9e2c02dbe254cd6b996bfb970a9cf02: List<LuaLogisticPoint>
{
}

public abstract class Type_6e8237d0f88b405bb671cba8f7d569c1: LuaEntity
{
}

public abstract class Type_a73a6f91af0a4fe2885007baa0baff14: List<LuaEntity>
{
}

public abstract class Type_2bb792a4601644e3b4be192e870be1a3: LuaForce
{
}

public abstract class Type_89c40a7e0a514303b29c0b2f16fefa1d: LuaEntity
{
}

public abstract class Type_0cac255d65844d2d97277f69235fe151: List<LuaEntity>
{
}

public abstract class Type_820fc00071904227b7b2973bffaa297b: LuaEntity
{
}

public abstract class Type_bf59d0a95e08442ba28c301be1f5aa6d: List<LuaEntity>
{
}

public abstract class Type_994704add2ad43af845e64b2db53ed5e: string
{
}

public abstract class Type_40a2a30f789249e38a9aadf670396e09: LuaLogisticPoint
{
}

public abstract class Type_ad909a2305484d888b90ac8b4f69eb23: List<LuaLogisticPoint>
{
}

public abstract class Type_5c5fbcf481c74a149124d1f14d8c7b54: LuaLogisticPoint
{
}

public abstract class Type_42b607d583994046954d28d40d86fddc: List<LuaLogisticPoint>
{
}

public abstract class Type_f3423573e94642e09f1a5e91dade7343: LuaEntity
{
}

public abstract class Type_155921ae9f0e4e0280f422f323e31849: List<LuaEntity>
{
}

public abstract class Type_a6ae4c0a03b941139e7081a172036f0a: LuaLogisticPoint
{
}

public abstract class Type_d163c80fd56946deac86866fca95254b: List<LuaLogisticPoint>
{
}

public abstract class Type_a673c0696f2549aca862d92a15ea2056: LuaEntity
{
}

public abstract class Type_52528f8f68ca4c888b8dfa531dbf7036: List<LuaEntity>
{
}

public abstract class Type_4f0b401e7eb24eeda06c70959e0e9047: uint
{
}

public abstract class Type_e333eba8f00543ffab832fb479ed3ab5: LuaEntity
{
}

public abstract class Type_3609d5346ad74ca29ecb0862079d26a1: List<LuaEntity>
{
}

public abstract class Type_3f879cf614244e4e992b764a90326c31: LuaLogisticPoint
{
}

public abstract class Type_393e118988774216ab6c0eff7247d56c: List<LuaLogisticPoint>
{
}

public abstract class Type_a82cef5162bd4d60a7f0582e03cfd355: LuaEntity
{
}

public abstract class Type_60b0e3140af74ce3b88e0c0cb512e542: List<LuaEntity>
{
}

public abstract class Type_9e0d5af5735843e182b75eac648b5c9d: bool
{
}

public abstract class Type_01adde6f636e4b689e92b7466b874ed1: uint
{
}

public abstract class Type_4406aa7a0c794f3dab30df07233e4a38: bool
{
}

public abstract class Type_45242fe67c894c699a602be214ee2b0c: string
{
}

public abstract class Type_1903e143db0a40f4b5f463cdb1621df1: bool
{
}

public abstract class Type_70aaa6d1decc4e7ebb3d2088cc37d692: MapPosition
{
}

public abstract class Type_0eb39ae294b34c8292c4e30287cd54f2: LuaLogisticCell
{
}

public abstract class Type_2102541b5f1d4c49ab222d340658b346: string
{
}

public abstract class Type_68ead0d6b3bb45889f71b2645846b598: uint
{
}

public abstract class Type_d2eb87e70c8a4f40b3a411c055dcb5b7: Dictionary<string, uint>
{
}

public abstract class Type_35a18975c4654614b18ba1375f63effa: string
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals_fe0917534fe64eea9abe4da5a6f86bf6
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

  /// <summary>
  /// Literal value: providers
  /// </summary>
  [FactorioRconDefinitionValue("providers")]
  Providers,

}

public abstract class Type_106349febc6140d68fa84d6dacb2844f: int
{
}

public abstract class Type_6514f7bfb8d5481c9f55f9132adead40: string
{
}

public abstract class Type_77cad70c1bb24e509cef5644365bc749: LogisticsNetworkSupplyCounts
{
}

public abstract class Type_97587385701d454c81611c6fcfc81b51: string
{
}

public abstract class Type_da05743d502642efa5ba0c1f5650580f: LogisticsNetworkSupplyPoints
{
}

public abstract class Type_4b4c1f99776c42f88d8b5ef2033b2101: string
{
}

public abstract class Type_6cd58a1558474dde90cf6d43a0218561: ItemStackIdentification
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - storage-empty
///   - storage-empty-slot
///   - requester
/// </summary>
public enum Literals_79b30f84a29a4bbea6f11ff09ca1aab1
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty")]
  Storagesubtractempty,

  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  Storagesubtractemptysubtractslot,

  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconDefinitionValue("requester")]
  Requester,

}

public abstract class Type_2db8a4b0969d4cc291174c627b97e6bf: uint
{
}

public abstract class Type_589124d260174984b5418033ca537e98: ItemStackIdentification
{
}

/// <summary>
/// Union of literals:
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
/// </summary>
public enum Literals_c736fe7611e24e82a52e86e3ba67e0b4
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  Activesubtractprovider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  Passivesubtractprovider,

  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconDefinitionValue("buffer")]
  Buffer,

  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

public abstract class Type_a8fefdb03d61452d95f6d07d8d54ef0b: uint
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - storage-empty
///   - storage-empty-slot
///   - requester
/// </summary>
public enum Literals_02710c18069440619afdd85e314c5c05
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty")]
  Storagesubtractempty,

  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  Storagesubtractemptysubtractslot,

  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconDefinitionValue("requester")]
  Requester,

}

public abstract class Type_f5a625793fe14277abe292bbaed1b04c: ItemStackIdentification
{
}

public abstract class Type_9aff82e36d8e4e1793f601b2b715f07d: LuaLogisticPoint
{
}

public abstract class Type_04bf4ac9941346ce931ab8903891364e: bool
{
}

/// <summary>
/// Union of literals:
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
/// </summary>
public enum Literals_7b3afa3578484eae8d25d93d42c9a437
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  Activesubtractprovider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  Passivesubtractprovider,

  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconDefinitionValue("buffer")]
  Buffer,

  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconDefinitionValue("storage")]
  Storage,

}

public abstract class Type_aaf5509165ea41a79ceb8725baf3c518: string
{
}

public abstract class Type_5546bfdc010c49ff8fb38d5aef2c7337: MapPosition
{
}

public abstract class Type_94de2aec3c754db78f38657a12a2a56d: LuaLogisticPoint
{
}

public abstract class Type_169d0aa4483b451fb4e22b09e89e3e6e: bool
{
}

public abstract class Type_0158fb6c33fc48629d620ef9b48610f7: LogisticFilter
{
}

public abstract class Type_f8a7e8005bf94b989e5c56e819095c0b: List<LogisticFilter>
{
}

public abstract class Type_c8ddd1525abd4118836feb22199aa7c5: LuaForce
{
}

public abstract class Type_2b8c258aa8254c4baf2f766471395c65: uint
{
}

public abstract class Type_db7717570990471d9db92dc895bc8cd9: LuaLogisticNetwork
{
}

public abstract class Type_13f1c2a545a64672a7e8218f2189ebed: LogisticModeEnum
{
}

public abstract class Type_104c717eeaa649e39c0d2a09d8cbb44a: string
{
}

public abstract class Type_3921592f6e1543f9897ae2a9366bc5a8: LuaEntity
{
}

public abstract class Type_0594d9ff035c4f64b170075e9343b22a: string
{
}

public abstract class Type_d9af9f954d0043adbc77fbf04bc92200: uint
{
}

public abstract class Type_6cca23e1665640b88496f39994002f7c: Dictionary<string, uint>
{
}

public abstract class Type_b72e3d7a1b4f41fabeeccbb7c8b325ab: string
{
}

public abstract class Type_96f4d03acb664dc892cc3f324a8d399b: uint
{
}

public abstract class Type_d380d9c8a2b64d32bdf3b76b78d6cf32: Dictionary<string, uint>
{
}

public abstract class Type_85e58171e61a4aa88e1c052b5077089b: bool
{
}

public abstract class Type_6c766b668b02439a96576579e567a409: string
{
}

public abstract class Type_4f3c41554b614fc6b6d57ecc1acf4d24: bool
{
}

public abstract class Type_8d31974a1c28491c884504a69af5c309: bool
{
}

public abstract class Type_d1754f2ce5a64104801b367374f2d93c: string
{
}

public abstract class Type_0a3ac588b0b946b9b26ad4b2b72c38c3: ControlBehaviorMiningDrillResourceReadModeEnum
{
}

public abstract class Type_129ef78224984b38895178c53548e638: LuaEntity
{
}

public abstract class Type_082e457c648443fcb0a56166f714d401: List<LuaEntity>
{
}

public abstract class Type_302bdfc2f0594ec2a669286551e6d785: bool
{
}

public abstract class Type_58473edc6eed4865a5d4ef8698c6ef38: string
{
}

public abstract class Type_fc0fb004044a42eb9afb962ccce63fe4: bool
{
}

public abstract class Type_f7c5a4157a164e31b7f275f67cef81f1: string
{
}

public abstract class Type_4bb0e1102d684fdaae4466d7998810c9: List<string>
{
}

public abstract class Type_b3fa31ef9c5046ada297b29ca0af8673: int
{
}

public abstract class Type_afa83512a4384b1f97183c70f877189f: List<int>
{
}

public abstract class Type_4804821638924aea9190c73d62a1e19f: double
{
}

public abstract class Type_21b3ea4fbfba467ab641e560bc79da39: List<double>
{
}

[GenerateOneOf]
public abstract partial class Union_e94151b93e4949149937cf62b9963fd1: OneOfBase<List<string>, List<int>, List<double>>
{
}

public abstract class Type_f0a4b93ad7d94f0888875a13f7f31154: bool
{
}

public abstract class Type_0bff560420634b9f9dc6965150434234: bool
{
}

public abstract class Type_004996c57e6a4210bbb6776cb617a813: double
{
}

public abstract class Type_560ca968002e4317ab7e1f3dcb4f7760: int
{
}

public abstract class Type_42505eff338b4cc3bfa46884cc0b5190: string
{
}

[GenerateOneOf]
public abstract partial class Union_90facd0785d64b68a615bc1f72e29f17: OneOfBase<bool, double, int, string>
{
}

public abstract class Type_b51a13ee4e674af6a6515423ed4853bc: bool
{
}

public abstract class Type_8a45fabdd84c411083cb682b9bfb074b: LocalisedString
{
}

public abstract class Type_98cb64298209482292157d4b5deb3e84: LocalisedString
{
}

public abstract class Type_86db221654a140b487dd6c90ca46e8d2: double
{
}

public abstract class Type_91a05edfb0204d2a86b8e861e9935c36: int
{
}

[GenerateOneOf]
public abstract partial class Union_df283ec4ed5d4e4aa774c4b8f3c9c113: OneOfBase<double, int>
{
}

public abstract class Type_b90ef786428a480dad2b4f56ac367660: double
{
}

public abstract class Type_9c1d3c0f775f4d7fb10600b58eafcc92: int
{
}

[GenerateOneOf]
public abstract partial class Union_bc28add6db194ca2827c29156a969395: OneOfBase<double, int>
{
}

public abstract class Type_9647aa9824eb4241b7c6b86cbe5caa39: string
{
}

public abstract class Type_30f03a1e84a14856b3520898e2126a54: string
{
}

public abstract class Type_afab7fb1185a4b26a3dd1df529545e35: string
{
}

public abstract class Type_587152a1c95d475d9ae4943bed2fbb99: string
{
}

public abstract class Type_fad3493bcd10414fa3e4be6662286404: string
{
}

public abstract class Type_1a65d3a4786e4c4993f2f63644608bc1: string
{
}

public abstract class Type_1c852d689f6e457aa7b6b7a5ac1b9dd3: bool
{
}

public abstract class Type_54e821eae7624b3eb155e1b58bfc490a: string
{
}

public abstract class Type_3fa5f5fb26954ad88637d961dd48cad8: LocalisedString
{
}

public abstract class Type_b3281418563c4a10a5e00a5045103d7e: LocalisedString
{
}

public abstract class Type_b23a3dd75c244e1ca3ded395f731b953: string
{
}

public abstract class Type_b27ab08c51ca423289128f171f783b92: string
{
}

public abstract class Type_d56c85ec0a7241c3bcf1b9e57008b1b6: string
{
}

public abstract class Type_2f6336af4edb4998b0820a7528606bc8: bool
{
}

public abstract class Type_15b14f77038747949e8da502cc69bb5a: string
{
}

public abstract class Type_644564281c1b4efeb6ba01e659601aeb: NoiseExpression
{
}

public abstract class Type_90a9daf57baf44bbbd63407e9c01eced: string
{
}

public abstract class Type_a4f1cba8536d4450b04b62a0958697e9: LocalisedString
{
}

public abstract class Type_c61a4749f70f42acb6ad2b4a734a0e75: LocalisedString
{
}

public abstract class Type_94265977fb87410c9a6bc4c08e2986b4: string
{
}

public abstract class Type_7fad48c5dca44738859931df50511b12: string
{
}

public abstract class Type_1dc9350274d446978cc5a74101bd9368: string
{
}

public abstract class Type_793d85d409444410bfa882ed3ee8da9d: bool
{
}

public abstract class Type_fde6bb5382164be1b7b289a9945378d7: string
{
}

public abstract class Type_3009133ce4b448b096a12c486ad633c2: LocalisedString
{
}

public abstract class Type_00b0c38aa1ec446fa36da5f791e8923a: LocalisedString
{
}

public abstract class Type_83eff399934246948ce3d8d57311df2c: string
{
}

public abstract class Type_7b44077153cc4affa80619f11f12969c: string
{
}

public abstract class Type_7bb19853fea14679b4a1fe71166691a2: string
{
}

public abstract class Type_662ccb69170f494d8ffe99c51dbe3653: bool
{
}

public abstract class Type_948bc64d68fb45878e58bcb3de92d44d: string
{
}

public abstract class Type_a84b33477e554d63a31f0bfd8df44363: TriggerEffectItem
{
}

public abstract class Type_f548f79089824462b7e532092241e06d: uint
{
}

public abstract class Type_25868ea793d245d589e65679ba335aee: LocalisedString
{
}

public abstract class Type_4321c643ecd94b12936a6a07f76a0967: LocalisedString
{
}

public abstract class Type_be89f094e9214512b3a6673558c5649f: float
{
}

public abstract class Type_e0445da7717847d6a6d74f7caa9c03d0: float
{
}

public abstract class Type_21e385788b7748749e4896f9f9891a02: float
{
}

public abstract class Type_d3952ba3c344417595010a1abcd1e84d: string
{
}

public abstract class Type_22f7676e0e7c403186a1e7d54504031e: string
{
}

public abstract class Type_fa648f60897640f69e2de8c0d79addc1: string
{
}

public abstract class Type_c0588d4be75b4aea8604701d604e64ae: TriggerEffectItem
{
}

public abstract class Type_88074ffb6cb64595aa97d13ee0e7e7a2: uint
{
}

public abstract class Type_b89092eb39fe4d3faa44d64a9e373298: RenderLayer
{
}

public abstract class Type_142daf03951e49728ad4c228d9db3f99: RenderLayer
{
}

public abstract class Type_34ee1536db614b95a20869434a476118: bool
{
}

public abstract class Type_fed1075e9ac34f86987476ddf81d6cc2: string
{
}

public abstract class Type_24b86c5ef25c451e9b77109a2c03ac05: uint
{
}

public abstract class Type_f1ff2fb744f34308b24bf8e511ef6abd: string
{
}

public abstract class Type_1c7f22c2b0574617b07aac9b6d518e04: string
{
}

public abstract class Type_452b7124596d40e0b788df0e1fd2a73d: LuaPlayer
{
}

public abstract class Type_44cf7080a1164e0286973bdca5653e40: List<LuaPlayer>
{
}

public abstract class Type_d46512bc6e854456b91cb60773b01827: bool
{
}

public abstract class Type_865bc16f1e104509927389df108ecd03: PlayerIdentification
{
}

public abstract class Type_cb82bb3bd303404ca89a49df08891674: bool
{
}

public abstract class Type_75f711b5ef854ab9ad3127f2633554f7: InputActionEnum
{
}

public abstract class Type_ed6199d6a4ee40989d1b056b071a866b: bool
{
}

public abstract class Type_0559d8556a5b4c5eb9e15b61cd3b4cb2: bool
{
}

public abstract class Type_d4bf171d3c064e3daf5b2ac499da92da: string
{
}

public abstract class Type_47f792e71c65478d8c5c2d2692b7db9c: PlayerIdentification
{
}

public abstract class Type_3ee0f79b541c40b599fc3e4b588708cc: bool
{
}

public abstract class Type_768408708f364c4780d2d68658f11954: InputActionEnum
{
}

public abstract class Type_9c6c908e39d8465490940b8e2830b96c: bool
{
}

public abstract class Type_d050f3a3bb5d4969b9f56582626336dd: bool
{
}

public abstract class Type_d26e8868c5924415943f4ef4772023fc: LuaPermissionGroup
{
}

public abstract class Type_9c6899b1b6bc4510bec9a5b8178bc13a: List<LuaPermissionGroup>
{
}

public abstract class Type_c7bf8295c277478ab07bfc8a5ae6c04a: string
{
}

public abstract class Type_6f4d56ff8f9540ceb6b2fcd689666752: bool
{
}

public abstract class Type_5f6d2e92cc824f3680397bdab538112d: string
{
}

public abstract class Type_080d02c56f1747e0945b5124a8f9b747: LuaPermissionGroup
{
}

public abstract class Type_ba6e91d3f3734bf0aff6030cc5e77ed3: string
{
}

public abstract class Type_43b3c88bc3f34a50ba381fcdc84613f5: uint
{
}

[GenerateOneOf]
public abstract partial class Union_55bc44f0fac94121880bafa5c548346d: OneOfBase<string, uint>
{
}

public abstract class Type_82ea8c86c6b448fe8d690dddaf3418fb: LuaPermissionGroup
{
}

public abstract class Type_855dd4192f6c44ffa8b0efe6417e047a: string
{
}

public abstract class Type_418906f2cbdc4701a7b999148581653b: bool
{
}

public abstract class Type_3cdab8f32928439994b0151155b3812e: uint
{
}

public abstract class Type_9158fa731556423783d5c1f3e0e0b676: bool
{
}

public abstract class Type_310577bd631e41be89117a4d0bfaa4db: LuaItemStack
{
}

public abstract class Type_a07ed786951447a4a4213e644a2b70b5: LuaEntity
{
}

public abstract class Type_a8d60df52911434d84ff81b871600c9c: Color
{
}

public abstract class Type_1b52068a9dc048488ab0fbba8042f78a: Color
{
}

public abstract class Type_f15c2bafcf434618860b940c5ad99774: bool
{
}

public abstract class Type_c994df956e8243868f04fa4e98bb3a82: ControllersEnum
{
}

public abstract class Type_625b75d6cbd94a22a88070850bff710e: bool
{
}

public abstract class Type_00c8caef6bce436da030d586ae7ef8f8: LuaEntity
{
}

public abstract class Type_70414ed879d94ffab06cb537d510301e: DisplayResolution
{
}

public abstract class Type_04c6c7f8b5e14f9b962538e57b6869af: double
{
}

public abstract class Type_7c18bb05a2c649d1a6c15dbe2c9e58be: DragTarget
{
}

public abstract class Type_143fd66619a1491297ca7ab30f9ce80c: LuaEntity
{
}

public abstract class Type_ccaa07ebaaad4d448d2e9eddf15913bd: GameViewSettings
{
}

public abstract class Type_82acb1f513e444648736705fdea9b32a: LuaGui
{
}

public abstract class Type_f036ef84288d4060971c8e1fadc8b334: ItemStackLocation
{
}

public abstract class Type_c71e141e6614471dbcdd0051831ebba9: uint
{
}

public abstract class Type_7850e75caa204b1c801cf4d34d2b529e: InfinityInventoryFilter
{
}

public abstract class Type_d35d3f7cd07f4321bd1438b258f387cc: List<InfinityInventoryFilter>
{
}

public abstract class Type_597def611ab846d79326d0ad38fb9e54: InputMethodEnum
{
}

public abstract class Type_7301b24c98ef4e8dac1ce5d7c7ec0215: uint
{
}

public abstract class Type_9223dc4eedaf413990bcbe5207ecc9c3: MapViewSettings
{
}

public abstract class Type_1b06a79e4b214727909494933df329a0: bool
{
}

public abstract class Type_db0dc46d70254325aa12b6b61fd5343f: string
{
}

public abstract class Type_604b742bc1e94854abed47faab550bdd: ModSetting
{
}

public abstract class Type_2855fe8d52714c3a911a93fd56ae68b5: LuaCustomTable<string, ModSetting>
{
}

public abstract class Type_3b591f5956c24a8d9fb1f93a09eea87c: string
{
}

public abstract class Type_9245ea9cd61745d3ae6d7d2f206f9e60: string
{
}

public abstract class Type_011e975c9e6247788aef8dcc538f4d1e: uint
{
}

public abstract class Type_9a3cedbb60e34d889beaae5945c5923d: bool
{
}

public abstract class Type_ab43391216bf43d5952c5b1d79a22997: LuaPermissionGroup
{
}

public abstract class Type_3a9a132f68034423ae9530683911a9ba: bool
{
}

public abstract class Type_9ec2f7902838420c802568d439a5101e: RenderModeEnum
{
}

public abstract class Type_9d33ea2a4cc847058cf8de241bed0f12: bool
{
}

public abstract class Type_acc1f40a68b24aeeaa9ea6c7307954fe: bool
{
}

public abstract class Type_becc51b8e9e64e13ab06421a5c00e941: ControllersEnum
{
}

public abstract class Type_19a5c39a727a4fe89d229324167befa3: string
{
}

public abstract class Type_b87c56ea808c45308d1a442be7a5953e: uint
{
}

public abstract class Type_a6fa80f0f44f4096bc34ee1e4a906458: bool
{
}

public abstract class Type_334b844b8533430b9469f80dd742d1b8: double
{
}

public abstract class Type_1e2b7edcfff745eb8243a92ba09d1a5f: LuaEntity
{
}

public abstract class Type_790fc337f49444008a0419dace720236: AlertTypeEnum
{
}

public abstract class Type_6c44b8957c9e41f2a3a9fb070b8fb23c: LuaEntity
{
}

public abstract class Type_47661a272fb74b018516c6bdb6dd1930: SignalID
{
}

public abstract class Type_cb3fe7a2429f43f29aaffa85938c569a: LocalisedString
{
}

public abstract class Type_9118f701887944f9875299886af124bd: bool
{
}

public abstract class Type_a758e249b5b24017a4ffd5715a6c7bdd: string
{
}

public abstract class Type_cf08b178e0ff449cb12c4d8f7ca35faa: LuaItemStack
{
}

public abstract class Type_9343f3c504814104b363dcc5ed914284: LuaEntity
{
}

public abstract class Type_6111ce34f7f3434b85ccd3121fac4fc6: bool
{
}

public abstract class Type_080c6699407848fe8b55b2ba5d94194c: DirectionEnum
{
}

public abstract class Type_df7e1f88f4d94712a33cefdcce8d30f9: MapPosition
{
}

public abstract class Type_53ad7627e734406683a7b38857cb6406: bool
{
}

public abstract class Type_4f387f2c05d54147ad3edb6d2f66a55a: uint
{
}

public abstract class Type_2c0becdfb99143dea75cc63479aebc04: bool
{
}

public abstract class Type_405eaee67f224bd6a1afb59aa4dc95ce: DirectionEnum
{
}

public abstract class Type_66ddda5d66c743b79f20f7b5f79470ea: MapPosition
{
}

public abstract class Type_425bd2d1f10b4fee833b6c539e9c2e26: bool
{
}

public abstract class Type_b3b9d547081d45ed89a2a587e52581be: uint
{
}

public abstract class Type_facb84e162324fe090481494c7f11504: bool
{
}

public abstract class Type_72ad975370af43e29fea48673d7124d6: DirectionEnum
{
}

public abstract class Type_f069f8ba85ef41ec9693497aa3c3f233: string
{
}

public abstract class Type_bcdf35a6c1334420ad301a35f0590d83: MapPosition
{
}

public abstract class Type_131e8d4609b5481e963d2be4616028b6: bool
{
}

public abstract class Type_9ec97f6203a248d7a1ca9f8343ed4304: bool
{
}

public abstract class Type_a2e9b457cb7e48bd90085991fb0f173e: string
{
}

public abstract class Type_5020120313d74fe4bee78ce1ccccbe9b: LocalisedString
{
}

public abstract class Type_844d4e1aae3a46599d7d0b60fca4c284: LocalisedString
{
}

public abstract class Type_69634a2149224a1bbf51782a4d55232e: string
{
}

public abstract class Type_ca3dd204615041748e86e1f47b4501d1: string
{
}

public abstract class Type_87204f5d0abc40cd874918041278cc74: bool
{
}

public abstract class Type_bfd4f75854bb469486efdd00ff841e38: Color
{
}

public abstract class Type_6694e79f96c94998ae322c12bba09a85: bool
{
}

public abstract class Type_d8f639871f254c99ab1cac2f8eb371d1: MapPosition
{
}

public abstract class Type_67c767577d4047d291373be8a95674b2: double
{
}

public abstract class Type_08cabdd56588449fb95e3deb81d77673: LocalisedString
{
}

public abstract class Type_e9113c270f9a47e0b68b68f7d82b20a2: uint
{
}

public abstract class Type_c7d352a01dd246beba5f0fabc3e59f2f: AlertTypeEnum
{
}

public abstract class Type_49368d618c574a439dbbb0197c4550be: bool
{
}

public abstract class Type_15f393b2dce249bdba4fb07e6d0fe83a: LuaEntity
{
}

public abstract class Type_f592ea961919409987443912a1d6618e: MapPosition
{
}

public abstract class Type_74ddf55e12ff47b0bb320db87ae7a6f8: bool
{
}

public abstract class Type_7c087ed4c41b48d79ade29d75a8484ef: AlertTypeEnum
{
}

public abstract class Type_b2d1d2edeb4145e8931d351d47a20db7: bool
{
}

public abstract class Type_f42962d1987d418e99dddd8d3e79f949: uint
{
}

public abstract class Type_a1fb31369b624bd38af73bfa812cc16d: byte
{
}

public abstract class Type_22e6ea30b8114787b0f36f49223eacf1: LuaEntity
{
}

public abstract class Type_520265d0968140dba2abc3800e8cf624: MapPosition
{
}

public abstract class Type_c8f6f03104db41fd843d6c966749f582: LuaEntityPrototype
{
}

public abstract class Type_57bd1fa92e154f9ca215b0a7f72d827c: SurfaceIdentification
{
}

public abstract class Type_f6bd3a64b8524b25b6e5825408725fc3: AlertTypeEnum
{
}

public abstract class Type_a4dcaf5a3e6747e580c23f72cd9df10a: uint
{
}

public abstract class Type_ba70bc80ee984fe2b921b63cdacd761a: AlertTypeEnum
{
}

public abstract class Type_a5e7578507374f23b7af1b9bda5460b7: Alert
{
}

public abstract class Type_1df1b5b62dc04e059555372b516a1cfc: List<Alert>
{
}

public abstract class Type_2724213ac08e424bb2a8a2515a1613bb: Dictionary<AlertTypeEnum, List<Alert>>
{
}

public abstract class Type_ad720b7eadb44da5ad8635de8cdda884: Dictionary<uint, Dictionary<AlertTypeEnum, List<Alert>>>
{
}

public abstract class Type_f2ca4b841e52440bbfb40f0493ca6f50: LuaEntity
{
}

public abstract class Type_d0a4ae1f22924f2cb03cd8faf5b55b4e: List<LuaEntity>
{
}

public abstract class Type_cab8a565bcbf4cfa93d7052e26c4d3d2: LocalisedString
{
}

public abstract class Type_1cd29acefacd44009f303c8348b06bba: uint
{
}

public abstract class Type_6ee9389343624a7bb31bb07fd821def8: InfinityInventoryFilter
{
}

public abstract class Type_5a3de492d95c4904b996e942d569517e: uint
{
}

public abstract class Type_86f4f65773224a8aaa9194c4ee554ae5: LuaItemPrototype
{
}

public abstract class Type_ff44ce43687a4ba5a38f87612db24d2f: string
{
}

public abstract class Type_45baae9414674de494d69481a24f4333: AlertTypeEnum
{
}

public abstract class Type_7cea037c7a2f42cfbeaed08bc2744cc4: bool
{
}

public abstract class Type_cc0e3348aa404364a53c79cc95bb4e4d: AlertTypeEnum
{
}

public abstract class Type_a29b0d267801483392c1f4be48a48191: bool
{
}

public abstract class Type_508d33e795e74ceca56bf7d20399eb0a: string
{
}

public abstract class Type_8cace2aaba7f4f51acc706bfa30e4c08: bool
{
}

public abstract class Type_bcc5e953c0ed40f2b6a0b872e19320e8: string
{
}

public abstract class Type_1f03192730404276ae2190a3920b35ac: bool
{
}

public abstract class Type_01614ab238444b7c955e41d366bd5c0a: uint
{
}

public abstract class Type_9e64b1f775fb4894b588e6a4ad54d2eb: AlertTypeEnum
{
}

public abstract class Type_0b861d43b37b45ecba51e6f3e4091c4e: bool
{
}

public abstract class Type_822bda763c934d498463d50850479c60: LuaEntity
{
}

public abstract class Type_c3cf1125c1e44d2ab38ad111a71c6cb1: MapPosition
{
}

public abstract class Type_994397e033f54d1499b2a7a11cd6d610: double
{
}

public abstract class Type_15c116b9f4b349dd8d2915015626f899: string
{
}

public abstract class Type_66034d025dc54078b81c0e729caf7239: LuaEntity
{
}

public abstract class Type_dbf7d9229c3f41ae9876b2363588907d: LuaEntityPrototype
{
}

[GenerateOneOf]
public abstract partial class Union_53e3902d90034156ab036eba6dfbd86e: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

public abstract class Type_4f86b13fe9be41bab9ef3fd3b072e717: bool
{
}

public abstract class Type_557a07f85ab54bc5b38cee8e430c938f: SoundType
{
}

public abstract class Type_0ec25ee7952346038bbde7f54e29c227: SoundPath
{
}

public abstract class Type_8d883a139d5f4257ba7807719d4c756a: MapPosition
{
}

public abstract class Type_161f5920c98c4e54a42df939e036fc41: double
{
}

public abstract class Type_7587494b872a44dc895780569c61fd18: LocalisedString
{
}

public abstract class Type_8778a8c45b2b4b94bd034d49f12fb99c: Color
{
}

public abstract class Type_5eae80c0ed3a45e89b3cde360da31064: PrintSettings
{
}

[GenerateOneOf]
public abstract partial class Union_d7cfb3a9284c4843aec1b0547086e94f: OneOfBase<Color, PrintSettings>
{
}

public abstract class Type_e38542091c2240a49d515cf5d0b64791: string
{
}

public abstract class Type_1ea5f7cba78e444a9fae39611dbfcbbc: List<string>
{
}

public abstract class Type_1b0db79e42bd4df3acab2d87a7b80288: LuaEntity
{
}

public abstract class Type_38b80890137d4a64a31b81acbd264b1e: SignalID
{
}

public abstract class Type_fa5263b455124fae9d46db4f4b50b1b2: LocalisedString
{
}

public abstract class Type_14a478994e3f4b68acc66bcd2360fd07: MapPosition
{
}

public abstract class Type_a293505184044bd08d45bc1c0df65c92: LuaEntityPrototype
{
}

public abstract class Type_64f19289a2a24ca1af42146727739b2d: string
{
}

[GenerateOneOf]
public abstract partial class Union_104b2ee6377045cd9f27bde5be629bb3: OneOfBase<LuaEntityPrototype, string>
{
}

public abstract class Type_d12a1dc4b7534040b474af97a725ee1b: SurfaceIdentification
{
}

public abstract class Type_8d8f545c4b284cdba5ec1e08e4aefa11: AlertTypeEnum
{
}

public abstract class Type_f749304ab0ff49beb0c700337bb16308: LocalisedString
{
}

public abstract class Type_8de670938a674b99a8279483a8789f94: uint
{
}

public abstract class Type_457366b1c3294165aa81cdd374b83016: LocalisedString
{
}

public abstract class Type_16b734f3dfd14a3fa95360a43d0dc066: List<LocalisedString>
{
}

public abstract class Type_769d0362214f4af4a025e223c833a4ca: uint
{
}

public abstract class Type_d6813c301bfc4e5299b25671277240cb: List<uint>
{
}

public abstract class Type_75e929ec41b34ca88dd03f462f5689f4: uint
{
}

public abstract class Type_da654cb6675a42cc858f8cb7e4c5ee03: uint
{
}

public abstract class Type_6708e6ee54a74caaa0319b4bbb2061a5: LuaEntity
{
}

public abstract class Type_d97e5d596038402b978651763c1650c4: double
{
}

public abstract class Type_917b95bafec543848e18866080eb4179: uint
{
}

public abstract class Type_6e3f30cd7de54a1290bc5abd7d12ca76: MapPosition
{
}

public abstract class Type_3f40d208dc31440ea4369a87f5d37b28: double
{
}

public abstract class Type_97a71b673cc24300b41b44c44d3e166b: ControllersEnum
{
}

public abstract class Type_d107769d1377400484f9e2363209a970: CutsceneWaypoint
{
}

public abstract class Type_3aba2e1b47014ece8c38e4f6d66981e6: string
{
}

public abstract class Type_d7a146e1c909415e8820d938f9806916: LocalisedString
{
}

public abstract class Type_b1620bc89d6e436eb1d36bc3b8c8ba83: bool
{
}

public abstract class Type_c27996571ee74033b7295b8a2829871c: LocalisedString
{
}

public abstract class Type_a6c952db75154e81ac05caf20770e05e: InfinityInventoryFilter
{
}

public abstract class Type_aedcca07af824377af12d32731c0b06b: LuaNil
{
}

[GenerateOneOf]
public abstract partial class Union_6a59246041ed4349aa415510d829376c: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

public abstract class Type_d4a6d4f776ab4145b316dba3ab8ba457: uint
{
}

public abstract class Type_aba5267c19d8496fbf191b867072aa48: string
{
}

public abstract class Type_761ce12618724b12aa627ddd620f3dd3: LuaItemPrototype
{
}

public abstract class Type_cf150cb2ec624ce7b1c6502d1fcec621: LuaItemStack
{
}

[GenerateOneOf]
public abstract partial class Union_6c3297ecbb834fca8ce2f2f19028a023: OneOfBase<string, LuaItemPrototype, LuaItemStack>
{
}

public abstract class Type_e827ce44921044ca8be031ed6cbca540: uint
{
}

public abstract class Type_0b537312a7da421b9fc531967fd6c779: bool
{
}

public abstract class Type_3e2b9025dc4f4739ae5fae1b1da5f6e6: string
{
}

public abstract class Type_f7a88157445a4adf9f7509da32d2cb92: string
{
}

public abstract class Type_4ae2174901ea44628fc673da885ea28e: bool
{
}

public abstract class Type_f3972ede6c74438396915ef93ec51b2e: MapPosition
{
}

public abstract class Type_7aa2fb486587486e94639444d93dcb66: string
{
}

public abstract class Type_83d187e846cb44ac8bf4e020455f8495: string
{
}

public abstract class Type_e28151cfd19e440d80da9abd0e894e5f: AlertTypeEnum
{
}

public abstract class Type_b88fc177b55a488aa0efdf9d7cf3cc24: bool
{
}

public abstract class Type_c59be55781174addb997020fa96c7754: MapPosition
{
}

public abstract class Type_656792bdb14a4d6485f0379a1542488b: LuaEntity
{
}

public abstract class Type_bd0eb167be524ca88adb9da77a38bc5b: MapPosition
{
}

public abstract class Type_6f81ca98330745aebe60aac379b24d8d: double
{
}

public abstract class Type_0a2ea744bcf449e3bc315ceb277658b2: string
{
}

public abstract class Type_51779bfe9d49423f9d475078e88e9577: bool
{
}

public abstract class Type_1f462479f2e6437980dcd37a3c360ce8: LuaProfiler
{
}

public abstract class Type_d85fdfa815194e6ba73fa560e757cb42: double
{
}

public abstract class Type_2fec7cb9b37c438596491265eda8a08c: string
{
}

public abstract class Type_80b268cebbd94e3691d89ccc87b3d6f4: CircuitConditionDefinition
{
}

public abstract class Type_ff0ce512ef55488987749ebdd9621e05: ProgrammableSpeakerCircuitParameters
{
}

public abstract class Type_6830dd7788c742c8b041940da459340a: string
{
}

public abstract class Type_21837005b1f240e89c345a8c50ccf3cb: bool
{
}

public abstract class Type_6826ebbe000d4fdfb6614d8915e51895: string
{
}

public abstract class Type_97dd54ef4dc542128be4d8290e3d8c0d: string
{
}

public abstract class Type_4db306eb18e24d2c8d2d994067e353ca: LocalisedString
{
}

public abstract class Type_6cadc57e33d248f69b83eb44d460a2e1: SignalID
{
}

public abstract class Type_1f6de3557b7c420bb9ffc28e4ea3b8e0: SignalID
{
}

public abstract class Type_881f1eec68f84f07a1604212d5ade8ea: string
{
}

public abstract class Type_1e71d617791e40d3a8e2a8515cf5d09c: SignalID
{
}

public abstract class Type_7c1bbf1154dc4a10a2707f7961960ed1: SignalID
{
}

public abstract class Type_11c9dba7f39f4901b450bc0609ea5cc4: bool
{
}

public abstract class Type_dea41e3a02d44c07af65d98c235b8d9c: string
{
}

public abstract class Type_d8473ae656ec4ceb95fbcae4919f0d5d: uint
{
}

public abstract class Type_08871840cdd84a169c484ef81f9a4339: bool
{
}

public abstract class Type_4b3152c2f62e4215a9f0a39405351ed0: string
{
}

public abstract class Type_c392a82106e0426a9945523894d799b6: uint
{
}

public abstract class Type_ee2faee09af04104b986dae19e3a193b: LuaEntity
{
}

public abstract class Type_2453071e926542b7a187942edfe2b590: LuaCustomTable<uint, LuaEntity>
{
}

public abstract class Type_e0ec1cc7bb0b421699fa443db5bf883d: uint
{
}

public abstract class Type_28dadfa9ad11402b8c60dddfb8f8808e: double
{
}

public abstract class Type_f82b74d8a238451b89bbe652f0cc2e6b: double
{
}

public abstract class Type_d927f7baaa2a4b5ba6caea9a26fa1e89: bool
{
}

public abstract class Type_5f6dd8478a8a4e29b8858bd5134471a0: string
{
}

public abstract class Type_f77019ff917c40feb9d5c6b6af2d9640: CircuitConditionDefinition
{
}

public abstract class Type_d1fd4ccb1ce44739ac4fa396bbdb5e49: bool
{
}

public abstract class Type_674a3ebeeff245cdb4ae62cd9cd9a847: SignalID
{
}

public abstract class Type_c2e2bf5cc83a453698ef156ce7c1de0c: string
{
}

public abstract class Type_9eb54141b2b84bbda4487c95f01550d0: SignalID
{
}

public abstract class Type_ffa06cfbb9a3466ebc28d121a4e3c3a4: bool
{
}

public abstract class Type_dc211a56b1514fe0b491f1a578b536a1: SignalID
{
}

public abstract class Type_b159ecbb56b24587a436ccb98f2b79f5: bool
{
}

public abstract class Type_d9e66d317dad40449304f938c9b5bef8: string
{
}

public abstract class Type_8d4fe28a357f4d21bb413fc300acc715: string
{
}

public abstract class Type_892aec8020ed44b183fa47794049f8f4: bool
{
}

public abstract class Type_445f0e6a4bf749afb6faa19d14d9054c: string
{
}

public abstract class Type_dba228c948644707a2b7bd35016f666b: uint
{
}

public abstract class Type_8a740c69075c4ae284aef8c8c9c05b0b: string
{
}

public abstract class Type_30acac06db0846b98b63757eea9b303a: bool
{
}

public abstract class Type_e2e3ec0cd3c540229b9870d805312c89: double
{
}

public abstract class Type_2253bc46f8a645acb3f7494add8ef052: LuaForce
{
}

public abstract class Type_79993a74be1e4feea9b180e42f7b8f7c: LuaGroup
{
}

public abstract class Type_bcbafe703dd6447e83d783f0e46997c3: bool
{
}

public abstract class Type_a77e8c8662244e4c9205cda4991c936f: bool
{
}

public abstract class Type_a2d9834ceb7b4fb8ac43b3249af0cc6e: Ingredient
{
}

public abstract class Type_7301857ee56c4a3f993c22dd338e5a06: List<Ingredient>
{
}

public abstract class Type_3cf8f6504ba343b5b4911501bc962883: LocalisedString
{
}

public abstract class Type_273efa18d30446529becbdbea647327a: LocalisedString
{
}

public abstract class Type_0368db3de3014749bf8931bc38801dc0: string
{
}

public abstract class Type_189280b025f74a7dbb6870667e2a03f7: string
{
}

public abstract class Type_ceddf03aa679423bbd6f1a2ab5ee17de: string
{
}

public abstract class Type_91bc022318f74441b2d27a9968e7ab22: Product
{
}

public abstract class Type_5c4864eb6c714fa792fdc78eda444604: List<Product>
{
}

public abstract class Type_c6f1d5f5153448d5b54cb082b97050e4: LuaRecipePrototype
{
}

public abstract class Type_db6606a921554ff4bd3b4b0257689c42: LuaGroup
{
}

public abstract class Type_89330fff52bc443a86c4bf11e0cce1e0: bool
{
}

public abstract class Type_ae2a614eac324831827ff4a605868dfb: string
{
}

public abstract class Type_efa8da4fddac4042a317b857380639ea: LocalisedString
{
}

public abstract class Type_5d14bfd1114f46db92e1d5c969d0b86c: LocalisedString
{
}

public abstract class Type_792589dcdb2f487ba1115963fe671acd: string
{
}

public abstract class Type_5e1890247d0540b9b703c5974f2c6b75: string
{
}

public abstract class Type_d4d18155b5c84669866c7e8e4b22b669: string
{
}

public abstract class Type_4f15af52e9384373bc1705d0c2de7fab: bool
{
}

public abstract class Type_4905453e7d6942e6ab4c9814cd7de8e3: string
{
}

public abstract class Type_9a3aa6c1bfa048158548c25fb096515d: bool
{
}

public abstract class Type_28504b43cb734a70ab207c5bdfff4cee: bool
{
}

public abstract class Type_49322f0559274acb998af297f6c24e02: bool
{
}

public abstract class Type_2d0b3b48040740f5905e2013a039adae: bool
{
}

public abstract class Type_85abb529a7044e4a929cb2df962b5f0b: bool
{
}

public abstract class Type_f749417eb0b446b7a6513ab4dcdb8992: bool
{
}

public abstract class Type_3bf787f2741b4fc7b9e503e9b6d55c0a: string
{
}

public abstract class Type_bb0fadc87abf428f8b933b525023e8e1: double
{
}

public abstract class Type_7251f8b61a23400b9be6a4a9bde9641c: bool
{
}

public abstract class Type_b52b768459814e16b7c51e68359b1e71: double
{
}

public abstract class Type_9ea8d282c73b4d29acc25503aa83b3bb: LuaGroup
{
}

public abstract class Type_e9d05edb929e4ba59f37bf7e589c6307: bool
{
}

public abstract class Type_247dbd75905747a09e38957b59b9232e: bool
{
}

public abstract class Type_a08ad069d5f849a2ba9b41207ee61357: bool
{
}

public abstract class Type_90e49e09ecb54be6af48fa700667829b: Ingredient
{
}

public abstract class Type_cdf4d780526649b684f878677278e36f: List<Ingredient>
{
}

public abstract class Type_1384189e4788408696a0b78801fe831a: LocalisedString
{
}

public abstract class Type_0faa021f9d4b4884973063ebc716de20: LocalisedString
{
}

public abstract class Type_f357c6f91fe84086a993dc59e8e3f3d9: Product
{
}

public abstract class Type_34435e7f32f2438da6f8fd1e50b6e5c1: string
{
}

public abstract class Type_cad4ba11339342d191e9750a5af96908: string
{
}

public abstract class Type_edba1842fdaf47f7ab6897ba2e60b5bd: string
{
}

public abstract class Type_3b085d1a6b744644afe1e08235ffd43e: uint
{
}

public abstract class Type_524e978986ca41bbbdcd509fa0fa506e: Product
{
}

public abstract class Type_138b8f7cce074acd90144d2750cd318a: List<Product>
{
}

public abstract class Type_57e3ab373a1f4974a3a50aa290e75f00: uint
{
}

public abstract class Type_adcdabe22aaa4a92be9566906ee2c70f: bool
{
}

public abstract class Type_a8ba85e0f44848109afc463d0f857a72: LuaGroup
{
}

public abstract class Type_3f41f5c7939e470cae268f9562a67d8b: bool
{
}

public abstract class Type_9fe6906051b24b0897f418371de9087e: bool
{
}

public abstract class Type_015c779c9f8d4bbdaa00692f01bfa26b: string
{
}

public abstract class Type_fda12fea50924c89806ffc23a60afcca: string
{
}

public abstract class Type_3a987befc1cc4ce28c040feb02df1440: string
{
}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_c106db243c744eca9eb79ad5771808e9
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

public abstract class Type_47b6884b17554a6aba404b5ec7dfc205: Dictionary<string, Literal_c106db243c744eca9eb79ad5771808e9>
{
}

public abstract class Type_9f5e7a91b29c4afbb814e06bb1023ca1: Dictionary<string, Dictionary<string, Literal_c106db243c744eca9eb79ad5771808e9>>
{
}

public abstract class Type_ed00585a31de4b25aa37532bdc328528: string
{
}

public abstract class Type_b344f121579e49e9b45bf11315e3d1be: string
{
}

public abstract class Type_ce4bf1dfa1144f688c5c764691b6a3f2: Action
{
}

public abstract class Type_23e2f8e13f7f495eadff9a990e580d73: Dictionary<string, Action>
{
}

public abstract class Type_4691aa7af0c74d2ea983512f1cc6db9e: string
{
}

public abstract class Type_03de1a3509304d5c82ebbf9eebb1a51e: string
{
}

public abstract class Type_3a81f8bdc7c44cd5915d8b783f4635bf: string
{
}

public abstract class Type_a532a14779294b6bba479952d95f123b: Any
{
}

public abstract class Type_6c8cbbc1432f4997a79b696a6a5f0aeb: string
{
}

public abstract class Type_1f6e437c13bf4dd6bb7856fa7b4b7041: bool
{
}

public abstract class Type_0a0ef298a5484381b2fe9d00abe752b8: string
{
}

public abstract class Type_546b281c98d546da87d36f1cddbce44f: ulong
{
}

public abstract class Type_9e9c6b0f8cdc43aea44f35ea9f23b406: string
{
}

public abstract class Type_d18095e1a464457aaeab4c63b4a12d1a: ulong
{
}

public abstract class Type_a8f2da25cf5041d29332de5750b17185: string
{
}

public abstract class Type_71fc8436c32549a5a79525490d33f64d: double
{
}

public abstract class Type_82c3da878a014480875444a54c76410f: double
{
}

public abstract class Type_9f107a7be2b7415594c5c9bb3cd000ad: ForceIdentification
{
}

public abstract class Type_be712e69f8ea4854a885ce20d5ea1f66: List<ForceIdentification>
{
}

public abstract class Type_ee43e53189534420b55ad036c99a6d69: bool
{
}

public abstract class Type_531ddf5d44b54762932a4399107a616d: RealOrientation
{
}

public abstract class Type_7852776188b942aa8ccc569981518e06: MapPosition
{
}

public abstract class Type_679630b0c328425390e13549267bf815: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_cbf7db66d28e459398f38f3ee8c9fd62: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_221ec1580cb547f4bff88bdbb96af502: Vector
{
}

public abstract class Type_938380a311a448008204b2a74ec13e47: Vector
{
}

public abstract class Type_8d4cd33892cd42b3a16b14da0f259ddd: PlayerIdentification
{
}

public abstract class Type_39cc4707b33945b1913f85906c65d62f: List<PlayerIdentification>
{
}

public abstract class Type_6280a6573e5340c3ad1d6117b40741a8: RenderLayer
{
}

public abstract class Type_ac0626cae57548febee5744b16442b4f: SurfaceIdentification
{
}

public abstract class Type_024ab85a1df644609b8e95f06577aaa7: MapPosition
{
}

public abstract class Type_cdf04abff4b24412be44a1a47bd64482: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_8cbec1b4728d41efb0dc333b0dfa383d: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_63fe4e35f692459492929bdd38da6c88: Vector
{
}

public abstract class Type_36467259a5c24ea2aa8477343e21333d: uint
{
}

public abstract class Type_a75a9a922b2e44418cc2b305ee4026ce: Color
{
}

public abstract class Type_b646c3a9244e45cfa55529c8b2867316: bool
{
}

public abstract class Type_f4578b0f9ed94380b9c66930824a52ef: bool
{
}

public abstract class Type_5009837bf6994bcd8b0b83f81a725c0b: double
{
}

public abstract class Type_03dae6a2fb754e22904d08bffadb0634: double
{
}

public abstract class Type_9ab7ae84d73049b59755bde2862ef845: ulong
{
}

public abstract class Type_261608d273f144e499670114a8f0a93f: float
{
}

public abstract class Type_3a99f319a4dd45a59f0e7379bd1c8a50: Color
{
}

public abstract class Type_03286ccd834e496185459fe78c050686: bool
{
}

public abstract class Type_a9f77089fd7941339ffa62f2a2114f6f: ForceIdentification
{
}

public abstract class Type_e82bbd58b60b4b62b6bdd5db1c08b0e9: List<ForceIdentification>
{
}

public abstract class Type_caf99414a4174a918e6253246ce378df: double
{
}

public abstract class Type_9056f2103d014bc39a58e243b9cdbe1a: double
{
}

public abstract class Type_a8819e6d04b64932a8d3b4b74a844a82: bool
{
}

public abstract class Type_42787fe83e6b4b789a4d1ef15fd6678e: PlayerIdentification
{
}

public abstract class Type_f7402b4bfca347c59827514ff2a1e39a: List<PlayerIdentification>
{
}

public abstract class Type_367291aee7be495295b3e6fa367e4ec8: float
{
}

public abstract class Type_7c4c8dd87b3d4d1b8327639371eae7d9: SurfaceIdentification
{
}

public abstract class Type_416997c5b7114387a524b5a87e915a1b: MapPosition
{
}

public abstract class Type_095990f663e34ac98a0bb7584200a058: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_38ad3b7811af440d941391ab60531382: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_220d33c3ca95400d99ac8d157dc97109: Vector
{
}

public abstract class Type_f33b614bc49b4c6ab90560c74f73b831: uint
{
}

public abstract class Type_7805f5bb74c14ef6ae2511df00ed6cb3: bool
{
}

public abstract class Type_301311806fea4badaf5e0baae1d65996: ulong
{
}

public abstract class Type_a6dcca321869444fbb974fc66eb4a3c2: Color
{
}

public abstract class Type_d4fac29762854744befa80d3c05c56a8: bool
{
}

public abstract class Type_d62c3db10cb940f896b61129ad82cf52: bool
{
}

public abstract class Type_fedf92609ee14d23ac2c4e56761c62a7: ForceIdentification
{
}

public abstract class Type_20946f7a4b7642f2a7a04d02457da464: List<ForceIdentification>
{
}

public abstract class Type_64015634caab4269bf9fd4aef5ff0196: bool
{
}

public abstract class Type_d2364baaa1e54fef97c8e905ea2881bc: PlayerIdentification
{
}

public abstract class Type_516028a1c35f4b4992d09f42986b2eb0: List<PlayerIdentification>
{
}

public abstract class Type_e95b87fb2acb4809a10c17e069fa946d: double
{
}

public abstract class Type_df98dca68b8b4604adcf85cac4f23a77: SurfaceIdentification
{
}

public abstract class Type_77a7f08375d342feb95a1d28d897de97: MapPosition
{
}

public abstract class Type_60e20572dcbd46968a86ebc2f73f85af: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_944d6da0d6ca4dbbac26010eceb4a047: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_cfa644cd705448e8b5ae5f928fe5ea33: Vector
{
}

public abstract class Type_ba4ae5da281e42b790946623a0f9ad13: uint
{
}

public abstract class Type_50a453bad7da4ab8828fbcca8433bc3e: bool
{
}

public abstract class Type_d9ec73535a5b4eec970ee3a16a15c197: float
{
}

public abstract class Type_25cd2125153a4f13bccc59bfd2aac6f8: ulong
{
}

public abstract class Type_41536faf28e143c9aab59a8b3bb1dfe1: Color
{
}

public abstract class Type_19baf4d4b9d04766a0c24ed08666e1ad: ForceIdentification
{
}

public abstract class Type_ab3ea6005fad4515b809d09000ed6e6b: List<ForceIdentification>
{
}

public abstract class Type_9657245a04a648e988a023955a477bfa: float
{
}

public abstract class Type_a79c73c2613a47e1ad36b678024e1522: float
{
}

public abstract class Type_16d05bdaafae427fa82a366996dd76dd: bool
{
}

public abstract class Type_84fa86efc06a42e9a2d0299c05b4bd92: RealOrientation
{
}

public abstract class Type_9db71c5481654323b305c2d1c9693b97: bool
{
}

public abstract class Type_5f5fdd83be84466c8d26de2bd6bab6f4: PlayerIdentification
{
}

public abstract class Type_7363327ae525470c8cec7a1eb04d73df: List<PlayerIdentification>
{
}

public abstract class Type_45b3323a75564336a59c3770122146df: float
{
}

public abstract class Type_a7f41ab92db04868a61fe668d7b3ca58: SpritePath
{
}

public abstract class Type_7063f1e8b77749edbbad5d8253598fb1: SurfaceIdentification
{
}

public abstract class Type_420e6375bfd54da094718f494862dd96: MapPosition
{
}

public abstract class Type_c2c4498abcd24e798c08cdfab9223e47: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_766dcead259240e6921aae30283a5270: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_7e62390ebbd149bcb3fdf8e569b0341b: Vector
{
}

public abstract class Type_5133ce5c12fa471db10f18c632f2777b: uint
{
}

public abstract class Type_31c0ce58baf34d1ca6eba54e178e2f56: bool
{
}

public abstract class Type_36ce684005b4461daab97003a04e384b: ulong
{
}

public abstract class Type_1d87586ea43244cfa97e7318d003e124: Color
{
}

public abstract class Type_a5dac17be3934c10bfbe397bdcb4d597: double
{
}

public abstract class Type_782c84baca9f452994ce9179e2e989b8: double
{
}

public abstract class Type_e01d4fb769894220baf5e02cb3c730e6: bool
{
}

public abstract class Type_57af687996304ed694f35b63fdbe23fa: ForceIdentification
{
}

public abstract class Type_306affa6d8ca4ee5aa349de1c0b6ca7b: List<ForceIdentification>
{
}

public abstract class Type_71f8332dad184c2cb68032c9937ae45a: MapPosition
{
}

public abstract class Type_df93814088e5421a99a51cacb4e583fb: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_2cb91e8150654d16a833ed3ec07c82b7: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_eae5e1716bf44dbebf884b0bc3fe1f50: Vector
{
}

public abstract class Type_c401f82ecb3049c5910df5ef24593934: double
{
}

public abstract class Type_9d27e5c6679d4825a01a4873cfdf8050: bool
{
}

public abstract class Type_6a546e866f3c4b7ca1da26968c567127: PlayerIdentification
{
}

public abstract class Type_7245b5a38e0e435ab9397b5cda32d096: List<PlayerIdentification>
{
}

public abstract class Type_37395301f692433b83c8dc8a29915ad2: SurfaceIdentification
{
}

public abstract class Type_1843c254c7454abdb1d0d5bb03c9fd8e: uint
{
}

public abstract class Type_7b04b3aa3a504ee5a97b77939802144a: MapPosition
{
}

public abstract class Type_e2329b2bb21f4c4498286087822a8b23: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_5fbdb2aa781c4451b704d3aafbe87e9c: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_ba86d48238144a7694605d4e8914283d: Vector
{
}

public abstract class Type_519097797ba74b9ca42cedf1fc4c7cf9: bool
{
}

public abstract class Type_3fecbb4b622a43d8ba0431db092a291b: float
{
}

public abstract class Type_d26ebe4b1a594ea5a903fc1efc2094f9: ulong
{
}

public abstract class Type_1e78b4cc930b44009bc33c04bdef21cf: Color
{
}

public abstract class Type_2821e0ae514b457c8030c1f82fc1a50f: bool
{
}

public abstract class Type_7a8c0f1446674aa884b4f2eb6227b453: ForceIdentification
{
}

public abstract class Type_3415bd29d1a649d1af6243dd84eb413f: List<ForceIdentification>
{
}

public abstract class Type_5e194a18220c462f823ff354702d49bf: bool
{
}

public abstract class Type_677fbc10ecff4bfab1e8fb5dd90cfe36: RealOrientation
{
}

public abstract class Type_9ad318b7af074a859a83d31fadbad347: MapPosition
{
}

public abstract class Type_2c78d4e0114647db9aa1e0447e6c5eb0: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_8ab54b7bc73e4272836c92fa4c61a324: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_f21d46dd0d2a451a891553ca93702bfa: Vector
{
}

public abstract class Type_9ba0f3a2693e437a90a3f70974b66710: PlayerIdentification
{
}

public abstract class Type_5718da2705924ea6989d5cea2f52f68b: List<PlayerIdentification>
{
}

public abstract class Type_be2b227b6f2e49b7ae2129bfe5b5b40b: SurfaceIdentification
{
}

public abstract class Type_a608fcfc679647789fb7d78464b21821: MapPosition
{
}

public abstract class Type_37c534371f86408e87ed9a31f0cb3089: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_6fcb98f727a64a9ebfa507cea91f08c6: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_34edab0454094d419bf6941c07161371: Vector
{
}

public abstract class Type_ee43e4f2f1364572bc407b0675564058: uint
{
}

public abstract class Type_14f2e86f6916449595fbb7577dd8cc76: bool
{
}

public abstract class Type_f190ad2076864045863c874397d12e30: ScriptRenderVertexTarget
{
}

public abstract class Type_fb386993478748d4a31d47ec67c5e36d: List<ScriptRenderVertexTarget>
{
}

public abstract class Type_3bbec3ac0c0344629e48323198b74563: bool
{
}

public abstract class Type_aa4258434780421c9bd80980d18c3229: ulong
{
}

public abstract class Type_b4ba2a03692948db85c1434181fbd3d1: Color
{
}

public abstract class Type_e19491ffa5484103b5135ccdd6e7549d: bool
{
}

public abstract class Type_a7b117f6ecd24ec5b276c07e9430c586: bool
{
}

public abstract class Type_2188a47d9b254d08aedf8a364a0cc0b9: ForceIdentification
{
}

public abstract class Type_90073376be294655862d80a229198c02: List<ForceIdentification>
{
}

public abstract class Type_62faeab118494160bc38ecce1cabdd61: MapPosition
{
}

public abstract class Type_c4c72a326bc94155b7cb31f6afcc95d3: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_e3bf8f443fb74a8ab202497efaed4f2b: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_012d6f34ad1d4aba844a1d38abaa8d3a: Vector
{
}

public abstract class Type_6699687bab4a4234a2710625620a0d37: bool
{
}

public abstract class Type_ad7bdcb0f32a49f8af011244e5532c9d: PlayerIdentification
{
}

public abstract class Type_97c9cd83da8c4b2e92f7ed43284aa133: List<PlayerIdentification>
{
}

public abstract class Type_c615f3ab0f55440ebd0551131c16653d: MapPosition
{
}

public abstract class Type_d52ccac98a4a492b90edf4073e449df4: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_bcabc664e3b643979aa3fee022981b98: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_8af44b648d634be3ad4b6a605f7e0a9a: Vector
{
}

public abstract class Type_8052005b4dcc4dd9b86d522ca92ebff7: SurfaceIdentification
{
}

public abstract class Type_04ba299f1af2405899e8bd24dcbbfb58: uint
{
}

public abstract class Type_f7f1a924214e4ab98c33084201bc2cda: bool
{
}

public abstract class Type_3c72320aa5304497aff5745e2208524c: float
{
}

public abstract class Type_d42c63e828f2418192640a7649ed74d9: ulong
{
}

public abstract class Type_5c4fb7dbb218421bb86b5eedf45acc25: ForceIdentification
{
}

public abstract class Type_3630397684ce4110b85d9bb4b683f4f1: List<ForceIdentification>
{
}

public abstract class Type_25cf04e2f2c24151b4774ac4465227ad: bool
{
}

public abstract class Type_708ec77e784741f8a7968f21b0ded8a6: RealOrientation
{
}

public abstract class Type_92572f8ebabc43938e93394f62a0f474: MapPosition
{
}

public abstract class Type_99f4c853e8cd4f4da1cab5c638e0a1d7: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_425e58e82fbb48e8a60a3c93a4fd2888: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_25f668d9741048d49ac859a5aeb22584: Vector
{
}

public abstract class Type_5eecd663e8b14196ab0183364651fbe6: Vector
{
}

public abstract class Type_0b10649ceb014b869a72cf48dd75a5d1: PlayerIdentification
{
}

public abstract class Type_472eb023d69549aea74801a54886aede: List<PlayerIdentification>
{
}

public abstract class Type_da59f79029a246caa04588a5d4ba97e8: RenderLayer
{
}

public abstract class Type_9845c42c1a594cd59bbfbd18384f2aa2: SpritePath
{
}

public abstract class Type_707bd7b38be9413faa9e3d780211856a: SurfaceIdentification
{
}

public abstract class Type_37b700eea6d34b2199faefbed3007bfd: MapPosition
{
}

public abstract class Type_9ebd385deb0b4cd1bbb9b665f4cd5ccf: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_39ff54966f974ff18ad858e2d7fc4a70: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_4097c55046d84a1e80b8607664d72641: Vector
{
}

public abstract class Type_b705ce7a60e1459ab5cc06275379377a: uint
{
}

public abstract class Type_bac3c23482c74b3a8235a9d7d5dcf2d0: Color
{
}

public abstract class Type_0957b2d098d14f15b151a750710b9794: bool
{
}

public abstract class Type_da6357f3e63a4325aee7905429fa11f9: bool
{
}

public abstract class Type_a66d18cd028a42fdab27265a324f34d5: double
{
}

public abstract class Type_c727fbf740c64058a1c73beddfaf327e: double
{
}

public abstract class Type_4f32318b654149198cb79b1f8ffcf40f: ulong
{
}

public abstract class Type_28d7708f0a4d4f3da2e7ac5beb6a12f2: TextAlign
{
}

public abstract class Type_a15c910fcc404e07877d0b5cf0b4681b: Color
{
}

public abstract class Type_119b0873f4e3409192b310c55430fc22: bool
{
}

public abstract class Type_5fcc213f808b46e3a9e6789f86662277: string
{
}

public abstract class Type_ceab11bf3456489da032caaefa52e098: ForceIdentification
{
}

public abstract class Type_6474d6723b2943088cfad3dbac1f1605: List<ForceIdentification>
{
}

public abstract class Type_c629c28edcd94587a30836ec44e743c2: bool
{
}

public abstract class Type_5268b388ecd3497d8dcaeb7c8da51c77: RealOrientation
{
}

public abstract class Type_3d2629f23c5a4cf4ab7ace9a41ecee14: PlayerIdentification
{
}

public abstract class Type_7525c2afba43426c8276df983d5d022f: List<PlayerIdentification>
{
}

public abstract class Type_85ac89f801dc45c69e4f1936eab1635e: double
{
}

public abstract class Type_e52b64bb4a7c49f6a40a9612243044f0: bool
{
}

public abstract class Type_45088a591b3742edb9d6ce18903cccb1: SurfaceIdentification
{
}

public abstract class Type_790b3edc5492430cba85688a536846bc: MapPosition
{
}

public abstract class Type_408be845268b4dca9186fed7c537733d: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_507025f80ff34e5db31b0efa5f73455b: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_80e847ff40cd4716891be2b9fafbc78d: Vector
{
}

public abstract class Type_a29a992d60ce413da9b4f5b099546085: LocalisedString
{
}

public abstract class Type_e67a14fb8a5f45848361fe0f617c9d3c: uint
{
}

public abstract class Type_c0b6e9d97a0346bda58c6376e0c11b80: bool
{
}

public abstract class Type_87441040dd4246e9ac83e96f7906134a: VerticalTextAlign
{
}

public abstract class Type_1bd30cce1b104b0d972cbc626f1b0112: bool
{
}

public abstract class Type_2f1cbfc914504ea483f93660a1798df2: ulong
{
}

public abstract class Type_5da69d403d7448388ea97ef0834eca49: ulong
{
}

public abstract class Type_6d544f121d6f420781435313e83aa5e8: TextAlign
{
}

public abstract class Type_7d5a4f924a4a4b388d435cf3883c138c: string
{
}

public abstract class Type_e022993525fd414b9a21a289bbf93aed: ulong
{
}

public abstract class Type_7cd28cb5f0c749299c5c697614a1d183: List<ulong>
{
}

public abstract class Type_84fb8f354d7f41f3b35d3bc595527097: ulong
{
}

public abstract class Type_bb4adc066e514972b36c63509075dd87: float
{
}

public abstract class Type_65ec33f9cb5241f3a7e49d679c7339b8: ulong
{
}

public abstract class Type_1c2766827afb43b3a4b741a82d0920bb: string
{
}

public abstract class Type_32005ac48f574882a4dd7e846bc8eb38: ulong
{
}

public abstract class Type_9471c0aa5e17448ba26e8b77454af509: double
{
}

public abstract class Type_b34cc046f0474b6f935416d9e7d066d2: ulong
{
}

public abstract class Type_037c8bf356534602b12652d7ad47f6d6: double
{
}

public abstract class Type_29492b34897c452a8ce91ff465d034a5: ulong
{
}

public abstract class Type_729895d24e05495e9714de443e36d101: Color
{
}

public abstract class Type_a189e6b30e084907ab668c6a0bad6710: ulong
{
}

public abstract class Type_9d570f48958f4794825784fac877994a: double
{
}

public abstract class Type_2c04c7ea95b24b2daeb9cb17c6a3a076: ulong
{
}

public abstract class Type_e244738538db470dba45f502202bc2e3: bool
{
}

public abstract class Type_27c54c61dfd64e3faccba6c61496dad8: ulong
{
}

public abstract class Type_fd11028f76c94ed7b7abe0617437d42f: bool
{
}

public abstract class Type_566e778c12064f00a957db896da55444: ulong
{
}

public abstract class Type_60b2414427c1427fb4bf0a80ba9299f7: string
{
}

public abstract class Type_a7b9f41396854f2ba125199373b5fedc: ulong
{
}

public abstract class Type_23dcc1aef00b48c5aa3adda0f371c995: LuaForce
{
}

public abstract class Type_f824553aad0d4131b532cb7cef83e6d1: List<LuaForce>
{
}

public abstract class Type_5ce30de0189848ce8a8cb7a209b74b85: ulong
{
}

public abstract class Type_7041ae5f470b4eb1899c8fc72d1cd3e4: ScriptRenderTarget
{
}

public abstract class Type_4aa804d5781e4cd5b74f9ed7566c45ec: ulong
{
}

public abstract class Type_196fddda2a194764a05828489c2475d1: double
{
}

public abstract class Type_07c2b9e5f90146e19d865e9b79f338d1: ulong
{
}

public abstract class Type_fb1351e98f3a468e8d9a341474e982ce: float
{
}

public abstract class Type_e7ea6d37fd6b41c0b0eafe26f063715a: ulong
{
}

public abstract class Type_60d81b90ef284dbd936ddf5de8dde293: ScriptRenderTarget
{
}

public abstract class Type_ea7a02777d674aad8e30ee5cca376c22: ulong
{
}

public abstract class Type_826b07c24a4f44e1b86c6f7eda12c68d: double
{
}

public abstract class Type_e09dc8af999e4c4eaab85a757de0300b: ulong
{
}

public abstract class Type_526b0c99283c44f49e11559678318586: double
{
}

public abstract class Type_51a17ca5030f4fb4badb6416c08ea2b8: ulong
{
}

public abstract class Type_d5ff05fe4b344b5b97673d65c1fa18c1: float
{
}

public abstract class Type_7230535803e04f8bae1177a1ce1c8ea6: ulong
{
}

public abstract class Type_ce022e24f39840b8856f288888a83496: bool
{
}

public abstract class Type_32f41d906660481381fe18ef777ba767: ulong
{
}

public abstract class Type_9f03dc16e3f94186b4af54886fe1ea32: RealOrientation
{
}

public abstract class Type_a75a50bcc0004755af84f8f956d16ccb: ulong
{
}

public abstract class Type_c67b53d41a6e46e198f02cde0999c763: ScriptRenderTarget
{
}

public abstract class Type_3ff917146ee14326a579854bdd5ac2d6: ulong
{
}

public abstract class Type_4025eccef95e4f948f47ce5ce5e2d128: bool
{
}

public abstract class Type_358118b680de43459f57d599a514d1c3: ulong
{
}

public abstract class Type_fa2b8d696f0f46148873f9baac5b0a05: Vector
{
}

public abstract class Type_627762c338fd40ba8707ad899c9bc775: ulong
{
}

public abstract class Type_f0162032c3164b5a91ec8b195e9e2724: LuaPlayer
{
}

public abstract class Type_f9df6fa5237046d5a8f4254ec8160f54: List<LuaPlayer>
{
}

public abstract class Type_7d38eb724473460f8c2b972648e95d7d: ulong
{
}

public abstract class Type_50f7dee7dfdd48c085b1e346ab639711: double
{
}

public abstract class Type_73e787294d9740e7a85c57ff2c83b146: ulong
{
}

public abstract class Type_9402e009c0db4b088d4a37f8ffbded00: RenderLayer
{
}

public abstract class Type_42d911df5b9a4c389c8217761024fddb: ulong
{
}

public abstract class Type_a6cd789ffb7148f3a0654996d209d65c: ScriptRenderTarget
{
}

public abstract class Type_f8570909cdef450ca3b6d0c6b159a64f: ulong
{
}

public abstract class Type_9567ddd563e8445ab031b6eb4924ad72: double
{
}

public abstract class Type_664ec49807a24472bb78db78635c9c26: ulong
{
}

public abstract class Type_5f7ee8c71cf64813b6a7d48eada4b1d0: bool
{
}

public abstract class Type_479e736caab64991bec7a09aff000f48: ulong
{
}

public abstract class Type_28459a996e994c57b0975d3404aeb16b: SpritePath
{
}

public abstract class Type_5a2d3117b62644498b14077e32a55df5: ulong
{
}

public abstract class Type_ad551a202fb640c48dd36277e20140a6: float
{
}

public abstract class Type_49c62e97f04142c8baf85ee5cff9257b: ulong
{
}

public abstract class Type_dfd93d1dfa394b1580f84f6487a3a96a: LuaSurface
{
}

public abstract class Type_48557a29f7654da6b154e3dd0eb02080: ulong
{
}

public abstract class Type_9b579df0ce9a4a55ae6d84003556f739: ScriptRenderTarget
{
}

public abstract class Type_7617742a91ba4c3eb59978c47d12e8f1: ulong
{
}

public abstract class Type_e73a1717e17b4faf8ba2d4afc8814350: LocalisedString
{
}

public abstract class Type_091946b5fd904d78b0ee6f6f2e2ab443: ulong
{
}

public abstract class Type_6deff2e9ece04aad94a84a76e36481bc: uint
{
}

public abstract class Type_0fcbff1c3f3e489581d0205ee5c02a6e: ulong
{
}

public abstract class Type_88ba24e991164c769c378ec9777b7398: ScriptRenderTarget
{
}

public abstract class Type_4f350d70560b4dc7b63680ad716dac7a: ulong
{
}

/// <summary>
/// Union of literals:
///   - text
///   - line
///   - circle
///   - rectangle
///   - arc
///   - polygon
///   - sprite
///   - light
///   - animation
/// </summary>
public enum Literals_589c217040b148a8a3e5570933f4f6a9
{
  /// <summary>
  /// Literal value: text
  /// </summary>
  [FactorioRconDefinitionValue("text")]
  Text,

  /// <summary>
  /// Literal value: line
  /// </summary>
  [FactorioRconDefinitionValue("line")]
  Line,

  /// <summary>
  /// Literal value: circle
  /// </summary>
  [FactorioRconDefinitionValue("circle")]
  Circle,

  /// <summary>
  /// Literal value: rectangle
  /// </summary>
  [FactorioRconDefinitionValue("rectangle")]
  Rectangle,

  /// <summary>
  /// Literal value: arc
  /// </summary>
  [FactorioRconDefinitionValue("arc")]
  Arc,

  /// <summary>
  /// Literal value: polygon
  /// </summary>
  [FactorioRconDefinitionValue("polygon")]
  Polygon,

  /// <summary>
  /// Literal value: sprite
  /// </summary>
  [FactorioRconDefinitionValue("sprite")]
  Sprite,

  /// <summary>
  /// Literal value: light
  /// </summary>
  [FactorioRconDefinitionValue("light")]
  Light,

  /// <summary>
  /// Literal value: animation
  /// </summary>
  [FactorioRconDefinitionValue("animation")]
  Animation,

}

public abstract class Type_5c694bcdbce340fb86c637ec60a59fb7: ulong
{
}

public abstract class Type_6d6c75dff5c440ef91add390904b8619: bool
{
}

public abstract class Type_b1f0a205c6434654b0bcc525b5f613b6: ulong
{
}

public abstract class Type_950ca04e10214cca934ed7e732cdb733: bool
{
}

public abstract class Type_d4b514bc263c4cfb840a6aabe4b8df39: ulong
{
}

public abstract class Type_c5ef2f1cc8674628b1da9f468722c74c: VerticalTextAlign
{
}

public abstract class Type_4e9086c8504c499b8d3d7bd0c7ce46b5: ulong
{
}

public abstract class Type_749e47398c944952ab2c35095dbff019: ScriptRenderTarget
{
}

public abstract class Type_51f4030133be44149651125ca5545cc0: List<ScriptRenderTarget>
{
}

public abstract class Type_577739df82a247ada39cd1ef6db24709: ulong
{
}

public abstract class Type_6aa8d04eb14a40f896480f57be353ace: bool
{
}

public abstract class Type_3116755276eb4c27a76b22974d9a3bde: ulong
{
}

public abstract class Type_2a250fb74ff144538f48bb828f0ee0ee: float
{
}

public abstract class Type_9628af44c9be4c5981b75e45c79f3ad4: ulong
{
}

public abstract class Type_3de9b09c477b44bbb486f29566589181: double
{
}

public abstract class Type_42391a80a6aa4a119e3308f7ed10e78f: ulong
{
}

public abstract class Type_bf4400d62cab43218f47bba904a00ffc: double
{
}

public abstract class Type_a8ccdb2d37fa4c4b9b21e9ab6a269958: string
{
}

public abstract class Type_d82450594555441cb1421582f743fc0f: bool
{
}

public abstract class Type_8b3803f0b43540a29e07fae04d34a861: ulong
{
}

public abstract class Type_cfd21271ebb24842806279a70184d6b5: bool
{
}

public abstract class Type_4ebb84f581c44a70b10cdbaecd583528: TextAlign
{
}

public abstract class Type_cb6b7998a4d14ed3b6e6a021acbdc59c: ulong
{
}

public abstract class Type_b916753e29fc4dd8a79eeb4c7a9cc00b: float
{
}

public abstract class Type_41d841f783504936a0c4ecdc984aa864: ulong
{
}

public abstract class Type_4a3f23b50636453fada730de0fe741f9: string
{
}

public abstract class Type_d0d6c805e26b44298294f77eab93c708: ulong
{
}

public abstract class Type_c626ca373a1049609d50a4508dc8cdc4: double
{
}

public abstract class Type_711fa4c93fff4a7c9a032b190ba6e9a0: ulong
{
}

public abstract class Type_5d52ff271df940c5a0a8db1847863a21: double
{
}

public abstract class Type_1fa004073ec9487f99310c6f0ec2d5c8: ulong
{
}

public abstract class Type_cee8c2cf0bfb416b9e59b45441c71bd2: Color
{
}

public abstract class Type_872a43347dba4d90b829b21fbe506cd7: ulong
{
}

public abstract class Type_eae72eac0ed748b7b8bf61aed176e101: ulong
{
}

public abstract class Type_31abdc8b51c64d61a78c2ab9de5bcf6a: MapPosition
{
}

public abstract class Type_8cd5d9c5668b418985e118dd5329fee9: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_3b26b4581f044f9b83463a170ac7dd54: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_1507590a30924c90a41133596647f453: Vector
{
}

public abstract class Type_49d644a72f6a4085929d57db65c4484f: MapPosition
{
}

public abstract class Type_7b12c44502494560a69440b44ce5d24b: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_f65f0dbee7f44fbcae03cbc93e6e4b6d: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_cdcb184ae90a426892694f86f7434b98: Vector
{
}

public abstract class Type_7544a12998294d07bc5f488332527e7c: double
{
}

public abstract class Type_eff36df9d9864610a07d19ee23f0908c: ulong
{
}

public abstract class Type_5d953a07b8b54ac9917f261c0428292d: double
{
}

public abstract class Type_615864c79d8740d18349b7ccd50d817a: double
{
}

public abstract class Type_dd96888ca6b14c22b3170427ce48325b: ulong
{
}

public abstract class Type_aaf38ab34a784e68b4543d2ed8fd6826: bool
{
}

public abstract class Type_6a19dd1b822747f8ba9fab7eb4ebdcb6: ulong
{
}

public abstract class Type_fb946f225ac242608e7afafff1d92da4: bool
{
}

public abstract class Type_8bdb622e119f4c43b1755e3987a1370b: ulong
{
}

public abstract class Type_3a81c77c67db4b0a8f6200843fe4e9a8: string
{
}

public abstract class Type_6205ce2ac45a41f2bb689bff94e0d519: ulong
{
}

public abstract class Type_61a6bcce34aa4977ab13eb735152338f: ForceIdentification
{
}

public abstract class Type_5719c4b62ae347a4a1e76c34d0820a3b: List<ForceIdentification>
{
}

public abstract class Type_cd0fc0f61f4d4a8d9552050fedb27f9d: ulong
{
}

public abstract class Type_081c80a6541141a7b80bbc42034e3751: MapPosition
{
}

public abstract class Type_a583c664172143e38f008a54d42a905a: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_10ca1e587617419196108b490f6977ef: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_2b40e77038d44e789190f07a7eb839b5: Vector
{
}

public abstract class Type_4b94ab595cbc4a3b9c10ab7cc99cc1ae: ulong
{
}

public abstract class Type_2af3b7c3c80e41c2ac2e9970feccf38b: double
{
}

public abstract class Type_627e67efe73f4804941694b06f0326f5: ulong
{
}

public abstract class Type_4da5d147c9be48b9a3726d9b52a2452b: ulong
{
}

public abstract class Type_f42c93d99b9b460496c55335156e88d9: float
{
}

public abstract class Type_ae2f2c53f25c42b989d1b68bb1bba1c3: ulong
{
}

public abstract class Type_47f558201268476fb1019e9992940398: MapPosition
{
}

public abstract class Type_798cace100184f2ba15ddd1813f1f9dc: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_4de6b6b42e6e4b44b0f131a026540f6e: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_2049646fb09647c08a6e9ebb898a211f: Vector
{
}

public abstract class Type_b20e205d1f744c14aacf4a3f916584a1: ulong
{
}

public abstract class Type_6b45c542008448b8b1a5e9b2376063ea: double
{
}

public abstract class Type_1403d542631044bf88c6a17bc1f9fbe9: ulong
{
}

public abstract class Type_4801a68d42b24bf7a45b31c9060a17de: double
{
}

public abstract class Type_3abda1f0c6ca4a2d8868205309980c57: ulong
{
}

public abstract class Type_b2f09dd1b49a465fb6443530c0352171: float
{
}

public abstract class Type_4aa2b9a8dd7e4460bde2e24b4f08cec9: ulong
{
}

public abstract class Type_c92c333b62924da4a15c18dd1964b60e: bool
{
}

public abstract class Type_25612494e1d9459b846ad1bcc267506d: ulong
{
}

public abstract class Type_9ccded0e0f3f47d9b8847632b5d80dab: RealOrientation
{
}

public abstract class Type_c70a4b635faf4defad74cccfe1bdcb7c: ulong
{
}

public abstract class Type_db3852d7ef1c4647abea22882355a7b4: MapPosition
{
}

public abstract class Type_d401f106a81d45a188aee8c8b1fb12a3: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_94ccc26e20344ebb9194aaf17eab78ce: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_a9203cfd7fae49a7b3384c99565521b3: Vector
{
}

public abstract class Type_354db849c6b74d41bb5b7e15e21fc1bd: ulong
{
}

public abstract class Type_1405decaf35d415ebf9a6ef62955164a: bool
{
}

public abstract class Type_f0208618587f4369a565571dcd10f885: ulong
{
}

public abstract class Type_09532004ac5e4c5ebf72e66320adbaa1: Vector
{
}

public abstract class Type_48f3d41e01a84a5eb6ab356394d6b1f7: ulong
{
}

public abstract class Type_f48535a900a543949c2f56cf8a7a2982: PlayerIdentification
{
}

public abstract class Type_63218ec7ba824172a0669326b4f1b3e9: List<PlayerIdentification>
{
}

public abstract class Type_318547b01dba42a6a12c4813feb3b44d: ulong
{
}

public abstract class Type_b5587e115b3f4b19a6ef204d4b368af6: double
{
}

public abstract class Type_f4e6fa7b806f45c7a4e164fe0f1fe94a: ulong
{
}

public abstract class Type_13e92518c12b4e9bbb603e722d62fb84: RenderLayer
{
}

public abstract class Type_30a9f25be8e444369f92b95ed0d0a956: ulong
{
}

public abstract class Type_afeac3e70e91449595a737bf6d58dab7: MapPosition
{
}

public abstract class Type_ad92daa3ace945f0ba33c9e1057cc4f7: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_6c05cabc5a324563999f74f5e3e1754e: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_bd450cdb9ca9447386fe688a6dad3cd5: Vector
{
}

public abstract class Type_57dbe03a67a349948cefd9c7ceb4aba2: ulong
{
}

public abstract class Type_c175e17389a946da8262416255c26799: double
{
}

public abstract class Type_785fb0e708cb44b2b2e13bc569a0bb3c: ulong
{
}

public abstract class Type_72958a5e609941c1abd0ae1306f0bb45: bool
{
}

public abstract class Type_d85ae193c7b74bbaad33e31ba225cc25: ulong
{
}

public abstract class Type_e53b129097e14b74b4185c9cdfbee231: SpritePath
{
}

public abstract class Type_932be8e63acb48968a374fb964db1800: ulong
{
}

public abstract class Type_40be41648133408c9471f6beb8e1d58c: float
{
}

public abstract class Type_fd1d93856ca94dfbb726b2047c65f47e: ulong
{
}

public abstract class Type_50ec00a224ae4ab7881bfee85d2d6963: MapPosition
{
}

public abstract class Type_4cf8599c634342ea82f05bd49d28f67b: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_eac7ca54d8274bb3ae1835e588041efb: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_5f49595ff56e4e5882c02aa7cd6fe15f: Vector
{
}

public abstract class Type_a7414cb17e254829b2fdfd1e2c621071: ulong
{
}

public abstract class Type_e6932a4ae4d441eb89023e56648e6b8c: LocalisedString
{
}

public abstract class Type_9d2f5783139d4e0399853b73eb639f63: ulong
{
}

public abstract class Type_14a5a320aa93446a8f5c7b0e6371c7ec: uint
{
}

public abstract class Type_ae9c2b1ef5dd46a284d669afef99a02a: ulong
{
}

public abstract class Type_8eca8be2b0664c9790ff0bdac12c84da: MapPosition
{
}

public abstract class Type_8cc9b1d0585f42e180b2d3b881be7b63: LuaEntity
{
}

[GenerateOneOf]
public abstract partial class Union_c3f86330f2164b02952bc329874486fe: OneOfBase<MapPosition, LuaEntity>
{
}

public abstract class Type_a765d2217fda400d9e61f9f500a76506: Vector
{
}

public abstract class Type_b21f06504a004b04952b86aa8fa599de: ulong
{
}

public abstract class Type_a705c5c609e0432d888a0c42eb689c98: bool
{
}

public abstract class Type_1a9236cfb6c84d76a6233c49cfca5466: ulong
{
}

public abstract class Type_7155dbf16c724b25b0c66cc7d8bac63c: bool
{
}

public abstract class Type_d218d135d52b4989baf79fc23a3a178b: VerticalTextAlign
{
}

public abstract class Type_d859c02d5f9c466c943ac39f8432cddb: ulong
{
}

public abstract class Type_25559329f6ce48eca43f197c3468a8b5: ulong
{
}

public abstract class Type_6558c1254a604ed4b3f4253d9796d020: ScriptRenderVertexTarget
{
}

public abstract class Type_72f4b29509884da99936bd19028c5a90: List<ScriptRenderVertexTarget>
{
}

public abstract class Type_8534258c8c4348d19ccfcf967bee3fc4: ulong
{
}

public abstract class Type_3adc9c5ba8e0458199004f0d78e044f7: bool
{
}

public abstract class Type_06d68337979742929c242874e30d9296: ulong
{
}

public abstract class Type_b1b628ba71a6429e9b7f6b77dc100fd7: float
{
}

public abstract class Type_a7469e80248a4dd38483b73fac415197: ulong
{
}

public abstract class Type_401ac90b7d1c49748843d119658933a0: double
{
}

public abstract class Type_e4b28214c82a40f9a8f5cc9aa8a298ed: ulong
{
}

public abstract class Type_d9bceb28567840cf8608e8110e3e3652: double
{
}

public abstract class Type_d986d19a04624fb7b7abf001e522e890: LocalisedString
{
}

public abstract class Type_652aaea4f2924732a3d95d0be90bbf2b: LocalisedString
{
}

public abstract class Type_069384efb715458eb21b21e6b32bb7fb: string
{
}

public abstract class Type_d66a380df0994708a1d15114b30db612: string
{
}

public abstract class Type_f47654fa38aa4d68991741791782f8ff: string
{
}

public abstract class Type_f70d242906d849c1be44b5b8a115dc10: bool
{
}

public abstract class Type_c4d472b6d1894f25b1b410e0a771f1df: string
{
}

public abstract class Type_9a4140cc73474e378160e3569a06bdd7: SignalID
{
}

public abstract class Type_f3785db3d80744f79b742c3c963f028d: SignalID
{
}

public abstract class Type_775d669b4e514abc8e49cc8fc7872490: string
{
}

public abstract class Type_75d8b6b38f9d4001bdc1ecb2a62f655f: bool
{
}

public abstract class Type_85d7bb3b89ce41a79d7612a83b9688f5: bool
{
}

public abstract class Type_2647d7388fa54a9ea2c21a398b47931b: SignalID
{
}

public abstract class Type_d6a80685e1ae424480a2590ca9a505ba: SignalID
{
}

public abstract class Type_c8dbe58ffb5a488a916f99d8d38b0bd2: bool
{
}

public abstract class Type_b88ddfd169ad4fe69e2f5af255999eb7: string
{
}

public abstract class Type_d8349f2fda57487c9a60b4d5c0fb2dfd: string
{
}

public abstract class Type_bc332127fd7b42928f7af79a3f27e0c0: ModSetting
{
}

public abstract class Type_0af16f9ce3be4a73ba3d4cb689088268: LuaCustomTable<string, ModSetting>
{
}

public abstract class Type_dcce9f77d4dc4d8b9591cc7809055ecf: string
{
}

public abstract class Type_006de689741f4883b18be1c1ce0aa314: string
{
}

public abstract class Type_1c4caa6b8bd5411d9979ad69ca4daf9f: ModSetting
{
}

public abstract class Type_f07adf389f7348058db577ea9f996156: LuaCustomTable<string, ModSetting>
{
}

public abstract class Type_36c6ea0315164487b005f22f08419e40: string
{
}

public abstract class Type_7475daded89340c8ac665f3c3bcec6e6: ModSetting
{
}

public abstract class Type_8f6aea39df8a40b5b53feb6fc7e4bf6f: LuaCustomTable<string, ModSetting>
{
}

public abstract class Type_0d1d531cbc364288abf2ed5e90f6c761: PlayerIdentification
{
}

public abstract class Type_2e70345135df4cc69326395e8ce210bc: string
{
}

public abstract class Type_becc2eb7a41647218d3efe5699489356: ModSetting
{
}

public abstract class Type_9f01f03d5e664e72903c1db944b0fe3e: LuaCustomTable<string, ModSetting>
{
}

public abstract class Type_2bdf1de1fafd4bdda4be0533afff60b9: string
{
}

public abstract class Type_dee73bc07360405da952171e13a03653: string
{
}

public abstract class Type_775fe51fe50446aaae324f2119fc5da9: LuaItemPrototype
{
}

public abstract class Type_3264972ea4444688a0289f82d34eac06: LocalisedString
{
}

public abstract class Type_57f4047a058d40508fe05e10f049132c: LocalisedString
{
}

public abstract class Type_a060925612654fbd90bd29e13bc6c14e: string
{
}

public abstract class Type_b47a2e935cc9412795c5dcb1f4834259: string
{
}

public abstract class Type_b7428b1fae714bda9527e7c43b036540: string
{
}

public abstract class Type_dba548d0c14a46e7946ced05fcb6f492: LuaTechnologyPrototype
{
}

public abstract class Type_b2fc58cb37b849d48fcc0722854a56d9: bool
{
}

public abstract class Type_90d45fe4ff074762aeb1a2ce34836a1c: bool
{
}

public abstract class Type_90c04ea7941d491598a07876e53c5057: string
{
}

public abstract class Type_f044623cf08b455bab44cd19d064bac1: string
{
}

public abstract class Type_9673754396c0493ea9c1010a0a7f3868: bool
{
}

public abstract class Type_ad57fac3739b40a29d66ab131e22628a: string
{
}

public abstract class Type_8e23be2248a142568566bc202d291035: string
{
}

public abstract class Type_677e688344a24070a5ad184c84bdb3b6: int
{
}

public abstract class Type_9386c24b84c24932b5d94771f7f86fc3: uint
{
}

public abstract class Type_108c686b243e4a50a24aeca7caa9d871: int
{
}

public abstract class Type_17ecfe8730fd4a57a00462b62d0331e4: int
{
}

public abstract class Type_9527e81973e74d0f87d655d4900c03c2: int
{
}

public abstract class Type_baa6808c37514984a44d9b48779e07d2: int
{
}

public abstract class Type_5223c02515db4f41b3d7e9582c82a0f3: Color
{
}

public abstract class Type_9c8bc5ed1d51412e83a6a9574b7c5526: int
{
}

public abstract class Type_a5b49aee08dd4451a5ab4b56020e43bf: Color
{
}

public abstract class Type_935574ee79b54ddfbc89e69ce0b1a0a7: uint
{
}

public abstract class Type_c8e86e2a4e3947f6abd787249ce08179: Alignment
{
}

public abstract class Type_0ce880e4b2354b799013d12ff5873bcb: LuaCustomTable<uint, Alignment>
{
}

public abstract class Type_3a790646b68841a4abe8c5a56ca86a73: Color
{
}

public abstract class Type_3f56275596db49de8e9f66049a3e8b1e: Color
{
}

public abstract class Type_93bc3148206846cd935fb1923fb50e06: Color
{
}

public abstract class Type_448ac5bf166846c2a5fb48379b95cfe1: bool
{
}

public abstract class Type_d70b341af9c649b99e2f30fadd1dc7ac: int
{
}

public abstract class Type_5c0d9631cee349a0ad2387d32e56492a: int
{
}

public abstract class Type_da70bbdacb754eccab142db7e640e7f2: int
{
}

public abstract class Type_28bf276dce9d45ecab8f99cf74f7c302: int
{
}

public abstract class Type_2eff0fad0d054a9fa59b656fcd1e6381: int
{
}

public abstract class Type_e1a13a05965c4cec846db995ebd3e848: int
{
}

public abstract class Type_9ba23321a0614829a75a64f2b621c978: List<int>
{
}

[GenerateOneOf]
public abstract partial class Union_3dd0c117f2c848b986deed3338d68f5c: OneOfBase<int, List<int>>
{
}

public abstract class Type_5fae452152a24dfd9f2d024275220164: int
{
}

public abstract class Type_3d39ce7c4f854c6b91cc75fb6ac78dbf: int
{
}

public abstract class Type_6dc707d9d573465cabb36527c0cba4b6: List<int>
{
}

[GenerateOneOf]
public abstract partial class Union_b0d9e1efa3a0499580dcae83c7e0f7fe: OneOfBase<int, List<int>>
{
}

public abstract class Type_e87d128e551244edb01805aae9480e94: int
{
}

public abstract class Type_afb119ebb0e745b28458e991cf9d1b32: int
{
}

public abstract class Type_82dc6eb63c994bc8b26f98cbb8e82aec: int
{
}

public abstract class Type_16d949aef12940bb977eedcab46341a0: int
{
}

public abstract class Type_905dd35f9cc84bc18de726425f218af1: string
{
}

public abstract class Type_cf7abea9131540dcb07bd1eac8fe0322: Color
{
}

public abstract class Type_dfdc473fca114ddc971af2cd196a76b1: LuaGui
{
}

public abstract class Type_3f653c73f4074dafb3878d9c82088006: int
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals_175557542ec54c62bbb80832e36e4374
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconDefinitionValue("center")]
  Center,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

public abstract class Type_4f6af48161e0426f86c9417d4eee97cb: int
{
}

public abstract class Type_3bf308dbcda7446f98480d70426d44b7: bool
{
}

public abstract class Type_0a51612c53a4426cb99a53b18ca6867d: bool
{
}

public abstract class Type_aae6d5395a7841b8a63a0881791b845f: Color
{
}

public abstract class Type_9ea27650ab874b14b5d51013639be61a: int
{
}

public abstract class Type_fc66008f91f74f7a9f0174e04ab5fbaa: int
{
}

public abstract class Type_f819226c2d8740c8b51824437612f4a7: int
{
}

public abstract class Type_84c666d851a3417a8ad7840d7f40d1ea: int
{
}

public abstract class Type_7dffadbb69b84b3b8a44828669a40160: int
{
}

public abstract class Type_bc64845117a64e4eb6a332a57b2544e8: List<int>
{
}

[GenerateOneOf]
public abstract partial class Union_b782a0b4770449a2af5d64086b975808: OneOfBase<int, List<int>>
{
}

public abstract class Type_f1974f84d1274544b3a4d685f9ac6020: int
{
}

public abstract class Type_5219a5e885074ce0a9f2f8e780254581: int
{
}

public abstract class Type_8dfebc629a4248f9bb7b3440bb9044dc: int
{
}

public abstract class Type_ad42dae115254e5d9a356ab5e71c7e8f: int
{
}

public abstract class Type_509693ac41ca49b09cfd9f18bb28a514: string
{
}

public abstract class Type_a9f3e7684dc741eeac7201de480f4e7d: int
{
}

public abstract class Type_562ef67e88ff4d48ad1eadfafcc1a8a3: int
{
}

public abstract class Type_8fda2cb14882478da15e1c4871b44947: string
{
}

public abstract class Type_4d396a646eb547329f5ecdb116bf5108: int
{
}

public abstract class Type_cdeb80b11c1a4221a1d30f865a8df53e: int
{
}

public abstract class Type_45fca13da9294c9f937b884b622eceeb: List<int>
{
}

[GenerateOneOf]
public abstract partial class Union_7da113533c2f4ac69c3fa92948c3e558: OneOfBase<int, List<int>>
{
}

public abstract class Type_2ba1c73713884b9aaee7f0c02e6ed723: Color
{
}

public abstract class Type_c058309c5bc049228602ce6eca865ab9: RichTextSettingEnum
{
}

public abstract class Type_27cd5a959b3b41f1af0ea032ab72886f: int
{
}

public abstract class Type_23e8064ecd97402d939791f27d5d1fda: int
{
}

public abstract class Type_f1441e944bf24335bad3cf5b4c7fe29d: int
{
}

public abstract class Type_d7595c2e447149d39784bbe7dc0f33f4: Color
{
}

public abstract class Type_ee2a8d927c7e4c20a62cd905d0cffc10: Color
{
}

public abstract class Type_c250fa684e774c60a4f95914b61c5857: Color
{
}

public abstract class Type_d593401c024a4f58ad9ce56e08cebfab: Color
{
}

public abstract class Type_ed44b21fc3cc4bb08f9d8d7bdc8ec717: bool
{
}

public abstract class Type_81a2020fc10e4d24a53fc04a9a3d51bc: int
{
}

public abstract class Type_f2989feab74443f888c551b3db651713: int
{
}

public abstract class Type_c52671d6329c444d8a1d0e675032c49c: List<int>
{
}

[GenerateOneOf]
public abstract partial class Union_2701cb3b716e4eec9d3b88903dc7b319: OneOfBase<int, List<int>>
{
}

public abstract class Type_b1220175c2a0465a96566487010d026a: bool
{
}

public abstract class Type_f664ac6ca0c4404a828221bddcff1452: Color
{
}

public abstract class Type_29950c0012c749ce9eb93990f5a483b8: int
{
}

public abstract class Type_04161fa97af647e9b6582aef71d25c95: int
{
}

public abstract class Type_409089252a73409d9d5536d2ddf2696e: int
{
}

public abstract class Type_cfdf2f60a0f34bffaa92c93962c90703: bool
{
}

public abstract class Type_eebffcae59c94082b085c38c3371475a: bool
{
}

/// <summary>
/// Union of literals:
///   - top
///   - center
///   - bottom
/// </summary>
public enum Literals_e4b417295a4c42aca2b5c3c483bc03a7
{
  /// <summary>
  /// Literal value: top
  /// </summary>
  [FactorioRconDefinitionValue("top")]
  Top,

  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconDefinitionValue("center")]
  Center,

  /// <summary>
  /// Literal value: bottom
  /// </summary>
  [FactorioRconDefinitionValue("bottom")]
  Bottom,

}

public abstract class Type_48643d53a0324976a6ea9310bda40ed5: int
{
}

public abstract class Type_67073e9288b74f45a419e4b95062edf3: bool
{
}

public abstract class Type_8faf19aff17d419e944b06b0bd7ce9dd: bool
{
}

public abstract class Type_c7db510d027e4914b7466ed844d1f979: int
{
}

public abstract class Type_00e0dfb8538f4a43a44207cd407b0e13: string
{
}

public abstract class Type_d4502c6b79d240d9b3e9e3e897ac77d3: bool
{
}

public abstract class Type_1efe20b1029a49e59b676086cdb7bc04: ColorModifier
{
}

public abstract class Type_17f3ccff70e444919e17d53f004d37b0: float
{
}

public abstract class Type_5337bd9378304df495a0d6a272830a8a: double
{
}

public abstract class Type_da235368aec84c83acea99963364a63f: double
{
}

public abstract class Type_b9351ebcca43477cbc720bbe1acd8389: double
{
}

public abstract class Type_4e94b76bf0b840f48affae919bbdae04: double
{
}

public abstract class Type_42ec8b239b364620a1db49d8806b2d57: bool
{
}

public abstract class Type_1c9434d0861345d8a16f0bedd93663f7: bool
{
}

public abstract class Type_9b3567d52d4b418cb540e90a8c249374: uint
{
}

public abstract class Type_7c10619025514e9096a491f97717f0ae: MapGenSettings
{
}

public abstract class Type_57dc045e4e2b47c5bf357ec267c69f6b: double
{
}

public abstract class Type_628d2aecd62449b2bfd67972dbe9b49b: double
{
}

public abstract class Type_0ad6c88d3d3e4bb0ae13ef7b96225b47: string
{
}

public abstract class Type_1e2a15037a534c64bdb24cf0c9d2abc2: string
{
}

public abstract class Type_0bd46394a7ac40b588eeed14cfbe707f: bool
{
}

public abstract class Type_a973c7a17d3241548dd3ef68569b04dc: bool
{
}

public abstract class Type_fc152d0f057948f7b7008052bb391509: double
{
}

public abstract class Type_c90a34dbabe94281b6e4c77d17cf9bfd: uint
{
}

public abstract class Type_ab44574ef144405cabfca269f04dc068: bool
{
}

public abstract class Type_fce31f8f3528432390cdb59c4858d8dd: RealOrientation
{
}

public abstract class Type_10d0c50b81d944288c0b7c2c989e0e67: double
{
}

public abstract class Type_1fa3934349c9410d9a454385eac7617d: double
{
}

public abstract class Type_71759b027aff4bec964d8c10596e4428: ScriptArea
{
}

public abstract class Type_361313cc0b8c4e68add8073c282d7aab: uint
{
}

public abstract class Type_32dac81e51a2407ca31545ebf82b73f8: ScriptPosition
{
}

public abstract class Type_8d8c89ad36364106b0e2218ec4bbb7db: uint
{
}

public abstract class Type_87991ebf93614fcf8e29455ece3ae324: BoundingBox
{
}

public abstract class Type_a2940338df2c4101a077ce06becf846a: ForceIdentification
{
}

public abstract class Type_b80e2750bfc1434fb245f26ab2df4868: MapPosition
{
}

public abstract class Type_befc832ccf5c4cea9994ad29cdb07cd2: uint
{
}

public abstract class Type_f9d705f02a81406da58ebf92ac55a12d: MapPosition
{
}

public abstract class Type_c1c36c0660a84ac8b703ce7c7bb2601d: List<MapPosition>
{
}

public abstract class Type_887191477f814bbfb3228033e91dff96: string
{
}

public abstract class Type_6c568ba6cf0348809bfc2b250c2f5871: List<string>
{
}

public abstract class Type_b391f313f17747a2b1bf0762d2c9bfe8: string
{
}

public abstract class Type_f0fe83deb1414146aa96f14ec3b0ae36: double
{
}

public abstract class Type_d5428706dbad45eaa0b8533099ed6816: List<double>
{
}

public abstract class Type_285715c91967461693c8e31d9f6b9282: Dictionary<string, List<double>>
{
}

public abstract class Type_527043c9588b46a39218afc35fc9a535: DirectionEnum
{
}

public abstract class Type_a7474ab220dd4323b294839491af4ded: ForceIdentification
{
}

public abstract class Type_90f77e53d9774b32876eb0ead100bb62: string
{
}

public abstract class Type_f5ce047f96fa4b71961b86d7ca2562fc: MapPosition
{
}

public abstract class Type_03194ca6fa524b018663b7a845ea6781: bool
{
}

public abstract class Type_e28a7502979949cd8e69e1a142322fd0: BuildCheckTypeEnum
{
}

public abstract class Type_95e88752ab544ae2ade2ece9d5b39b1b: DirectionEnum
{
}

public abstract class Type_026181d62b20430197bcf5263efd30a5: ForceIdentification
{
}

public abstract class Type_ac1d30fb8de744f3a4a02a12acc9f894: bool
{
}

public abstract class Type_664248a9020b420ba0764db2c693d5c4: string
{
}

public abstract class Type_0ab7401252c24563887fbd2569d10fe2: string
{
}

public abstract class Type_b522c52f56d348d98235ea50a8284dc5: MapPosition
{
}

public abstract class Type_49a8e91e82d642afade3a5333d8a4611: bool
{
}

public abstract class Type_9a53ff644a00421b8c89c298be131e35: BoundingBox
{
}

public abstract class Type_f85d99be65314302a3d53b0c9ddaf385: ForceIdentification
{
}

public abstract class Type_2a1ff460b6a6423aa6f4a6c01953adfe: LuaItemStack
{
}

public abstract class Type_8830489b475c45b6a95ea1751edcd80a: PlayerIdentification
{
}

public abstract class Type_d4dd3fa817c04b4bad9f6e7f63944f42: bool
{
}

public abstract class Type_e174589052f6427e9eab5097e3ee5a15: BoundingBox
{
}

public abstract class Type_211853cace694682b4d057829377ce87: ForceIdentification
{
}

public abstract class Type_1d9321a019eb41a6b8717bc4819ca027: LuaItemStack
{
}

public abstract class Type_f3d069e38ca942ca8c18d6d38eeb5cc0: PlayerIdentification
{
}

public abstract class Type_a7f8f99a49df49a59ee70f60f0d343b5: bool
{
}

public abstract class Type_354cd73e76024e3f8d3476b0c206d5ce: bool
{
}

public abstract class Type_6890a0d7ab8c4fd9b6fb79e9043a2fc2: bool
{
}

public abstract class Type_98c7b9ff442f49c3b647a4b6f4434c6a: bool
{
}

public abstract class Type_dc4b7930f51243e282b824680f59f898: bool
{
}

public abstract class Type_519d07975a854970a166b7310e2f9404: bool
{
}

public abstract class Type_f7d37f9fec0a4d3882124fb40ef70573: bool
{
}

public abstract class Type_295e445256704906b7cb8426bc62fa0c: bool
{
}

public abstract class Type_2faff8ba649a466aaf6fbf0e7002308f: BoundingBox
{
}

public abstract class Type_313e78779b784908aa3678ec9da8a2c1: ForceIdentification
{
}

public abstract class Type_96a86ab6e9ca41f5893cd073d042afff: SurfaceIdentification
{
}

public abstract class Type_bc2a638e4496409fb66ec0d6cc36029d: bool
{
}

public abstract class Type_6d4b52806d4045e6823388105cd6b83d: BoundingBox
{
}

public abstract class Type_03c95c8b4d554a53baa13664ed0ac7e9: bool
{
}

public abstract class Type_d54822cf3b8d440e90ea9e1a401751e1: bool
{
}

public abstract class Type_468ae9115ec54eb8819a803afcc1071a: bool
{
}

public abstract class Type_9ce29f275ac14e2ba7da37b0ecf23a53: bool
{
}

public abstract class Type_d840d0d2ef1d42c69dd6b475a46a3e2c: bool
{
}

public abstract class Type_9ace8c8c1e1147cea877311358868eec: bool
{
}

public abstract class Type_253da26f514b4bf18ede4972c560a6e9: LuaForce
{
}

public abstract class Type_6999967067224fc0a2a30b0483dfa11e: string
{
}

[GenerateOneOf]
public abstract partial class Union_db81f03de8a9421093cb93a0f557bfcd: OneOfBase<LuaForce, string>
{
}

public abstract class Type_709a04cb4de54c7398f6fd7ab020e92e: TilePosition
{
}

public abstract class Type_b93d314aec1342daa34f39488992f1c5: SurfaceIdentification
{
}

public abstract class Type_64cfbc4504f14f3b9628cc87d9572437: bool
{
}

public abstract class Type_99878f066daf4d71b1bd5a91e32a4900: bool
{
}

public abstract class Type_02e3d3884a69432bb73711aa0d552913: TilePosition
{
}

public abstract class Type_be2ceb84cd634168aaa539e543dbab43: TilePosition
{
}

public abstract class Type_221202d5642d40bb848876680d5c0e07: List<TilePosition>
{
}

public abstract class Type_cf876cb6ee024894b357c361f7394d78: bool
{
}

public abstract class Type_ca4fbd73b01745029c6feefabfe6942c: ForceIdentification
{
}

public abstract class Type_c9a05e225a17498ca0a82c03f4b11f78: Vector
{
}

public abstract class Type_a02d4543ee3345e197d08ed25d7f6947: SurfaceIdentification
{
}

public abstract class Type_c0bfb90de41a4db8b47b05519759cf43: LuaEntity
{
}

public abstract class Type_f7341f97274a4ae9808a1afa5a6cd2f3: List<LuaEntity>
{
}

public abstract class Type_ef2d136151784638b4b881b5f8c0f13f: bool
{
}

public abstract class Type_44b773ba33b8454d87f778acd26c536e: BoundingBox
{
}

public abstract class Type_6141e74ac79d492aa84799010d920f69: CollisionMaskLayer
{
}

public abstract class Type_3efaabbc67284f14a92880368fad9226: CollisionMaskLayer
{
}

public abstract class Type_f8c2986d46d14055a37b3e811b9be5af: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_cd7f598e7d644ce3b98bee1c1e109d54: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_a786a1034aac43d3ac5d52d05deabf85: DirectionEnum
{
}

public abstract class Type_db8d4b192f514906a182832bdcb73561: DirectionEnum
{
}

public abstract class Type_ee992e090f7540ac900c19b8622e122b: List<DirectionEnum>
{
}

[GenerateOneOf]
public abstract partial class Union_1e069c985b134ea8a3161e28a5af1773: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

public abstract class Type_a6a2912393994a998edfac4e78d99ce5: ForceIdentification
{
}

public abstract class Type_5a99f08d03494bc1b6ce2477879b9796: ForceIdentification
{
}

public abstract class Type_9a2036833ded4b0ea90179023b4a1f49: List<ForceIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_8971b7e83fe747bd9df760c05f53372c: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

public abstract class Type_71553a7c16c44f699b5087a9cbac3550: string
{
}

public abstract class Type_e0f4aaf3ab37430287808d527460bdb4: string
{
}

public abstract class Type_3a05a5075ce64a0c9e344306e458423f: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_a92891771b1c4e52ae4e634224d021e6: OneOfBase<string, List<string>>
{
}

public abstract class Type_b73e5e17ac064b0cba22ee02b22dd4a5: string
{
}

public abstract class Type_9fa11e7689d045269abcc2a677767d2e: string
{
}

public abstract class Type_bf2bea0833b84c9b94947fc107c3c7bc: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_767de5805b644b33855d7dea7c007c43: OneOfBase<string, List<string>>
{
}

public abstract class Type_ef57ce414eb940388960d97dc3c14a33: bool
{
}

public abstract class Type_fbf6ef8ebfe642a9b63905b8a99d8253: bool
{
}

public abstract class Type_a4cd75a01d284a5e817d2503f0e8b1ce: uint
{
}

public abstract class Type_59b9b7cafc4f4462bcfe322eddf50715: string
{
}

public abstract class Type_e7a2bcc158ed41a2bacac71601cbc6f9: string
{
}

public abstract class Type_0f4a7c7a0f494a429ff260b7e12b9534: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_97335a1f8d4a4a31a1d0bb68ef91edc2: OneOfBase<string, List<string>>
{
}

public abstract class Type_7b82e842096a4d949b7bc75d15f48c89: MapPosition
{
}

public abstract class Type_61d03dcc94304f4aa1b1e99a6726f681: double
{
}

public abstract class Type_0fc968d377be4b6b87b4830ea12a2e41: bool
{
}

public abstract class Type_81909890ef5a4957b2c47a6b37f51c82: bool
{
}

public abstract class Type_ed92131056e24d5aac23803843dc80fc: string
{
}

public abstract class Type_6bc157477d064bf0af438b5c2ed91ada: string
{
}

public abstract class Type_04eb16684a614b528593178a5136de00: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_ed0a951de2eb444b9691e3fafda78a65: OneOfBase<string, List<string>>
{
}

public abstract class Type_6c1b3155fe6e4770913bc3768f1c3350: uint
{
}

public abstract class Type_034ab41f52c94cd5af022632577c8ae7: BoundingBox
{
}

public abstract class Type_10b10c5ce974477d8635dc6ec7e4e57a: CollisionMaskLayer
{
}

public abstract class Type_e962a806a346449dbd534cec414d13aa: CollisionMaskLayer
{
}

public abstract class Type_60714ad9e9884dbeacf072217ca4f126: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_862279ff6ae14e929815c7cb7af1b569: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_af38da558756437bbf51cc6a9dc8875e: ForceIdentification
{
}

public abstract class Type_03ddddf029314c23b474cb620078b655: ForceIdentification
{
}

public abstract class Type_0035170f8cd7418bbc35eb11dc868cd9: List<ForceIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_89379b2b556f4ba9a2fc0488a8be4561: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

public abstract class Type_6c259513488e4a2fa8b76f200f2d7393: bool
{
}

public abstract class Type_ba19324f9c084d9598483c3826643c0b: bool
{
}

public abstract class Type_6a1c8ce04e7e4ee9b516370c091f0969: bool
{
}

public abstract class Type_ca67267e68b442cab2eb45d48f22b72b: uint
{
}

public abstract class Type_dc60b168963448ce93865770abf27adf: string
{
}

public abstract class Type_755e8ea959bc48a9b692ab7722c04555: string
{
}

public abstract class Type_9120d4ce06e24ac3a8521122f25ab9dc: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_e85895ba3f1f4e39a927a6aba090da6f: OneOfBase<string, List<string>>
{
}

public abstract class Type_be72a0f275d847ecb6e5a7fec479904e: MapPosition
{
}

public abstract class Type_ba7cec98b54847dfa154d52209335048: double
{
}

public abstract class Type_b9cbf1f7221347b98fbd85ae039a0147: bool
{
}

public abstract class Type_6a77fc94828c4ad49466d2fe4542c862: uint
{
}

public abstract class Type_41f9bb1b466a4e1b87a4dd9ac6cc3798: bool
{
}

public abstract class Type_5cca5020f28c42e0a86720b1399d02b3: Decorative
{
}

public abstract class Type_b84afb00a2f34e7f9033248e9a9f2913: List<Decorative>
{
}

public abstract class Type_46b574e8bebf43cdb216216dc88499e4: LuaEntity
{
}

public abstract class Type_7a447d5bbea54a9c97e19c46211f628c: bool
{
}

public abstract class Type_7c8c1e2877d949bb9380f28357a1326e: DirectionEnum
{
}

public abstract class Type_37467cc783754f41b13da3451c18d520: bool
{
}

public abstract class Type_144c4bac71a64edf98009dcd8dd81fca: ForceIdentification
{
}

public abstract class Type_ceb762cb9b32447f8fb3f11760a8d83d: LuaItemStack
{
}

public abstract class Type_ecb8e701f3444c49a1ce837224c37b1f: bool
{
}

public abstract class Type_7f63f203622d4759af72588632866f62: string
{
}

public abstract class Type_f80d19661e0c4345a58cbe526232da35: PlayerIdentification
{
}

public abstract class Type_cb7ddf23db1e4e1483610aa8ff6a124a: MapPosition
{
}

public abstract class Type_b9e0bd10aad04edabf2b3c74a5be6dcd: bool
{
}

public abstract class Type_5cd2aeb7122f4f5a8c322b465f6b4901: LuaEntity
{
}

public abstract class Type_cfc108cb903546b694003aa22f543b63: MapPosition
{
}

[GenerateOneOf]
public abstract partial class Union_4ffbf61acc19486a9e239aef52293e4c: OneOfBase<LuaEntity, MapPosition>
{
}

public abstract class Type_6145e23185fd4bbdb23cab747a5705d0: bool
{
}

public abstract class Type_a61cba91e01b4783877629409562daa9: bool
{
}

public abstract class Type_9ad0ff910def4dd590b2d64cea32a786: LuaEntity
{
}

public abstract class Type_1e0651ddb50d43c4895478f109919a6e: MapPosition
{
}

[GenerateOneOf]
public abstract partial class Union_66995bce6cbf4b02b457df1d37f2bc5e: OneOfBase<LuaEntity, MapPosition>
{
}

public abstract class Type_34c74eb1c1014763a1a6ae2940ee8233: LuaEntity
{
}

public abstract class Type_de9f28aa4a39473bbd5378d75d10ad6f: float
{
}

public abstract class Type_964cf21c39ec4818a12ff14c1cc6a805: float
{
}

public abstract class Type_66bdd0358ff04e9cb07c412b760c1926: Vector
{
}

public abstract class Type_53924c795f3b4458881e1224b3755e18: string
{
}

public abstract class Type_81a61b2acd5b4954ab12315a10abd73e: MapPosition
{
}

public abstract class Type_53dd43337a424102972e8bbe0418b6a4: float
{
}

public abstract class Type_55415cf3110545a3b4e55bc6b3775a8c: string
{
}

public abstract class Type_6dbf3f680bd94b7586ff8fad33c504f4: MapPosition
{
}

public abstract class Type_680c276b8cb841f28226f80db3a9172f: ForceIdentification
{
}

public abstract class Type_f14ea2c3eaad4e809788d58821c56252: MapPosition
{
}

public abstract class Type_271536216b044c2ea41d3294e54abba0: LuaUnitGroup
{
}

public abstract class Type_b89fc730a75840328bb46d0d42b19de3: BoundingBox
{
}

public abstract class Type_771c0734f04940a18b45b19bff809123: ForceIdentification
{
}

public abstract class Type_10ad505d7f9f4c4d80e317c87644894e: LuaItemStack
{
}

public abstract class Type_00256fda3a4d488c834af0dd54f61281: PlayerIdentification
{
}

public abstract class Type_6548b2019c1843a0a436aa692d185ae2: bool
{
}

public abstract class Type_f4b2a7ccd5f2431089de6de8a00fe588: MapPosition
{
}

public abstract class Type_694cf9fd6473497dbe7fcec4125cf9e8: string
{
}

public abstract class Type_c4252b33e0b94018b042c9613c3e89a7: bool
{
}

public abstract class Type_75037549f68d45b18a9965c8a17e9fd0: ChunkPosition
{
}

public abstract class Type_f4db6150cbdb472095c539efaa59a889: BoundingBox
{
}

public abstract class Type_c068f75ed58d4823919b5c90d4406e99: CollisionMaskLayer
{
}

public abstract class Type_4f38d58d8f3f4e948c5e2ff43913fee2: CollisionMaskLayer
{
}

public abstract class Type_b46052c17f554281ad19483c36dd3d7a: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_bbb5b94ef9e146fe8258496721df669f: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_805249ce38bd43039f8544037fc9e8a3: bool
{
}

public abstract class Type_f11901668511476ab6990330e3308d06: string
{
}

public abstract class Type_731f98b8f2f7426f9a968c7d74218c75: bool
{
}

public abstract class Type_fdfa4425ebbd4118be4aa42ddf38f65c: uint
{
}

public abstract class Type_3d35c83075f44e9796405d72ad9a0e24: string
{
}

public abstract class Type_920743b9903648bd974a006f7ce014db: string
{
}

public abstract class Type_81a8c670529a4d09828f1795490f9313: List<string>
{
}

public abstract class Type_69ef2e4e97694d2f86b5dd0b07416f92: LuaDecorativePrototype
{
}

public abstract class Type_750f400ed1704064a9d9583d9b2b5c21: LuaDecorativePrototype
{
}

public abstract class Type_fc352006c1094c678a3f8bc6e0b43f69: List<LuaDecorativePrototype>
{
}

[GenerateOneOf]
public abstract partial class Union_0df51e1736014cdba63f9b5c96451129: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

public abstract class Type_436a0359f25a448c84393454bd3ac5cf: TilePosition
{
}

public abstract class Type_734f3bf5d6cd4f4181e9c474bd81ef8f: string
{
}

public abstract class Type_3283460acddf4b4881508be541e8d16a: ScriptArea
{
}

public abstract class Type_3168305e91134c38a570aa0eebe96419: uint
{
}

public abstract class Type_321638f3ace04128875c7c2824813deb: ScriptPosition
{
}

public abstract class Type_23fdca9f9df3482d9c1fc0dc34b8202f: uint
{
}

public abstract class Type_d8b11b44f9514595a270c23080ec646a: DirectionEnum
{
}

public abstract class Type_e4105e7c2f78457c88f65d8f25a5df3d: MapPosition
{
}

public abstract class Type_fbbc57e617b44ba78a247186b6e7e639: EntityPrototypeIdentification
{
}

public abstract class Type_f9171b76e9a140c4a35c1d3367d15046: bool
{
}

public abstract class Type_ad1ec64c56484a109524db5ac600ca25: bool
{
}

public abstract class Type_99f6555017cc43f184d416dc4a714da6: ForceIdentification
{
}

public abstract class Type_7d1c11025747499dad6c82f4fcf0cf4c: MapPosition
{
}

public abstract class Type_17ad92b6311e4734be049f351c1a2b74: LuaLogisticNetwork
{
}

public abstract class Type_928d01aee76644eb943877ff1bf39ba2: BoundingBox
{
}

public abstract class Type_30035a6fb8a84396a7bbb17ff4da6018: CollisionMaskLayer
{
}

public abstract class Type_3d63ad849ff44bdaa951e2ee11d4987d: CollisionMaskLayer
{
}

public abstract class Type_243cbf3174c14e1e9c7f5eaca68c9449: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_d0a9cabe0a5c4ea096086179fb0473f0: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_2ca4ec83c7cb418db242563c63da0088: bool
{
}

public abstract class Type_dbce4e25acb04f0bb63eed6f01e6eedb: string
{
}

public abstract class Type_bf0c7746ce1f4b158009c3e7afb2b977: bool
{
}

public abstract class Type_e80b44f997ed44ec9c4eed5e3952097a: uint
{
}

public abstract class Type_139363b1073f4151977412a89b787b8b: string
{
}

public abstract class Type_1b3c201323e44a389b50579a6a3de151: string
{
}

public abstract class Type_3cc8a27206174d8fad53d2e9df242edf: List<string>
{
}

public abstract class Type_f4cd05e09f774f669cfdb3e76771acc4: LuaDecorativePrototype
{
}

public abstract class Type_23fa5e101ca14e309c45d79b38413ceb: LuaDecorativePrototype
{
}

public abstract class Type_5344a3f7f2db4b9cbf4b9d6c6e9077db: List<LuaDecorativePrototype>
{
}

[GenerateOneOf]
public abstract partial class Union_527f333eb300494f9b393e65de231267: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

public abstract class Type_0687668c12c545b89655c810c11607e9: TilePosition
{
}

public abstract class Type_cb423aa1d53d4864a1e1a5774169133f: string
{
}

public abstract class Type_d4ff3d7b8f35475587bb967f14c941d2: DecorativeResult
{
}

public abstract class Type_a65e4618b8e041cf98919487fd38a9a0: List<DecorativeResult>
{
}

public abstract class Type_5818526f77ce4af6bf709b7ba3019629: MapPosition
{
}

public abstract class Type_ffd2354e39d346efb49b028ba7411340: ForceIdentification
{
}

public abstract class Type_c52c7439125c4069a292938f301865b5: double
{
}

public abstract class Type_8d1af607e377466193f144a18a13aac0: LuaEntity
{
}

public abstract class Type_97cd5e9667da46deb95d884d99e71a67: List<LuaEntity>
{
}

public abstract class Type_8d59caffe55d4ddebc2b6db19aab1211: BoundingBox
{
}

public abstract class Type_4cf7ed351d8f4a43b64e3d698297805e: LuaEntity
{
}

public abstract class Type_9b8d1afebb544697b001c5751df25443: List<LuaEntity>
{
}

public abstract class Type_0fc529eb4bfe4b1fb587dc4a67fc5a73: BoundingBox
{
}

public abstract class Type_7af2f318ae98434db88aef49496851b7: CollisionMaskLayer
{
}

public abstract class Type_8e3e9f8304964acd9364c524fd8cee65: CollisionMaskLayer
{
}

public abstract class Type_0ca23bf948eb41b69edce8e809ea0eb8: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_4e62b0ab4740439d8f787065e9253ede: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_505e045545d141abb7ff449b3ca8950f: DirectionEnum
{
}

public abstract class Type_663445c8882d4eeb96e5e847a6a8d2ff: DirectionEnum
{
}

public abstract class Type_1a5f8507c2bc475f876ee2fac2b93c5a: List<DirectionEnum>
{
}

[GenerateOneOf]
public abstract partial class Union_ce7dbe70c28445f3a6fb23ce8178c748: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

public abstract class Type_c1417fde19cd49a6a6490cef5351d4ef: ForceIdentification
{
}

public abstract class Type_0aa093d5a1c343198475ea7d787e7215: ForceIdentification
{
}

public abstract class Type_d16c8d7dbcec46bf82722caacfed57b3: List<ForceIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_5743d69b92c14b8fbc6947f54c853bed: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

public abstract class Type_f175a02690e14c70b2b6c817cfec09b6: string
{
}

public abstract class Type_28cadd4281f2482891af10524b22a79e: string
{
}

public abstract class Type_fc99ee156e4249f19b8fdd1c6d943075: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_bffc52de44c84b8896890858e54ef0f2: OneOfBase<string, List<string>>
{
}

public abstract class Type_c7efce8dc4e341418f5944d4810140c4: string
{
}

public abstract class Type_b3d9b8d1c99c4982b323690470885fe4: string
{
}

public abstract class Type_de6547ab2ca54a7382bfb0eee941aac5: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_1423a30a02d14835a25eeeb5a1aab40a: OneOfBase<string, List<string>>
{
}

public abstract class Type_f58e8d8093c844689316f3c2a453256b: LuaItemPrototype
{
}

public abstract class Type_038b31fa3e5741a3b79e4e72577aec17: bool
{
}

public abstract class Type_4ca4e76ff41b474cae43bd5be3a3b388: bool
{
}

public abstract class Type_03aadf8366c745378b95c01821841a00: uint
{
}

public abstract class Type_155a2bec0f4f42f3a8f93726222cd720: string
{
}

public abstract class Type_4590a01b5bec43a1a37cfb3b6d2fb541: string
{
}

public abstract class Type_ae4186b9e7d34c1190a424ae06c57c52: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_0c0d7f7adee94cbc94341e3090e7ce25: OneOfBase<string, List<string>>
{
}

public abstract class Type_a1a0132da3334f5ca8395cd5f352e874: MapPosition
{
}

public abstract class Type_657d1143015a471da8d6b73a39729d0a: double
{
}

public abstract class Type_2c1277d56225443a9224fabf6896edde: bool
{
}

public abstract class Type_3dc306a76d3149909c69c98e688973f0: bool
{
}

public abstract class Type_30553399bf9749b99e4c813e708d5210: string
{
}

public abstract class Type_17dba7a22ef14a039f75bc302fcde3d7: string
{
}

public abstract class Type_0b34c2a4d2f94e9f9951a64fb6336902: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_a41d1fbcb0e44f49949fee1046b0b490: OneOfBase<string, List<string>>
{
}

public abstract class Type_e017bdc3f4b54f6887e52926f914e775: LuaEntity
{
}

public abstract class Type_c522a17e31ff46258bfccaf477b40222: List<LuaEntity>
{
}

public abstract class Type_c7a742b20b024e70989fcb48ff738c9a: string
{
}

public abstract class Type_f965252be0974e80a39f055b9541b5bd: MapPosition
{
}

public abstract class Type_957c51b810894bfea4dc5d906453bc36: LuaEntity
{
}

public abstract class Type_de15d158406e4f14956eb28a29873c98: ForceIdentification
{
}

public abstract class Type_835610786d41413ba52a8b7008c4b644: MapPosition
{
}

public abstract class Type_9ab62006b06948229bce053260515380: LuaLogisticNetwork
{
}

public abstract class Type_af84534f30f141e9ad884ef1dedfaaa8: ForceIdentification
{
}

public abstract class Type_a2e6825bacca4c10805903db126e6e1e: MapPosition
{
}

public abstract class Type_5060f9398b2a40469f577df43dd5e475: LuaLogisticNetwork
{
}

public abstract class Type_984daf324d9f411da56c8b47aa140cfe: List<LuaLogisticNetwork>
{
}

public abstract class Type_3422b8fc458f44a9a162f3a02403e369: ForceIdentification
{
}

public abstract class Type_917d682be6c1407b9175b24c7679cf76: double
{
}

public abstract class Type_4c88233c477c4bd9bc9d86da25791a8a: MapPosition
{
}

public abstract class Type_e4af20cd74744df1b54b5465062a9003: LuaEntity
{
}

public abstract class Type_9404ade68c684d0ba2318f6ad8c6fc5d: ForceIdentification
{
}

public abstract class Type_dc3d0253d59f4d0ba0379ed14189c310: double
{
}

public abstract class Type_babcf48c625c48f98575446b980d2838: MapPosition
{
}

public abstract class Type_e71e8aed5c12447a9cfaf0083fb3376e: LuaEntity
{
}

public abstract class Type_95b5c6b9c05a44d6a5ced7fde4042d68: MapPosition
{
}

public abstract class Type_848f5f18776c4628bd0df499091d0ca7: bool
{
}

public abstract class Type_59d92a5ff09d4cd39d1eeccf9fa390cb: string
{
}

public abstract class Type_5b05c50b5ca340068f727aa8f339e1be: double
{
}

public abstract class Type_68295000471b47458c819e1992511f1f: double
{
}

public abstract class Type_b5bab52a13cf4f46afabbfef40214f6f: MapPosition
{
}

public abstract class Type_bdc623e7f9aa4f829fdfbf8b102dd9bb: bool
{
}

public abstract class Type_caa870d932da4dfd9e2d7c77ee1123de: string
{
}

public abstract class Type_51456dbcbee34badb281c437da71fa50: double
{
}

public abstract class Type_51d57782595e41cb947b0a1496f9c000: BoundingBox
{
}

public abstract class Type_bc4cc7da65fc4252a8be755e8eb2ece7: MapPosition
{
}

public abstract class Type_30701e03a26442af93aa9eaa9024c566: BoundingBox
{
}

public abstract class Type_41a7a19745ec4d93a3d3cea79fe76333: CollisionMaskLayer
{
}

public abstract class Type_a1a71b9934c5426ca3c545af54f79ab5: CollisionMaskLayer
{
}

public abstract class Type_e3f922c9bdfb4f5bbffe039f8ac57b97: List<CollisionMaskLayer>
{
}

[GenerateOneOf]
public abstract partial class Union_b98b801fd352457cbf2759d0b4ace50a: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

public abstract class Type_fb59fa8467254884b1eac4fa249fde8d: ForceIdentification
{
}

public abstract class Type_0a97f6079e3648c7a6fb06cf3bb290ce: ForceIdentification
{
}

public abstract class Type_15000a6900de49c7822bddb9844128dc: List<ForceIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_314827fca5b24d9ea2b012472e48fec1: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

public abstract class Type_b992132a3f0a426b8405961f48fa902c: bool
{
}

public abstract class Type_c57254006c0e457ba65b8298db5d367a: bool
{
}

public abstract class Type_49640d0b7ddf49d8ab23aaca86bea44e: bool
{
}

public abstract class Type_5797db3818064c4e950e7858271f146d: uint
{
}

public abstract class Type_8438597fecfd4f65aeb5773cb5034872: string
{
}

public abstract class Type_b36cb51cdefd4c6f80fe51c93bf8dc57: string
{
}

public abstract class Type_baf7b7cbc7cb41cbad4ae424b79a7b1d: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_22561d21e7064505bad66d3cf2026ecd: OneOfBase<string, List<string>>
{
}

public abstract class Type_d852009580aa4d1ba215ba85bd0062b2: MapPosition
{
}

public abstract class Type_136eeae584324275bd17dd6da2f57733: double
{
}

public abstract class Type_b339dc32b8ce4014b9492b86f3364656: bool
{
}

public abstract class Type_8550a84f9bb0402c88059f5f876e6b1e: LuaTile
{
}

public abstract class Type_1b7122eb45f64c42a2987b47f3a27167: List<LuaTile>
{
}

public abstract class Type_b7ed005bc10a4371a4609e1ff92a205c: BoundingBox
{
}

public abstract class Type_7950340c733e4b3a9b5b672bdd97e7c5: ForceCondition
{
}

public abstract class Type_15d55cf9bc9e4050a67bda1b0f32cd84: ForceIdentification
{
}

public abstract class Type_5a2ec686dcc143458a5e27b44a51152f: LuaEntity
{
}

public abstract class Type_6a431369be4c4558aa367f3de136934f: List<LuaEntity>
{
}

public abstract class Type_9e2b0a6be5a04e4b9e1748fd760c9309: LuaChunkIterator
{
}

public abstract class Type_fb3a2e28fddf4a7cb7cb1681ebc3f37f: LuaEntity
{
}

public abstract class Type_6738ce6f8d84460b9ff52ae0bebe35dd: List<LuaEntity>
{
}

public abstract class Type_6704c39b5c88419595b021d8e151bbae: MapPosition
{
}

public abstract class Type_2ec5f450f87c44a69486fa22da39ae22: LuaEntity
{
}

public abstract class Type_eb44a7face4b4ad188981945be9c6f4e: BoundingBox
{
}

public abstract class Type_128f734217a141688b0cee5ed67e20cb: bool
{
}

public abstract class Type_7e1941799b8c4502b6c3535a084ef632: TilePosition
{
}

public abstract class Type_5c9c46fabca440e8be1ab32cd19df317: string
{
}

public abstract class Type_07dc117b02f449fdaba97786d313fd37: List<string>
{
}

public abstract class Type_05c811e467d74278a4608aa6c43cf7d8: TilePosition
{
}

public abstract class Type_ad593f8f6f174af68c2aa666f45c9b32: List<TilePosition>
{
}

public abstract class Type_fa77831f53c14e58ad926ae279aac6e5: ForceIdentification
{
}

public abstract class Type_ce6d9924bc7046e190809c2457b7dedf: ChunkPosition
{
}

public abstract class Type_18e0f279518646e4b2a2f09872e50f02: LuaEntity
{
}

public abstract class Type_ab4f7e83d85b4e63964614b4033614be: List<LuaEntity>
{
}

public abstract class Type_ba5113d9688f4354aab6b6472fa7fa96: TilePosition
{
}

public abstract class Type_de59e37fa9df4af48c659517fca618ab: string
{
}

public abstract class Type_0c2e055d3cf84accb26bb6115ba740e8: string
{
}

public abstract class Type_27478b4c07724abc802462ef5d018b2a: MapPosition
{
}

public abstract class Type_d50ff7754334427182495b436cf24164: double
{
}

public abstract class Type_b296ff4c770e45579923a7904e4a0ea6: ChunkPosition
{
}

public abstract class Type_9215e1b98667430e95b2a7803059ec79: string
{
}

public abstract class Type_73cbce93b3ec4539a13ae512bd256112: uint
{
}

public abstract class Type_2f55cc8679f4421ab1d5ee8189ef33ef: Dictionary<string, uint>
{
}

public abstract class Type_57f740f70d1f4bc2a6e954ef8c302a9e: string
{
}

public abstract class Type_4e5cf96eaa2543a6afe4c7622a5375d6: uint
{
}

[GenerateOneOf]
public abstract partial class Union_a4d2b5ab6a214796be1e031c746a7f56: OneOfBase<string, uint>
{
}

public abstract class Type_42aa000266404b99879319a8c2231bde: ScriptArea
{
}

public abstract class Type_c800bafb2a6e490cb8fd1c78f4de0689: string
{
}

public abstract class Type_1d1738378fdb4c9fbe2e2b13c6f090c5: ScriptArea
{
}

public abstract class Type_18922907b1b94c189da7844f148fc908: List<ScriptArea>
{
}

public abstract class Type_b28b45eea98c4c4d98afcc160306d7db: string
{
}

public abstract class Type_792cbefd23fd4977960b3f1482506be7: uint
{
}

[GenerateOneOf]
public abstract partial class Union_685235746a264b3f99585ccf278ca081: OneOfBase<string, uint>
{
}

public abstract class Type_782cee828576455991f2eed34ccca2e5: ScriptPosition
{
}

public abstract class Type_e26f07ef1e6c4277901dcc189e5e2eca: string
{
}

public abstract class Type_eecdd27bed874dd3a769138df81cb7c3: ScriptPosition
{
}

public abstract class Type_d42216be7eba4d57a8e4e70794ba44dd: List<ScriptPosition>
{
}

public abstract class Type_e2eb11f027574e929aa71700f5089a34: double
{
}

public abstract class Type_9e406a5f981244cc972c943e7054f13b: int
{
}

public abstract class Type_b391c0be08084c56a0bfde81d4daf38d: int
{
}

public abstract class Type_eda104522c4b4cb4862128d9fdc5004c: LuaTile
{
}

public abstract class Type_9b4f8d69ca4142a3ad55032b6a36e580: double
{
}

public abstract class Type_ccc7a3a968af4618a8e89db535156640: ForceIdentification
{
}

public abstract class Type_252a18f4aa1f414b962380127fd087e1: string
{
}

public abstract class Type_9813847925cd460cbf427a00f750dba0: string
{
}

public abstract class Type_352ecfe22c1c42a3a4ac08a39f5cf604: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_74eaeb7af90448029b7fdbdca879fa3f: OneOfBase<string, List<string>>
{
}

public abstract class Type_906295d8ac4040a5b19371f886911616: LuaEntity
{
}

public abstract class Type_1b69b3bf97f4471d95135556087a5d49: List<LuaEntity>
{
}

public abstract class Type_6312c6d9d4784f2b9518f0210dc4e9e9: ForceIdentification
{
}

public abstract class Type_387222eb8dad464589c3f50ec5ee3dce: LuaTrain
{
}

public abstract class Type_9ebb75c322ea497c933b98e1a2182c5d: List<LuaTrain>
{
}

public abstract class Type_4ed12c29cd8f4d3fa73bc841b09bd871: string
{
}

public abstract class Type_d88849fbb37246aeb7465daa30a46e6a: ChunkPosition
{
}

public abstract class Type_3724083769f049acba4b977bceb53385: bool
{
}

public abstract class Type_7ede0f58d8ee427dab2ea4181954fcac: SoundType
{
}

public abstract class Type_a8e5a800b34844a69e6bf798ef26bda6: SoundPath
{
}

public abstract class Type_24f552e3a08447abb8e2cac72aaba452: MapPosition
{
}

public abstract class Type_e66a54ae0d67497abe3384742861085a: double
{
}

public abstract class Type_23b0890b8057497fbd3b57cf288f6d24: double
{
}

public abstract class Type_904038ceb5184e04bddb146f2267f422: MapPosition
{
}

public abstract class Type_a807b6ef148a431297411ec627b3513a: LocalisedString
{
}

public abstract class Type_c13c3df949fa4ddc8042bafd19308045: Color
{
}

public abstract class Type_c7965ba546bd4db0bc81df7398c15312: PrintSettings
{
}

[GenerateOneOf]
public abstract partial class Union_246e70737a21401c82dbf247e114f71a: OneOfBase<Color, PrintSettings>
{
}

public abstract class Type_b59bdb8419364b1b97671ee4e0a92c69: ChunkPosition
{
}

public abstract class Type_9fd538fe33b04ff0a5b7fae71afa52de: List<ChunkPosition>
{
}

public abstract class Type_3e346d92aac8490abfeed39999b06877: string
{
}

public abstract class Type_5c989ec3989448ddbeb72a976890c81c: string
{
}

public abstract class Type_ea65ed73ed764143b4f04e7361d2ae47: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_0712eb0324374e6898748d085f78c30c: OneOfBase<string, List<string>>
{
}

public abstract class Type_286613b2c32943eeafda0f405a6b577d: ChunkPosition
{
}

public abstract class Type_0a7cd26a33f040bba8559eae51e02c7f: List<ChunkPosition>
{
}

public abstract class Type_4e0ca4a3944147c8ada9c83dd68a2da2: string
{
}

public abstract class Type_34d695bc6cb2496e9cc7cc7ba4e605f5: string
{
}

public abstract class Type_f63917957a064c089f932d4f0ad930b2: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_9649468751704cf3b6cfa58614ec28c5: OneOfBase<string, List<string>>
{
}

public abstract class Type_029a9120cd474084922d9dbd69f72520: uint
{
}

public abstract class Type_e2f723b71ef24e6f932f09ce1f26d588: bool
{
}

public abstract class Type_c3f20a3c2e374d34ae6113d8d381d770: uint
{
}

public abstract class Type_5bb59cffbfb54180abe0f5facab8c3cd: bool
{
}

public abstract class Type_b97200970a4e48919a270eb7c8d986e6: BoundingBox
{
}

public abstract class Type_fefe04837ea0480ca4cf73dea5d9fe70: bool
{
}

public abstract class Type_0fbb8a18feb24641ad71072fb2cac178: CollisionMaskWithFlags
{
}

public abstract class Type_df6c96cd0bae46a2ac7a0743bafe63b4: string
{
}

public abstract class Type_114e57ffb3f54f98ae30464ba29fd9d9: List<string>
{
}

[GenerateOneOf]
public abstract partial class Union_05e5038b834642848f4015903b1a5b0d: OneOfBase<CollisionMaskWithFlags, List<string>>
{
}

public abstract class Type_4308ee1063ba4e26ae1a171f61567c58: LuaEntity
{
}

public abstract class Type_448439c66cb54bc4932f1fa30188a28b: ForceIdentification
{
}

public abstract class Type_d13cf22de142424889f71aa677489fcc: MapPosition
{
}

public abstract class Type_bb685995042a4ee19c68da768f60a3c3: int
{
}

public abstract class Type_29b071809bce4e79b4b22431c5ffb719: PathfinderFlags
{
}

public abstract class Type_275d7267887247d39dfecbbc11834636: double
{
}

public abstract class Type_863f04fbd0bf4dde9537901beaf3279f: MapPosition
{
}

public abstract class Type_3d1e132dfd024784bf54274996f6cf70: uint
{
}

public abstract class Type_8989b575aae84afe834b28d84825ce0d: MapPosition
{
}

public abstract class Type_60b60f473439414584f35ea799d24d2e: uint
{
}

public abstract class Type_2229c9202ad748949c028cc4263f503a: ChunkPosition
{
}

public abstract class Type_f0e83ae7cbbc42dda2ac642863c0cd2e: ChunkGeneratedStatusEnum
{
}

public abstract class Type_5f6079bc370e4916ab79253071ef9074: TilePosition
{
}

public abstract class Type_5dbb8202d69b40fd94e64b926f0d7ec3: string
{
}

public abstract class Type_1c51e9d160a346f993e126b25783ea69: LuaTilePrototype
{
}

[GenerateOneOf]
public abstract partial class Union_841da1c936df407eab335c7b6b831314: OneOfBase<string, LuaTilePrototype>
{
}

public abstract class Type_cfbadea2c36e4a85a6f4f875b5e58fe7: Command
{
}

public abstract class Type_013ca79091514718b06a9f18bbf37707: ForceIdentification
{
}

public abstract class Type_1214620e471341f39b6af994f04b8136: uint
{
}

public abstract class Type_822556320c9f4afb8ddbea9116b37f7d: uint
{
}

public abstract class Type_09cbbdbcaec542ccad3eb63b91e01c74: uint
{
}

public abstract class Type_8e82842c95b5480daea95a65c76ab74c: bool
{
}

public abstract class Type_01c6733e511f4121900a37d29644e9aa: bool
{
}

public abstract class Type_667d01b639bb4902a804967484e76a49: bool
{
}

public abstract class Type_3451ebc444f8449080d7adc64e0327de: bool
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal_45f8836bdb9b43cf9ef0a91fbe65562c
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public abstract partial class Union_fc9d5ccd5ea843f5b18638aee16c6ee6: OneOfBase<bool, Literal_45f8836bdb9b43cf9ef0a91fbe65562c>
{
}

public abstract class Type_8633c34dcf7847a690a9e820dbff2a81: Tile
{
}

public abstract class Type_8220ba850b714a02a6637af882ad4e4a: List<Tile>
{
}

public abstract class Type_c1b9f06718164fa6b3f6021a4993c1b0: bool
{
}

public abstract class Type_6af9bab135af4fefb6bfc66e1bd8576c: bool
{
}

public abstract class Type_4b705febc7ed4ee7aca9adb968ed47f9: ForceIdentification
{
}

public abstract class Type_e741eb1150364fc89e54ddfd40daf3db: ItemStackIdentification
{
}

public abstract class Type_4ed3824ed61345b390c9d9e5eff7d891: MapPosition
{
}

public abstract class Type_e7bfef28327648a4a1f38a580eb5fdb5: LuaEntity
{
}

public abstract class Type_6dd5339c435d4510aa8bf78497bdb789: List<LuaEntity>
{
}

public abstract class Type_868461c5b0e843d6a49f26861307339c: BoundingBox
{
}

public abstract class Type_94ba707beb244c75a9cd7c4e6163d2ad: ForceIdentification
{
}

public abstract class Type_02612be93c574e038194cd8827a8b5f0: LuaItemStack
{
}

public abstract class Type_457fd7cb9c0a45139484143867c0da82: PlayerIdentification
{
}

public abstract class Type_ac20afe794b2405e9b048d4896297a44: bool
{
}

public abstract class Type_3066bf50be6b42e9837582933d810e43: TechnologyModifier
{
}

public abstract class Type_525c0db02c744a91a86cd00b821083c7: List<TechnologyModifier>
{
}

public abstract class Type_2344850f2e404bf9867383bf7cdbb703: bool
{
}

public abstract class Type_ece2ae5f1db44df497ff6b289fbd7dfc: LuaForce
{
}

public abstract class Type_6e63e353b8ef4ac58ca7b5e50eacc0dc: uint
{
}

public abstract class Type_65f20b3dc6a54b0a8894ad4700e3bc49: LocalisedString
{
}

public abstract class Type_0daffc0e63324a878cea38229e07231b: LocalisedString
{
}

public abstract class Type_4f790873e74d42ba99f7e71ea0de428f: string
{
}

public abstract class Type_91c44dbc7ec44505aac73355019aa000: string
{
}

public abstract class Type_ed4a675685684e28966668c12695e1b3: string
{
}

public abstract class Type_deeba14d267f4355aabb669ba8c6dc88: string
{
}

public abstract class Type_7c27a85b24d64559b4d063e17fd53f70: LuaTechnology
{
}

public abstract class Type_8066a68fce634ab190368581304cfd2f: Dictionary<string, LuaTechnology>
{
}

public abstract class Type_0ccb149123024bd99221b8dee15099e9: LuaTechnologyPrototype
{
}

public abstract class Type_8261427ae9df428bb54e043a0af3d2cc: uint
{
}

public abstract class Type_b8b90240c08b40ddaf6909ce0e97ae87: string
{
}

public abstract class Type_818df39dd9a944eda5e13a8ed568b024: double
{
}

public abstract class Type_69b16c24ad0a46bea84fb1ed804e0e61: Ingredient
{
}

public abstract class Type_2149e666f157434e9508a63ca9eb573f: List<Ingredient>
{
}

public abstract class Type_69d9a5707c374957bcfd7a5dafe42f10: bool
{
}

public abstract class Type_03ddd3b5cd034732b1b429b35f4cfdfd: bool
{
}

public abstract class Type_8c515a6ea7384e00a598366de63ed483: bool
{
}

public abstract class Type_1fb750acab0c49c6951095da2273bbcd: bool
{
}

public abstract class Type_09f250f01a72407e900fabca1ff9fba2: string
{
}

public abstract class Type_54cd0d42985144afbdcffee5ae50878d: TechnologyModifier
{
}

public abstract class Type_5bdb76c0f51948819a014c516c927807: List<TechnologyModifier>
{
}

public abstract class Type_fa560384b6024a23b08b6d1de604af11: bool
{
}

public abstract class Type_9f923ac0096c4cb8b1e80e043a571ea8: bool
{
}

public abstract class Type_2ca4fc6f3e404bae90cc1011c6ce57da: bool
{
}

public abstract class Type_7a0d4912d77f4d8ebffb85179349aeac: uint
{
}

public abstract class Type_558e21c6fab440d7a2ce1cb9fb2fa251: LocalisedString
{
}

public abstract class Type_805b6246cba148e380e46374a204ec88: LocalisedString
{
}

public abstract class Type_ea05677a26954413b1eed6330709b3c3: uint
{
}

public abstract class Type_49a775d6ccc7455191f4e9fcea3bd801: string
{
}

public abstract class Type_e2626ca684cd48308162c3b5401f6c2a: string
{
}

public abstract class Type_5f9eb625b4b54146be7de980192e0d33: string
{
}

public abstract class Type_0ad50693599949c1a37081d87fecce7b: string
{
}

public abstract class Type_73ba8df1872649c1bed38574bbca5ae0: LuaTechnologyPrototype
{
}

public abstract class Type_25e0ee87cdd04e68912e5245095e6f7a: Dictionary<string, LuaTechnologyPrototype>
{
}

public abstract class Type_fd398292a8c34c4796c1f6e11a3c9d08: uint
{
}

public abstract class Type_f7dda9d4c5b24d51b8a6f0dbbcc17c22: string
{
}

public abstract class Type_550abc5a276949d5856f9e7eee6eb663: double
{
}

public abstract class Type_4843884c2cf74d98a0d0bb228f52c090: Ingredient
{
}

public abstract class Type_77577ccdb86548e192672b4e7f9ad9e1: List<Ingredient>
{
}

public abstract class Type_85b4ea524fc24d2694add3d34684b47e: bool
{
}

public abstract class Type_c62d2e4857594564b552faed71fcbf35: bool
{
}

public abstract class Type_12a7802c938f4951849b70013032a2b6: bool
{
}

public abstract class Type_9c27a2f193d14c0daa4316d431ff94d9: string
{
}

public abstract class Type_381537a190ed4a55a61577e55223e985: string
{
}

public abstract class Type_cc7a0212b39d4d3caf2873f736d8b90e: string
{
}

public abstract class Type_81549a29e8b2430195e1dc5bf8c7cb51: string
{
}

public abstract class Type_26cca0c94eb448aeae305a0eb236b0f9: TilePosition
{
}

public abstract class Type_104f9dd036d645bab9ef87c2c87e6742: LuaTilePrototype
{
}

public abstract class Type_6f3b8de59b9d479781cbcb0d2d4b2bc5: LuaSurface
{
}

public abstract class Type_c7ac948605a643dcaf69c82acf22b199: bool
{
}

public abstract class Type_da7fd221140b4d16a5c0075329e1d1c6: ForceIdentification
{
}

public abstract class Type_c8d77aaea2c94a3599cab56b51913087: PlayerIdentification
{
}

public abstract class Type_302122a4b4fb4f7d91a2a9a3ad1a535f: CollisionMaskLayer
{
}

public abstract class Type_ae988239a98c4c21aafd8a83ccce0672: bool
{
}

public abstract class Type_da6aad98fe024f95ac317bf5f168c2a4: ForceIdentification
{
}

public abstract class Type_f4740b98a6d74aaca2bca7f5c7bbfd63: LuaTile
{
}

public abstract class Type_82c5deaa03d74253bddcdf983a380b94: List<LuaTile>
{
}

public abstract class Type_e0a15875e7504df28af06c96e666295a: ForceIdentification
{
}

public abstract class Type_183fcb6844f246f7b9d682980ae01043: bool
{
}

public abstract class Type_d290d9f70b8a47c39f97bfd8665fed85: string
{
}

public abstract class Type_2893074efb274a9aa745d3aba941389f: ForceIdentification
{
}

public abstract class Type_09708362b6fb40a8a70bebf620382915: PlayerIdentification
{
}

public abstract class Type_19e900b5744c4e27a739138b43c4ff54: LuaEntity
{
}

public abstract class Type_2308ca91299546ce8e7aa9998ad498d3: ForceIdentification
{
}

public abstract class Type_1431d1ee5dd24973a97a65c6053fdf9c: bool
{
}

public abstract class Type_2f648c86d7d24bd2805bdbda20e94b04: string
{
}

public abstract class Type_7deeab42fc5e420888d3bb9409fa3bc4: LuaTilePrototype
{
}

public abstract class Type_fceb5d82ec804513b19dfc8ea614ae51: Dictionary<string, LuaTilePrototype>
{
}

public abstract class Type_92c50eb4aaeb46769853b9290747d4fc: bool
{
}

public abstract class Type_10dab670f4fc40a4829e12aef74f9197: AutoplaceSpecification
{
}

public abstract class Type_b474d9c92c4a48b6afd6fdb1ffe7c7f2: bool
{
}

public abstract class Type_599b7c52799143b5a379d61bfb0eb84b: bool
{
}

public abstract class Type_dc528e1b339d421194acf7a823b25fed: CollisionMask
{
}

public abstract class Type_1192b450eb0e44a8b533237945826a83: CollisionMaskWithFlags
{
}

public abstract class Type_c4436068431642e381e4b6a3c3ce293f: float
{
}

public abstract class Type_cdfcbd4da7734540a7c14cc9f0259916: double
{
}

public abstract class Type_57afca4cca6a4464b2cfc4dfab7cbde6: ItemStackDefinition
{
}

public abstract class Type_4f7907c1107e4cef818d5b5144c5fca0: List<ItemStackDefinition>
{
}

public abstract class Type_a8b34a5b85984050988d9a402e970129: uint
{
}

public abstract class Type_ad39750744be49889f385647fc578d6c: LocalisedString
{
}

public abstract class Type_e043099782c8484dbe704e98370d1cb3: LocalisedString
{
}

public abstract class Type_a141bf7d479949c8ab88988d67697056: Color
{
}

public abstract class Type_15576f5526ae4b07b9ddd89bbf94240e: bool
{
}

public abstract class Type_1426bb3f15104be4b423b7d5c21dec11: string
{
}

public abstract class Type_e6cc6869931f4c139ee8c7e884084b17: double
{
}

public abstract class Type_8542c05f7ef541de8ad36fc0699a0d44: Product
{
}

public abstract class Type_b799b069dd9749c880ca8177e4dbbbd5: List<Product>
{
}

public abstract class Table_dba74dfe98774f459ed0d4536031205c
{
  /// <summary>
  /// Is this tile mineable at all?
  /// </summary>
  [FactorioRconAttribute("minable")]
  public bool Minable { get; set; }

  /// <summary>
  /// Energy required to mine a tile.
  /// </summary>
  [FactorioRconAttribute("mining_time")]
  public double MiningTime { get; set; }

  /// <summary>
  /// Prototype name of the particle produced when mining this tile. Will only be present if this tile produces any particle during mining.
  /// </summary>
  [FactorioRconAttribute("mining_particle")]
  public string MiningParticle { get; set; }

  /// <summary>
  /// Products obtained by mining this tile.
  /// </summary>
  [FactorioRconAttribute("products")]
  public List<Product> Products { get; set; }

}

public abstract class Type_6ccf1e1a230246e9a5595dcbd44dbd88: string
{
}

public abstract class Type_bcbdee96048e4ebfa68cbfbe3a66f598: bool
{
}

public abstract class Type_42650c0d10e94d78bf4a9ede4321445e: LuaTilePrototype
{
}

public abstract class Type_294347a677a546098692ddbfde35f856: string
{
}

public abstract class Type_cebfaea846cd486e945e25145ba00c4d: string
{
}

public abstract class Type_d05f14a5608c46bf9cf8e7778f28c617: bool
{
}

public abstract class Type_4514bb8e712f4bc8ab118b44ae6120f5: float
{
}

public abstract class Type_ff2585917dfb40769107dbfbdd529820: float
{
}

public abstract class Type_c80e6527625d4df2851a84b3b4365ef4: string
{
}

public abstract class Type_635ed10c1e5a4d908be722cee79b6d50: LuaEntity
{
}

public abstract class Type_9b14cf809b1c4693bd721567486f29d0: LuaEntity
{
}

public abstract class Type_9c7db949ce6c4731aeb356176b86c9c8: LuaEntity
{
}

public abstract class Type_e4bf4f0c4787416c886222249527351b: List<LuaEntity>
{
}

public abstract class Type_baf031e98e5c4dd19fc0fc07650a3028: LuaEntity
{
}

public abstract class Type_f7b36c8bbb0c4c9a8f152e58676a9666: List<LuaEntity>
{
}

public abstract class Type_3a7111783137450eae15f6b412a8e0ec: LuaEntity
{
}

public abstract class Type_c6ab9c1251ac43c08f9e631a0870f2d8: List<LuaEntity>
{
}

public abstract class Type_6f6fe2cce37347f59ec783088c307974: LuaEntity
{
}

public abstract class Type_d8ea9d0a184a4cfaa2c4a7aec0b78414: LuaEntity
{
}

public abstract class Type_df768746f47a4f85a4a25dfc3b61def8: bool
{
}

public abstract class Type_7f5c173701ce4c0f9e28ea373669a829: uint
{
}

public abstract class Type_4b35142667234e16bc91aec107e42c5d: uint
{
}

public abstract class Type_d4d788912057423abc9efc89d5cb1f28: uint
{
}

public abstract class Type_e9dbe28607b647b198cc50ae97c20e9a: uint
{
}

public abstract class Type_c5f999e22cb2428a8cf26cefa68160a1: Dictionary<uint, uint>
{
}

public abstract class Type_7b1dcce371164c43b5626968d5e3522c: LuaEntity
{
}

public abstract class Type_1eeefd358ae8410eb65c6e0ecf1548cd: List<LuaEntity>
{
}

public abstract class Type_99d50b7f44c5462a9ab8f8e2ada2feb9: LuaEntity
{
}

public abstract class Type_fcb9c75dc7524d1d93236fb7fbae0bef: List<LuaEntity>
{
}

public abstract class Table_5a2a9b1b29e447ffb2302a647f868b36
{
  /// <summary>
  /// Array of locomotives.
  /// </summary>
  [FactorioRconAttribute("front_movers")]
  public List<LuaEntity> FrontMovers { get; set; }

  /// <summary>
  /// Array of locomotives.
  /// </summary>
  [FactorioRconAttribute("back_movers")]
  public List<LuaEntity> BackMovers { get; set; }

}

public abstract class Type_ee12962d59a946f89fafbbdfe16cf6e0: bool
{
}

public abstract class Type_e26b5deab4514f87a2d1625267df9e12: double
{
}

public abstract class Type_763858bca08443e686650d779bfbb036: double
{
}

public abstract class Type_cfdc2ca46e9b4a92a55b8ef34525036e: string
{
}

public abstract class Type_eb90e858d41e4833b61399dc3dd1498c: LuaPlayer
{
}

public abstract class Type_b6ec9cd8bce546c5a8628e4a7ed75915: List<LuaPlayer>
{
}

public abstract class Type_c2e899e180ae423d8c0b9abb02fc4266: LuaRailPath
{
}

public abstract class Type_017815f9bc2a470594b07b8567878c6d: LuaEntity
{
}

public abstract class Type_b5ca5d1f72ec43d99bea287edc6a337f: LuaEntity
{
}

public abstract class Type_c13c2a16b00f4fa09ff586dbd8f1d2f5: RailDirectionEnum
{
}

public abstract class Type_954894e6c0f74c78b3cf4942df4cc7b9: RailDirectionEnum
{
}

public abstract class Type_523e9400cfa748c1b210f2e98d6ab15a: RidingState
{
}

public abstract class Type_d11d8a7c7865474cbe160813f408fd3e: TrainSchedule
{
}

public abstract class Type_a5135901745b4d578620ef93c5470fb9: LuaEntity
{
}

public abstract class Type_7b8aeb0dca984848b6ab103b86135618: double
{
}

public abstract class Type_e60dae970e2d4d0d93e146c3a6ec81a0: TrainStateEnum
{
}

public abstract class Type_0ef9d1346572486d9e2b639f341d654c: LuaEntity
{
}

public abstract class Type_261fdbefa42d4b7887206105d24c30f9: bool
{
}

public abstract class Type_113d1666772840d5b6218ddc020de2c7: double
{
}

public abstract class Type_6f627093c52047e89689c573708b8925: string
{
}

public abstract class Type_69368cc401ab46a1851f8269bc766557: uint
{
}

public abstract class Type_dcc9ada4263b41c8b5ab5bbf1540dadc: Dictionary<string, uint>
{
}

public abstract class Type_f3136d33b18b472abd1d513cb8552c37: string
{
}

public abstract class Type_b86a4f5a33e940c08db5d019298e0c9f: double
{
}

public abstract class Type_7c18e6c3136243eabf8ad14cd30d904e: Dictionary<string, double>
{
}

public abstract class Type_e135dc9ced89498d910a98f5a88ef106: string
{
}

public abstract class Type_9b84550e67564fa98bc2cf1d5c5719ca: double
{
}

public abstract class Type_9eb28e63f9284422872721573dc35e84: string
{
}

public abstract class Type_e24626d9352445bea1d35a96ad4c902e: uint
{
}

public abstract class Type_8b1bf151fcaa4a87ab123a73383fcb89: LuaEntity
{
}

public abstract class Type_456839a076a94d73898f0e8036ed4681: List<LuaEntity>
{
}

public abstract class Type_7b9cd28ae210484f9bbd524e22e45927: uint
{
}

public abstract class Type_f231377f2ca04d90a3925adbbab112a1: string
{
}

public abstract class Type_370511b6c691499cbe6742ae9145be1f: ItemStackIdentification
{
}

public abstract class Type_e61bf1c0b02b4773b3ca446ceba4544d: Fluid
{
}

public abstract class Type_a94df3d57ee24544a32627c8313f39a1: double
{
}

public abstract class Type_aebc18a19fe24b05b53505b1da40b16f: bool
{
}

public abstract class Type_b13de8feb81440e0b70855f55a40df8c: bool
{
}

public abstract class Type_c49df6e82bea4d6dae2bdef684fe9498: Fluid
{
}

public abstract class Type_866f7f33670e4a67acd537006ca6f51a: double
{
}

public abstract class Type_c2565784d8a14a049818310863c01f3d: ItemStackIdentification
{
}

public abstract class Type_5ace58a1bc924885b8dd82188d2c90cb: uint
{
}

public abstract class Type_5ec7e998de6c4b519af4eb4b63096887: bool
{
}

public abstract class Type_87dc8554e7bb4e84a9cef61c9b2589e5: string
{
}

public abstract class Type_6c5e42d1d8bd479ea6aedaeb28c4de00: bool
{
}

public abstract class Type_08dca49a57e54017831cad54202ba29b: bool
{
}

public abstract class Type_68d93b8293b34d058c1e074936ba1f77: bool
{
}

public abstract class Type_ad90563fbae54634bdc42ca7fe67bdb9: bool
{
}

public abstract class Type_b88fe09026224f17a0e6f97898733f87: bool
{
}

public abstract class Type_134d5458e5154ac7bf415580b3b255b8: SignalID
{
}

public abstract class Type_b3c5a1b19f2147139b9df3cd56671b8b: SignalID
{
}

public abstract class Type_931b44202b4f48b095177ff27ff27a4c: SignalID
{
}

public abstract class Type_9210c96a22544d44b3fa34678f63be72: bool
{
}

public abstract class Type_942e8ef50d814e70afda942b28d2625c: string
{
}

public abstract class Type_886c7e55c9c748c1ae208a03de677eec: bool
{
}

public abstract class Type_37caf2a7c9ee42019d294cad1f249749: string
{
}

public abstract class Type_165711fddef94384aad8960dc8f3e117: bool
{
}

public abstract class Type_6e90c1ab527d4e5b8f9e2d024ec8f970: ControlBehaviorTransportBeltContentReadModeEnum
{
}

public abstract class Type_1c04e30c299a4e33ab040ed538fb8a1a: bool
{
}

public abstract class Type_fda4e844917b48be8ae46f4de60f9fc3: string
{
}

public abstract class Type_90219246a3aa48bc8d75f1b4f874c495: LuaTransportLine
{
}

public abstract class Type_5e120ac5b2bc41e2a50b7276bb9f8439: List<LuaTransportLine>
{
}

public abstract class Type_c4a37b4308af46aa98b4197dca74a295: string
{
}

public abstract class Type_d7fd141af53c482e82715bdbf2e2f50b: LuaTransportLine
{
}

public abstract class Type_9008a3a6ccf64d468a2b82ef1ce071e4: List<LuaTransportLine>
{
}

public abstract class Type_4e7dffa422b1413189402e19712b0cba: LuaEntity
{
}

public abstract class Type_cb30a6ab1c0e4a72854b15e135365673: bool
{
}

public abstract class Type_38dce82624ac4f7e80fcdb0b50e5c588: LuaItemStack
{
}

public abstract class Type_1cb94d93dfa14c3d989e340706fffe7e: uint
{
}

public abstract class Type_b8c96291a6da41e4bf10639f433dcb68: float
{
}

public abstract class Type_e3f5cc1ae28f49249a86c9e742d18529: bool
{
}

public abstract class Type_a80337dec2fa446591a2748bd990ca81: bool
{
}

public abstract class Type_7c6d39df336c49ea8f11a56d380c58f3: string
{
}

public abstract class Type_3da4799a94c9434889b81918a2d57b70: uint
{
}

public abstract class Type_6636f9dc31724124bbfb68b3c5525317: Dictionary<string, uint>
{
}

public abstract class Type_6315adb3152b49e5814d82c8dc77e888: string
{
}

public abstract class Type_283d867febcf4d828bac1b807b54855c: uint
{
}

public abstract class Type_c23bbadaaef74105a4e4d17f1a9c4ae0: string
{
}

public abstract class Type_5378a2c8b89f435db42c498f94982d37: ItemStackIdentification
{
}

public abstract class Type_ae3dca844ea1497d978cec2180f53364: float
{
}

public abstract class Type_e97a2bcf8a964d91b59cec6d13d0f92b: bool
{
}

public abstract class Type_77393a3d8b174a34b97e5756bdd5e588: ItemStackIdentification
{
}

public abstract class Type_ad129e205d7b431d869acac0c4760419: bool
{
}

public abstract class Type_66225d528748432d914346b201001609: LuaTransportLine
{
}

public abstract class Type_951c69dad51e4d2b8d334d74b3aa7dbd: bool
{
}

public abstract class Type_9a7a1e8eaa1f4ed69c1b6b5d76b3aa04: ItemStackIdentification
{
}

public abstract class Type_0e562da89c29401aa40f95ff687d1ac1: uint
{
}

public abstract class Type_e98dd3d9c7ee47e68f50ef04d37e7243: bool
{
}

public abstract class Type_4d56f409c0394977b3070f62285d842d: Color
{
}

public abstract class Type_bf209f1b52024fc4bf0cb24f78f8028a: bool
{
}

public abstract class Type_082508bdfd4a4e5b8da58c5618d1dae3: uint
{
}

public abstract class Type_6d3efb767a314e369dfa3314c955331d: double
{
}

public abstract class Type_d6991b2602524720b57d6f8dde61f6f7: uint
{
}

public abstract class Type_52a648a76d244459b521629f2efb85ed: uint
{
}

public abstract class Type_f6dc29d9b9024ce6beb840f3e71e3967: bool
{
}

public abstract class Type_83632fe23c0e49c7b7436176c36268ba: uint
{
}

public abstract class Type_a99d9728ae7c4e238c656fff34a184a0: LocalisedString
{
}

public abstract class Type_9726cba235f24065a9aee33891beb1b8: LocalisedString
{
}

public abstract class Type_deaf401ef41a43cf80825a3e2ae265de: double
{
}

public abstract class Type_df390e4ebf774868b23bc1fde1750119: string
{
}

public abstract class Type_48f1b0a727ac4a5bb9401d4ff50cfddf: string
{
}

public abstract class Type_e5315df6353f4a44b7fdf29db6d62de6: string
{
}

public abstract class Type_e9251160359446d293ef0f909c209213: RenderLayer
{
}

public abstract class Type_b135aef50be14c3480f731cd992714a1: bool
{
}

public abstract class Type_8d8e6e2c37594d9a8c8e522a15167acb: uint
{
}

public abstract class Type_8083df3189ca486a804a34bb73b2d9ba: double
{
}

public abstract class Type_443de0c641ef4e90a41ca43ead570d7f: bool
{
}

public abstract class Type_d21524b9ab6b4f72886823e05be94e3c: string
{
}

public abstract class Type_b920b86646dd499989aa186083a91fcc: Command
{
}

public abstract class Type_ccff797407a04244bb04bce89683751f: Command
{
}

public abstract class Type_ebfd27250a6249ddb6005bc290a6c5ce: LuaForce
{
}

public abstract class Type_c93b26574aa145cb87d7c59a2fcaa818: uint
{
}

public abstract class Type_449c08d8aa8542b980560e987ec92461: bool
{
}

public abstract class Type_5ac544487fef4b58a5ec4d0af572a320: LuaEntity
{
}

public abstract class Type_25cf9628a52e44d0b5b6ec1ff86634c5: List<LuaEntity>
{
}

public abstract class Type_aecb0c52d2b343039f49c617bafc9e7a: string
{
}

public abstract class Type_bf8694378daa4992868ed3efa5f7b70b: MapPosition
{
}

public abstract class Type_6c15fe6d863341b79840a43c08b7482f: GroupStateEnum
{
}

public abstract class Type_9b30fdd2d59e47d1b12e2f85a04b7a8f: LuaSurface
{
}

public abstract class Type_ebb94df532ff48b5a34722defa13efe2: bool
{
}

public abstract class Type_c5da5c2288954f81bfed6af443e407f9: LuaEntity
{
}

public abstract class Type_446e892ee24d4dc396d3ccad5656a750: string
{
}

public abstract class Type_aa3261cbd13741fa91e1119a7263d854: Command
{
}

public abstract class Type_5c7de299da9541fe8177eab0952c23f0: Command
{
}

public abstract class Type_b8fa08f3ebfa4dbb82ef38787e1e8e1d: LocalisedString
{
}

public abstract class Type_3f4bc44dbfac42429ce6a38808624190: LocalisedString
{
}

public abstract class Type_746ab59251b048a0a1f30bf2d34c2c52: string
{
}

public abstract class Type_d01f2c305c8544e19b23ee8e5f769e4a: string
{
}

public abstract class Type_b377620c83994443bc9dbad5665be6d6: string
{
}

public abstract class Type_cfe64df55e1849be8bf0e24876c90f64: bool
{
}

public abstract class Type_db0b942c9c2e4640b5a5af6daabb4459: LuaGroup
{
}

public abstract class Type_398725bd7de541f394c90937a4d28885: bool
{
}

public abstract class Type_758784a661d4433293a8397ecb37504b: string
{
}

public abstract class Type_0e016585a63e4b92bf1ef9975255015a: double
{
}

public abstract class Type_f25da7be948841d393b10969b1f84d40: string
{
}

public abstract class Type_5fb141b4b5b64ba7a1f9eda5a2f0a1f5: bool
{
}

public abstract class Type_a52503e6da16488eacd4c36d3e608ded: bool
{
}

public abstract class Type_cdf79a2c3b56455e9b728b4314586000: bool
{
}

public abstract class Type_5de6b22b2e304ead9c149b3d18a6d684: string
{
}

public abstract class Type_82437a0e2af947a9a0aeff0084e1f811: CircuitConditionDefinition
{
}

public abstract class Type_0c3e5f1816a741c2ab4c61349e640163: string
{
}

public abstract class Type_ade577fdb05c44f18c2c15427dd9b561: bool
{
}

public abstract class Type_0887cac5924f45f5a0ebb1d3e77ed2c9: SignalID
{
}

public abstract class Type_b18f4907986d452bb950ddd778224467: bool
{
}

public abstract class Type_fa4a94e1b4fc4fec914b7bcd7c679744: bool
{
}

public abstract class Type_4386e0503c5a4a09960e8a5164919c1d: string
{
}

