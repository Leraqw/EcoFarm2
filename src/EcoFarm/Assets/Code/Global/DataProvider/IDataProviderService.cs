using System.Collections.Generic;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		IEnumerable<Player> Players { get; }

		Storage Storage { get; }
	}
}