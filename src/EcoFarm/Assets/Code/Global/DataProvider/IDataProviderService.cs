using System.Collections.Generic;
using EcoFarmModel;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		IEnumerable<Player> Players { get; }

		Storage Storage { get; }
	}
}