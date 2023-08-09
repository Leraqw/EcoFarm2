using System;
using System.Collections.Generic;
using EcoFarmModel;

namespace EcoFarm
{
	public class JsonDataProviderService : IDataProviderService
	{
		public IEnumerable<Player> Players => Deserialize<Player[]>();

		public StorageSO Storage => Deserialize<StorageSO>();

		private static T Deserialize<T>() => throw new NotImplementedException();
	}
}