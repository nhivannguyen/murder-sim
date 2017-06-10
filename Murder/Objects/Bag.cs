using MurderSim.Interfaces;

namespace MurderSim.Objects
{
	public class Bag : Item, IInventory
	{
		public Bag(string[] ids, string name, string desc) : base(ids, name, desc) => Inventory = new Inventory();

		public override string FullDescription =>
			$"In the {Name} you can see: {Inventory.ItemList}";

		public Inventory Inventory { get; }

		public GameObject Locate(string id)
		{
			if (AreYou(id)) return this;
			if (Inventory.HasItem(id)) return Inventory.Fetch(id);
			return null;
		}

		public Inventory FindInventory()
		{
			return Inventory;
		}
	}
}