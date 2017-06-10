using MurderSim.Objects;

namespace MurderSim.Commands
{
	public abstract class Cmd : IdentifiableObject
	{
		public Cmd(string[] ids) : base(ids)
		{
		}

		public abstract string Execute(Player chr, string[] text);
	}
}