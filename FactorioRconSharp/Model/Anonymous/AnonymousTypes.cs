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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_050af24f14294573aa43a2da5eef4fdb
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

[GenerateOneOf]
public abstract partial class Union_62b4d42373bb4b819744e75b9e143004: OneOfBase<string, List<string>>
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
public enum Literals_14f663a7aa90443f91e4932994023833
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

/// <summary>
/// Union of literals:
///   - center-to-center
///   - bounding-box-to-bounding-box
/// </summary>
public enum Literals_0894aec7511742478f4cbced204bd5c0
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

/// <summary>
/// Union of literals:
///   - projectile
///   - stream
///   - beam
/// </summary>
public enum Literals_f91b5cb67185460daa2b80c7b9f2e9fe
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

public abstract class Table_942be70db2a44649ab5666d238380c46
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public abstract class Tuple_8a579f39d4bb4eb8a8f1244f1a227868
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
public enum Literals_4c8639f91f544c8db1a09c2b38a3e100
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

public abstract class Table_34a448b189464b11b795847ce8f32900
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Tuple_c8ef66468fb54cd697f3ad9f01afcaa3
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_4b540f4f67c7473bbb772e816a0021ee
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

/// <summary>
/// Literal value: not-colliding-with-itself
/// </summary>
public enum Literal_6f2d568bde4f49d485dec0dff7542a80
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
public enum Literal_43fc962cc3e74110bef60af37642c8db
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
public enum Literal_cdf3131b59a4453583f8bf60624e8367
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  Collidingsubtractwithsubtracttilessubtractonly,

}

[GenerateOneOf]
public abstract partial class Union_ae2efb64c409418d823bf519910ae89f: OneOfBase<CollisionMaskLayer, Literal_6f2d568bde4f49d485dec0dff7542a80, Literal_43fc962cc3e74110bef60af37642c8db, Literal_cdf3131b59a4453583f8bf60624e8367>
{
}

public abstract class Table_cd1f6465420a4cd09014336d8c9ebef5
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

public abstract class Tuple_731a758830a847838d08aa276fc3a400
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

public abstract class Tuple_cf6ec2ffd906414a967b565dd54f419d
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

[GenerateOneOf]
public abstract partial class Union_a49663851796444399e7ff28da77f848: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_8970855f6acd447ca2eedd0a28e4fba1
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

[GenerateOneOf]
public abstract partial class Union_a216fdf355884ed49978ff52f626b199: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals_2ba76542c15c4d93ba847cb7005b7705
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_81f840f84f994d78a3e3c0e7906b2eb2
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

/// <summary>
/// Union of literals:
///   - collides
///   - layers-equals
///   - contains-any
///   - contains-all
/// </summary>
public enum Literals_b033116b49c24d06b0a8ec6c22ad0fdb
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

public abstract class Tuple_e968521550ea4911bd679b86be46d822
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_208c75aa84fd4dd6818851f2d640091b
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

[GenerateOneOf]
public abstract partial class Union_c5dbae64c731463082587c789d0a3d82: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter, LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter, LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals_8c539b93e4964a63af09b363ce2558d9
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_c349e67fc68c40fdad8b5fef05ae2b38
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

/// <summary>
/// Union of literals:
///   - player
///   - target
///   - player-quickbar
///   - player-equipment-bar
/// </summary>
public enum Literals_22ca2e07b3c34cbe81768e03950649f2
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

public abstract class Tuple_3c6430b02763470ab4cf55055e142789
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
///   - add
///   - remove
/// </summary>
public enum Literals_c4506573a4704cbb987bed4fa0039c9f
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

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
/// </summary>
public enum Literals_15e29deadeb94ca699b4cdb146ca4ce6
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

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
///   - add
///   - remove
/// </summary>
public enum Literals_a05f37cb6ebc4c6fa91f80872105012a
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

