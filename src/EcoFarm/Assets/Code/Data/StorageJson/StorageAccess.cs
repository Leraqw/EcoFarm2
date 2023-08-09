using UnityEngine;

namespace EcoFarm
{
	public class StorageAccess : IDataService
	{
		public StorageSO Storage => Resources.Load<StorageSO>("StaticData/Storage/Storage");
	}
}