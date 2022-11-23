using EcoFarmDataModule;
using static System.IO.Path;
using static Code.Unity.TEMP.TempDataCreator;
using static UnityEngine.Application;
using Constants = Code.Utils.StaticClasses.Constants;

// ReSharper disable Unity.PerformanceCriticalCodeInvocation

namespace Code.Unity.TEMP
{
	public static class TempPlayersCreator
	{
		public static Player[] Players;

		public static void CreateEmpty()
		{
			Players = new Player[]
			{
				new()
				{
					Nickname = "NewPlayer",
					CompletedLevelsCount = 0,
				}
			};

			Serialize(Players, Constants.PathToPlayers);
		}

		public static void CreateTest()
		{
			Players = new Player[]
			{
				new()
				{
					Nickname = "Tester 123",
					CompletedLevelsCount = 1,
				}
			};

			Serialize(Players, Constants.PathToPlayers);
		}
	}
}