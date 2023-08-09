using System.Collections.Generic;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		IEnumerable<PlayerSO> Players { get; }

		StorageSO Storage { get; }
	}
}