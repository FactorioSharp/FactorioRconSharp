#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Allows rendering of geometric shapes, text and sprites in the game world through the global object named `rendering`. Each render object is identified by an id that is
///     universally unique for the lifetime of a whole game.
/// </summary>
[FactorioRconClass("LuaRendering")]
public abstract class LuaRendering : LuaObject
{
  /// <summary>
  ///     This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

  /// <summary>
  ///     Create a line.
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
    public abstract ulong DrawLine(
        Color color,
        float width,
        Union5349442 from,
        Union5349442 to,
        SurfaceIdentification surface,
        double? gapLength = null,
        double? dashLength = null,
        double? dashOffset = null,
        Vector? fromOffset = null,
        Vector? toOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create a text.
  /// </summary>
  /// <remarks>
  ///     Not all fonts support scaling.
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
    public abstract ulong DrawText(
        LocalisedString text,
        SurfaceIdentification surface,
        Union5349442 target,
        Color color,
        Vector? targetOffset = null,
        double? scale = null,
        string? font = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        RealOrientation? orientation = null,
        TextAlign? alignment = null,
        VerticalTextAlign? verticalAlignment = null,
        bool? scaleWithZoom = null,
        bool? onlyInAltMode = null,
        bool? useRichText = null
    );

  /// <summary>
  ///     Create a circle.
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
    public abstract ulong DrawCircle(
        Color color,
        double radius,
        Union5349442 target,
        SurfaceIdentification surface,
        float? width = null,
        bool? filled = null,
        Vector? targetOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create a rectangle.
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
    public abstract ulong DrawRectangle(
        Color color,
        Union5349442 leftTop,
        Union5349442 rightBottom,
        SurfaceIdentification surface,
        float? width = null,
        bool? filled = null,
        Vector? leftTopOffset = null,
        Vector? rightBottomOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create an arc.
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
    public abstract ulong DrawArc(
        Color color,
        double maxRadius,
        double minRadius,
        float startAngle,
        float angle,
        Union5349442 target,
        SurfaceIdentification surface,
        Vector? targetOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create a triangle mesh defined by a triangle strip.
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
    public abstract ulong DrawPolygon(
        Color color,
        List<ScriptRenderVertexTarget> vertices,
        SurfaceIdentification surface,
        Union5349442? target = null,
        Vector? targetOffset = null,
        RealOrientation? orientation = null,
        Union5349442? orientationTarget = null,
        Vector? orientationTargetOffset = null,
        bool? useTargetOrientation = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? drawOnGround = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create a sprite.
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
    public abstract ulong DrawSprite(
        SpritePath sprite,
        Union5349442 target,
        SurfaceIdentification surface,
        RealOrientation? orientation = null,
        double? xScale = null,
        double? yScale = null,
        Color? tint = null,
        RenderLayer? renderLayer = null,
        Union5349442? orientationTarget = null,
        Vector? orientationTargetOffset = null,
        bool? useTargetOrientation = null,
        Vector? orientedOffset = null,
        Vector? targetOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create a light.
  /// </summary>
  /// <remarks>
  ///     The base game uses the utility sprites `light_medium` and `light_small` for lights.
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
    public abstract ulong DrawLight(
        SpritePath sprite,
        Union5349442 target,
        SurfaceIdentification surface,
        RealOrientation? orientation = null,
        float? scale = null,
        float? intensity = null,
        float? minimumDarkness = null,
        bool? oriented = null,
        Color? color = null,
        Vector? targetOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Create an animation.
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
    public abstract ulong DrawAnimation(
        string animation,
        Union5349442 target,
        SurfaceIdentification surface,
        RealOrientation? orientation = null,
        double? xScale = null,
        double? yScale = null,
        Color? tint = null,
        RenderLayer? renderLayer = null,
        double? animationSpeed = null,
        double? animationOffset = null,
        Union5349442? orientationTarget = null,
        Vector? orientationTargetOffset = null,
        bool? useTargetOrientation = null,
        Vector? orientedOffset = null,
        Vector? targetOffset = null,
        uint? timeToLive = null,
        List<ForceIdentification>? forces = null,
        List<PlayerIdentification>? players = null,
        bool? visible = null,
        bool? onlyInAltMode = null
    );

  /// <summary>
  ///     Destroy the object with the given id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("destroy")]
    public abstract void Destroy(ulong id);

  /// <summary>
  ///     Does a font with this name exist?
  /// </summary>
  /// <param name="fontName">Lua name: font_name</param>
  [FactorioRconMethod("is_font_valid")]
    public abstract bool IsFontValid(string fontName);

  /// <summary>
  ///     Does a valid object with this id exist?
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("is_valid")]
    public abstract bool IsValid(ulong id);

  /// <summary>
  ///     Gets an array of all valid object ids.
  /// </summary>
  /// <param name="modName">Lua name: mod_name</param>
  [FactorioRconMethod("get_all_ids")]
    public abstract List<ulong> GetAllIds(string? modName = null);

  /// <summary>
  ///     Destroys all render objects.
  /// </summary>
  /// <param name="modName">Lua name: mod_name</param>
  [FactorioRconMethod("clear")]
    public abstract void Clear(string? modName = null);

  /// <summary>
  ///     Gets the type of the given object.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_type")]
    public abstract Literals431714712 GetType(ulong id);

  /// <summary>
  ///     Reorder this object so that it is drawn in front of the already existing objects.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("bring_to_front")]
    public abstract void BringToFront(ulong id);

  /// <summary>
  ///     The surface the object with this id is rendered on.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_surface")]
    public abstract LuaSurface GetSurface(ulong id);

  /// <summary>
  ///     Get the time to live of the object with this id. This will be 0 if the object does not expire.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_time_to_live")]
    public abstract uint GetTimeToLive(ulong id);

  /// <summary>
  ///     Set the time to live of the object with this id. Set to 0 if the object should not expire.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  [FactorioRconMethod("set_time_to_live")]
    public abstract void SetTimeToLive(ulong id, uint timeToLive);

  /// <summary>
  ///     Get the forces that the object with this id is rendered to or `nil` if visible to all forces.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_forces")]
    public abstract List<LuaForce>? GetForces(ulong id);

  /// <summary>
  ///     Set the forces that the object with this id is rendered to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="forces">Lua name: forces</param>
  [FactorioRconMethod("set_forces")]
    public abstract void SetForces(ulong id, List<ForceIdentification> forces);

  /// <summary>
  ///     Get the players that the object with this id is rendered to or `nil` if visible to all players.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_players")]
    public abstract List<LuaPlayer>? GetPlayers(ulong id);

  /// <summary>
  ///     Set the players that the object with this id is rendered to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="players">Lua name: players</param>
  [FactorioRconMethod("set_players")]
    public abstract void SetPlayers(ulong id, List<PlayerIdentification> players);

  /// <summary>
  ///     Get whether this is rendered to anyone at all.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_visible")]
    public abstract bool GetVisible(ulong id);

  /// <summary>
  ///     Set whether this is rendered to anyone at all.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="visible">Lua name: visible</param>
  [FactorioRconMethod("set_visible")]
    public abstract void SetVisible(ulong id, bool visible);

  /// <summary>
  ///     Get whether this is being drawn on the ground, under most entities and sprites.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_draw_on_ground")]
    public abstract bool GetDrawOnGround(ulong id);

  /// <summary>
  ///     Set whether this is being drawn on the ground, under most entities and sprites.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="drawOnGround">Lua name: draw_on_ground</param>
  [FactorioRconMethod("set_draw_on_ground")]
    public abstract void SetDrawOnGround(ulong id, bool drawOnGround);

  /// <summary>
  ///     Get whether this is only rendered in alt-mode.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_only_in_alt_mode")]
    public abstract bool GetOnlyInAltMode(ulong id);

  /// <summary>
  ///     Set whether this is only rendered in alt-mode.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="onlyInAltMode">Lua name: only_in_alt_mode</param>
  [FactorioRconMethod("set_only_in_alt_mode")]
    public abstract void SetOnlyInAltMode(ulong id, bool onlyInAltMode);

  /// <summary>
  ///     Get whether this uses the target orientation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_use_target_orientation")]
    public abstract bool GetUseTargetOrientation(ulong id);

  /// <summary>
  ///     Set whether this uses the target orientation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="useTargetOrientation">Lua name: use_target_orientation</param>
  [FactorioRconMethod("set_use_target_orientation")]
    public abstract void SetUseTargetOrientation(ulong id, bool useTargetOrientation);

  /// <summary>
  ///     Get the color or tint of the object with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_color")]
    public abstract Color? GetColor(ulong id);

  /// <summary>
  ///     Set the color or tint of the object with this id. Does nothing if this object does not support color.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="color">Lua name: color</param>
  [FactorioRconMethod("set_color")]
    public abstract void SetColor(ulong id, Color color);

  /// <summary>
  ///     Get the width of the object with this id. Value is in pixels (32 per tile).
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_width")]
    public abstract float? GetWidth(ulong id);

  /// <summary>
  ///     Set the width of the object with this id. Does nothing if this object does not support width. Value is in pixels (32 per tile).
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="width">Lua name: width</param>
  [FactorioRconMethod("set_width")]
    public abstract void SetWidth(ulong id, float width);

  /// <summary>
  ///     Get from where the line with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_from")]
    public abstract ScriptRenderTarget? GetFrom(ulong id);

  /// <summary>
  ///     Set from where the line with this id is drawn. Does nothing if the object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="from">Lua name: from</param>
  /// <param name="fromOffset">Lua name: from_offset</param>
  [FactorioRconMethod("set_from")]
    public abstract void SetFrom(ulong id, Union5349442 from, Vector? fromOffset = null);

  /// <summary>
  ///     Get where the line with this id is drawn to.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_to")]
    public abstract ScriptRenderTarget? GetTo(ulong id);

  /// <summary>
  ///     Set where the line with this id is drawn to. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="to">Lua name: to</param>
  /// <param name="toOffset">Lua name: to_offset</param>
  [FactorioRconMethod("set_to")]
    public abstract void SetTo(ulong id, Union5349442 to, Vector? toOffset = null);

  /// <summary>
  ///     Get the dash length of the line with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_dash_length")]
    public abstract double? GetDashLength(ulong id);

  /// <summary>
  ///     Set the dash length of the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="dashLength">Lua name: dash_length</param>
  [FactorioRconMethod("set_dash_length")]
    public abstract void SetDashLength(ulong id, double dashLength);

  /// <summary>
  ///     Get the length of the gaps in the line with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_gap_length")]
    public abstract double? GetGapLength(ulong id);

  /// <summary>
  ///     Set the length of the gaps in the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="gapLength">Lua name: gap_length</param>
  [FactorioRconMethod("set_gap_length")]
    public abstract void SetGapLength(ulong id, double gapLength);

  /// <summary>
  ///     Set the length of the dashes and the length of the gaps in the line with this id. Does nothing if this object is not a line.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="dashLength">Lua name: dash_length</param>
  /// <param name="gapLength">Lua name: gap_length</param>
  [FactorioRconMethod("set_dashes")]
    public abstract void SetDashes(ulong id, double dashLength, double gapLength);

  /// <summary>
  ///     Get where the object with this id is drawn.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_target")]
    public abstract ScriptRenderTarget? GetTarget(ulong id);

  /// <summary>
  ///     Set where the object with this id is drawn. Does nothing if this object does not support target.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="targetOffset">Lua name: target_offset</param>
  [FactorioRconMethod("set_target")]
    public abstract void SetTarget(ulong id, Union5349442 target, Vector? targetOffset = null);

  /// <summary>
  ///     Get the orientation of the object with this id.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_orientation")]
    public abstract RealOrientation? GetOrientation(ulong id);

  /// <summary>
  ///     Set the orientation of the object with this id. Does nothing if this object is not a text, polygon, sprite, light or animation.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientation">Lua name: orientation</param>
  [FactorioRconMethod("set_orientation")]
    public abstract void SetOrientation(ulong id, RealOrientation orientation);

  /// <summary>
  ///     Get the scale of the text or light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_scale")]
    public abstract double? GetScale(ulong id);

  /// <summary>
  ///     Set the scale of the text or light with this id. Does nothing if this object is not a text or light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="scale">Lua name: scale</param>
  [FactorioRconMethod("set_scale")]
    public abstract void SetScale(ulong id, double scale);

  /// <summary>
  ///     Get the text that is displayed by the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_text")]
    public abstract LocalisedString? GetText(ulong id);

  /// <summary>
  ///     Set the text that is displayed by the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="text">Lua name: text</param>
  [FactorioRconMethod("set_text")]
    public abstract void SetText(ulong id, LocalisedString text);

  /// <summary>
  ///     Get the font of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_font")]
    public abstract string? GetFont(ulong id);

  /// <summary>
  ///     Set the font of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="font">Lua name: font</param>
  [FactorioRconMethod("set_font")]
    public abstract void SetFont(ulong id, string font);

  /// <summary>
  ///     Get the alignment of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_alignment")]
    public abstract TextAlign? GetAlignment(ulong id);

  /// <summary>
  ///     Set the alignment of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="alignment">Lua name: alignment</param>
  [FactorioRconMethod("set_alignment")]
    public abstract void SetAlignment(ulong id, TextAlign alignment);

  /// <summary>
  ///     Get the vertical alignment of the text with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_vertical_alignment")]
    public abstract VerticalTextAlign? GetVerticalAlignment(ulong id);

  /// <summary>
  ///     Set the vertical alignment of the text with this id. Does nothing if this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="alignment">Lua name: alignment</param>
  [FactorioRconMethod("set_vertical_alignment")]
    public abstract void SetVerticalAlignment(ulong id, VerticalTextAlign alignment);

  /// <summary>
  ///     Get if the text with this id scales with player zoom.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_scale_with_zoom")]
    public abstract bool? GetScaleWithZoom(ulong id);

  /// <summary>
  ///     Set if the text with this id scales with player zoom, resulting in it always being the same size on screen, and the size compared to the game world changes. Does nothing if
  ///     this object is not a text.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="scaleWithZoom">Lua name: scale_with_zoom</param>
  [FactorioRconMethod("set_scale_with_zoom")]
    public abstract void SetScaleWithZoom(ulong id, bool scaleWithZoom);

  /// <summary>
  ///     Get if the text with this id parses rich text tags.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_use_rich_text")]
    public abstract bool? GetUseRichText(ulong id);

  /// <summary>
  ///     Set if the text with this id parses rich text tags.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="useRichText">Lua name: use_rich_text</param>
  [FactorioRconMethod("set_use_rich_text")]
    public abstract void SetUseRichText(ulong id, bool useRichText);

  /// <summary>
  ///     Get if the circle or rectangle with this id is filled.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_filled")]
    public abstract bool? GetFilled(ulong id);

  /// <summary>
  ///     Set if the circle or rectangle with this id is filled. Does nothing if this object is not a circle or rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="filled">Lua name: filled</param>
  [FactorioRconMethod("set_filled")]
    public abstract void SetFilled(ulong id, bool filled);

  /// <summary>
  ///     Get the radius of the circle with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_radius")]
    public abstract double? GetRadius(ulong id);

  /// <summary>
  ///     Set the radius of the circle with this id. Does nothing if this object is not a circle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="radius">Lua name: radius</param>
  [FactorioRconMethod("set_radius")]
    public abstract void SetRadius(ulong id, double radius);

  /// <summary>
  ///     Get where top left corner of the rectangle with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_left_top")]
    public abstract ScriptRenderTarget? GetLeftTop(ulong id);

  /// <summary>
  ///     Set where top left corner of the rectangle with this id is drawn. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="leftTop">Lua name: left_top</param>
  /// <param name="leftTopOffset">Lua name: left_top_offset</param>
  [FactorioRconMethod("set_left_top")]
    public abstract void SetLeftTop(ulong id, Union5349442 leftTop, Vector? leftTopOffset = null);

  /// <summary>
  ///     Get where bottom right corner of the rectangle with this id is drawn.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_right_bottom")]
    public abstract ScriptRenderTarget? GetRightBottom(ulong id);

  /// <summary>
  ///     Set where top bottom right of the rectangle with this id is drawn. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="rightBottom">Lua name: right_bottom</param>
  /// <param name="rightBottomOffset">Lua name: right_bottom_offset</param>
  [FactorioRconMethod("set_right_bottom")]
    public abstract void SetRightBottom(ulong id, Union5349442 rightBottom, Vector? rightBottomOffset = null);

  /// <summary>
  ///     Set the corners of the rectangle with this id. Does nothing if this object is not a rectangle.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="leftTop">Lua name: left_top</param>
  /// <param name="leftTopOffset">Lua name: left_top_offset</param>
  /// <param name="rightBottom">Lua name: right_bottom</param>
  /// <param name="rightBottomOffset">Lua name: right_bottom_offset</param>
  [FactorioRconMethod("set_corners")]
    public abstract void SetCorners(ulong id, Union5349442 leftTop, Vector leftTopOffset, Union5349442 rightBottom, Vector rightBottomOffset);

  /// <summary>
  ///     Get the radius of the outer edge of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_max_radius")]
    public abstract double? GetMaxRadius(ulong id);

  /// <summary>
  ///     Set the radius of the outer edge of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="maxRadius">Lua name: max_radius</param>
  [FactorioRconMethod("set_max_radius")]
    public abstract void SetMaxRadius(ulong id, double maxRadius);

  /// <summary>
  ///     Get the radius of the inner edge of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_min_radius")]
    public abstract double? GetMinRadius(ulong id);

  /// <summary>
  ///     Set the radius of the inner edge of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="minRadius">Lua name: min_radius</param>
  [FactorioRconMethod("set_min_radius")]
    public abstract void SetMinRadius(ulong id, double minRadius);

  /// <summary>
  ///     Get where the arc with this id starts.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_start_angle")]
    public abstract float? GetStartAngle(ulong id);

  /// <summary>
  ///     Set where the arc with this id starts. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="startAngle">Lua name: start_angle</param>
  [FactorioRconMethod("set_start_angle")]
    public abstract void SetStartAngle(ulong id, float startAngle);

  /// <summary>
  ///     Get the angle of the arc with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_angle")]
    public abstract float? GetAngle(ulong id);

  /// <summary>
  ///     Set the angle of the arc with this id. Does nothing if this object is not a arc.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="angle">Lua name: angle</param>
  [FactorioRconMethod("set_angle")]
    public abstract void SetAngle(ulong id, float angle);

  /// <summary>
  ///     Get the vertices of the polygon with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_vertices")]
    public abstract List<ScriptRenderTarget>? GetVertices(ulong id);

  /// <summary>
  ///     Set the vertices of the polygon with this id. Does nothing if this object is not a polygon.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="vertices">Lua name: vertices</param>
  [FactorioRconMethod("set_vertices")]
    public abstract void SetVertices(ulong id, List<ScriptRenderVertexTarget> vertices);

  /// <summary>
  ///     Get the sprite of the sprite or light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_sprite")]
    public abstract SpritePath? GetSprite(ulong id);

  /// <summary>
  ///     Set the sprite of the sprite or light with this id. Does nothing if this object is not a sprite or light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="sprite">Lua name: sprite</param>
  [FactorioRconMethod("set_sprite")]
    public abstract void SetSprite(ulong id, SpritePath sprite);

  /// <summary>
  ///     Get the horizontal scale of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_x_scale")]
    public abstract double? GetXScale(ulong id);

  /// <summary>
  ///     Set the horizontal scale of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="xScale">Lua name: x_scale</param>
  [FactorioRconMethod("set_x_scale")]
    public abstract void SetXScale(ulong id, double xScale);

  /// <summary>
  ///     Get the vertical scale of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_y_scale")]
    public abstract double? GetYScale(ulong id);

  /// <summary>
  ///     Set the vertical scale of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="yScale">Lua name: y_scale</param>
  [FactorioRconMethod("set_y_scale")]
    public abstract void SetYScale(ulong id, double yScale);

  /// <summary>
  ///     Get the render layer of the sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_render_layer")]
    public abstract RenderLayer? GetRenderLayer(ulong id);

  /// <summary>
  ///     Set the render layer of the sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="renderLayer">Lua name: render_layer</param>
  [FactorioRconMethod("set_render_layer")]
    public abstract void SetRenderLayer(ulong id, RenderLayer renderLayer);

  /// <summary>
  ///     The object rotates so that it faces this target. Note that `orientation` is still applied to the object. Get the orientation_target of the object with this id.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_orientation_target")]
    public abstract ScriptRenderTarget? GetOrientationTarget(ulong id);

  /// <summary>
  ///     The object rotates so that it faces this target. Note that `orientation` is still applied to the object. Set the orientation_target of the object with this id. Does nothing if
  ///     this object is not a polygon, sprite, or animation. Set to `nil` if the object should not have an orientation_target.
  /// </summary>
  /// <remarks>
  ///     Polygon vertices that are set to an entity will ignore this.
  /// </remarks>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientationTarget">Lua name: orientation_target</param>
  /// <param name="orientationTargetOffset">Lua name: orientation_target_offset</param>
  [FactorioRconMethod("set_orientation_target")]
    public abstract void SetOrientationTarget(ulong id, Union5349442 orientationTarget, Vector? orientationTargetOffset = null);

  /// <summary>
  ///     Offsets the center of the sprite or animation if `orientation_target` is given. This offset will rotate together with the sprite or animation. Get the oriented_offset of the
  ///     sprite or animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_oriented_offset")]
    public abstract Vector? GetOrientedOffset(ulong id);

  /// <summary>
  ///     Offsets the center of the sprite or animation if `orientation_target` is given. This offset will rotate together with the sprite or animation. Set the oriented_offset of the
  ///     sprite or animation with this id. Does nothing if this object is not a sprite or animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="orientedOffset">Lua name: oriented_offset</param>
  [FactorioRconMethod("set_oriented_offset")]
    public abstract void SetOrientedOffset(ulong id, Vector orientedOffset);

  /// <summary>
  ///     Get the intensity of the light with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_intensity")]
    public abstract float? GetIntensity(ulong id);

  /// <summary>
  ///     Set the intensity of the light with this id. Does nothing if this object is not a light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="intensity">Lua name: intensity</param>
  [FactorioRconMethod("set_intensity")]
    public abstract void SetIntensity(ulong id, float intensity);

  /// <summary>
  ///     Get the minimum darkness at which the light with this id is rendered.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_minimum_darkness")]
    public abstract float? GetMinimumDarkness(ulong id);

  /// <summary>
  ///     Set the minimum darkness at which the light with this id is rendered. Does nothing if this object is not a light.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="minimumDarkness">Lua name: minimum_darkness</param>
  [FactorioRconMethod("set_minimum_darkness")]
    public abstract void SetMinimumDarkness(ulong id, float minimumDarkness);

  /// <summary>
  ///     Get if the light with this id is rendered has the same orientation as the target entity. Note that `orientation` is still applied to the sprite.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_oriented")]
    public abstract bool? GetOriented(ulong id);

  /// <summary>
  ///     Set if the light with this id is rendered has the same orientation as the target entity. Does nothing if this object is not a light. Note that `orientation` is still applied
  ///     to the sprite.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="oriented">Lua name: oriented</param>
  [FactorioRconMethod("set_oriented")]
    public abstract void SetOriented(ulong id, bool oriented);

  /// <summary>
  ///     Get the animation prototype name of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation")]
    public abstract string? GetAnimation(ulong id);

  /// <summary>
  ///     Set the animation prototype name of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animation">Lua name: animation</param>
  [FactorioRconMethod("set_animation")]
    public abstract void SetAnimation(ulong id, string animation);

  /// <summary>
  ///     Get the animation speed of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation_speed")]
    public abstract double? GetAnimationSpeed(ulong id);

  /// <summary>
  ///     Set the animation speed of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animationSpeed">Lua name: animation_speed</param>
  [FactorioRconMethod("set_animation_speed")]
    public abstract void SetAnimationSpeed(ulong id, double animationSpeed);

  /// <summary>
  ///     Get the animation offset of the animation with this id.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("get_animation_offset")]
    public abstract double? GetAnimationOffset(ulong id);

  /// <summary>
  ///     Set the animation offset of the animation with this id. Does nothing if this object is not an animation.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="animationOffset">Lua name: animation_offset</param>
  [FactorioRconMethod("set_animation_offset")]
    public abstract void SetAnimationOffset(ulong id, double animationOffset);
}
