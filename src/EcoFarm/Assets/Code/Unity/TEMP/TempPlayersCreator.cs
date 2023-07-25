using System.Collections.Generic;
using System.Linq;
using EcoFarmModel;

// ReSharper disable Unity.PerformanceCriticalCodeInvocation

namespace Code
{
	public static class TempPlayersCreator
	{
		public static Dictionary<string, Player> Players { get; private set; }

		public static void Save() => Save(Players);

		private static void Save(Dictionary<string,Player> value)
		{
			_array = value.Select((p) => p.Value).ToArray();

			TempDataCreator.Serialize(_array, Constants.PathToPlayers);
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

			TempDataCreator.Serialize(_array, Constants.PathToPlayers);
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

			TempDataCreator.Serialize(_array, Constants.PathToPlayers);
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