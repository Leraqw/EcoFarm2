using System.Collections.Generic;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		PlayersList PlayersList { get; }
		PlayerView PlayerView { get; }

		Storage Storage { get; }
	}
}