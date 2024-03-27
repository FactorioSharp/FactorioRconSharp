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
public enum Literals625099390
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
public abstract partial class Union1031746849: OneOfBase<string, List<string>>
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
public enum Literals1949933936
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
public enum Literals1690588554
{
  /// <summary>
  /// Literal value: center-to-center
  /// </summary>
  [FactorioRconDefinitionValue("center-to-center")]
  CenterToCenter,

  /// <summary>
  /// Literal value: bounding-box-to-bounding-box
  /// </summary>
  [FactorioRconDefinitionValue("bounding-box-to-bounding-box")]
  BoundingBoxToBoundingBox,

}

/// <summary>
/// Union of literals:
///   - projectile
///   - stream
///   - beam
/// </summary>
public enum Literals359156413
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

public abstract class Table1323895177
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public abstract class Tuple944895359
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
public enum Literals1730886009
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
  EquipmentRemote,

  /// <summary>
  /// Literal value: use-on-self
  /// </summary>
  [FactorioRconDefinitionValue("use-on-self")]
  UseOnSelf,

  /// <summary>
  /// Literal value: artillery-remote
  /// </summary>
  [FactorioRconDefinitionValue("artillery-remote")]
  ArtilleryRemote,

  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  DestroyCliffs,

}

public abstract class Table226803317
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Tuple1730261087
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal1447807750
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
public enum Literal511613179
{
  /// <summary>
  /// Literal value: not-colliding-with-itself
  /// </summary>
  [FactorioRconDefinitionValue("not-colliding-with-itself")]
  NotCollidingWithItself,

}

/// <summary>
/// Literal value: consider-tile-transitions
/// </summary>
public enum Literal1377869905
{
  /// <summary>
  /// Literal value: consider-tile-transitions
  /// </summary>
  [FactorioRconDefinitionValue("consider-tile-transitions")]
  ConsiderTileTransitions,

}

/// <summary>
/// Literal value: colliding-with-tiles-only
/// </summary>
public enum Literal549476902
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  CollidingWithTilesOnly,

}

[GenerateOneOf]
public abstract partial class Union518890224: OneOfBase<CollisionMaskLayer, Literal511613179, Literal1377869905, Literal549476902>
{
}

public abstract class Table1096126715
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

public abstract class Tuple1065929875
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

public abstract class Tuple1026453931
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
public abstract partial class Union2063683450: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1024742378
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
public abstract partial class Union1625292844: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals598523974
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconDefinitionValue("after-victory")]
  AfterVictory,

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
public enum Literals1593638652
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
public enum Literals332809100
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
  LayersEquals,

  /// <summary>
  /// Literal value: contains-any
  /// </summary>
  [FactorioRconDefinitionValue("contains-any")]
  ContainsAny,

  /// <summary>
  /// Literal value: contains-all
  /// </summary>
  [FactorioRconDefinitionValue("contains-all")]
  ContainsAll,

}

public abstract class Tuple236604395
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
public enum Literals1786677598
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
public abstract partial class Union553548621: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter, LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter, LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals590048808
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
  InputOutput,

}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1818399951
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
public enum Literals964230813
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
  PlayerQuickbar,

  /// <summary>
  /// Literal value: player-equipment-bar
  /// </summary>
  [FactorioRconDefinitionValue("player-equipment-bar")]
  PlayerEquipmentBar,

}

public abstract class Tuple1366754673
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
public enum Literals554835741
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  AtLeast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  AtMost,

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
public enum Literals1972962480
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  AtLeast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  AtMost,

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
public enum Literals1570027940
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  AtLeast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  AtMost,

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
public abstract partial class Union1808765183: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals244410248
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
public enum Literals835787873
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
public enum Literals48826546
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
public enum Literals368530390
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
public enum Literals2054124589
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
public enum Literals1739792298
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
public enum Literals1710669109
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
public enum Literals1852992154
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
public enum Literals136920173
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
public enum Literals2034370990
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
public enum Literals1713924778
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
public enum Literals994587346
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
public enum Literals1189860015
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
public enum Literals228183130
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
public enum Literals1294978870
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
public enum Literals2117939803
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
public enum Literals1110151811
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
public enum Literals232394612
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
public enum Literals1510853182
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
public enum Literals821179823
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
public enum Literals26575416
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
public enum Literals1585591844
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
public enum Literals1617124836
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
public enum Literals1453984159
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
public enum Literals719962462
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconDefinitionValue("after-victory")]
  AfterVictory,

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
public enum Literals770346556
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
public enum Literal354846551
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
public enum Literal2059969705
{
  /// <summary>
  /// Literal value: very-low
  /// </summary>
  [FactorioRconDefinitionValue("very-low")]
  VeryLow,

}

