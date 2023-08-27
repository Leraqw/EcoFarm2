using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class MarkFallingSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public MarkFallingSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
			=> _configurationService = configurationService;

		private IFruitConfig FruitConfig => _configurationService.Balance.Fruit;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(WillFall, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isWillFall && entity.hasPosition;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Mark);

		private void Mark(GameEntity entity)
			=> entity.Do((e) => e.AddTargetPosition(OnGroundPosition(entity)))
			         .Do((e) => e.isWillFall = false)
			         .Do((e) => e.AddDuration(FruitConfig.FallTime));

		private Vector2 OnGroundPosition(GameEntity entity)
			=> entity.GetActualPosition() - FruitConfig.SpawnOffset;
	}
}