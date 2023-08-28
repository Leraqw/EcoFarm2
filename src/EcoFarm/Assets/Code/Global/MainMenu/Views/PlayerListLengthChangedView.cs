using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public sealed class PlayerListLengthChangedView : MonoBehaviour, IPlayerListLengthListener
	{
		private PlayerContext _context;
		private IDataProviderService _dataProvider;
		private PlayerEntity _entity;

		[Inject]
		public void Construct(PlayerContext context, IDataProviderService dataProvider)
		{
			_dataProvider = dataProvider;
			_context = context;
			_entity = context.playerListLengthEntity;
		}

		private PlayerEntity CurrentPlayer => _context.currentPlayerEntity;

		private IEnumerable<Player> Players => _dataProvider.PlayersList.Players;

		public void Start()
		{
			_entity.AddPlayerListLengthListener(this);

			if (_entity.hasPlayerListLength)
				OnPlayerListLength(_entity, _entity.playerListLength.Value);
		}

		public void OnPlayerListLength(PlayerEntity entity, int value)
		{
			if (value > 0)
			{
				CurrentPlayer.ReplaceNickname(Players.First().Nickname);
				CurrentPlayer.ReplaceCompletedLevelsCount(Players.First().CompletedLevelsCount);
			}
		}
	}
}