/// <summary>
/// Literal value: very-small
/// </summary>
public enum Literal1410056151
{
  /// <summary>
  /// Literal value: very-small
  /// </summary>
  [FactorioRconDefinitionValue("very-small")]
  VerySmall,

}

/// <summary>
/// Literal value: very-poor
/// </summary>
public enum Literal363506414
{
  /// <summary>
  /// Literal value: very-poor
  /// </summary>
  [FactorioRconDefinitionValue("very-poor")]
  VeryPoor,

}

/// <summary>
/// Literal value: low
/// </summary>
public enum Literal892972009
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
public enum Literal686134346
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
public enum Literal1955325612
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
public enum Literal888195366
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
public enum Literal274479976
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
public enum Literal260338842
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
public enum Literal1017103329
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
public enum Literal657923541
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
public enum Literal9558861
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
public enum Literal1432433727
{
  /// <summary>
  /// Literal value: very-high
  /// </summary>
  [FactorioRconDefinitionValue("very-high")]
  VeryHigh,

}

/// <summary>
/// Literal value: very-big
/// </summary>
public enum Literal2062107382
{
  /// <summary>
  /// Literal value: very-big
  /// </summary>
  [FactorioRconDefinitionValue("very-big")]
  VeryBig,

}

/// <summary>
/// Literal value: very-good
/// </summary>
public enum Literal893015467
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  VeryGood,

}

public abstract class Table1456718479
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public abstract class Tuple445921757
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

[GenerateOneOf]
public abstract partial class Union670163264: OneOfBase<int, double, bool, string, Color>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals792090252
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
public enum Literals1511172253
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
  Button4,

  /// <summary>
  /// Literal value: button-5
  /// </summary>
  [FactorioRconDefinitionValue("button-5")]
  Button5,

  /// <summary>
  /// Literal value: button-6
  /// </summary>
  [FactorioRconDefinitionValue("button-6")]
  Button6,

  /// <summary>
  /// Literal value: button-7
  /// </summary>
  [FactorioRconDefinitionValue("button-7")]
  Button7,

  /// <summary>
  /// Literal value: button-8
  /// </summary>
  [FactorioRconDefinitionValue("button-8")]
  Button8,

  /// <summary>
  /// Literal value: button-9
  /// </summary>
  [FactorioRconDefinitionValue("button-9")]
  Button9,

}

/// <summary>
/// Union of literals:
///   - normal
///   - underground
/// </summary>
public enum Literals361865678
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
public enum Literals523421081
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
  InputOutput,

}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals993774657
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
public abstract partial class Union256602862: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals322441129
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
public enum Literal462109298
{
  /// <summary>
  /// Literal value: water-tile
  /// </summary>
  [FactorioRconDefinitionValue("water-tile")]
  WaterTile,

}

/// <summary>
/// Literal value: ground-tile
/// </summary>
public enum Literal748848117
{
  /// <summary>
  /// Literal value: ground-tile
  /// </summary>
  [FactorioRconDefinitionValue("ground-tile")]
  GroundTile,

}

/// <summary>
/// Literal value: tile-transition
/// </summary>
public enum Literal1782189767
{
  /// <summary>
  /// Literal value: tile-transition
  /// </summary>
  [FactorioRconDefinitionValue("tile-transition")]
  TileTransition,

}

/// <summary>
/// Literal value: decals
/// </summary>
public enum Literal806302051
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
public enum Literal1366146684
{
  /// <summary>
  /// Literal value: lower-radius-visualization
  /// </summary>
  [FactorioRconDefinitionValue("lower-radius-visualization")]
  LowerRadiusVisualization,

}

/// <summary>
/// Literal value: radius-visualization
/// </summary>
public enum Literal742326034
{
  /// <summary>
  /// Literal value: radius-visualization
  /// </summary>
  [FactorioRconDefinitionValue("radius-visualization")]
  RadiusVisualization,

}

