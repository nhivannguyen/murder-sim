using MurderSim.Interfaces;
using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class PutCmd : Cmd
	{
		public PutCmd() : base(new[] {"put"})
		{
		}

		public override string Execute(Player chr, string[] input)
		{
			string itemId = null;
			Item item = null;
			string where = "your inventory";
			IInventory container = chr;

			if (input[1 - 1] != "put")
			{
				return "I don't recognise this command\r";
			}
			if (input[2 - 1] != null)
			{
				itemId = input[2 - 1];
			}
			if (input.Length == 4)
			{
				if (input[3 - 1] != "to")
				{
					return $"Where do you put {input[2 - 1]} to?\r";
				}
				container = input[4 - 1] == "inventory" ? chr : FetchContainer(chr, input[4 - 1]);
				item = chr.FindInventory().Take(itemId);
				if (item == null)
				{
					return $"Sorry, I can't find {itemId}\r";
				}
				where = input[4 - 1];
			}
			container.FindInventory().Put(item);
			return $"You have put {itemId} to {where}\r";
		}

		private IInventory FetchContainer(Player chr, string id)
		{
			return chr.Locate(id) as IInventory;
		}
	}
}