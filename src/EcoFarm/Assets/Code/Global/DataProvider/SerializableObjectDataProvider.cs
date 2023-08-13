using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
	public class SerializableObjectDataProvider : IDataProviderService
	{
		public IEnumerable<Player> Players => Resources.Load<PlayersList>("StaticData/Players").Players;

		public Storage Storage => Resources.Load<Storage>("StaticData/Storage/Storage");
	}
}