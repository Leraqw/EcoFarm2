using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class CheckFellUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;
		private readonly IConfigurationService _configurationService;

		public CheckFellUpSystem(GameContext context, IConfigurationService configurationService)
		{
			_configurationService = configurationService;
			_entities = context.GetGroup(AllOf(TargetPosition, Position));
		}

		private ICommonConfig Constants => _configurationService.Common;

		public void Execute() => _entities.ForEach(Check);

		private void Check(GameEntity entity) => entity.Do(MarkAsFell, @if: IsFell);

		private static void MarkAsFell(GameEntity entity) => entity.OnTargetPositionReached();

		private bool IsFell(GameEntity entity)
			=> Vector2.Distance(entity.position.Value, entity.targetPosition.Value) <= Constants.Tolerance;
	}
}