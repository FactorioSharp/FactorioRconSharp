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
public enum Literals2103753580
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
public partial class Union788293329: OneOfBase<string, List<string>>
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
public enum Literals719457675
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
public enum Literals376494084
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
public enum Literals917709806
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

public class Table236166204
{
  [FactorioRconAttribute("left_top")]
  public MapPosition LeftTop { get; set; }

  [FactorioRconAttribute("right_bottom")]
  public MapPosition RightBottom { get; set; }

  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

}

public class Tuple1974522505
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
public enum Literals830635357
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

public class Table912949041
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public class Tuple1160236180
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal666164478
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
public enum Literal2032930217
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
public enum Literal1790320577
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
public enum Literal652396252
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  CollidingWithTilesOnly,

}

[GenerateOneOf]
public partial class Union65647394: OneOfBase<CollisionMaskLayer, Literal2032930217, Literal1790320577, Literal652396252>
{
}

public class Table1094727361
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

public class Tuple1740987856
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

public class Tuple625899554
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
public partial class Union699767741: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1536882468
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
public partial class Union173852224: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

/// <summary>
/// Union of literals:
///   - after-victory
///   - always
///   - never
/// </summary>
public enum Literals1811226216
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
public enum Literals217796577
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
public enum Literals346169845
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

public class Tuple272689614
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
public enum Literals1600917385
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
public partial class Union424113022: OneOfBase<Union424113022_0, Union424113022_1, Union424113022_2>
{
}

[GenerateOneOf]
public partial class Union424113022_0: OneOfBase<LuaEntityClonedEventFilter, LuaEntityDamagedEventFilter, LuaPlayerMinedEntityEventFilter, LuaPreRobotMinedEntityEventFilter, LuaRobotBuiltEntityEventFilter, LuaPostEntityDiedEventFilter, LuaEntityDiedEventFilter, LuaScriptRaisedReviveEventFilter, LuaPrePlayerMinedEntityEventFilter>
{
}

[GenerateOneOf]
public partial class Union424113022_1: OneOfBase<LuaEntityMarkedForDeconstructionEventFilter, LuaPreGhostDeconstructedEventFilter, LuaPreGhostUpgradedEventFilter, LuaEntityDeconstructionCancelledEventFilter, LuaEntityMarkedForUpgradeEventFilter, LuaSectorScannedEventFilter, LuaRobotMinedEntityEventFilter, LuaScriptRaisedDestroyEventFilter, LuaUpgradeCancelledEventFilter>
{
}

[GenerateOneOf]
public partial class Union424113022_2: OneOfBase<LuaScriptRaisedBuiltEventFilter, LuaPlayerBuiltEntityEventFilter, LuaPlayerRepairedEntityEventFilter>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Literals1519574860
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
public enum Literals1337161002
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
public enum Literals1165044932
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

public class Tuple2119569188
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
public enum Literals2128439232
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
public enum Literals1595034191
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
public enum Literals2137799683
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
public partial class Union613135482: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Literals877552609
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
public enum Literals1805688620
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
public enum Literals2106838900
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
public enum Literals104470220
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
public enum Literals804670956
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
public enum Literals1999050891
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
public enum Literals904730392
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
public enum Literals1082237099
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
public enum Literals1605436502
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
public enum Literals277555421
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
public enum Literals739711677
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
public enum Literals1952384577
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
public enum Literals717326618
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
public enum Literals1871614285
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
public enum Literals391230097
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
public enum Literals1342793802
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
public enum Literals1356663384
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
public enum Literals1690220799
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
public enum Literals365945383
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
public enum Literals734414535
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
public enum Literals292527364
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
public enum Literals570496752
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
public enum Literals373287830
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
public enum Literals103804470
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
public enum Literals1464276068
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
public enum Literals1959536829
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
public enum Literal454947645
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
public enum Literal1640958002
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
public enum Literal1895387756
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
public enum Literal1188150639
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
public enum Literal685208893
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
public enum Literal437896026
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
public enum Literal1800004541
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
public enum Literal39260770
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
public enum Literal1335578432
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
public enum Literal1436522388
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
public enum Literal1781632603
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
public enum Literal521429334
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
public enum Literal2042580432
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
public enum Literal1685315224
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
public enum Literal1416605479
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
public enum Literal728989117
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconDefinitionValue("very-good")]
  VeryGood,

}

