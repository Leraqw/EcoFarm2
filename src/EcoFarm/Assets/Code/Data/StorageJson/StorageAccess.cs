using UnityEngine;

namespace EcoFarm
{
	public class StorageAccess : IDataService
	{
		public Storage Storage => Resources.Load<Storage>("StaticData/Storage/Storage");
	}
}