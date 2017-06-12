using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class MurderCmd : Cmd
	{
		public MurderCmd() : base(new[] {"murder", "execute", "fuck"})
		{
		}

		public override string Execute(Player p, string[] input)
		{
			if (input.Length == 2)
			{
				if (input[1 - 1] == "murder" || input[1 - 1] == "execute")
				{
					NonPlayer target = p.Location.FindChar(input[2 - 1]);
					if (target == null)
					{
						return $"I can't find this person you want to {input[1 - 1]}\r";
					}
					if (target.AreYou("target"))
					{
						target.AddIdentifier("dead");
						p.Location.PresentChar.Remove(target);
						return $"You have {input[1 - 1]}ed {input[2 - 1]}\r";
					}
					else
					{
						return $"You can't {input[1 - 1]} {input[2 - 1]}!\r" +
						       $"{input[2 - 1]} is not your target!\r";
					}
				}
				return "What are you trying to do?\r";
			}
			return "This command only requires 2 words\r";
		}
	}
}