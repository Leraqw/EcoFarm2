using System.IO;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;

namespace Code.Data.StorageJson
{
	public class StorageAccess
	{
		private Storage _storage;

		public StorageAccess()
		{
			LoadStorage();
		}

		private void LoadStorage()
		{
			_storage = JsonConvert.DeserializeObject<Storage>(File.ReadAllText(Constants.PathToStorage));
		}

		public int TreesCount => _storage.Levels[0].TreesCount;
	}
}