using System.Collections.Generic;

namespace MurderSim.Objects
{
	public class IdentifiableObject
	{
		private readonly List<string> _identifiers;

		public IdentifiableObject(string[] idents)
		{
			_identifiers = new List<string>();
			_identifiers.AddRange(idents);
		}

		public string FirstId
		{
			get
			{
				if (_identifiers.Count != 0)
					return _identifiers[0];
				return "";
			}
		}

		public bool AreYou(string id)
		{
			return _identifiers.Contains(id.ToLower());
		}

		public void AddIdentifier(string id)
		{
			_identifiers.Add(id.ToLower());
		}
	}
}