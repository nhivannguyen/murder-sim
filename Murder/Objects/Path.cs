namespace MurderSim.Objects
{
	public class Path : GameObject
	{
		public Path(string[] ids, string name, string desc, Location dest) : base(ids, name, desc)
		{
			dest.AddPath(this);
			Destination = dest;
		}

		public Location Destination { get; set; }

		public void Move(Character character)
		{
			if (character.Location != Destination)
				character.Location = Destination;
		}
	}
}