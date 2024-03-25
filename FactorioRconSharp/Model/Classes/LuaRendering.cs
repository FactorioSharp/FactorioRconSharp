#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Allows rendering of geometric shapes, text and sprites in the game world through the global object named `rendering`. Each render object is identified by an id that is universally unique for the lifetime of a whole game.
/// </summary>
[FactorioRconClass("LuaRendering")]
public class LuaRendering
{
  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Create a line.
  /// </summary>
  /// <param name="color">Lua name: color</param>
  /// <param name="width">Lua name: width</param>
  /// <param name="gapLength">Lua name: gap_length</param>
  /// <param name="dashLength">Lua name: dash_length</param>
  /// <param name="dashOffset">Lua name: dash_offset</param>
  /// <param name="from">Lua name: from</param>
  /// <param name="fromOffset">Lua name: from_offset</param>
  /// <param name="to">Lua name: to</param>
  /// <param name="toOffset">Lua name: to_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_line")]
  public ulong DrawLine(Color color, float width, OneOf<MapPosition, LuaEntity> from, OneOf<MapPosition, LuaEntity> to, SurfaceIdentification surface, double? gapLength = null, double? dashLength = null, double? dashOffset = null, Vector? fromOffset = null, Vector? toOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a text.
  /// </summary>
  /// <remarks>
  /// Not all fonts support scaling.
  /// </remarks>
  /// <param name="text">Lua name: text</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="color">Lua name: color</param>
  /// <param name="scale">Lua name: scale</param>
  /// <param name="font">Lua name: font</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="orientation">Lua name: orientation</param>
  /// <param name="alignment">Lua name: alignment</param>
  /// <param name="verticalAlignment">Lua name: vertical_alignment</param>
  /// <param name="scaleWithZoom">Lua name: scale_with_zoom</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  /// <param name="useRichText">Lua name: use_rich_text</param>
  [FactorioRconMethod("draw_text")]
  public ulong DrawText(LocalisedString text, SurfaceIdentification surface, OneOf<MapPosition, LuaEntity> target, Color color, Vector? targetOffset = null, double? scale = null, string? font = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, RealOrientation? orientation = null, TextAlign? alignment = null, VerticalTextAlign? verticalAlignment = null, bool? scaleWithZoom = null, bool? onlyInAltMode = null, bool? useRichText = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a circle.
  /// </summary>
  /// <param name="color">Lua name: color</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="width">Lua name: width</param>
  /// <param name="filled">Lua name: filled</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_circle")]
  public ulong DrawCircle(Color color, double radius, OneOf<MapPosition, LuaEntity> target, SurfaceIdentification surface, float? width = null, bool? filled = null, Vector? targetOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a rectangle.
  /// </summary>
  /// <param name="color">Lua name: color</param>
  /// <param name="width">Lua name: width</param>
  /// <param name="filled">Lua name: filled</param>
  /// <param name="leftTop">Lua name: left_top</param>
  /// <param name="leftTopOffset">Lua name: left_top_offset</param>
  /// <param name="rightBottom">Lua name: right_bottom</param>
  /// <param name="rightBottomOffset">Lua name: right_bottom_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_rectangle")]
  public ulong DrawRectangle(Color color, OneOf<MapPosition, LuaEntity> leftTop, OneOf<MapPosition, LuaEntity> rightBottom, SurfaceIdentification surface, float? width = null, bool? filled = null, Vector? leftTopOffset = null, Vector? rightBottomOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create an arc.
  /// </summary>
  /// <param name="color">Lua name: color</param>
  /// <param name="maxRadius">Lua name: max_radius</param>
  /// <param name="minRadius">Lua name: min_radius</param>
  /// <param name="startAngle">Lua name: start_angle</param>
  /// <param name="angle">Lua name: angle</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_arc")]
  public ulong DrawArc(Color color, double maxRadius, double minRadius, float startAngle, float angle, OneOf<MapPosition, LuaEntity> target, SurfaceIdentification surface, Vector? targetOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a triangle mesh defined by a triangle strip.
  /// </summary>
  /// <param name="color">Lua name: color</param>
  /// <param name="vertices">Lua name: vertices</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="orientation">Lua name: orientation</param>
  /// <param name="orientationTarget">Lua name: orientation_target</param>
  /// <param name="orientationTargetOffset">Lua name: orientation_target_offset</param>
  /// <param name="useTargetOrientation">Lua name: use_target_orientation</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_polygon")]
  public ulong DrawPolygon(Color color, ScriptRenderVertexTarget[] vertices, SurfaceIdentification surface, OneOf<MapPosition, LuaEntity>? target = null, Vector? targetOffset = null, RealOrientation? orientation = null, OneOf<MapPosition, LuaEntity>? orientationTarget = null, Vector? orientationTargetOffset = null, bool? useTargetOrientation = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? drawOnGround = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a sprite.
  /// </summary>
  /// <param name="sprite">Lua name: sprite</param>
  /// <param name="orientation">Lua name: orientation</param>
  /// <param name="xScale">Lua name: x_scale</param>
  /// <param name="yScale">Lua name: y_scale</param>
  /// <param name="tint">Lua name: tint</param>
  /// <param name="renderLayer">Lua name: render_layer</param>
  /// <param name="orientationTarget">Lua name: orientation_target</param>
  /// <param name="orientationTargetOffset">Lua name: orientation_target_offset</param>
  /// <param name="useTargetOrientation">Lua name: use_target_orientation</param>
  /// <param name="orientedOffset">Lua name: oriented_offset</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_sprite")]
  public ulong DrawSprite(SpritePath sprite, OneOf<MapPosition, LuaEntity> target, SurfaceIdentification surface, RealOrientation? orientation = null, double? xScale = null, double? yScale = null, Color? tint = null, RenderLayer? renderLayer = null, OneOf<MapPosition, LuaEntity>? orientationTarget = null, Vector? orientationTargetOffset = null, bool? useTargetOrientation = null, Vector? orientedOffset = null, Vector? targetOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create a light.
  /// </summary>
  /// <remarks>
  /// The base game uses the utility sprites `light_medium` and `light_small` for lights.
  /// </remarks>
  /// <param name="sprite">Lua name: sprite</param>
  /// <param name="orientation">Lua name: orientation</param>
  /// <param name="scale">Lua name: scale</param>
  /// <param name="intensity">Lua name: intensity</param>
  /// <param name="minimumDarkness">Lua name: minimum_darkness</param>
  /// <param name="oriented">Lua name: oriented</param>
  /// <param name="color">Lua name: color</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_light")]
  public ulong DrawLight(SpritePath sprite, OneOf<MapPosition, LuaEntity> target, SurfaceIdentification surface, RealOrientation? orientation = null, float? scale = null, float? intensity = null, float? minimumDarkness = null, bool? oriented = null, Color? color = null, Vector? targetOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create an animation.
  /// </summary>
  /// <param name="animation">Lua name: animation</param>
  /// <param name="orientation">Lua name: orientation</param>
  /// <param name="xScale">Lua name: x_scale</param>
  /// <param name="yScale">Lua name: y_scale</param>
  /// <param name="tint">Lua name: tint</param>
  /// <param name="renderLayer">Lua name: render_layer</param>
  /// <param name="animationSpeed">Lua name: animation_speed</param>
  /// <param name="animationOffset">Lua name: animation_offset</param>
  /// <param name="orientationTarget">Lua name: orientation_target</param>
  /// <param name="orientationTargetOffset">Lua name: orientation_target_offset</param>
  /// <param name="useTargetOrientation">Lua name: use_target_orientation</param>
  /// <param name="orientedOffset">Lua name: oriented_offset</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="forces">Lua name: forces</param>
  /// <param name="players">Lua name: players</param>
  /// <param name="visible">Lua name: visible</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("draw_animation")]
  public ulong DrawAnimation(string animation, OneOf<MapPosition, LuaEntity> target, SurfaceIdentification surface, RealOrientation? orientation = null, double? xScale = null, double? yScale = null, Color? tint = null, RenderLayer? renderLayer = null, double? animationSpeed = null, double? animationOffset = null, OneOf<MapPosition, LuaEntity>? orientationTarget = null, Vector? orientationTargetOffset = null, bool? useTargetOrientation = null, Vector? orientedOffset = null, Vector? targetOffset = null, uint? timeToLive = null, ForceIdentification[]? forces = null, PlayerIdentification[]? players = null, bool? visible = null, bool? onlyInAltMode = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Destroy the object with the given id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("destroy")]
  public void Destroy(ulong id) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Does a font with this name exist?
  /// </summary>
  /// <param name="fontName">Lua name: font_name</param>
  [FactorioRconMethod("is_font_valid")]
  public bool IsFontValid(string fontName) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Does a valid object with this id exist?
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("is_valid")]
  public bool IsValid(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets an array of all valid object ids.
  /// </summary>
  /// <param name="modName">Lua name: mod_name</param>
  [FactorioRconMethod("get_all_ids")]
  public ulong[] GetAllIds(string? modName = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Destroys all render objects.
  /// </summary>
  /// <param name="modName">Lua name: mod_name</param>
  [FactorioRconMethod("clear")]
  public void Clear(string? modName = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Gets the type of the given object.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_type")]
  public OneOf<Literal40535505, Literal34678979, Literal66166301, Literal39774547, Literal12611187, Literal30180123, Literal2808346, Literal14333193, Literal13009416> GetType(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Reorder this object so that it is drawn in front of the already existing objects.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("bring_to_front")]
  public void BringToFront(ulong id) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// The surface the object with this id is rendered on.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_surface")]
  public LuaSurface GetSurface(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Get the time to live of the object with this id. This will be 0 if the object does not expire.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_time_to_live")]
  public uint GetTimeToLive(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the time to live of the object with this id. Set to 0 if the object should not expire.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  [FactorioRconMethod("set_time_to_live")]
  public void SetTimeToLive(ulong id, uint timeToLive) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the forces that the object with this id is rendered to or `nil` if visible to all forces.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_forces")]
  public LuaForce[]? GetForces(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the forces that the object with this id is rendered to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="forces">Lua name: forces</param>
  [FactorioRconMethod("set_forces")]
  public void SetForces(ulong id, ForceIdentification[] forces) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the players that the object with this id is rendered to or `nil` if visible to all players.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_players")]
  public LuaPlayer[]? GetPlayers(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the players that the object with this id is rendered to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="players">Lua name: players</param>
  [FactorioRconMethod("set_players")]
  public void SetPlayers(ulong id, PlayerIdentification[] players) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get whether this is rendered to anyone at all.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_visible")]
  public bool GetVisible(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set whether this is rendered to anyone at all.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="visible">Lua name: visible</param>
  [FactorioRconMethod("set_visible")]
  public void SetVisible(ulong id, bool visible) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get whether this is being drawn on the ground, under most entities and sprites.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_draw_on_ground")]
  public bool GetDrawOnGround(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set whether this is being drawn on the ground, under most entities and sprites.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  [FactorioRconMethod("set_draw_on_ground")]
  public void SetDrawOnGround(ulong id, bool drawOnGround) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get whether this is only rendered in alt-mode.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_only_in_alt_mode")]
  public bool GetOnlyInAltMode(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set whether this is only rendered in alt-mode.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("set_only_in_alt_mode")]
  public void SetOnlyInAltMode(ulong id, bool onlyInAltMode) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get whether this uses the target orientation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_use_target_orientation")]
  public bool GetUseTargetOrientation(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set whether this uses the target orientation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="useTargetOrientation">Lua name: use_target_orientation</param>
  [FactorioRconMethod("set_use_target_orientation")]
  public void SetUseTargetOrientation(ulong id, bool useTargetOrientation) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the color or tint of the object with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_color")]
  public Color? GetColor(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the color or tint of the object with this id. Does nothing if this object does not support color.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="color">Lua name: color</param>
  [FactorioRconMethod("set_color")]
  public void SetColor(ulong id, Color color) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the width of the object with this id. Value is in pixels (32 per tile).
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_width")]
  public float? GetWidth(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the width of the object with this id. Does nothing if this object does not support width. Value is in pixels (32 per tile).
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="width">Lua name: width</param>
  [FactorioRconMethod("set_width")]
  public void SetWidth(ulong id, float width) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get from where the line with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_from")]
  public ScriptRenderTarget? GetFrom(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set from where the line with this id is drawn. Does nothing if the object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="from">Lua name: from</param>
  /// <param name="fromOffset">Lua name: from_offset</param>
  [FactorioRconMethod("set_from")]
  public void SetFrom(ulong id, OneOf<MapPosition, LuaEntity> from, Vector? fromOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get where the line with this id is drawn to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_to")]
  public ScriptRenderTarget? GetTo(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set where the line with this id is drawn to. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="to">Lua name: to</param>
  /// <param name="toOffset">Lua name: to_offset</param>
  [FactorioRconMethod("set_to")]
  public void SetTo(ulong id, OneOf<MapPosition, LuaEntity> to, Vector? toOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the dash length of the line with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_dash_length")]
  public double? GetDashLength(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the dash length of the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="dashLength">Lua name: dash_length</param>
  [FactorioRconMethod("set_dash_length")]
  public void SetDashLength(ulong id, double dashLength) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the length of the gaps in the line with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_gap_length")]
  public double? GetGapLength(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the length of the gaps in the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="gapLength">Lua name: gap_length</param>
  [FactorioRconMethod("set_gap_length")]
  public void SetGapLength(ulong id, double gapLength) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Set the length of the dashes and the length of the gaps in the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="dashLength">Lua name: dash_length</param>
  /// <param name="gapLength">Lua name: gap_length</param>
  [FactorioRconMethod("set_dashes")]
  public void SetDashes(ulong id, double dashLength, double gapLength) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get where the object with this id is drawn.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_target")]
  public ScriptRenderTarget? GetTarget(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set where the object with this id is drawn. Does nothing if this object does not support target.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  [FactorioRconMethod("set_target")]
  public void SetTarget(ulong id, OneOf<MapPosition, LuaEntity> target, Vector? targetOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the orientation of the object with this id.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_orientation")]
  public RealOrientation? GetOrientation(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the orientation of the object with this id. Does nothing if this object is not a text, polygon, sprite, light or animation.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientation">Lua name: orientation</param>
  [FactorioRconMethod("set_orientation")]
  public void SetOrientation(ulong id, RealOrientation orientation) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the scale of the text or light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_scale")]
  public double? GetScale(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the scale of the text or light with this id. Does nothing if this object is not a text or light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="scale">Lua name: scale</param>
  [FactorioRconMethod("set_scale")]
  public void SetScale(ulong id, double scale) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the text that is displayed by the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_text")]
  public LocalisedString? GetText(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the text that is displayed by the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="text">Lua name: text</param>
  [FactorioRconMethod("set_text")]
  public void SetText(ulong id, LocalisedString text) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the font of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_font")]
  public string? GetFont(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the font of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="font">Lua name: font</param>
  [FactorioRconMethod("set_font")]
  public void SetFont(ulong id, string font) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the alignment of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_alignment")]
  public TextAlign? GetAlignment(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the alignment of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="alignment">Lua name: alignment</param>
  [FactorioRconMethod("set_alignment")]
  public void SetAlignment(ulong id, TextAlign alignment) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the vertical alignment of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_vertical_alignment")]
  public VerticalTextAlign? GetVerticalAlignment(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the vertical alignment of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="alignment">Lua name: alignment</param>
  [FactorioRconMethod("set_vertical_alignment")]
  public void SetVerticalAlignment(ulong id, VerticalTextAlign alignment) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get if the text with this id scales with player zoom.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_scale_with_zoom")]
  public bool? GetScaleWithZoom(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set if the text with this id scales with player zoom, resulting in it always being the same size on screen, and the size compared to the game world changes. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="scaleWithZoom">Lua name: scale_with_zoom</param>
  [FactorioRconMethod("set_scale_with_zoom")]
  public void SetScaleWithZoom(ulong id, bool scaleWithZoom) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get if the text with this id parses rich text tags.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_use_rich_text")]
  public bool? GetUseRichText(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set if the text with this id parses rich text tags.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="useRichText">Lua name: use_rich_text</param>
  [FactorioRconMethod("set_use_rich_text")]
  public void SetUseRichText(ulong id, bool useRichText) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get if the circle or rectangle with this id is filled.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_filled")]
  public bool? GetFilled(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set if the circle or rectangle with this id is filled. Does nothing if this object is not a circle or rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="filled">Lua name: filled</param>
  [FactorioRconMethod("set_filled")]
  public void SetFilled(ulong id, bool filled) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the radius of the circle with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_radius")]
  public double? GetRadius(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the radius of the circle with this id. Does nothing if this object is not a circle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="radius">Lua name: radius</param>
  [FactorioRconMethod("set_radius")]
  public void SetRadius(ulong id, double radius) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get where top left corner of the rectangle with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_left_top")]
  public ScriptRenderTarget? GetLeftTop(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set where top left corner of the rectangle with this id is drawn. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="leftTop">Lua name: left_top</param>
  /// <param name="leftTopOffset">Lua name: left_top_offset</param>
  [FactorioRconMethod("set_left_top")]
  public void SetLeftTop(ulong id, OneOf<MapPosition, LuaEntity> leftTop, Vector? leftTopOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get where bottom right corner of the rectangle with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_right_bottom")]
  public ScriptRenderTarget? GetRightBottom(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set where top bottom right of the rectangle with this id is drawn. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="rightBottom">Lua name: right_bottom</param>
  /// <param name="rightBottomOffset">Lua name: right_bottom_offset</param>
  [FactorioRconMethod("set_right_bottom")]
  public void SetRightBottom(ulong id, OneOf<MapPosition, LuaEntity> rightBottom, Vector? rightBottomOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Set the corners of the rectangle with this id. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="leftTop">Lua name: left_top</param>
  /// <param name="leftTopOffset">Lua name: left_top_offset</param>
  /// <param name="rightBottom">Lua name: right_bottom</param>
  /// <param name="rightBottomOffset">Lua name: right_bottom_offset</param>
  [FactorioRconMethod("set_corners")]
  public void SetCorners(ulong id, OneOf<MapPosition, LuaEntity> leftTop, Vector leftTopOffset, OneOf<MapPosition, LuaEntity> rightBottom, Vector rightBottomOffset) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the radius of the outer edge of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_max_radius")]
  public double? GetMaxRadius(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the radius of the outer edge of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="maxRadius">Lua name: max_radius</param>
  [FactorioRconMethod("set_max_radius")]
  public void SetMaxRadius(ulong id, double maxRadius) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the radius of the inner edge of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_min_radius")]
  public double? GetMinRadius(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the radius of the inner edge of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="minRadius">Lua name: min_radius</param>
  [FactorioRconMethod("set_min_radius")]
  public void SetMinRadius(ulong id, double minRadius) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get where the arc with this id starts.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_start_angle")]
  public float? GetStartAngle(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set where the arc with this id starts. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="startAngle">Lua name: start_angle</param>
  [FactorioRconMethod("set_start_angle")]
  public void SetStartAngle(ulong id, float startAngle) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the angle of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_angle")]
  public float? GetAngle(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the angle of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="angle">Lua name: angle</param>
  [FactorioRconMethod("set_angle")]
  public void SetAngle(ulong id, float angle) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the vertices of the polygon with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_vertices")]
  public ScriptRenderTarget[]? GetVertices(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the vertices of the polygon with this id. Does nothing if this object is not a polygon.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="vertices">Lua name: vertices</param>
  [FactorioRconMethod("set_vertices")]
  public void SetVertices(ulong id, ScriptRenderVertexTarget[] vertices) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the sprite of the sprite or light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_sprite")]
  public SpritePath? GetSprite(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the sprite of the sprite or light with this id. Does nothing if this object is not a sprite or light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="sprite">Lua name: sprite</param>
  [FactorioRconMethod("set_sprite")]
  public void SetSprite(ulong id, SpritePath sprite) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the horizontal scale of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_x_scale")]
  public double? GetXScale(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the horizontal scale of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="xScale">Lua name: x_scale</param>
  [FactorioRconMethod("set_x_scale")]
  public void SetXScale(ulong id, double xScale) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the vertical scale of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_y_scale")]
  public double? GetYScale(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the vertical scale of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="yScale">Lua name: y_scale</param>
  [FactorioRconMethod("set_y_scale")]
  public void SetYScale(ulong id, double yScale) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the render layer of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_render_layer")]
  public RenderLayer? GetRenderLayer(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the render layer of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="renderLayer">Lua name: render_layer</param>
  [FactorioRconMethod("set_render_layer")]
  public void SetRenderLayer(ulong id, RenderLayer renderLayer) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// The object rotates so that it faces this target. Note that `orientation` is still applied to the object. Get the orientation_target of the object with this id.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_orientation_target")]
  public ScriptRenderTarget? GetOrientationTarget(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// The object rotates so that it faces this target. Note that `orientation` is still applied to the object. Set the orientation_target of the object with this id. Does nothing if this object is not a polygon, sprite, or animation. Set to `nil` if the object should not have an orientation_target.
  /// </summary>
  /// <remarks>
  /// Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientationTarget">Lua name: orientation_target</param>
  /// <param name="orientationTargetOffset">Lua name: orientation_target_offset</param>
  [FactorioRconMethod("set_orientation_target")]
  public void SetOrientationTarget(ulong id, OneOf<MapPosition, LuaEntity> orientationTarget, Vector? orientationTargetOffset = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Offsets the center of the sprite or animation if `orientation_target` is given. This offset will rotate together with the sprite or animation. Get the oriented_offset of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_oriented_offset")]
  public Vector? GetOrientedOffset(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Offsets the center of the sprite or animation if `orientation_target` is given. This offset will rotate together with the sprite or animation. Set the oriented_offset of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientedOffset">Lua name: oriented_offset</param>
  [FactorioRconMethod("set_oriented_offset")]
  public void SetOrientedOffset(ulong id, Vector orientedOffset) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the intensity of the light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_intensity")]
  public float? GetIntensity(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the intensity of the light with this id. Does nothing if this object is not a light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="intensity">Lua name: intensity</param>
  [FactorioRconMethod("set_intensity")]
  public void SetIntensity(ulong id, float intensity) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the minimum darkness at which the light with this id is rendered.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_minimum_darkness")]
  public float? GetMinimumDarkness(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the minimum darkness at which the light with this id is rendered. Does nothing if this object is not a light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="minimumDarkness">Lua name: minimum_darkness</param>
  [FactorioRconMethod("set_minimum_darkness")]
  public void SetMinimumDarkness(ulong id, float minimumDarkness) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get if the light with this id is rendered has the same orientation as the target entity. Note that `orientation` is still applied to the sprite.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_oriented")]
  public bool? GetOriented(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set if the light with this id is rendered has the same orientation as the target entity. Does nothing if this object is not a light. Note that `orientation` is still applied to the sprite.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="oriented">Lua name: oriented</param>
  [FactorioRconMethod("set_oriented")]
  public void SetOriented(ulong id, bool oriented) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the animation prototype name of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation")]
  public string? GetAnimation(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the animation prototype name of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animation">Lua name: animation</param>
  [FactorioRconMethod("set_animation")]
  public void SetAnimation(ulong id, string animation) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the animation speed of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation_speed")]
  public double? GetAnimationSpeed(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the animation speed of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animationSpeed">Lua name: animation_speed</param>
  [FactorioRconMethod("set_animation_speed")]
  public void SetAnimationSpeed(ulong id, double animationSpeed) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the animation offset of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation_offset")]
  public double? GetAnimationOffset(ulong id) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set the animation offset of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animationOffset">Lua name: animation_offset</param>
  [FactorioRconMethod("set_animation_offset")]
  public void SetAnimationOffset(ulong id, double animationOffset) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

}

/// <summary>
/// Literal value: text
/// </summary>
public class Literal40535505
{
  /// <summary>
  /// Literal value: text
  /// </summary>
  [FactorioRconAttribute("text")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: line
/// </summary>
public class Literal34678979
{
  /// <summary>
  /// Literal value: line
  /// </summary>
  [FactorioRconAttribute("line")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: circle
/// </summary>
public class Literal66166301
{
  /// <summary>
  /// Literal value: circle
  /// </summary>
  [FactorioRconAttribute("circle")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: rectangle
/// </summary>
public class Literal39774547
{
  /// <summary>
  /// Literal value: rectangle
  /// </summary>
  [FactorioRconAttribute("rectangle")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: arc
/// </summary>
public class Literal12611187
{
  /// <summary>
  /// Literal value: arc
  /// </summary>
  [FactorioRconAttribute("arc")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: polygon
/// </summary>
public class Literal30180123
{
  /// <summary>
  /// Literal value: polygon
  /// </summary>
  [FactorioRconAttribute("polygon")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: sprite
/// </summary>
public class Literal2808346
{
  /// <summary>
  /// Literal value: sprite
  /// </summary>
  [FactorioRconAttribute("sprite")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: light
/// </summary>
public class Literal14333193
{
  /// <summary>
  /// Literal value: light
  /// </summary>
  [FactorioRconAttribute("light")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: animation
/// </summary>
public class Literal13009416
{
  /// <summary>
  /// Literal value: animation
  /// </summary>
  [FactorioRconAttribute("animation")]
  public static object Value { get; private set; }

}

