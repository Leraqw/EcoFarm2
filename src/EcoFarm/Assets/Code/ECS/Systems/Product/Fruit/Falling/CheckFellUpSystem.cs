using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class CheckFellUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckFellUpSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Falling, GameMatcher.View);

		public void Execute() => _entities.ForEach(Check);

		private void Check(GameEntity entity) => entity.Do(RemoveFalling, @if: IsFell);

		private void RemoveFalling(GameEntity entity)
		{
			entity.RemoveFalling();
			entity.isFell = true;
		}

		private bool IsFell(GameEntity entity)
			=> entity.falling.Value.IsContains(entity.GetActualPosition()) == false;
	}
}