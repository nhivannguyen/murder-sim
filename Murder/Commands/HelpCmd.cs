using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class HelpCmd : Cmd
	{
		public HelpCmd() : base(new[] {"help"})
		{
		}

		public override string Execute(Player p, string[] input)
		{
			if (input[1 - 1] == "help")
			{
				if (input.Length == 1)
				{
					return
						"COMMAND LISTS\r" +
						"~> move <path-direction> : move yourself to the destination of the path\r" +
						"~> put <item-id> : find item you have and add them to your inventory\r" +
						"~> put <item-id> to <location-name> : find item you have and leave it the location\r" +
						"~> take <item> : retrieve item from your inventory\r" +
						"~> take <item> from <location> : retrieve item from location and add to your inventory\r" +
						"~> look around : see what your location has\r" +
						"~> look at <object> \r" +
						"~> look at <item> in <location> : get details of the item at that location\r" +
						"~> talk to <someone> : communicate with an NPC\r" +
						"~> murder <someone> : remove them from the world\r";
				}
				if (input.Length == 2)
				{
					switch (input[2 - 1])
					{
						case "put":
							return "PUT COMMAND LISTS\r" +
							       "~> put <item-id> : find item you have and add them to your inventory\r" +
							       "~> put <item-id> to <location-name> : find item you have and leave it the location\r";
						case "move":
							return "MOVE COMMAND LISTS\r" +
							       "~> move <path-direction> : move yourself to the destination of the path\r";
						case "take":
							return "TAKE COMMAND LIST\r" +
							       "~> take <item> : retrieve item from your inventory\r" +
							       "~> take <item> from <location> : retrieve item from location and add to your inventory\r";
						case "look":
							return "LOOK COMMAND LIST\r" +
							       "~> look around : see what your location has\r" +
							       "~> look at <object> \r" +
							       "~> look at <item> in <location> : get details of the item at that location\r";
						case "talk":
							return "TALK COMMAND LIST\r" +
							       "~> talk to <someone> : communicate with an NPC\r";
						case "murder":
							return "MURDER COMMAND LIST\r" +
							       "~> murder <someone> : remove them from the world\r";
					}
				}
			}

			return "I don't understand this HELP command.\r";
		}
	}
}