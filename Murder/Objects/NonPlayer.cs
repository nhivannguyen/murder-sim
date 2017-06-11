using System;

namespace MurderSim.Objects
{
	public class NonPlayer : Character
	{
		private Location _location;

		public NonPlayer(string name, string desc) : base(name, desc)
		{
		}

		public override Location Location
		{
			get => _location;
			set
			{
				//_location.PresentChar.Remove(this);
				_location = value;
				_location.AddChar(this);
			}
		}

		public override Inventory Inventory { get; }

		public string Greet()
		{
			return $"Hi, you are at {Location.Name}, {Location.Description}. Is there anything you want to ask me?";
		}

		public string Talk(Character chr)
		{
			return $"{Name} said: I have nothing to say to you, {chr.Name}\r";
		}
	}
}