/// <summary>
/// Literal value: transport-belt-integration
/// </summary>
public enum Literal1796051575
{
  /// <summary>
  /// Literal value: transport-belt-integration
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-integration")]
  TransportBeltIntegration,

}

/// <summary>
/// Literal value: resource
/// </summary>
public enum Literal1283778033
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
public enum Literal1384945747
{
  /// <summary>
  /// Literal value: building-smoke
  /// </summary>
  [FactorioRconDefinitionValue("building-smoke")]
  BuildingSmoke,

}

/// <summary>
/// Literal value: decorative
/// </summary>
public enum Literal1798183051
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
public enum Literal442936003
{
  /// <summary>
  /// Literal value: ground-patch
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch")]
  GroundPatch,

}

/// <summary>
/// Literal value: ground-patch-higher
/// </summary>
public enum Literal1920897406
{
  /// <summary>
  /// Literal value: ground-patch-higher
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch-higher")]
  GroundPatchHigher,

}

/// <summary>
/// Literal value: ground-patch-higher2
/// </summary>
public enum Literal1141398981
{
  /// <summary>
  /// Literal value: ground-patch-higher2
  /// </summary>
  [FactorioRconDefinitionValue("ground-patch-higher2")]
  GroundPatchHigher2,

}

/// <summary>
/// Literal value: remnants
/// </summary>
public enum Literal1027790432
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
public enum Literal1186745381
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
public enum Literal301664649
{
  /// <summary>
  /// Literal value: transport-belt
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt")]
  TransportBelt,

}

/// <summary>
/// Literal value: transport-belt-endings
/// </summary>
public enum Literal2101186801
{
  /// <summary>
  /// Literal value: transport-belt-endings
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-endings")]
  TransportBeltEndings,

}

/// <summary>
/// Literal value: floor-mechanics-under-corpse
/// </summary>
public enum Literal1034640028
{
  /// <summary>
  /// Literal value: floor-mechanics-under-corpse
  /// </summary>
  [FactorioRconDefinitionValue("floor-mechanics-under-corpse")]
  FloorMechanicsUnderCorpse,

}

/// <summary>
/// Literal value: corpse
/// </summary>
public enum Literal1100836474
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
public enum Literal452228270
{
  /// <summary>
  /// Literal value: floor-mechanics
  /// </summary>
  [FactorioRconDefinitionValue("floor-mechanics")]
  FloorMechanics,

}

/// <summary>
/// Literal value: item
/// </summary>
public enum Literal222835751
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
public enum Literal78419455
{
  /// <summary>
  /// Literal value: lower-object
  /// </summary>
  [FactorioRconDefinitionValue("lower-object")]
  LowerObject,

}

/// <summary>
/// Literal value: transport-belt-circuit-connector
/// </summary>
public enum Literal906556088
{
  /// <summary>
  /// Literal value: transport-belt-circuit-connector
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-circuit-connector")]
  TransportBeltCircuitConnector,

}

/// <summary>
/// Literal value: lower-object-above-shadow
/// </summary>
public enum Literal1281043596
{
  /// <summary>
  /// Literal value: lower-object-above-shadow
  /// </summary>
  [FactorioRconDefinitionValue("lower-object-above-shadow")]
  LowerObjectAboveShadow,

}

/// <summary>
/// Literal value: object
/// </summary>
public enum Literal128873365
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
public enum Literal1171203079
{
  /// <summary>
  /// Literal value: higher-object-under
  /// </summary>
  [FactorioRconDefinitionValue("higher-object-under")]
  HigherObjectUnder,

}

/// <summary>
/// Literal value: higher-object-above
/// </summary>
public enum Literal783820895
{
  /// <summary>
  /// Literal value: higher-object-above
  /// </summary>
  [FactorioRconDefinitionValue("higher-object-above")]
  HigherObjectAbove,

}

/// <summary>
/// Literal value: item-in-inserter-hand
/// </summary>
public enum Literal2075355857
{
  /// <summary>
  /// Literal value: item-in-inserter-hand
  /// </summary>
  [FactorioRconDefinitionValue("item-in-inserter-hand")]
  ItemInInserterHand,

}

