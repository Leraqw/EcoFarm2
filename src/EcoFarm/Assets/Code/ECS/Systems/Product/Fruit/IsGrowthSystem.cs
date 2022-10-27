using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class IsGrowthSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public IsGrowthSystem(Contexts contexts)
		{
			_entities = contexts.game.GetGroup(GameMatcher.Growing);
		}

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity)
		{
			if (entity.growing.Value.IsContains(entity.GetLocalScale()) == false)
			{
				entity.RemoveGrowing();
			}
		}
	}
}