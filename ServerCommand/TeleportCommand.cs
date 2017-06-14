﻿using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace ServerSideCharacter.ServerCommand
{
	public class TeleportCommand : ModCommand
	{
		public override string Command
		{
			get { return "tp"; }
		}

		public override CommandType Type
		{
			get { return CommandType.Chat; }
		}

		public override string Description
		{
			get { return "Teleport to a player"; }
		}

		public override string Usage
		{
			get { return "/tp <player id|player name>"; }
		}

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			int who;
			if (!int.TryParse(args[0], out who))
			{
				Player player = Utils.TryGetPlayer(args[0]);
				if (player == null || !player.active)
				{
					Main.NewText("Player not found", Color.Red);
					return;
				}
				who = player.whoAmI;
			}
			MessageSender.SendTeleportCommand(Main.myPlayer, who);
		}
	}
}
