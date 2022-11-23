using System.Collections.Generic;
using System.Linq;
using EcoFarmDataModule;
using static Code.Unity.TEMP.TempDataCreator;
using Constants = Code.Utils.StaticClasses.Constants;

// ReSharper disable Unity.PerformanceCriticalCodeInvocation

namespace Code.Unity.TEMP
{
	public static class TempPlayersCreator
	{
		public static Dictionary<string, Player> Players { get; private set; }

		public static void Save() => Save(Players);

		private static void Save(Dictionary<string,Player> value)
		{
			_array = value.Select((p) => p.Value).ToArray();

			Serialize(_array, Constants.PathToPlayers);
		}

		private static Player[] _array;

		public static void CreateEmpty()
		{
			_array = new Player[]
			{
				new()
				{
					Nickname = "NewPlayer",
					CompletedLevelsCount = 0,
				},
			};

			RefillDictionary();

			Serialize(_array, Constants.PathToPlayers);
		}

		public static void CreateTest()
		{
			_array = new Player[]
			{
				new()
				{
					Nickname = "Tester 123",
					CompletedLevelsCount = 1,
				},
			};

			RefillDictionary();

			Serialize(_array, Constants.PathToPlayers);
		}

		private static void RefillDictionary()
		{
			Players = new Dictionary<string, Player>();
			foreach (var player in _array)
			{
				Players.Add(player.Nickname, player);
			}
		}
	}
}