using MurderSim.Interfaces;

namespace MurderSim.Objects
{
	public abstract class Character : GameObject, IInventory
	{
		protected Character(string name, string desc) : base(new[] {name.ToLower(), "inventory"}, name, desc)
		{
		}
		
		public abstract Inventory Inventory { get; }

		public abstract Location Location { get; set; }

		public GameObject Locate(string id)
		{
			if (Inventory.HasItem(id)) return Inventory.Fetch(id);
			if (AreYou(id)) return Location;
			if (Location.Locate(id) != null) return Location.Locate(id);
			return null;
		}

		public Inventory FindInventory()
		{
			return Inventory;
		}
	}
}