/// <summary>
/// Literal value: wires
/// </summary>
public enum Literal1406657950
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
public enum Literal2140464520
{
  /// <summary>
  /// Literal value: wires-above
  /// </summary>
  [FactorioRconDefinitionValue("wires-above")]
  WiresAbove,

}

/// <summary>
/// Literal value: entity-info-icon
/// </summary>
public enum Literal1536548624
{
  /// <summary>
  /// Literal value: entity-info-icon
  /// </summary>
  [FactorioRconDefinitionValue("entity-info-icon")]
  EntityInfoIcon,

}

/// <summary>
/// Literal value: entity-info-icon-above
/// </summary>
public enum Literal416281494
{
  /// <summary>
  /// Literal value: entity-info-icon-above
  /// </summary>
  [FactorioRconDefinitionValue("entity-info-icon-above")]
  EntityInfoIconAbove,

}

/// <summary>
/// Literal value: explosion
/// </summary>
public enum Literal106903552
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
public enum Literal570530880
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
public enum Literal224025048
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
public enum Literal1206477495
{
  /// <summary>
  /// Literal value: air-object
  /// </summary>
  [FactorioRconDefinitionValue("air-object")]
  AirObject,

}

/// <summary>
/// Literal value: air-entity-info-icon
/// </summary>
public enum Literal1253489246
{
  /// <summary>
  /// Literal value: air-entity-info-icon
  /// </summary>
  [FactorioRconDefinitionValue("air-entity-info-icon")]
  AirEntityInfoIcon,

}

/// <summary>
/// Literal value: light-effect
/// </summary>
public enum Literal1615661572
{
  /// <summary>
  /// Literal value: light-effect
  /// </summary>
  [FactorioRconDefinitionValue("light-effect")]
  LightEffect,

}

/// <summary>
/// Literal value: selection-box
/// </summary>
public enum Literal1041675805
{
  /// <summary>
  /// Literal value: selection-box
  /// </summary>
  [FactorioRconDefinitionValue("selection-box")]
  SelectionBox,

}

/// <summary>
/// Literal value: higher-selection-box
/// </summary>
public enum Literal274777295
{
  /// <summary>
  /// Literal value: higher-selection-box
  /// </summary>
  [FactorioRconDefinitionValue("higher-selection-box")]
  HigherSelectionBox,

}

/// <summary>
/// Literal value: collision-selection-box
/// </summary>
public enum Literal1009355613
{
  /// <summary>
  /// Literal value: collision-selection-box
  /// </summary>
  [FactorioRconDefinitionValue("collision-selection-box")]
  CollisionSelectionBox,

}

/// <summary>
/// Literal value: arrow
/// </summary>
public enum Literal873264475
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
public enum Literal47487980
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

[GenerateOneOf]
public abstract partial class Union263924331: OneOfBase<MapPosition, LuaEntity>
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
public enum Literals450079464
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
  CancelDeconstruct,

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
  BuildableType,

  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  /// <summary>
  /// Literal value: items-to-place
  /// </summary>
  [FactorioRconDefinitionValue("items-to-place")]
  ItemsToPlace,

  /// <summary>
  /// Literal value: any-entity
  /// </summary>
  [FactorioRconDefinitionValue("any-entity")]
  AnyEntity,

  /// <summary>
  /// Literal value: any-tile
  /// </summary>
  [FactorioRconDefinitionValue("any-tile")]
  AnyTile,

  /// <summary>
  /// Literal value: same-force
  /// </summary>
  [FactorioRconDefinitionValue("same-force")]
  SameForce,

  /// <summary>
  /// Literal value: not-same-force
  /// </summary>
  [FactorioRconDefinitionValue("not-same-force")]
  NotSameForce,

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
  CancelUpgrade,

  /// <summary>
  /// Literal value: downgrade
  /// </summary>
  [FactorioRconDefinitionValue("downgrade")]
  Downgrade,

  /// <summary>
  /// Literal value: entity-with-health
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-health")]
  EntityWithHealth,

  /// <summary>
  /// Literal value: entity-with-force
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-force")]
  EntityWithForce,

  /// <summary>
  /// Literal value: is-military-target
  /// </summary>
  [FactorioRconDefinitionValue("is-military-target")]
  IsMilitaryTarget,

  /// <summary>
  /// Literal value: entity-with-owner
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-owner")]
  EntityWithOwner,

  /// <summary>
  /// Literal value: avoid-rolling-stock
  /// </summary>
  [FactorioRconDefinitionValue("avoid-rolling-stock")]
  AvoidRollingStock,

  /// <summary>
  /// Literal value: entity-ghost
  /// </summary>
  [FactorioRconDefinitionValue("entity-ghost")]
  EntityGhost,

  /// <summary>
  /// Literal value: tile-ghost
  /// </summary>
  [FactorioRconDefinitionValue("tile-ghost")]
  TileGhost,

}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
///   - virtual
/// </summary>
public enum Literals1683304720
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
public enum Literals1452006423
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

