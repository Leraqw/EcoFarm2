using System.Collections.Generic;
using System.IO;
using EcoFarmModel;
using Newtonsoft.Json;
using static EcoFarm.JsonUtils;

namespace EcoFarm
{
	public class JsonDataProviderService : IDataProviderService
	{
		public IEnumerable<Player> Players => Deserialize<Player[]>(Constants.PathToPlayers);

		public Storage Storage => Deserialize<Storage>(Constants.PathToStorage);

		private static T Deserialize<T>(string path)
		{
			if (File.Exists(path) == false)
				TempDataCreator.Create();

			var json = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<T>(json, WithReferences);
		}
	}
}