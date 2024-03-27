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
public enum Literals_29bc27000ef24875931afb8ae3250ee6
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
public abstract partial class Union_15322821de664c9f856201c8fe7bc9ac: OneOfBase<string, List<string>>
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
public enum Literals_ee7da92ad6bb4388aab68ce3797ce16b
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
public enum Literals_f8b48a28787144c799fd6dc765f41e45
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
public enum Literals_0643d51930f24a459177703f91a106b1
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

public abstract class Table_8b8d83ceab384d2bbab03c5f2ec7872c
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public abstract class Tuple_4c6f522565ce43baabcda365689f25c8
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
public enum Literals_1b0e347c2487464088fbd3fb45fff44b
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

public abstract class Table_dfee8b0052fa4341a5161a408caf1ab5
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Tuple_ac54399f4a7d45fd95edefb63dd60a0e
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal_b36dbe3b10d14af8bea2ec781245305a
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
public enum Literal_45ad3d362c42491bad6f589b78c3f84d
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
public enum Literal_326da56d07e445f292743ac3b7219c96
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
public enum Literal_2b8d139d4c7744a9a59e061e49002bb5
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  Collidingsubtractwithsubtracttilessubtractonly,

}

[GenerateOneOf]
public abstract partial class Union_97d5e462394544e9962c7559503b0c89: OneOfBase<CollisionMaskLayer, Literal_45ad3d362c42491bad6f589b78c3f84d, Literal_326da56d07e445f292743ac3b7219c96, Literal_2b8d139d4c7744a9a59e061e49002bb5>
{
}

public abstract class Table_79691af683294a1da82299c9a7395b8e
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

public abstract class Tuple_0a00738154b34ddbbc6c8e6413922b4f
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

public abstract class Tuple_95223dbc07f6494fb271d4db11261101
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
public abstract partial class Union_5d967d8aa48c41ed9152bd53995aa3ad: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_8c99d70ddb264db682d3ff89d7696f9a
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
public abstract partial class Union_4ba2411f0fb94f9a8e42181fa51e1435: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals_79374eb8ac4145eb92ea110307a6f6fa
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
public enum Literals_3adf1e6bc90c401ab7b90e362e8222d9
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
public enum Literals_358d51f3344a48a18042419a7cf9a30b
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

public abstract class Tuple_ceb4707b717c4723a2387d73c66f45c4
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
public enum Literals_932df1ff2bf64e2eaaa06cea8dd2c2e3
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
public abstract partial class Union_0fe9efe5006b4267a0ff5ecbfb2d0fc7: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter, LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter, LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals_b31d8cf4b9e44474bed9a09285473c42
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
public enum Literals_f4e7232ccf3f432e8e217d89d46a36c2
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
public enum Literals_d043c8d109b44baf85e99e000399c12a
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

