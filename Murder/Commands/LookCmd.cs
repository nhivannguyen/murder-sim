using MurderSim.Interfaces;
using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class LookCmd : Cmd
	{
		public LookCmd() : base(new[] {"look"})
		{
		}

		/// <summary>
		///     Read through the command and execute the command
		///     <para>Must be 3 to 5 words in sentence</para>
		///     <para>1st word must be LOOK else return Error</para>
		///     <para>2nd word must be AT else ask What</para>
		///     <para>if 3 words then CONTAINER is PLAYER</para>
		///     <para>4th must be IN else ask What in</para>
		///     <para>if 5 words then 5TH WORD is CONTAINER ID</para>
		/// </summary>
		/// <param name="p"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public override string Execute(Player chr, string[] text)
		{
			IInventory container = null;
			string thingId = "";
			if (text.Length == 2 || text.Length == 3 || text.Length == 5)
			{
				if (text.Length == 3)
				{
					thingId = text[3 - 1];
				}
				if (text[1 - 1].ToLower() != "look")
				{
					return "Error in look input.";
				}
				if (text[2 - 1] == "around")
				{
					return chr.Location.FullDescription;
				}
				if (text[2 - 1].ToLower() != "at")
				{
					return "What are you looking at?";
				}
				if (text.Length == 3)
				{
					container = chr;
				}
				if (text.Length == 5 && text[5 - 1] != null)
				{
					if (text[5 - 1] == "inventory")
					{
						container = chr;
					}
					else
					{
						container = FetchContainer(chr, text[5 - 1]);
					}
					if (container == null)
					{
						return $"I cannot find {text[5 - 1]}.";
					}
					if (text[4 - 1].ToLower() != "in")
					{
						return "What do you want to look in?";
					}
				}
				return LookAtIn(thingId, container);
			}
			return "I don't know how to look like that :<";
		}

		/// <summary>
		///     Locate the container where item resides
		/// </summary>
		/// <param name="p"></param>
		/// <param name="containerId">obj id</param>
		/// <returns>location of the obj</returns>
		private IInventory FetchContainer(Player chr, string containerId)
		{
			return chr.Locate(containerId) as IInventory;
		}

		/// <summary>
		///     Locate the item in the container
		/// </summary>
		/// <param name="thingId"></param>
		/// <param name="container"></param>
		/// <returns></returns>
		private string LookAtIn(string thingId, IInventory container)
		{
			GameObject thing = container.Locate(thingId);
			if (thing == null)
			{
				return $"I cannot find {thingId}.";
			}
			return thing.FullDescription;
		}
	}
}