﻿// <copyright file="AddCommandChatCommandPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.ChatCommands;

using System.Runtime.InteropServices;
using MUnique.OpenMU.AttributeSystem;
using MUnique.OpenMU.GameLogic.Attributes;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// A chat command plugin which handles the command to add command stat points.
/// </summary>
[Guid("042EC5C6-27C8-4E00-A48B-C5458EDEA0BF")]
[PlugIn("Add command chat command", "Adds the specified amount of command points to the character.")]
[ChatCommandHelp(Command, "Adds the specified amount of command points to the character.", typeof(Arguments), MinimumStatus)]
public class AddCommandChatCommandPlugIn : AddStatChatCommandPlugInBase.AddSingleStatChatCommandPlugInBase
{
    private const string Command = "/addcmd";

    private const CharacterStatus MinimumStatus = CharacterStatus.Normal;

    /// <inheritdoc />
    public override string Key => Command;

    /// <inheritdoc />
    public override CharacterStatus MinCharacterStatusRequirement => MinimumStatus;

    /// <inheritdoc />
    protected override AttributeDefinition TheStat => Stats.BaseLeadership;
}