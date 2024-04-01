#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;
using OneOf;

namespace FactorioSharp.Rcon.Model.Anonymous;

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1275546047
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
public partial class Union730525469: OneOfBase<string, LuaArray<string>>
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
public enum Literals598489490
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
public enum Literals1850457581
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
public enum Literals1612390030
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

public class Table1448100345
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public class Tuple95508044
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
public enum Literals2030689442
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

public class Table1833102582
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public class Tuple188748581
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal1719260023
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
public enum Literal1226272907
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
public enum Literal662509229
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
public enum Literal1929678977
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  CollidingWithTilesOnly,

}

[GenerateOneOf]
public partial class Union1777727082: OneOfBase<CollisionMaskLayer, Literal1226272907, Literal662509229, Literal1929678977>
{
}

public class Table531944975
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

public class Tuple1200651997
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

public class Tuple526134302
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
public partial class Union801998465: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1022678453
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
public partial class Union1510377638: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals1213222642
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
public enum Literals40973115
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
public enum Literals1320789476
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

public class Tuple1168545282
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
public enum Literals599619848
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
public partial class Union984118263: OneOfBase<Union984118263_0, Union984118263_1, Union984118263_2>
{
}

[GenerateOneOf]
public partial class Union984118263_0: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter>
{
}

[GenerateOneOf]
public partial class Union984118263_1: OneOfBase<LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter>
{
}

[GenerateOneOf]
public partial class Union984118263_2: OneOfBase<LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals1802748296
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
public enum Literals624609759
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
public enum Literals700338232
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

public class Tuple1951126369
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
public enum Literals557802695
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
public enum Literals1040884443
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
public enum Literals984648661
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
public partial class Union1141608305: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals1535629394
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
public enum Literals1046004639
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
public enum Literals1588744542
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
public enum Literals258646765
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
public enum Literals1445023393
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
public enum Literals1295205345
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
public enum Literals327551783
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
public enum Literals93792072
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
public enum Literals1821576234
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
public enum Literals1441465655
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
public enum Literals87923058
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
public enum Literals1998930559
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
public enum Literals1905991896
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
public enum Literals750841608
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
public enum Literals1615594983
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
public enum Literals1705038549
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
public enum Literals455053708
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
public enum Literals1996640080
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
public enum Literals255707818
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
public enum Literals2009925975
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
public enum Literals62323405
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
public enum Literals689552354
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
public enum Literals1425183661
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
public enum Literals681912299
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
public enum Literals1012770182
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
public enum Literals463982082
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
public enum Literal440243395
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
public enum Literal1406079683
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
public enum Literal1132764350
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
public enum Literal385105859
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
public enum Literal1161457328
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
public enum Literal185388464
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
public enum Literal1825344215
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
public enum Literal788070672
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
public enum Literal242097688
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
public enum Literal1633423983
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
public enum Literal1759391102
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
public enum Literal267487537
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
public enum Literal1504458719
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
public enum Literal1874956755
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
public enum Literal1182825855
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
public enum Literal1119430570
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  VeryGood,

}

public class Table366880528
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public class Tuple2026807468
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

[GenerateOneOf]
public partial class Union1080622224: OneOfBase<int, double, bool, string, Color>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals748172936
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
public enum Literals1225610014
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
public enum Literals1051906687
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
public enum Literals1156498423
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
public enum Literals1142783330
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
public partial class Union1496072661: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals708646262
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
public enum Literal785176625
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
public enum Literal1122206333
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
public enum Literal1079284900
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
public enum Literal846077040
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
public enum Literal1768304625
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
public enum Literal906832243
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
public enum Literal1393360230
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
public enum Literal981041311
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
public enum Literal854961950
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
public enum Literal1068955747
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
public enum Literal1108511369
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
public enum Literal1436470375
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
public enum Literal280008327
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
public enum Literal2050018241
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
public enum Literal173586344
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
public enum Literal1117921224
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
public enum Literal508743920
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
public enum Literal2129654647
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
public enum Literal2093131094
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
public enum Literal187566171
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
public enum Literal492181361
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
public enum Literal528234710
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
public enum Literal827100120
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
public enum Literal1090376482
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
public enum Literal322671826
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
public enum Literal1545859840
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
public enum Literal1748773722
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
public enum Literal264597246
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
public enum Literal1385855715
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
public enum Literal1535820354
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
public enum Literal249581260
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
public enum Literal2137464667
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
public enum Literal1036516845
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
public enum Literal452811066
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
public enum Literal1547695486
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
public enum Literal703137882
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
public enum Literal1856269419
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
public enum Literal1543504295
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
public enum Literal2012603005
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
public enum Literal852558859
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
public enum Literal1021610954
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
public enum Literal523417407
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
public enum Literal1019994805
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

