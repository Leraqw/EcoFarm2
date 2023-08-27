using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ButtonPlayerToChooseReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private PlayerView _playerView;

		private IDataProviderService _dataProvider;
		private Contexts _contexts;

		[Inject]
		public void Construct(IDataProviderService dataProvider, Contexts contexts)
		{
			_contexts = contexts;
			_dataProvider = dataProvider;
		}

		private PlayerEntity PlayerEntity => _contexts.player.currentPlayerEntity;

		private GameEntity Window => _contexts.game.GetEntities(GameMatcher.PlayerChoiceWindow).First();

		private List<Player> PlayerList => _dataProvider.PlayersList.Players;

		protected override void OnButtonClick()
		{
			var player = _playerView.Player;

			PlayerEntity.ReplaceNickname(player.Nickname);
			PlayerEntity.ReplaceCompletedLevelsCount(player.CompletedLevelsCount);
			MovePlayerToTop(PlayerList, player);

			Window.isToggled = true;
		}

		private void MovePlayerToTop(IList<Player> playerList, Player player)
		{
			var index = FindPlayerIndex(player);
			if (index != -1)
			{
				playerList.RemoveAt(index);
				playerList.Insert(0, player);
			}
		}

		private int FindPlayerIndex(Player player)
			=> _dataProvider.PlayersList.Players.FindIndex(p => p.Equals(player));
	}
}