[GenerateOneOf]
public abstract partial class Union_daa813044b6c4683b39a27e063f1b65c: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals_4d1f4ebaddbb4c60a04b88492ad152c8
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_946cd558285949a7967c3fbbead4b1ab
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_83a53c0d24c54cadacf469ac171255c8
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_a2f5d70e608b437cb3a2ef47020822d8
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_15ff3f6f64d6409b948d2f51145f0731
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_6e66afe60777429b85bb1704fe18bbac
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_3f8b23765f92450db9be33822e38fa4f
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_c2f37e69ea6f442a8070f338c3b118a9
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_402cfe2ebb614c249cf5283d2a4748ae
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_d06eb4457bc84c1c83deeec6892c42b4
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_1026b561b3c54c61ab8df5202fddd918
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_567615ce4f0e4468878327c2ccb11893
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_8972cb19247549a3bf8b8bcc45651327
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_69ad8a6e55ec4e4489140f4dbe009034
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_74627786bb254412901030abd287a25a
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_33a63cabc1b6469c81077b46e889380e
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_d3b37fa1cbe54f9f8ee1f8d57a7f6f6f
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_c5740b89628a462b9bd0852f2f4fc132
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_824204dd843d4b6db29224b9e417f0ea
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_03376876cf5a4e8aa489c44817fe157a
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_16d4cbfe16a144a1bb44835994496b3b
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_ae0b2ea479854368ad11c5ea7555b28e
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_c0d6addcb67a4bedb3ace1f3f9513493
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_e18cc7c4a17047f2a7bfbcda38db232d
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

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals_4e45d141d7df4095a30bfb7f9cb1bd4c
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

/// <summary>
/// Union of literals:
///   - entity
///   - tile
///   - decorative
/// </summary>
public enum Literals_db4935d4775245738e4251f71aa47e87
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

/// <summary>
/// Literal value: none
/// </summary>
public enum Literal_e9929c90497d487ebc684fc282e5d70c
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
public enum Literal_2a191aaf64c241bead95618d06337b55
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
public enum Literal_636714bb197e41d494e5f367ea3dd314
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
public enum Literal_d4bb5b9c00a74423bfb34ba231ef41d5
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
public enum Literal_6798e93c9e824006b19648ebcb87639e
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
public enum Literal_2533f537226a41718997d37ec2ea4991
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
public enum Literal_ab2b8a90ae154667bd788752663d9471
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
public enum Literal_ae11bf2472b84b2ebe45ee7bb805df21
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
public enum Literal_f49afaa62bec464a85810361bbc7b1da
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
public enum Literal_9220240aab6b4a4d9427bbdd460557f2
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
public enum Literal_371629012161408c85c034031cc6b76b
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
public enum Literal_b85c793885be4f378b4cfec88d808a51
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
public enum Literal_085a6f20ed044abf9704c694d7cae693
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
public enum Literal_ba582ea63c5148f5b5977d540866b5a7
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
public enum Literal_0d9516a3afaf4422b6f9a7e350d1824e
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
public enum Literal_6067d49bef83424d9c88354358d7633f
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  Verysubtractgood,

}

public abstract class Table_b25b0ac0751e4d18b2cdf3dc575b4ac6
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public abstract class Tuple_12abcb3349084f3fa16bec31b12ddfe6
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

[GenerateOneOf]
public abstract partial class Union_78ca48ec41f546e1b1e2a62ad4ddf7ee: OneOfBase<int, double, bool, string, Color>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_90f147e13c95491ab18ba5fc72ca5770
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
public enum Literals_f895380ef3de4866852d2a0acf932d5b
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
/// Union of literals:
///   - normal
///   - underground
/// </summary>
public enum Literals_54e70034b6c34502a0659a5162d84fd9
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
public enum Literals_e5fa1ebfda3f4fccad4cb059cea7563c
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

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals_7cd80bc895a74f9588f803ac48cc4d81
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

[GenerateOneOf]
public abstract partial class Union_751b2327c32d4625949efbbd60b76964: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_9df5b7e351a945ab948c0f1154804260
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

