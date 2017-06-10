namespace MurderSim.Objects
{
	// anything the player can interact with
	public abstract class GameObject : IdentifiableObject
	{
		protected GameObject(string[] ids, string name, string desc) : base(ids)
		{
			Name = name;
			FullDescription = desc;
		}

		public string Name { get; }

		public string ShortDescription => $"a {Name} ({FirstId})";

		public virtual string FullDescription { get; }
	}
}