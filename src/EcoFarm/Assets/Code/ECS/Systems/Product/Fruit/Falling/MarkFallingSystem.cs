using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class MarkFallingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public MarkFallingSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IFruitConfig FruitConfig => _contexts.GetConfiguration().Balance.Fruit;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(WillFall, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isWillFall && entity.hasPosition;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Mark);

		private void Mark(GameEntity entity)
			=> entity.Do((e) => e.AddTargetPosition(OnGroundPosition(entity)))
			         .Do((e) => e.isWillFall = false)
			         .Do((e) => e.AddDuration(FruitConfig.FallTime));

		private Vector2 OnGroundPosition(GameEntity entity)
			=> entity.GetActualPosition() - FruitConfig.SpawnHeight;
	}
}