using System.IO;
using System.Linq;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;
using static Newtonsoft.Json.PreserveReferencesHandling;

namespace Code.Data.StorageJson
{
	public class StorageAccess : IDataAccess
	{
		private Storage _storage;

		public StorageAccess() => LoadStorage();

		private static JsonSerializerSettings WithReferences => new() { PreserveReferencesHandling = Objects };

		public int TreesCount => _storage.Levels.First().TreesCount;

		public Tree AppleTree => _storage.Trees.First();

		private void LoadStorage() => _storage = JsonConvert.DeserializeObject<Storage>(GetJson(), WithReferences);

		private static string GetJson() => File.ReadAllText(Constants.PathToStorage);
	}
}