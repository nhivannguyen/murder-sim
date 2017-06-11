using System.Collections.Generic;

namespace MurderSim.Objects
{
	public class Inventory
	{
		private readonly List<Item> _items;

		public Inventory() => _items = new List<Item>();

		public string ItemList
		{
			get
			{
				string ListItem = "";
				foreach (Item item in _items)
					ListItem += "- " + item.ShortDescription + "\n ";
				return ListItem;
			}
		}

		public bool HasItem(string id)
		{
			foreach (Item item in _items)
				return item.AreYou(id);
			return false;
		}

		/// <summary>
		///     Add Item to Inventory
		/// </summary>
		/// <param name="item"></param>
		public void Put(Item item)
		{
			_items.Add(item);
		}

		//remove item
		public Item Take(string id)
		{
			foreach (Item item in _items)
				if (item.AreYou(id))
				{
					_items.Remove(item);
					return item;
				}
			return null;
		}

		// locates an item by id with AreYou
		public Item Fetch(string id)
		{
			foreach (Item item in _items)
				if (item.AreYou(id))
					return item;
			return null;
		}
	}
}