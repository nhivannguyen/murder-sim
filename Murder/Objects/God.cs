using System.Collections.Generic;
using System.Linq;
using System.Xml;
using MurderSim.Commands;

namespace MurderSim.Objects
{
	public class God
	{
		private List<Item> _items = new List<Item>();
		private readonly List<Location> _locations = new List<Location>();
		private Player _p;

		private List<Path> _paths = new List<Path>();

		//this is the factory class : makes item
		private readonly XmlDocument _theBible;

		public God()
		{
			_theBible = new XmlDocument();
			_theBible.Load("D:/OOP/oh-oh-pee/Murder/Murder/Xml/World.xml"); //TODO: change the path

			CreatesLocationsFromXml();
			CreatesPlayerFromXml();
			CreatesItemsFromXml();
			CreatesNpcFromXml();
			CreatesPathsFromXml();
		}

		public string FulfillRequestTo(string request, Player ofP)
		{
			CmdController manager = new CmdController(request);
			return manager.ExeCmd(ofP);
		}

		public Player CreatesPlayer()
		{
			return _p;
		}

		private void CreatesPlayerFromXml()
		{
			XmlNode playerNode = _theBible.SelectSingleNode("//player");
			_p = new Player(playerNode.Attributes["name"].Value, playerNode.Attributes["desc"].Value);
			_p.Location = _locations.Find(
				theLoc => theLoc.AreYou(playerNode.ParentNode.Attributes["id"].Value.Split('-').First())
			);
		}

		private void CreatesLocationsFromXml()
		{
			XmlNodeList locationNodeList = _theBible.GetElementsByTagName("location");
			foreach (XmlNode locationNode in locationNodeList)
				_locations.Add(new Location
				(
					locationNode.Attributes["id"].Value.Split('-'),
					locationNode.Attributes["name"].Value,
					locationNode.Attributes["desc"].Value
				));
		}

		private void CreatesItemsFromXml()
		{
			XmlNodeList itemNodeList = _theBible.GetElementsByTagName("item");

			foreach (XmlNode itemNode in itemNodeList)
			{
				XmlNode itemLocNode = itemNode.ParentNode.ParentNode;
				if (itemLocNode.Name == "player")
				{
					_p.Inventory.Put(new Item
					(
						itemNode.Attributes["id"].Value.Split('-'),
						itemNode.Attributes["name"].Value,
						itemNode.Attributes["desc"].Value
					));
				}
				else
				{
					string itemLocFirstId = itemLocNode.Attributes["id"].Value.Split('-').First();
					foreach (Location aLoc in _locations)
						if (aLoc.FirstId == itemLocFirstId)
							aLoc.FindInventory().Put(new Item
							(
								itemNode.Attributes["id"].Value.Split('-'),
								itemNode.Attributes["name"].Value,
								itemNode.Attributes["desc"].Value
							));
				}
			}
		}

		private void CreatesNpcFromXml()
		{
			XmlNodeList npcNodeList = _theBible.GetElementsByTagName("npc");
			foreach (XmlNode npcNode in npcNodeList)
			{
				foreach (Location aLoc in _locations)
				{
					if (aLoc.FirstId == npcNode.ParentNode.Attributes["id"].Value.Split('-').First())
					{
						new NonPlayer(npcNode.Attributes["name"].Value, npcNode.Attributes["desc"].Value) {Location = aLoc};
					}
				}
			}
		}

		private void CreatesPathsFromXml()
		{
			XmlNodeList pathNodeList = _theBible.GetElementsByTagName("path");
			Location hasPath;
			foreach (XmlNode pathNode in pathNodeList)
			{
				foreach (Location aLoc in _locations)
				{
					hasPath = _locations.Find(l => l.AreYou(pathNode.ParentNode.Attributes["id"].Value.Split('-').First()));
					if (aLoc.AreYou(pathNode.SelectSingleNode("destination").InnerText) && aLoc != hasPath)
					{
						hasPath.AddPath(new Path
						(
							pathNode.Attributes["direction"].Value.Split('-'),
							pathNode.Attributes["name"].Value,
							pathNode.Attributes["desc"].Value,
							aLoc
						));
					}
				}
			}
		}
	}
}