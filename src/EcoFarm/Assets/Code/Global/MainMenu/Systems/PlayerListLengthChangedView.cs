using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public sealed class PlayerListLengthChangedView : MonoBehaviour, IPlayerListLengthListener
	{
		[SerializeField] private GameObject _greeting;

		private PlayerContext _context;
		private IDataProviderService _dataProvider;

		[Inject]
		public void Construct(PlayerContext context, IDataProviderService dataProvider)
		{
			_dataProvider = dataProvider;
			_context = context;
		}

		private PlayerEntity CurrentPlayer => _context.currentPlayerEntity;

		private IEnumerable<Player> Players => _dataProvider.PlayersList.Players;

		public void Register(PlayerEntity entity)
		{
			entity.AddPlayerListLengthListener(this);

			if (entity.hasPlayerListLength)
				OnPlayerListLength(entity, entity.playerListLength.Value);
		}

		public void OnPlayerListLength(PlayerEntity entity, int value)
		{
			var hasPlayers = value > 0;
			_greeting.SetActive(hasPlayers);

			if (hasPlayers)
			{
				CurrentPlayer.ReplaceNickname(Players.First().Nickname);
				CurrentPlayer.ReplaceCompletedLevelsCount(Players.First().CompletedLevelsCount);
			}
		}
	}
}