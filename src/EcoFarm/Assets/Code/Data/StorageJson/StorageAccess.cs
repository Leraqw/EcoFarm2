using System.IO;
using Code.Services.Interfaces;
using Code.Unity.TEMP;
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

		private static Storage Deserialize()
		{
			var path = Constants.PathToStorage;
			if (File.Exists(path) == false)
			{
				TempDataCreator.Create();
			}

			var json = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<Storage>(json, WithReferences);
		}
	}
}