/// <summary>
/// Literal value: water-tile
/// </summary>
public enum Literal_1c562ecce6fb4dc5aa9cfc371794af5b
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
public enum Literal_fd3f7d216ca1442fbd36f4b89c7abcd6
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
public enum Literal_36a65eb934414941986cd3f7ee3b5ab8
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
public enum Literal_bb9f5af784984b01b15c1afeb0cb3928
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
public enum Literal_ee64d133faa24e39b509d0cf7f514494
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
public enum Literal_7db984cabdef43bb85db903007ec5a9f
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
public enum Literal_e44bfd08b5a040b68af3ef91db61525f
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
public enum Literal_bfdbd174bbb94bae90d8ed6867be3fe4
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
public enum Literal_a8a3489393664d2d932aed870438f39a
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
public enum Literal_740889bcd8774d3698888db2a260496e
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
public enum Literal_195550fdfe32499f85c14d1405941a2b
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
public enum Literal_bc682fb30c7c4f7391a9bec9c203443a
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
public enum Literal_9652374f62804ce7b3b1bfbba1424e63
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
public enum Literal_34887f9292c64666a1007bfac8e8e6a9
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
public enum Literal_117ea08fd1ac4871a57210e547144322
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
public enum Literal_d6a7eb603aac4f59add805d18ea41f22
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
public enum Literal_d9ab526a4d4d42a8965432e2ad6a87bc
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
public enum Literal_6889daad5e7e4943b8d8a3e049a4e89c
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
public enum Literal_5e427e5d41e34f4e938a1b15de0e8675
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
public enum Literal_72dcbebcc3dc4e3ea487cc8b3638b9cb
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
public enum Literal_c45230bb3b76447386667f56d888fa6e
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
public enum Literal_37cc7032d52248b2a60db2ccb348316e
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
public enum Literal_f67f397e72a94828a7cf933abdf114e0
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
public enum Literal_8773e4f6a322412796487b8a97cdd0ed
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
public enum Literal_c6b20f431a544cd790fde8dd6d8be245
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
public enum Literal_d1f40f91e7fa49faa4b9610c0907e491
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
public enum Literal_29d99453eecd43d6987b796acbe01342
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
public enum Literal_c9d0a5a2daad4417af6a184d986e9465
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
public enum Literal_c4942b90387746b69f25faac157a522b
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
public enum Literal_676aa9d4a7514c2eac8cfd5891adad37
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
public enum Literal_df0d13b28afe4049a420c631e011fee5
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
public enum Literal_1f18c9bdb5294112ab1d4cdf99513911
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
public enum Literal_6f944eafbda94dc7a53ed3eda54bbd65
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
public enum Literal_17c02b6a509f45d98587e1c4f9f40ed7
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
public enum Literal_2091d8c04c134ef0ba717b8b88dae43e
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
public enum Literal_23c41045bff44a559b91ef6198c13fef
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
public enum Literal_29d080ecfe3a4d1aa641c19856b44eac
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
public enum Literal_c33c82f5e13a4c7d862f12af09ad0af8
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
public enum Literal_d3b3f70af6a645ad9a0927e95577f031
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
public enum Literal_173a39a77dec47ea81e90e9d17f82c18
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
public enum Literal_35dab9ec8cac41ad8691e9ada6d1f5e3
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
public enum Literal_fc9e72c648344fbab46ded719d203777
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
public enum Literal_8e264c5a776e4a08bcfcc07dcb9507c4
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

[GenerateOneOf]
public abstract partial class Union_2570cd50128d4b35b85d8a174fdba3f6: OneOfBase<MapPosition, LuaEntity>
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
public enum Literals_d927a729968442dc864f0818485f1448
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
/// Union of literals:
///   - item
///   - fluid
///   - virtual
/// </summary>
public enum Literals_118b30e5bea547bebd2d6dc99210fdb5
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

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_c6778e3b567e4155be8eb53416a2da4e
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

public abstract class Tuple_8db8a8e14a2d4e108d30c7aac7c809a7
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_244266b47b6744ccb460d2baf27c3f55
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

/// <summary>
/// Union of literals:
///   - instant
///   - projectile
///   - flame-thrower
///   - beam
///   - stream
///   - artillery
/// </summary>
public enum Literals_4da71100335d4209b74bf237263fbd5e
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

