using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Warehouse
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
			=> entity.Do((e) => e.isCollected = true)
			         .Do((e) => e.AddTargetPosition(WarehousePosition))
			         .Do((e) => e.AddDuration(Balance.Warehouse.PickupDuration))
			         .Do((e) => e.isInFactory = false, @if: (e) => e.isInFactory)
		/**/ ;
	}
}