public class Table759843722
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

public class Tuple68614424
{
  [FactorioRconAttribute("x")]
  public double X { get; set; }

  [FactorioRconAttribute("y")]
  public double Y { get; set; }

}

[GenerateOneOf]
public partial class Union1680461584: OneOfBase<int, double, bool, string, Color>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals1796016455
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
public enum Literals1854270051
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
public enum Literals1795444222
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
public enum Literals945930905
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
public enum Literals1969734777
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
public partial class Union762905804: OneOfBase<ItemPrototypeFilter, TilePrototypeFilter, EntityPrototypeFilter, FluidPrototypeFilter, RecipePrototypeFilter, DecorativePrototypeFilter, AchievementPrototypeFilter, EquipmentPrototypeFilter, TechnologyPrototypeFilter>
{
}

/// <summary>
/// Union of literals:
///   - or
///   - and
/// </summary>
public enum Literals438218433
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
public enum Literal1229088808
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
public enum Literal1403385148
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
public enum Literal320608118
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
public enum Literal307055857
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
public enum Literal1432400790
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
public enum Literal2003034430
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
public enum Literal787677799
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
public enum Literal992617774
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
public enum Literal1544103246
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
public enum Literal1411256037
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
public enum Literal1334332990
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
public enum Literal417285863
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
public enum Literal1739830175
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
public enum Literal301815651
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
public enum Literal152380036
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
public enum Literal678065848
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
public enum Literal536035853
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
public enum Literal1102191356
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
public enum Literal1708644846
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
public enum Literal835234050
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
public enum Literal1795124014
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
public enum Literal828113806
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
public enum Literal1465292703
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
public enum Literal1711021894
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
public enum Literal1958136677
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
public enum Literal304673406
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
public enum Literal570826533
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
public enum Literal1815743260
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
public enum Literal105266778
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
public enum Literal806987070
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
public enum Literal695027097
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
public enum Literal2073136626
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
public enum Literal425244835
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
public enum Literal246990460
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
public enum Literal1356290865
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
public enum Literal396619393
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
public enum Literal1866136299
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
public enum Literal1028522575
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
public enum Literal4121598
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
public enum Literal1926081820
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
public enum Literal1881235182
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
public enum Literal1049962658
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
public enum Literal141211978
{
  /// <summary>
  /// Literal value: cursor
  /// </summary>
  [FactorioRconDefinitionValue("cursor")]
  Cursor,

}

[GenerateOneOf]
public partial class Union5349442: OneOfBase<MapPosition, LuaEntity>
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
public enum Literals1542139774
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
public enum Literals342557859
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
public enum Literals476267896
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

public class Tuple1378645933
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
public enum Literals1643636419
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
public enum Literals1176204203
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
public enum Literals1259408369
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
public enum Literals1991223196
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

public class Table261089931
{
  [FactorioRconAttribute("x")]
  public float X { get; set; }

  [FactorioRconAttribute("y")]
  public float Y { get; set; }

}

public class Tuple2075155401
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
public enum Literals790578066
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

public class Table400975002
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
public partial class Union2085576092: OneOfBase<Action<ConfigurationChangedData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union757069871: OneOfBase<EventsEnum, string>
{
}

[GenerateOneOf]
public partial class Union496402827: OneOfBase<EventsEnum, string, List<Union757069871>>
{
}

[GenerateOneOf]
public partial class Union1127727384: OneOfBase<Action<EventData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1432207897: OneOfBase<Action, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1119418186: OneOfBase<Action<NthTickEventData>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union887350996: OneOfBase<uint, List<uint>, LuaNil>
{
}