/// <summary>
/// Union of literals:
///   - direct
///   - area
///   - line
///   - cluster
/// </summary>
public enum Literals_4037cc05be5940df8e6aed8340388bd6
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

/// <summary>
/// Union of literals:
///   - item
///   - entity
/// </summary>
public enum Literals_7aa5822617ec4df9ad980099663933aa
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

public abstract class Table_ae7c74efa1744aaabe50751cc1d02c3d
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public abstract class Tuple_787d79267c5447e59cc4ae7bd22d05af
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

/// <summary>
/// Union of literals:
///   - and
///   - or
/// </summary>
public enum Literals_b5151f7570bb42668a35f1ac96350b30
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

public abstract class Table_d09931ef453c443797e5d8dfd3b9030c
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

[GenerateOneOf]
public abstract partial class Union_4e17f928a4e4482bb83638d03fbcdc8f: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_aa09c194e9dc4eff891ec735d9ad25c8: OneOfBase<EventsEnum, string>
{
}

[GenerateOneOf]
public abstract partial class Union_4470318d2679472ba969104eb1979e13: OneOfBase<EventsEnum, string, List<Union_aa09c194e9dc4eff891ec735d9ad25c8>>
{
}

[GenerateOneOf]
public abstract partial class Union_b6ad7dcdb5524a18b8a4e3a418e18492: OneOfBase<Action<EventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_8306cafc48a54ab1b7c97c91dae280e2: OneOfBase<Action, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_db2ef7751a16478bb49e57310524b1b2: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_7c97928f054541bbafd4cdc69ec2e568: OneOfBase<uint, List<uint>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_da0ed1bbbc3b4921ab55709fed269140: OneOfBase<LuaEntity, LuaEquipment>
{
}

public abstract class Table_9d31ed9aaa514d3690d47dbc1192fc4c
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

public abstract class Table_47c62baab2ab43be8e9d1a27b9757db9
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

[GenerateOneOf]
public abstract partial class Union_d028cf848a3e41399bee2f6283413b41: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public abstract class Table_4d9e9aaaad804af2b7dc4feca020bae9
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

public abstract class Table_bb3fedceb6cd49c28050f58073e9bd18
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

public abstract class Table_5ed4534feedd48d9ba81579bad029faf
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

[GenerateOneOf]
public abstract partial class Union_37b243a5382942f9835263ece81791a7: OneOfBase<string, LuaRecipe>
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals_1862a146595243b69805bee796e074b7
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

[GenerateOneOf]
public abstract partial class Union_d1756ed7bbb94f24b81c9c60d5875291: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Table_076f09cdf4b3410cb3446dc6f930aac5
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
public enum Literals_d21bb27c2a8d45469a288ccdaf32379a
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
public enum Literals_3d318e70fd8d4f78b03e538f408c5535
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

public abstract class Table_4b99b2d7615847229f94112e03df2e78
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

[GenerateOneOf]
public abstract partial class Union_e7a56ebe64354beab1e0ddf2ee1ccc03: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals_4110168194d245fab62f04519ae0eb1f
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

/// <summary>
/// Union of literals:
///   - input
///   - output
/// </summary>
public enum Literals_c0ec478fb4c845deb79bce170718baba
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

/// <summary>
/// Union of literals:
///   - input
///   - output
/// </summary>
public enum Literals_3e278a5f24a54c8dbf39e8b3b5ef9207
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

[GenerateOneOf]
public abstract partial class Union_d3519403db13421aac1e515a32d6f12f: OneOfBase<Dictionary<string, List<LuaEntity>>, List<List<LuaEntity>>, LuaEntity>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals_113d00e8aa3a4447ba5bbf354884c491
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
public enum Literals_31133a341aea43cebe425769e06cee7e
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

public abstract class Table_d18749969ffe4700a32cc5b94c53a5a9
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

