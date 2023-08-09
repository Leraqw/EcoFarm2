using System;

namespace EcoFarm
{
	[Obsolete]
	public interface IDataService : IService
	{
		StorageSO Storage { get; }
	}
}