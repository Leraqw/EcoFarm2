using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
	public class SerializableObjectDataProvider : IDataProviderService
	{
		public IEnumerable<PlayerSO> Players => Resources.Load<PlayersList>("StaticData/Players").Players;

		public StorageSO Storage => Resources.Load<StorageSO>("StaticData/Storage/Storage");
	}
}