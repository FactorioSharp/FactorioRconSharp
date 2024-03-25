#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

/// <summary>
/// How commands are joined together in a compound command (see <see cref="Defines.Command.Compound)" />.
/// </summary>
[FactorioRconDefinition("compound_command")]
public enum CompoundCommandEnum
{
  /// <summary>
  /// Fail on first failure. Only succeeds if all commands (executed one after another) succeed.
  /// </summary>
  [FactorioRconDefinitionValue("logical_and")]
  LogicalAnd,

  /// <summary>
  /// Succeed on first success. Only fails if all commands (executed one after another) fail.
  /// </summary>
  [FactorioRconDefinitionValue("logical_or")]
  LogicalOr,

  /// <summary>
  /// Execute all commands in sequence and fail or succeed depending on the return status of the last command.
  /// </summary>
  [FactorioRconDefinitionValue("return_last")]
  ReturnLast,

}

