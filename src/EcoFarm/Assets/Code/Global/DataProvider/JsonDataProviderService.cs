using System.Collections.Generic;
using System.IO;
using EcoFarmModel;
using Newtonsoft.Json;
using UnityEngine;
using static EcoFarm.JsonUtils;

namespace EcoFarm
{
	public class JsonDataProviderService : IDataProviderService
	{
		public IEnumerable<Player> Players => Deserialize<Player[]>(Constants.PathToPlayers);

		public StorageSO Storage => Resources.Load<StorageSO>("StaticData/Storage/Storage");

		private static T Deserialize<T>(string path)
		{
			if (File.Exists(path) == false)
				TempDataCreator.Create();

			var json = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<T>(json, WithReferences);
		}
	}
}