[GenerateOneOf]
public abstract partial class Union_8a50d343c7164149b70ea0646883c088: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union_c8da3173acfc432da7664e136c9acf09: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union_83fc5900f8fb4d6297b736b235eb6df1: OneOfBase<LuaEntity, LuaPlayer>
{
}

[GenerateOneOf]
public abstract partial class Union_f3495b397e884cdf91406db6fd8805fa: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

[GenerateOneOf]
public abstract partial class Union_44fc3faba1b34763a24dca98fb64695b: OneOfBase<LuaEntity, MapPosition>
{
}

[GenerateOneOf]
public abstract partial class Union_fcb6edfa59764045a7a4f2b2e624d5eb: OneOfBase<LuaEntity, PlayerIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_11593840fc074f5181a4e7e97b4b19f2: OneOfBase<string, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_6d48cd2804bc4ddab1f9992a7df73403: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_2d66a1b0efd5444bb35438967502e377: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_fbfcb788a7cb48f9ae3068383a32edf8: OneOfBase<string, LuaRecipe, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals_cc6aff98ed0148b7946bc040e232247f
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

public abstract class Table_d36ecafef742466e97c1c21990c58dee
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

/// <summary>
/// Union of literals:
///   - requester
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
///   - none
/// </summary>
public enum Literals_66d63c3db29e4474b577eefcd3246800
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

public abstract class Table_b7ffa245791a40faa9f2ef050d63ec14
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

public abstract class Table_f0e765da70e344e5afbd491d69c5b6fd
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

public abstract class Table_fb9c59a837994b6f94ae21aa227314f3
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public abstract class Table_571c574d63714236bb03db5c485d1966
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public abstract class Table_5a376f09d5974df986f40907def76b9e
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

[GenerateOneOf]
public abstract partial class Union_05bde578e2be4158b08a55fdd8a36084: OneOfBase<ulong, double>
{
}

[GenerateOneOf]
public abstract partial class Union_8851b6c39888458b865a0fccc865515e: OneOfBase<LuaFluidBoxPrototype, List<LuaFluidBoxPrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union_f9add580ba07483384b3c67ee8f7666d: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals_eabe730238444b4cb89694efe84c8e13
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

[GenerateOneOf]
public abstract partial class Union_edd565b708da43f1b33f84dcc346d9b4: OneOfBase<Color, PrintSettings>
{
}

[GenerateOneOf]
public abstract partial class Union_412490f2c5744386aebdb9e1132bb1c9: OneOfBase<uint, string>
{
}

[GenerateOneOf]
public abstract partial class Union_34e2c1dbf42d4d168ff69c6bef57642e: OneOfBase<TrainStopGoal, RailEnd>
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals_56370bb55a0d4a83b5ae5733012b5acb
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

[GenerateOneOf]
public abstract partial class Union_6f788da5509c4d44b592525b7132eec7: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

[GenerateOneOf]
public abstract partial class Union_22df73005d794679a76709044270b997: OneOfBase<string, SignalID>
{
}

[GenerateOneOf]
public abstract partial class Union_0dbb0f87b0b84fadb7b5778cb553594e: OneOfBase<LuaStyle, string>
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals_29fcda1f0e554553ab638952ade83c00
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

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals_bc4e64134af2491c8fdd2a4b683976c5
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

/// <summary>
/// Union of literals:
///   - none
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals_775638f40f604ce58b49f0bbf51bc11c
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

/// <summary>
/// Union of literals:
///   - default
///   - never
///   - always
///   - when-manually-filtered
/// </summary>
public enum Literals_645aa0901acb438e9e700bc1745febb5
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

/// <summary>
/// Union of literals:
///   - default
///   - player
///   - turret
///   - vehicle
/// </summary>
public enum Literals_e0e01151d09542929b97e8ee65f678e2
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

/// <summary>
/// Union of literals:
///   - default
///   - never
///   - always
///   - when-manually-filtered
/// </summary>
public enum Literals_b6323f66b53d45c69d713dd05cb008e7
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

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals_50d2f06a21244b6aa9ea77a5cb1bcb1d
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

