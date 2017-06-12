using System;
using System.Collections.Generic;
using System.Xml;

namespace MurderSim.Objects
{
	public class Player : Character
	{
		private Location _location;
		private List<NonPlayer> _targets = new List<NonPlayer>();

		public Player(string name, string desc) : base(name, desc)
		{
			Inventory = new Inventory();
			AddIdentifier("me");
		}

		public override Inventory Inventory { get; }

		public override Location Location
		{
			get => _location;
			set
			{
				_location = value;
				_location.UponEnter();
			}
		}

		public void ManageTarget(NonPlayer target)
		{
			_targets.Add(target);
		}

		public string TargetList()
		{
			string list = "";
			foreach (NonPlayer t in _targets)
			{
				if (!t.AreYou("dead"))
				{
					list += $"> {t.Name}, {t.FullDescription}";
				}
			}
			return list;
		}
	}
}