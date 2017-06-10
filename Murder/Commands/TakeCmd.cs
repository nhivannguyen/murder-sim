using MurderSim.Interfaces;
using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class TakeCmd : Cmd
	{
		public TakeCmd() : base(new[] {"take"})
		{
		}

		public override string Execute(Player chr, string[] input)
		{
			string itemId;
			string where;
			IInventory container;
			if (input[1 - 1] != "take")
				return "I don't recognise this command";
			if (input[2 - 1] != null)
			{
				itemId = input[2 - 1];
				where = "inventory";
				container = chr;
			}
			else
			{
				return "What are you trying to take?";
			}
			if (input.Length == 4)
			{
				if (input[3 - 1] != "from")
					return $"Where do you take {input[2 - 1]} from?";
				container = input[4 - 1] == "inventory" ? chr : FetchContainer(chr, input[4 - 1]);
				// if the item is in the inventory then the container of the item is the character
				// if the iteam is in character location then the container of the item needs to be located
				where = input[4 - 1];
			}
			Item item = container.FindInventory().Take(itemId); // take item from the container
			if (item == null)
				return $"Sorry, I can't find {itemId}"; // in case such item does not exist
			chr.FindInventory().Put(item); // add item to inventory
			return $"You have taken {itemId} from {where}";
		}

		public IInventory FetchContainer(Player chr, string id)
		{
			return chr.Locate(id) as IInventory;
		}
	}
}