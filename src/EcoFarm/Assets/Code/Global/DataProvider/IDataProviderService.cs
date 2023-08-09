using System.Collections.Generic;
using EcoFarmModel;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		IEnumerable<PlayerSO> Players { get; }

		StorageSO Storage { get; }
	}
}