[GenerateOneOf]
public abstract partial class Union_9efc1f6a1562494eb3cac3a25d5e19e7: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_9ab2202a29f34d2c945625d3c6845fcd: OneOfBase<UpgradeFilter, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals_5eb0a1cfae7c4bb7b8a1658bac40d5c4
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

[GenerateOneOf]
public abstract partial class Union_3cc410bfd5db4140b475de746c9729a2: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals_9f1becf05f2d42d39eb14abc9d55d521
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

/// <summary>
/// Union of literals:
///   - storage
///   - storage-empty
///   - storage-empty-slot
///   - requester
/// </summary>
public enum Literals_edf9837d815f425db49121206ad80c9b
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

/// <summary>
/// Union of literals:
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
/// </summary>
public enum Literals_939d51da55ea4245a3ecb0867aa50079
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

/// <summary>
/// Union of literals:
///   - storage
///   - storage-empty
///   - storage-empty-slot
///   - requester
/// </summary>
public enum Literals_2830711851bd4a078036b4c0b8ff3341
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

/// <summary>
/// Union of literals:
///   - active-provider
///   - passive-provider
///   - buffer
///   - storage
/// </summary>
public enum Literals_f2027ee26be24e3da3b94bb58fd87418
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

[GenerateOneOf]
public abstract partial class Union_38deb8f16fc84bfc9d0ab31cb63f2bf3: OneOfBase<List<string>, List<int>, List<double>>
{
}

[GenerateOneOf]
public abstract partial class Union_dbf9bf5a5cd34b82a3c81210b7fa4471: OneOfBase<bool, double, int, string>
{
}

[GenerateOneOf]
public abstract partial class Union_adc134b8d7a04ab98d454599c744aa14: OneOfBase<double, int>
{
}

[GenerateOneOf]
public abstract partial class Union_2ca2a1b7257c41fdbdb085b9c6516f56: OneOfBase<string, uint>
{
}

[GenerateOneOf]
public abstract partial class Union_d36869b73b3e4cbc92cbf5d0af54be06: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

[GenerateOneOf]
public abstract partial class Union_30152a93cf904d9eaf23d0fcf7791f76: OneOfBase<LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public abstract partial class Union_92ffa47184d947ac8b4c9c209da80889: OneOfBase<string, LuaItemPrototype, LuaItemStack>
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
public enum Literals_27954f9a214341bea197921d1cb53339
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

[GenerateOneOf]
public abstract partial class Union_4c790a45e9e6460e86c00161c9eb7934: OneOfBase<int, List<int>>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals_eca34a2ba2c24993bee507338874056c
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

/// <summary>
/// Union of literals:
///   - top
///   - center
///   - bottom
/// </summary>
public enum Literals_278c78d92ca444bc917eb1487a7cfc67
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

[GenerateOneOf]
public abstract partial class Union_21690fdd97ce41789c7fdc8018f5d180: OneOfBase<LuaForce, string>
{
}

[GenerateOneOf]
public abstract partial class Union_bd48e0568a184bf38262ccf1d6fa1416: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

[GenerateOneOf]
public abstract partial class Union_c874a165234a4726a1a4fe73db72d5da: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

[GenerateOneOf]
public abstract partial class Union_25b19bc2cf594e9aa676a73dead4d952: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

[GenerateOneOf]
public abstract partial class Union_29be08a5ea8c4b648c32e623ed4405fe: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union_3c6cb1a644c54d8da1e7a14cd8c8ac85: OneOfBase<CollisionMaskWithFlags, List<string>>
{
}

[GenerateOneOf]
public abstract partial class Union_f624c0318fcb470da8d4c0fe44db04d3: OneOfBase<string, LuaTilePrototype>
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal_7ceb2527af8b4cc58162f398a3ed6219
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public abstract partial class Union_30148163e33345a0963a773335e3a771: OneOfBase<bool, Literal_7ceb2527af8b4cc58162f398a3ed6219>
{
}

public abstract class Table_3c9dda599e4f447780ce267b44a4f1f5
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

public abstract class Table_32755f10ea844e01a3f5507de2d4f902
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

