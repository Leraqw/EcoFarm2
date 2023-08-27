using System.Collections.Generic;
using Entitas;
using Zenject;
using static PlayerMatcher;


namespace EcoFarm
{
	public class PlayerListChangedSystem : IInitializeSystem, IExecuteSystem
	{
		private readonly IDataProviderService _dataProvider;
		private readonly IGroup<PlayerEntity> _entities;
		private readonly PlayerEntity.Factory _playerEntityFactory;

		[Inject]
		public PlayerListChangedSystem
		(
			Contexts contexts,
			IDataProviderService dataProvider,
			PlayerEntity.Factory playerEntityFactory
		)
		{
			_playerEntityFactory = playerEntityFactory;
			_dataProvider = dataProvider;
			_entities = contexts.player.GetGroup(PlayerListLength);
		}

		private List<Player> Players => _dataProvider.PlayersList.Players;

		public void Initialize() => _playerEntityFactory.Create().AddPlayerListLength(Players.Count);

		public void Execute()
		{
			foreach (var e in _entities)
			{
				e.ReplacePlayerListLength(Players.Count);
			}
		}
	}
}