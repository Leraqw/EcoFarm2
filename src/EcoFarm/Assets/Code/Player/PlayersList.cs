using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEditor;
using UnityEngine;
using Zenject;
using static EcoFarm.PlayerExtensions;
using static PlayerMatcher;

namespace EcoFarm
{
	[Serializable]
	[CreateAssetMenu(fileName = "Players", menuName = Constants.RootNamespace + "Players")]
	public class PlayersList : ScriptableObject
	{
		private IDataProviderService _dataProvider;

		[field: SerializeField] public List<Player> Players { get; set; }

		[Inject]
		public void Construct(IDataProviderService dataProvider)
			=> _dataProvider = dataProvider;

		public void SaveChanges()
		{
			EditorUtility.SetDirty(this);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}

		private static PlayerContext Context => Contexts.sharedInstance.player;

		private static PlayerEntity PlayerListEntity => Context.GetEntities(PlayerListLength).First();

		public void AddPlayer(string nickname)
		{
			var players = Players;

			if (IsNicknameInPlayerList(nickname) == false)
			{
				Debug.LogWarning($"player with {nickname} nickname already exists");
				return;
			}

			players.Add(new Player(nickname, 0));
			SaveChanges();

			PlayerListEntity.ReplacePlayerListLength(players.Count);
		}

		private bool IsNicknameInPlayerList(string nickname)
		{
			var players = Players;
			var index = players.FindIndex(p => p.Nickname.Equals(nickname));
			return index == -1;
		}

		public int FindPlayerIndex(Player player)
			=> _dataProvider.PlayersList.Players.IndexOf(player);

		public void RemovePlayer(Player player)
		{
			var players = Players;

			var index = FindPlayerIndex(player);
			if (index != -1) players.Remove(players[index]);

			SaveChanges();

			PlayerListEntity.ReplacePlayerListLength(players.Count);
		}
	}
}