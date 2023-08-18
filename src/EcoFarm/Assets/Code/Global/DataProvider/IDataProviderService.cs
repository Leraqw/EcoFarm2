using System.Collections.Generic;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		IEnumerable<Player> Players { get; }
		PlayerView PlayerView { get; }

		Storage Storage { get; }
	}
}