public abstract class Tuple_70981d097ea245e19557d7ecb85083c6
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
public enum Literals_9defb12a43244e5397ab7b0043e8a355
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
public enum Literals_41a0587ec54049c79aa58727823e2b1d
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
public enum Literals_e4c5cb51030141859651e1f7027260bc
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
public abstract partial class Union_1bc34c18d6234186bbd386bcbff8e98f: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals_24b4b5d751ed4c08a55d75c210aae373
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
public enum Literals_7dc5416b1fbc46f386b44fcc983c729f
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
public enum Literals_2551072efb9440d5a564978f03957382
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
public enum Literals_9b8420e6f1c4449893994e6a4c2cfc4d
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
public enum Literals_9f252af132474096805ca009bd50b92d
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
public enum Literals_bb6658736ce3416a88d6cce9591bd8b0
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
public enum Literals_b08af557bae64aa8928054efab58a5c2
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
public enum Literals_1d97e8c17b74496385302609c95dd675
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
public enum Literals_25de7c8df7394a84a6932c43635beb54
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
public enum Literals_ed04577fe8df442c886f2ef0bbf3f7d3
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
public enum Literals_8962d43db6c149b892fc779327820dd7
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
public enum Literals_26693572d0784320a106186b0cd72b75
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
public enum Literals_ee0580758e1c45f594a89a2db4ac7059
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
public enum Literals_7939e41eaa74406a9690156930f19fc1
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
public enum Literals_23c3a23742374728afdafad1bb4e91ff
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
public enum Literals_1f8f7f37d240407da4c2ec1a39b41738
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
public enum Literals_1efbcaa72e534d6d8d551870fead9c5f
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
public enum Literals_38334fe65f514e7e9f90f9d5ea8d158d
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
public enum Literals_55c008d940ae47378a03f92a736fb3ee
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
public enum Literals_8006e6008b4d4f3f9791936b374a2e2b
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
public enum Literals_47d143c8ab3447f285867d4846164a5c
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
public enum Literals_fa3bb005eaa441c899d5a2f56a89a5a3
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
public enum Literals_0ebcff9dab9b40789b3171d45e95c9b6
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
public enum Literals_599d91b0e44d4710bea577ab9c42c7fb
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
public enum Literals_7bdee30315f54d55b10f88e6f04c4028
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
public enum Literals_d9718b186eb949fd8af24571114e7a6f
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
public enum Literal_6e112a76f6e742498a2daf6b43752757
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
public enum Literal_36f16dc4bf3c482798237f03b16f1117
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
public enum Literal_c11a047309184a86a34cd6652a6312d9
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
public enum Literal_ef812de4bd5a43eab3ebc20aa91baeb3
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
public enum Literal_cb4fef1da0d64d46b0eeb74db189e6b7
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
public enum Literal_0bec2b182a3e4925b39d11e14adc6eb2
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
public enum Literal_904fdad438824710956859afaea7c1cc
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
public enum Literal_db612332ea0140c79be93506f40055d2
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
public enum Literal_83511215ebb143b39af1801878a70ce0
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
public enum Literal_e159e4fbf5034e3fa180d4ff9dcc36b8
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
public enum Literal_f3e07ca701cd4a239755ad5ef65f89c2
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
public enum Literal_f9c9c25063084cdea454e01db0d36263
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
public enum Literal_072e303f7d8645249bc7a37011b7016f
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
public enum Literal_a3535ab5ac62472f8354f70a9d8f04b8
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
public enum Literal_03d43b12fa75449884e4c023d9d4379d
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
public enum Literal_23ad07c49dd04afebbd8a18628f7c624
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  Verysubtractgood,

}

public abstract class Table_67b581b3b163413fba4dcdbf9419fc29
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public abstract class Tuple_55819a6fd97846af91c9525f230c2688
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

