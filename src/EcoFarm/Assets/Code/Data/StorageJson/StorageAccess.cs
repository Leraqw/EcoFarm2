using System.IO;
using Code.Services.Interfaces;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;
using static Code.Data.StorageJson.JsonUtils;

namespace Code.Data.StorageJson
{
	public class StorageAccess : IDataService
	{
		public StorageAccess() => Storage = Deserialize();

		public Storage Storage { get; }

		private static Storage Deserialize() => JsonConvert.DeserializeObject<Storage>(GetJson(), WithReferences);

		private static string GetJson() => File.ReadAllText(Constants.PathToStorage);
	}
}