using System.IO;
using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;
using static Code.Data.StorageJson.JsonUtils;

namespace Code.Data.StorageJson
{
	public class StorageAccess : IDataService
	{
		private Storage _storage;

		public StorageAccess() => LoadStorage();

		public int TreesCount => _storage.Levels.First().TreesCount;

		public Tree AppleTree => _storage.Trees.First();

		private void LoadStorage() => _storage = JsonConvert.DeserializeObject<Storage>(GetJson(), WithReferences);

		private static string GetJson() => File.ReadAllText(Constants.PathToStorage);
	}
}