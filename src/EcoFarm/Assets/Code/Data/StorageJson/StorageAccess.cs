using System.IO;
using Code.Data.DataBase;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;

namespace Code.Data.StorageJson
{
	public class StorageAccess : IDataAccess
	{
		private Storage _storage;

		public StorageAccess() => LoadStorage();

		public int TreesCount => _storage.Levels[0].TreesCount;

		private void LoadStorage() => _storage = JsonConvert.DeserializeObject<Storage>(GetJson());

		private static string GetJson() => File.ReadAllText(Constants.PathToStorage);
	}
}