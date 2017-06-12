using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class MoveCmd : Cmd
	{
		public MoveCmd() : base(new[] {"move"})
		{
		}
		
		public override string Execute(Player chr, string[] text)
		{
			string direction = "";
			if (text.Length == 2)
			{
				if (text[1 - 1] == "move")
				{
					if (text[2 - 1] == "forward" || text[2 - 1] == "back" || text[2 - 1] == "left" ||
					    text[2 - 1] == "right" || text[2 - 1] == "up" || text[2 - 1] == "down")
					{
						direction = text[2 - 1];

						return Move(chr, direction);
					}
				}
			}
			else
			{
				return "I don't understand this word.";
			}
			return null;
		}

		private string Move(Player chr, string direction)
		{
			Path path = (Path) chr.Locate(direction);
			if (path == null)
			{
				return $"This location does not have a path that goes {direction}\r";
			}
			if (chr.Location == path.Destination)
			{
				return $"{chr.Name} can't move {direction} as we have arrived the last location of this direction.\r";
			}
			path.Move(chr);

			return $"{chr.Name} moved {direction} and arrived {chr.Location.Name}.\r{chr.Location.UponEnter()}";
		}
	}
}