[GenerateOneOf]
public abstract partial class Union_d245a208afdc4917b11f44fb886d4d6d: OneOfBase<int, double, bool, string, Color>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_017dea80e3ff43e2a23404d2bf2adb5b
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
public enum Literals_5544fa79923244e8bfd46200ed4a47db
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
public enum Literals_3947e9929554404b8bbb87f3a7005593
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
public enum Literals_2427f028afca43cea0e2f46abf5beeac
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
public enum Literals_1b300c7e0075477ab2ac42774087771b
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
public abstract partial class Union_94b6ee39e8fd416fb8752a90047baaba: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals_6d58b31975b847c19dd83c583b8731cc
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
public enum Literal_a2b5ad416eda4b3989934caa12cd6940
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
public enum Literal_dbac3fcc99a74241a45b4525dc008ba5
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
public enum Literal_63c701f0ccac4eb4822fcb6a95284712
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
public enum Literal_2145cba24678441eabd95a0df7673734
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
public enum Literal_2f7787ec14174698847f3a1d4962cc04
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
public enum Literal_c29086f7891a4f538519493e7b81d9a6
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
public enum Literal_98d34d8bec59418a9f3da22891298c23
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
public enum Literal_578efd5fac3f41c3a3d8a3b257d64cc9
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
public enum Literal_205c9103a78a494da83f5eb89511e646
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
public enum Literal_5f06f8eba2504b6f96722b2cac4742ad
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
public enum Literal_a947d4fdd95c41318440ce4cc749fe06
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
public enum Literal_1cf225ccb4bc4b30a9bcd1e81ff0e700
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
public enum Literal_7a2bd2608c4647f480c56adafa23a2a8
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
public enum Literal_1439aed8492a4303a4737bfc7d0933f6
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
public enum Literal_ea9cda00b1c14dca821c691525656b27
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
public enum Literal_4272a26b94964d6fb43f94f4269f14b2
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
public enum Literal_7eaf094120334cba83b3abd376ddec08
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
public enum Literal_60e850ff81a14489902ddec65661f504
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
public enum Literal_c5da3b8e344244569b134268e0c00b42
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
public enum Literal_41166d85b6554c138ca367d3420107a4
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
public enum Literal_5f2be8eba6294cc0ae568c5bd0537e97
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
public enum Literal_e83d4d0275644ac3885bf86ab6855ccf
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
public enum Literal_fa3838167da0437498bace2f53079695
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
public enum Literal_1d053e7ed03b412bbd1deda610292b5f
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
public enum Literal_9e71deb7194b42ebbe91a371e07ed09f
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
public enum Literal_f5307217bab14198b31743bb4a45c04c
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
public enum Literal_6c970e2a2ee84728babce1a9d8f1e3e0
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
public enum Literal_ea5dc90f76754bf1b43ab09d0d28f170
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
public enum Literal_89012854ca844b8f8654acc2f4e359ea
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
public enum Literal_e1ffd85290554ee59bcf6827b7174c69
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
public enum Literal_7ee91a4884a9448eb9bbf5fabfea76cb
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
public enum Literal_8547b959648842f4a4f2f0d630e35376
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
public enum Literal_deae99ef930a47f2bbc0b0ea3d7c6238
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
public enum Literal_699f8d85501e4740b97fd1543761c46a
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
public enum Literal_e452b3d228b04190bdf1729dfff0ce4c
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
public enum Literal_2adb32fdadad48068016ac76f209a460
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
public enum Literal_14d50412535d41a38decc5d85fb9c3af
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
public enum Literal_13cda75dade74e2a88e2b6fe0d49828c
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
public enum Literal_0a25a206cd5c4279b7c5ef8c81fa745a
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
public enum Literal_cdc13eb6b62c4f068e31160eda26a3b5
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
public enum Literal_7e22d0a566fa464b8d931a7cb7815878
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
public enum Literal_162d3308c60e4145802d3ab52e8b39cb
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
public enum Literal_20269154e1e445dc8880d2472c5973db
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

[GenerateOneOf]
public abstract partial class Union_97d78def78f548a885c16178d2d97fb1: OneOfBase<MapPosition, LuaEntity>
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
public enum Literals_4ec1a5399dd247a195b8640cc51dd70b
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
public enum Literals_4930d9fca5a749009a33e8cc327cad09
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
public enum Literals_77a0b6c09a904edd80c91b2b5debf24a
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

public abstract class Tuple_c72dc1c513734620b26339e8199b0961
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
public enum Literals_729e180430ad4298aadc094ca897e7cc
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
public enum Literals_a1cef17fb1e14698907f4d8edb14a87d
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
public enum Literals_c5cfe80416384a8f9d54e4ff6404d837
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
public enum Literals_0d8a66786ce54cc2b3d6a614aeeb4edc
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

public abstract class Table_44a7c1e3414c4b66b230b3c55dda6269
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public abstract class Tuple_f1b220663d064b849445195c2766b38d
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
public enum Literals_148699c0c4c54c3390e6aac755fdb470
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

public abstract class Table_f5ac1a595f7f4cd9b040979d46591aa4
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
public abstract partial class Union_9e4a48c6eb8d4c5f9c29d406b627655e: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_02153e84d1704ee9aaa5d04ab64b9188: OneOfBase<EventsEnum, string>
{
}

[GenerateOneOf]
public abstract partial class Union_0989e2c8e250416181d57ba0ef7f9ba1: OneOfBase<EventsEnum, string, List<Union_02153e84d1704ee9aaa5d04ab64b9188>>
{
}

[GenerateOneOf]
public abstract partial class Union_98139e068f874c80b7ae54460b7d9398: OneOfBase<Action<EventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_11363cbc93034ab7a8105aeea43e51a4: OneOfBase<Action, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_eb8b96026bcc4e06b4392cf45ce77707: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_7a0f5da73a6144a69eb4120e9c49c90e: OneOfBase<uint, List<uint>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_f131840de01c49af805131fa089f55f0: OneOfBase<LuaEntity, LuaEquipment>
{
}

public abstract class Table_b986cd11885748b394f676a1c47e6ba3
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