[GenerateOneOf]
public partial class Union113870108: OneOfBase<MapPosition, LuaEntity>
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
public enum Literals10919201
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
public enum Literals1077893800
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
public enum Literals1746799141
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

public class Tuple1178087630
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
public enum Literals574586592
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
public enum Literals107688790
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
public enum Literals543162768
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
public enum Literals1174327423
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

public class Table1197135883
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public class Tuple1308506490
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
public enum Literals216464901
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

public class Table256941915
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
public partial class Union295106213: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union2136392065: OneOfBase<EventsEnum, string>
{
}

[GenerateOneOf]
public partial class Union523405214: OneOfBase<EventsEnum, string, LuaArray<Union2136392065>>
{
}

[GenerateOneOf]
public partial class Union222444785: OneOfBase<Action<EventData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1305542168: OneOfBase<Action, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1128762984: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1742669243: OneOfBase<uint, LuaArray<uint>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1466625243: OneOfBase<LuaEntity, LuaEquipment>
{
}

public class Table819374487
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

public class Table1118530349
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
public partial class Union399953530: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public class Table1974680908
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

public class Table502322755
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

public class Table1617932109
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
public partial class Union1409135452: OneOfBase<string, LuaRecipe>
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals1112723272
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
public partial class Union117051642: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public class Table1240572235
{
  /// <summary>
  /// Array of transport belt connectable entities.
  /// </summary>
  [FactorioRconAttribute("inputs")]
  public LuaArray<LuaEntity> Inputs { get; set; }

  /// <summary>
  /// Array of transport belt connectable entities.
  /// </summary>
  [FactorioRconAttribute("outputs")]
  public LuaArray<LuaEntity> Outputs { get; set; }

}

/// <summary>
/// Union of literals:
///   - straight
///   - left
///   - right
/// </summary>
public enum Literals1313438864
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
public enum Literals2116247600
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

public class Table1655723552
{
  /// <summary>
  /// Entities connected via the red wire.
  /// </summary>
  [FactorioRconAttribute("red")]
  public LuaArray<LuaEntity> Red { get; set; }

  /// <summary>
  /// Entities connected via the green wire.
  /// </summary>
  [FactorioRconAttribute("green")]
  public LuaArray<LuaEntity> Green { get; set; }

}

[GenerateOneOf]
public partial class Union713230012: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals1079457281
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
public enum Literals1392261673
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
public enum Literals1946544346
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
public partial class Union570686092: OneOfBase<Dictionary<string, LuaArray<LuaEntity>>, LuaArray<LuaArray<LuaEntity>>, LuaEntity>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals1837494301
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
public enum Literals1278166925
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

public class Table992657586
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

[GenerateOneOf]
public partial class Union1222737484: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public partial class Union940328784: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public partial class Union1875494002: OneOfBase<LuaEntity, LuaPlayer>
{
}

[GenerateOneOf]
public partial class Union236346165: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

[GenerateOneOf]
public partial class Union1290753571: OneOfBase<LuaEntity, MapPosition>
{
}

[GenerateOneOf]
public partial class Union408031669: OneOfBase<LuaEntity, PlayerIdentification>
{
}

[GenerateOneOf]
public partial class Union1867361001: OneOfBase<string, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1020099081: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1790158220: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1694500338: OneOfBase<string, LuaRecipe, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals2040331617
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

public class Table928231812
{
  [FactorioRconAttribute("smoke_name")]
  public string SmokeName { get; set; }

