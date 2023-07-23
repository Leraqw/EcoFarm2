using System.Collections.Generic;


using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code
{
	public sealed class PickedToWarehouseSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PickedToWarehouseSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private Vector2 WarehousePosition => _contexts.services.sceneObjectsService.Value.Warehouse;

		private IBalanceConfig Balance => _contexts.GetConfiguration().Balance;

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