public abstract class Table_8035ad6316664134bde522d7e6d300d9
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
public abstract partial class Union_23c7b0e272a54c1e9401ee6b36bb5fcb: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public abstract class Table_06b1d5b4b38c4b55957212777f1470eb
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

public abstract class Table_8c94d586d251454eb19b84f329f90101
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

public abstract class Table_0180da38d3c343908cda62b219256a06
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
public abstract partial class Union_ba8a088706d04f2c801ab39746da3d72: OneOfBase<string, LuaRecipe>
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals_cef7f9fc11ce4ac0aba490c4fbbd285d
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
public abstract partial class Union_86e696a89a9f49f1818aa69d473df9ec: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Table_f5309f845b304a388f89d8bad86a06e8
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
public enum Literals_e5565a527f144440aa3176c62dd3e0f4
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
public enum Literals_773cf10470c64f9b9a9c414a29b9927b
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

public abstract class Table_31ac61da27ed473789abca0c424d44f7
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
public abstract partial class Union_d5e68f2b611c4864a93b0befc4d19265: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals_1465ea726d614aeab5b7b66710385639
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
public enum Literals_bcea5a3366fa4d7fa5575f3a29d23e41
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
public enum Literals_2a5a061c226d45a089c659dbacc37919
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
public abstract partial class Union_78982de5e49a4101b6a1a27e5e684b18: OneOfBase<Dictionary<string, List<LuaEntity>>, List<List<LuaEntity>>, LuaEntity>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals_028b47dd0a22496ea473bf94da4d7db3
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
public enum Literals_76c9a0991f62448f94980b346743968d
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

public abstract class Table_e56906fbc23e425bae026f31a579c980
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

[GenerateOneOf]
public abstract partial class Union_869bd1b337b847dba03a5d7f432bba3a: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union_9382cdf6e89745a9a0faa5b16218f37a: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union_cad849acca9c453288114abaa92b1f1d: OneOfBase<LuaEntity, LuaPlayer>
{
}

[GenerateOneOf]
public abstract partial class Union_4c7d7be25ca34c1880814f380cabbc6a: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

[GenerateOneOf]
public abstract partial class Union_b6bad84bf3fc4d879c74444c5149e108: OneOfBase<LuaEntity, MapPosition>
{
}

[GenerateOneOf]
public abstract partial class Union_92166f6ccea948eca9a92810bdc9021e: OneOfBase<LuaEntity, PlayerIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union_2a6dd6d465c14cb1a4452c9ed20da301: OneOfBase<string, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_3ec2c9f28a104b119828bce8d5efe09e: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_8445ab5fd9a6431d984665c81ca45341: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_0da3d91197304350b8fe52bcf16c8408: OneOfBase<string, LuaRecipe, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals_4cc14fdb567843479ab2e7b044613083
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

public abstract class Table_24f30ca21de3407081ddfb087c787abe
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
public enum Literals_c1abc1dc93a64bb39719e66762b2fdfd
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

public abstract class Table_831c32f9c36043a3a121bd6f904207e3
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

public abstract class Table_d1d6d98b33ed466d98c03f2c751e1ac0
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

public abstract class Table_ec90525e33da409ab252612b993efcb7
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public abstract class Table_dcc8dac6fefc4b0ea3b370d7ed17c7a1
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public abstract class Table_5a6d63a63920458d851cf315990a46f4
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
public abstract partial class Union_46b1af14d5364ace86d88f68d46fc4c8: OneOfBase<ulong, double>
{
}

[GenerateOneOf]
public abstract partial class Union_a768fc98a4734be8bbfbdcf82934deb9: OneOfBase<LuaFluidBoxPrototype, List<LuaFluidBoxPrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union_66457f2f9c8d4c538553fece1a990997: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals_5104814d064242be94a0b85768798e6d
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
public abstract partial class Union_de62e3607ed34ac2af7d04457dc8863d: OneOfBase<Color, PrintSettings>
{
}

[GenerateOneOf]
public abstract partial class Union_10716f3da4214e889057084cf153ad1a: OneOfBase<uint, string>
{
}

[GenerateOneOf]
public abstract partial class Union_94ee260d15a14ec4bd71cb3df2c19e09: OneOfBase<TrainStopGoal, RailEnd>
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals_8238433eb76447b49c8441af16eeab31
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
public abstract partial class Union_63d486ae180a40f5875e3b406202d9bf: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