[GenerateOneOf]
public partial class Union737116176: OneOfBase<LuaEntity, LuaEquipment>
{
}

public class Table716228940
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

public class Table1408680011
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
public partial class Union2139524675: OneOfBase<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum>
{
}

public class Table1492839715
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

public class Table1093008433
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

public class Table1903244290
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
public partial class Union959413196: OneOfBase<string, LuaRecipe>
{
}

/// <summary>
/// Union of literals:
///   - none
///   - game-only
/// </summary>
public enum Literals1654996925
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
public partial class Union1098069758: OneOfBase<LuaPlayer, PlayerIdentification>
{
}

public class Table1930046673
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
public enum Literals1101482515
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
public enum Literals745161356
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

public class Table686901828
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
public partial class Union1459943261: OneOfBase<LuaEntityPrototype, LuaTilePrototype>
{
}

/// <summary>
/// Union of literals:
///   - whitelist
///   - blacklist
/// </summary>
public enum Literals168882120
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
public enum Literals1615578818
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
public enum Literals1975889157
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
public partial class Union1339664247: OneOfBase<Dictionary<string, List<LuaEntity>>, List<List<LuaEntity>>, LuaEntity>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - none
///   - right
/// </summary>
public enum Literals172106841
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
public enum Literals1076546222
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

public class Table1695062348
{
  [FactorioRconAttribute("speed_modifier")]
  public double SpeedModifier { get; set; }

  [FactorioRconAttribute("friction_modifier")]
  public double FrictionModifier { get; set; }

}

[GenerateOneOf]
public partial class Union851287548: OneOfBase<LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public partial class Union1812046695: OneOfBase<WireTypeEnum, LuaEntity, WireConnectionDefinition>
{
}

[GenerateOneOf]
public partial class Union497573081: OneOfBase<LuaEntity, LuaPlayer>
{
}

[GenerateOneOf]
public partial class Union1603896041: OneOfBase<LuaLogisticPoint, Dictionary<LogisticMemberIndexEnum, LuaLogisticPoint>>
{
}

[GenerateOneOf]
public partial class Union955315863: OneOfBase<LuaEntity, MapPosition>
{
}

[GenerateOneOf]
public partial class Union458526948: OneOfBase<LuaEntity, PlayerIdentification>
{
}

[GenerateOneOf]
public partial class Union1109066428: OneOfBase<string, LuaNil>
{
}

[GenerateOneOf]
public partial class Union532119748: OneOfBase<InfinityInventoryFilter, LuaNil>
{
}

[GenerateOneOf]
public partial class Union1023877861: OneOfBase<InfinityPipeFilter, LuaNil>
{
}

[GenerateOneOf]
public partial class Union493873923: OneOfBase<string, LuaRecipe, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - heat-water-inside
///   - output-to-separate-pipe
/// </summary>
public enum Literals761816996
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

public class Table162611662
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
public enum Literals1551579449
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

public class Table1436604149
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

public class Table133459763
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

public class Table350516831
{
  [FactorioRconAttribute("min")]
  public double Min { get; set; }

  [FactorioRconAttribute("max")]
  public double Max { get; set; }

}

public class Table1130911828
{
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

}

public class Table285637500
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
public partial class Union1887875776: OneOfBase<ulong, double>
{
}

[GenerateOneOf]
public partial class Union216791007: OneOfBase<LuaFluidBoxPrototype, List<LuaFluidBoxPrototype>>
{
}

[GenerateOneOf]
public partial class Union1751895091: OneOfBase<FluidBoxFilterSpec, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - input
///   - input-output
///   - output
///   - none
/// </summary>
public enum Literals893153438
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
public partial class Union478526905: OneOfBase<Color, PrintSettings>
{
}

[GenerateOneOf]
public partial class Union973672886: OneOfBase<uint, string>
{
}

