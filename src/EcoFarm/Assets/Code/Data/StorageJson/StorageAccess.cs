using System.IO;
using EcoFarmModel;
using Newtonsoft.Json;
using static EcoFarm.JsonUtils;

namespace EcoFarm
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