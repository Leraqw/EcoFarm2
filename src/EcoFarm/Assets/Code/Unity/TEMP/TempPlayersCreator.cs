using EcoFarmDataModule;
using Constants = Code.Utils.StaticClasses.Constants;

// ReSharper disable Unity.PerformanceCriticalCodeInvocation

namespace Code.Unity.TEMP
{
	public static class TempPlayersCreator
	{
		public static void CreateEmpty()
		{
			var players = new Player[] { };

			TempDataCreator.Serialize(players, Constants.PathToPlayers);
		}

		public static void CreateTest()
		{
			var players = new Player[]
			{
				new()
				{
					Nickname = "Tester 123",
					CompletedLevelsCount = 0,
				}
			};

			TempDataCreator.Serialize(players, Constants.PathToPlayers);
		}
	}
}