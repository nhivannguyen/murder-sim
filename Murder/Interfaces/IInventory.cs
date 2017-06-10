using MurderSim.Objects;

namespace MurderSim.Interfaces
{
	public interface IInventory
	{
		string Name { get; }
		GameObject Locate(string id);
		Inventory FindInventory();
	}
}