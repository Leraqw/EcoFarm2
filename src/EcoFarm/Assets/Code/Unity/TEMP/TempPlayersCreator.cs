using System.IO;
using EcoFarmDataModule;
using static UnityEngine.Application;

namespace Code.Unity.TEMP
{
	public static class TempPlayersCreator
	{
		public static void Create()
		{
			var players = new Player[]
			{
				new()
				{
					Nickname = "Tester 123",
					CompletedLevelsCount = 0,
				}
			};

			var completePath = Path.Combine(persistentDataPath, $"{nameof(players)}.json");
			TempDataCreator.Serialize(players, completePath);
		}
	}
}