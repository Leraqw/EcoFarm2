using System;
using System.Collections.Generic;
using EcoFarmModel;
using UnityEngine;

namespace EcoFarm
{
	public class SerializableObjectDataProvider : IDataProviderService
	{
		public IEnumerable<Player> Players => throw new NotImplementedException("implement Players list SO");

		public StorageSO Storage => Resources.Load<StorageSO>("StaticData/Storage/Storage");
	}
}