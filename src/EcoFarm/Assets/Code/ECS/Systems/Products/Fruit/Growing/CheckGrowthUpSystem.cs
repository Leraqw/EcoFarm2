using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class CheckGrowthUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;
		private readonly IConfigurationService _configurationService;

		public CheckGrowthUpSystem(Contexts contexts, IConfigurationService configurationService)
		{
			_configurationService = configurationService;
			_entities = contexts.game.GetGroup(AllOf(ProportionalScale, TargetScale));
		}

		private ICommonConfig Constants => _configurationService.Common;

		public void Execute() => _entities.ForEach(Check);

		private void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity) => entity.OnTargetScaleReached();

		private bool IsGrowth(GameEntity entity)
			=> Mathf.Abs(entity.proportionalScale.Value - entity.targetScale.Value) <= Constants.Tolerance;
	}
}