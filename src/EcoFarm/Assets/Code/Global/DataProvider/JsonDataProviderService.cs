using System.Collections.Generic;
using System.IO;
using EcoFarmModel;
using Newtonsoft.Json;

namespace Code
{
	public class JsonDataProviderService : IDataProviderService
	{
		public IEnumerable<Player> Players
		{
			get
			{
				var path = Constants.PathToPlayers;
				if (File.Exists(path) == false)
				{
					TempPlayersCreator.CreateEmpty();
				}

				var json = File.ReadAllText(path);
				return JsonConvert.DeserializeObject<Player[]>(json, JsonUtils.WithReferences);
			}
		}
	}
}