[GenerateOneOf]
public partial class Union45416710: OneOfBase<TrainStopGoal, RailEnd>
{
}

/// <summary>
/// Union of literals:
///   - respect-movement-direction
///   - any-direction-with-locomotives
/// </summary>
public enum Literals1861556821
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
public partial class Union625632831: OneOfBase<TrainPathFinderPathResult, TrainPathAnyGoalResult, TrainPathAllGoalsResult>
{
}

[GenerateOneOf]
public partial class Union588187751: OneOfBase<string, SignalID>
{
}

[GenerateOneOf]
public partial class Union1028307656: OneOfBase<LuaStyle, string>
{
}

/// <summary>
/// Union of literals:
///   - in-view
///   - top-third
/// </summary>
public enum Literals1299321874
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
public enum Literals92543650
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
public enum Literals947311345
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
public enum Literals1958288421
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
public enum Literals1189537475
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
public enum Literals2012425039
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
public enum Literals1744116963
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
public partial class Union1641951594: OneOfBase<string, LuaEntityPrototype, LuaEntity, LuaNil>
{
}

[GenerateOneOf]
public partial class Union2036427321: OneOfBase<UpgradeFilter, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - from
///   - to
/// </summary>
public enum Literals137692570
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
public partial class Union1444717342: OneOfBase<string, LuaTilePrototype, LuaTile, LuaNil>
{
}

/// <summary>
/// Union of literals:
///   - storage
///   - providers
/// </summary>
public enum Literals1997830415
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
public enum Literals1122877177
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
public enum Literals74191897
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
public enum Literals1436172750
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
public enum Literals339665519
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
public partial class Union582549694: OneOfBase<List<string>, List<int>, List<double>>
{
}

[GenerateOneOf]
public partial class Union1282806026: OneOfBase<bool, double, int, string>
{
}

[GenerateOneOf]
public partial class Union23339112: OneOfBase<double, int>
{
}

[GenerateOneOf]
public partial class Union35422357: OneOfBase<string, uint>
{
}

[GenerateOneOf]
public partial class Union1265061987: OneOfBase<string, LuaEntity, LuaEntityPrototype>
{
}

[GenerateOneOf]
public partial class Union844977329: OneOfBase<LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public partial class Union1054026747: OneOfBase<string, LuaItemPrototype, LuaItemStack>
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
public enum Literals431714712
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
public partial class Union859755215: OneOfBase<int, List<int>>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - center
///   - right
/// </summary>
public enum Literals2090650904
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
public enum Literals2105617757
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
public partial class Union1333519790: OneOfBase<LuaForce, string>
{
}

[GenerateOneOf]
public partial class Union1671383842: OneOfBase<CollisionMaskLayer, List<CollisionMaskLayer>>
{
}

[GenerateOneOf]
public partial class Union1558479331: OneOfBase<DirectionEnum, List<DirectionEnum>>
{
}

[GenerateOneOf]
public partial class Union1241242689: OneOfBase<ForceIdentification, List<ForceIdentification>>
{
}

[GenerateOneOf]
public partial class Union1980377764: OneOfBase<string, List<string>, LuaDecorativePrototype, List<LuaDecorativePrototype>>
{
}

[GenerateOneOf]
public partial class Union520878677: OneOfBase<CollisionMaskWithFlags, List<string>>
{
}

[GenerateOneOf]
public partial class Union1651295739: OneOfBase<string, LuaTilePrototype>
{
}

/// <summary>
/// Literal value: abort_on_collision
/// </summary>
public enum Literal1872039634
{
  /// <summary>
  /// Literal value: abort_on_collision
  /// </summary>
  [FactorioRconDefinitionValue("abort_on_collision")]
  AbortOnCollision,

}

[GenerateOneOf]
public partial class Union401330273: OneOfBase<bool, Literal1872039634>
{
}

public class Table1961989298
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

public class Table351806888
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