[GenerateOneOf]
public abstract partial class Union_3310add2f6d2469082c3a3c65388aa3b: OneOfBase<string, SignalID>
{
}

[GenerateOneOf]
public abstract partial class Union_b94913f312df4eb49a6e6a5bdb9f607c: OneOfBase<LuaStyle, string>
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals_c2294b8dd7ec49e9a913eb02bbfcba48
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
public enum Literals_80f1760b828c4b788baff9226784349f
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
public enum Literals_596e85fadabc4c7cad4e36d534d2314a
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
public enum Literals_bc6101c588104c0c8796e89850b6ef56
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
public enum Literals_944ef29ba42d4c2ba787fbb056331a14
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
public enum Literals_833e545ec5b74f5897db549731aa9acd
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
public enum Literals_53c4e57dad9b480fa961877b9cc0dd84
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
public abstract partial class Union_38892a7237a647e88ff7f7172084a743: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union_f27a15a4a98b4ef7acd549c59da75169: OneOfBase<UpgradeFilter, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals_12d0cca1305346b19c2643c28a9662fb
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
public abstract partial class Union_a152baa6afba49f1bd620db48a1311bb: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals_d279e98243514aeaaf68b93affb44abd
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
public enum Literals_5edb2a41bb43419cb0ef3eebce63655b
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
public enum Literals_95f88551c53a48e39c65870c819c6cb9
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
public enum Literals_244fbc36e1ce4b609cfc87589d4622e5
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
public enum Literals_5bb3b480c13c4bbc87651672150443de
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
public abstract partial class Union_23864149c8244038a57daa29f7da97e7: OneOfBase<List<string>, List<int>, List<double>>
{
}

[GenerateOneOf]
public abstract partial class Union_a1d217adbfed4e9fac905bcb8da5cd2a: OneOfBase<bool, double, int, string>
{
}

[GenerateOneOf]
public abstract partial class Union_ba5ff360ef474334a100ab133f18fdc8: OneOfBase<double, int>
{
}

[GenerateOneOf]
public abstract partial class Union_fd1d181ed7cf4a3fa2c7156a44866516: OneOfBase<string, uint>
{
}

[GenerateOneOf]
public abstract partial class Union_93e2de6d91ed4ec9b93cced6a67407bc: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

[GenerateOneOf]
public abstract partial class Union_e2b0be9be8434d6497a890a28261efc0: OneOfBase<LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public abstract partial class Union_82330e0a5dc64219b2e76c745ca9caeb: OneOfBase<string, LuaItemPrototype, LuaItemStack>
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
public enum Literals_d898911d25f94cd2880801fa0532402c
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
public abstract partial class Union_17892957bb56481eb399e07ab6dbb1cf: OneOfBase<int, List<int>>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals_a4ecc58a06a34206b634ed167d77d624
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
public enum Literals_59345bf7446743fd914ed4777084c9ea
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
public abstract partial class Union_6033961958ea44b39bafd970d1a1d589: OneOfBase<LuaForce, string>
{
}

[GenerateOneOf]
public abstract partial class Union_30798fb4c60f41099a5dfb86f0236085: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

[GenerateOneOf]
public abstract partial class Union_cfbf631eb6b147b499bf1943559bb09e: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

[GenerateOneOf]
public abstract partial class Union_0fadef4dded44e92b9ebd4a99705a71e: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

[GenerateOneOf]
public abstract partial class Union_4ff6071e8f3e4276856b9c51b3edce34: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union_aa0ed1a7efaa45478f1afb89c6274b6e: OneOfBase<CollisionMaskWithFlags, List<string>>
{
}

[GenerateOneOf]
public abstract partial class Union_cacbc34dbb144cb69e9f166498549a87: OneOfBase<string, LuaTilePrototype>
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal_40665224fa004e0892fc44dc73aa9958
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public abstract partial class Union_f11bef743b594e4cbfb12c7fb1f026e1: OneOfBase<bool, Literal_40665224fa004e0892fc44dc73aa9958>
{
}

public abstract class Table_55ed1bf36dce4a58911507a6e202fbdf
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

public abstract class Table_b016299592834f1191cc7e2682fd6b82
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