public abstract class Tuple1789856479
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
public enum Literals1752828518
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
public enum Literals1209507604
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
  FlameThrower,

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
public enum Literals408162524
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
public enum Literals1636264700
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

public abstract class Table2040421830
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public abstract class Tuple1951858239
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
public enum Literals99605378
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

public abstract class Table383689843
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
public abstract partial class Union1989775676: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union501146171: OneOfBase<EventsEnum, string>
{
}

[GenerateOneOf]
public abstract partial class Union677428686: OneOfBase<EventsEnum, string, List<Union501146171>>
{
}

[GenerateOneOf]
public abstract partial class Union194943605: OneOfBase<Action<EventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union2105988786: OneOfBase<Action, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union1868179365: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union2024603730: OneOfBase<uint, List<uint>, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union1391964874: OneOfBase<LuaEntity, LuaEquipment>
{
}

public abstract class Table261634427
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

public abstract class Table26654509
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
public abstract partial class Union1813993854: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public abstract class Table570868101
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

public abstract class Table803765384
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

public abstract class Table2127751533
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
public abstract partial class Union1195659050: OneOfBase<string, LuaRecipe>
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals485525229
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
  GameOnly,

}

[GenerateOneOf]
public abstract partial class Union2140447870: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public abstract class Table826059179
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
public enum Literals1590356304
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
public enum Literals1497054923
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

public abstract class Table30931475
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
public abstract partial class Union642631757: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals830964132
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
public enum Literals593052292
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
public enum Literals1866680303
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
public abstract partial class Union1141448063: OneOfBase<Dictionary<string, List<LuaEntity>>, List<List<LuaEntity>>, LuaEntity>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals322527339
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
public enum Literals197150346
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

public abstract class Table1732301996
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

[GenerateOneOf]
public abstract partial class Union2047767571: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union523343311: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union302528960: OneOfBase<LuaEntity, LuaPlayer>
{
}

[GenerateOneOf]
public abstract partial class Union470925502: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

[GenerateOneOf]
public abstract partial class Union1987818852: OneOfBase<LuaEntity, MapPosition>
{
}

[GenerateOneOf]
public abstract partial class Union1364185466: OneOfBase<LuaEntity, PlayerIdentification>
{
}

[GenerateOneOf]
public abstract partial class Union752343075: OneOfBase<string, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union938232886: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union846732200: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union316272156: OneOfBase<string, LuaRecipe, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals1288659895
{
  /// <summary>
  /// Literal value: heat-water-inside
  /// </summary>
  [FactorioRconDefinitionValue("heat-water-inside")]
  HeatWaterInside,

  /// <summary>
  /// Literal value: output-to-separate-pipe
  /// </summary>
  [FactorioRconDefinitionValue("output-to-separate-pipe")]
  OutputToSeparatePipe,

}

public abstract class Table996144392
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
public enum Literals803006753
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
  ActiveProvider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  PassiveProvider,

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

public abstract class Table2289904
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

public abstract class Table423424955
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

public abstract class Table2016794513
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public abstract class Table881138322
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public abstract class Table986091095
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
public abstract partial class Union1772560632: OneOfBase<ulong, double>
{
}

[GenerateOneOf]
public abstract partial class Union13848553: OneOfBase<LuaFluidBoxPrototype, List<LuaFluidBoxPrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union2070120942: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals1643300477
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
  InputOutput,

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
public abstract partial class Union1214362651: OneOfBase<Color, PrintSettings>
{
}

