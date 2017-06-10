using System.Collections.Generic;
using MurderSim.Interfaces;

namespace MurderSim.Objects
{
	public class Location : GameObject, IInventory
	{
		private readonly List<Path> _paths;

		public Location(string[] ids, string name, string desc) : base(ids, name, desc)
		{
			Inventory = new Inventory();
			_paths = new List<Path>();
			PresentChar = new HashSet<NonPlayer>();
			Description = desc;
		}

		public string Description { get; }

		public override string FullDescription =>
			$"You are at {Name}, {base.FullDescription}. \nThere are:\n {Inventory.ItemList}{PathDesc()}";

		public Inventory Inventory { get; }

		public HashSet<NonPlayer> PresentChar { get; }

		public GameObject Locate(string id)
		{
			if (AreYou(id)) return this;
			if (Inventory.HasItem(id)) return Inventory.Fetch(id);
			if (GetPath(id) != null) return GetPath(id);
			return null;
		}

		public Inventory FindInventory()
		{
			return Inventory;
		}

		/// <summary>
		///     Return the choosen path
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public Path GetPath(string pathId)
		{
			foreach (Path route in _paths)
				if (route.AreYou(pathId))
					return route;
			return null;
		}

		public void AddPath(Path newPath)
		{
			_paths.Add(newPath);
		}

		public string PathDesc()
		{
			string result = "";
			foreach (Path path in _paths)
				result += $"a path {path.Name}, {path.FullDescription}\n";
			return result;
		}

		public void AddChar(NonPlayer chr)
		{
			PresentChar.Add(chr);
		}

		public NonPlayer FindChar(string id)
		{
			foreach (NonPlayer character in PresentChar)
				if (character.Name == id)
					return character;
			return null;
		}

		public string UponEnter()
		{
			string greet = "";
			foreach (NonPlayer npc in PresentChar)
				greet += $"{npc.Name} said: {npc.Greet()}\n\r";
			return greet;
		}
	}
}