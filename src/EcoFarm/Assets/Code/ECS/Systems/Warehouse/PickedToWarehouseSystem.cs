using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PickedToWarehouseSystem : ReactiveSystem<GameEntity>
	{
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly IConfigurationService _configurationService;

		public PickedToWarehouseSystem
		(
			Contexts contexts,
			ISpawnPointsService spawnPointsService,
			IConfigurationService configurationService
		)
			: base(contexts.game)
		{
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
		}

		private Vector2 WarehousePosition => _spawnPointsService.Warehouse;

		private IBalanceConfig Balance => _configurationService.Balance;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Picked, Position));

		protected override bool Filter(GameEntity entity) => entity.isCollected == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(StartMoving);

		private void StartMoving(GameEntity entity)
		{
			entity.isCollected = true;
			entity.AddTargetPosition(WarehousePosition);
			entity.AddDuration(Balance.Warehouse.PickupDuration);
			entity.isInFactory = false;
		}
	}
}