[GenerateOneOf]
public abstract partial class Union361501935: OneOfBase<uint, string>
{
}

[GenerateOneOf]
public abstract partial class Union750034102: OneOfBase<TrainStopGoal, RailEnd>
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals352758368
{
  /// <summary>
  /// Literal value: respect-movement-direction
  /// </summary>
  [FactorioRconDefinitionValue("respect-movement-direction")]
  RespectMovementDirection,

  /// <summary>
  /// Literal value: any-direction-with-locomotives
  /// </summary>
  [FactorioRconDefinitionValue("any-direction-with-locomotives")]
  AnyDirectionWithLocomotives,

}

[GenerateOneOf]
public abstract partial class Union1347143919: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

[GenerateOneOf]
public abstract partial class Union1817665686: OneOfBase<string, SignalID>
{
}

[GenerateOneOf]
public abstract partial class Union84376394: OneOfBase<LuaStyle, string>
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals475746949
{
  /// <summary>
  /// Literal value: in-view
  /// </summary>
  [FactorioRconDefinitionValue("in-view")]
  InView,

  /// <summary>
  /// Literal value: top-third
  /// </summary>
  [FactorioRconDefinitionValue("top-third")]
  TopThird,

}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals964540723
{
  /// <summary>
  /// Literal value: in-view
  /// </summary>
  [FactorioRconDefinitionValue("in-view")]
  InView,

  /// <summary>
  /// Literal value: top-third
  /// </summary>
  [FactorioRconDefinitionValue("top-third")]
  TopThird,

}

/// <summary>
/// Union of literals:
///   - none
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals1545652026
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
public enum Literals1827453384
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
  WhenManuallyFiltered,

}

/// <summary>
/// Union of literals:
///   - default
///   - player
///   - turret
///   - vehicle
/// </summary>
public enum Literals1807146525
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
public enum Literals361350503
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
  WhenManuallyFiltered,

}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals1650794845
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
public abstract partial class Union1511464894: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

[GenerateOneOf]
public abstract partial class Union99942599: OneOfBase<UpgradeFilter, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals963430179
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
public abstract partial class Union763566067: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals443315975
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
public enum Literals1694775990
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
  StorageEmpty,

  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  StorageEmptySlot,

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
public enum Literals1293715670
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  ActiveProvider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  PassiveProvider,

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
public enum Literals509787023
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
  StorageEmpty,

  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconDefinitionValue("storage-empty-slot")]
  StorageEmptySlot,

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
public enum Literals301696409
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconDefinitionValue("active-provider")]
  ActiveProvider,

  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconDefinitionValue("passive-provider")]
  PassiveProvider,

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
public abstract partial class Union500910531: OneOfBase<List<string>, List<int>, List<double>>
{
}

[GenerateOneOf]
public abstract partial class Union1375408369: OneOfBase<bool, double, int, string>
{
}

[GenerateOneOf]
public abstract partial class Union640341853: OneOfBase<double, int>
{
}

[GenerateOneOf]
public abstract partial class Union407539177: OneOfBase<string, uint>
{
}

[GenerateOneOf]
public abstract partial class Union723741426: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

[GenerateOneOf]
public abstract partial class Union985541981: OneOfBase<LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public abstract partial class Union155356968: OneOfBase<string, LuaItemPrototype, LuaItemStack>
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
public enum Literals697450354
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
public abstract partial class Union183301791: OneOfBase<int, List<int>>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals1809664701
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
public enum Literals404467094
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
public abstract partial class Union1456464307: OneOfBase<LuaForce, string>
{
}

[GenerateOneOf]
public abstract partial class Union2088510672: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

[GenerateOneOf]
public abstract partial class Union1868375047: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

[GenerateOneOf]
public abstract partial class Union1635060484: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

[GenerateOneOf]
public abstract partial class Union17041547: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

[GenerateOneOf]
public abstract partial class Union1082161036: OneOfBase<CollisionMaskWithFlags, List<string>>
{
}

[GenerateOneOf]
public abstract partial class Union853856492: OneOfBase<string, LuaTilePrototype>
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal370985251
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public abstract partial class Union1499215080: OneOfBase<bool, Literal370985251>
{
}

public abstract class Table1890491516
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

public abstract class Table1316174655
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

