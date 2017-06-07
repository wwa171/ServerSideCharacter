﻿using System;
using Terraria.ModLoader;

namespace ServerSideCharacter.ServerCommand
{
	public class ItemCommand : ModCommand
	{
		public override string Command
		{
			get { return "i"; }
		}

		public override CommandType Type
		{
			get { return CommandType.Chat; }
		}

		public override string Description
		{
			get { return "Get item from the server"; }
		}

		public override string Usage
		{
			get { return "/i <item type>"; }
		}

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			MessageSender.SendItemCommand(Convert.ToInt32(args[0]));
		}
	}
}