  [FactorioRconAttribute("offsets")]
  public LuaArray<Vector> Offsets { get; set; }

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
public enum Literals1700853209
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

public class Table1441979268
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

public class Table1039872499
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
  public LuaArray<Product> Products { get; set; }

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
  public LuaArray<TriggerItem> MiningTrigger { get; set; }

}

public class Table677940270
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public class Table1919601880
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public class Table675764875
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

  /// <summary>
  /// Only set when the shape is "manual"
  /// </summary>
  [FactorioRconAttribute("points")]
  public LuaArray<EquipmentPoint> Points { get; set; }

}

[GenerateOneOf]
public partial class Union1104138130: OneOfBase<ulong, double>
{
}

[GenerateOneOf]
public partial class Union846036985: OneOfBase<LuaFluidBoxPrototype, LuaArray<LuaFluidBoxPrototype>>
{
}

[GenerateOneOf]
public partial class Union1577923143: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals1057275781
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
public partial class Union2104047295: OneOfBase<Color, PrintSettings>
{
}

[GenerateOneOf]
public partial class Union2142551273: OneOfBase<uint, string>
{
}

[GenerateOneOf]
public partial class Union247700948: OneOfBase<TrainStopGoal, RailEnd>
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals748702010
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
public partial class Union1729359848: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

[GenerateOneOf]
public partial class Union1056934784: OneOfBase<string, SignalID>
{
}

[GenerateOneOf]
public partial class Union1278627188: OneOfBase<LuaStyle, string>
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals423384086
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
public enum Literals734856076
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
public enum Literals1438752330
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
public enum Literals464502318
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
public enum Literals473967657
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
public enum Literals1744120650
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
public enum Literals178201565
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
public partial class Union671943175: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1738334743: OneOfBase<UpgradeFilter, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals1359052831
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
public partial class Union1209900440: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals1689258098
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
public enum Literals92624191
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
public enum Literals474377069
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
public enum Literals1693555544
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
public enum Literals1420590894
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
public partial class Union1188015788: OneOfBase<LuaArray<string>, LuaArray<int>, LuaArray<double>>
{
}

[GenerateOneOf]
public partial class Union2102353990: OneOfBase<bool, double, int, string>
{
}

[GenerateOneOf]
public partial class Union1418734391: OneOfBase<double, int>
{
}

[GenerateOneOf]
public partial class Union39584782: OneOfBase<string, uint>
{
}

[GenerateOneOf]
public partial class Union714321403: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

[GenerateOneOf]
public partial class Union26942466: OneOfBase<LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public partial class Union2042404864: OneOfBase<string, LuaItemPrototype, LuaItemStack>
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
public enum Literals733356171
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
public partial class Union432129940: OneOfBase<int, LuaArray<int>>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals1562218090
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
public enum Literals165461703
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
public partial class Union983765136: OneOfBase<LuaForce, string>
{
}

[GenerateOneOf]
public partial class Union1880426376: OneOfBase<CollisionMaskLayer, LuaArray<CollisionMaskLayer>>
{
}

[GenerateOneOf]
public partial class Union2136128864: OneOfBase<DirectionEnum, LuaArray<DirectionEnum>>
{
}

[GenerateOneOf]
public partial class Union542051561: OneOfBase<ForceIdentification, LuaArray<ForceIdentification>>
{
}

[GenerateOneOf]
public partial class Union826155468: OneOfBase<string, LuaArray<string>, LuaDecorativePrototype, LuaArray<LuaDecorativePrototype>>
{
}

[GenerateOneOf]
public partial class Union810426217: OneOfBase<CollisionMaskWithFlags, LuaArray<string>>
{
}

[GenerateOneOf]
public partial class Union1888955540: OneOfBase<string, LuaTilePrototype>
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal1366774134
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public partial class Union959644262: OneOfBase<bool, Literal1366774134>
{
}

public class Table601579287
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
  public LuaArray<Product> Products { get; set; }

}

public class Table463729494
{
  /// <summary>
  /// Array of locomotives.
  /// </summary>
  [FactorioRconAttribute("front_movers")]
  public LuaArray<LuaEntity> FrontMovers { get; set; }

  /// <summary>
  /// Array of locomotives.
  /// </summary>
  [FactorioRconAttribute("back_movers")]
  public LuaArray<LuaEntity> BackMovers { get; set; }

}

