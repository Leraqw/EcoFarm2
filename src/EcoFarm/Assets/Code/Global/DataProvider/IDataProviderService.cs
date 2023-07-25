using System.Collections.Generic;
using EcoFarmModel;

namespace Code
{
	public interface IDataProviderService
	{
		IEnumerable<Player> Players { get; }
	}
}