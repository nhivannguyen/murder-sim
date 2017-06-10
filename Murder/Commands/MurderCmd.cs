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
						return $"I can't find this person you want to {input[1 - 1]}";
					p.Location.PresentChar.Remove(target);
					return $"You have {input[1 - 1]}ed {input[2 - 1]}";
				}
				return "What are you trying to do?";
			}
			return "This command only requires 2 words";
		}
	}
}