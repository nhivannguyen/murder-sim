using System;
using System.Xml;

namespace MurderSim.Objects
{
	public class Player : Character
	{
		private Location _location;

		public Player(string name, string desc) : base(name, desc)
		{
			Inventory = new Inventory();
			AddIdentifier("me");
		}

		public override Inventory Inventory { get; }

		//public new string FullDescription => $"You are {Name}, {FullDescription}.";

		public override Location Location
		{
			get => _location;
			set
			{
				_location = value;
				_location.UponEnter();
			}
		}

		public Player CreatePlayerFromXmlString(string XmlData)
		{
			XmlDocument playerXml = new XmlDocument();
			playerXml.LoadXml(XmlData);

			throw new NotImplementedException();
		}
	}
}