using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class TalkCmd : Cmd
	{
		public TalkCmd() : base(new[] {"talk"})
		{
		}

		public override string Execute(Player chr, string[] text)
		{
			if (text[1 - 1] == "talk")
			{
				if (text[2 - 1] != "to")
					return "Who do you want to talk to?";

				NonPlayer target = chr.Location.FindChar(text[3 - 1]);

				if (target == null)
					return "This person is not in this room.";

				return target.Talk(chr);
			}
			return "I don't understand this word";
		}
	}
}