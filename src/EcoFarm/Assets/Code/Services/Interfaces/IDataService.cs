using System;

namespace EcoFarm
{
	[Obsolete]
	public interface IDataService : IService
	{
		Storage Storage { get; }
	}
}