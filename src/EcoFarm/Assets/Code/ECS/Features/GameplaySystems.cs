using Code.ECS.Systems.Common;
using Code.ECS.Systems.Product.Fruit;
using Code.ECS.Systems.Product.Fruit.Cooldown;
using Code.ECS.Systems.Product.Fruit.Falling;
using Code.ECS.Systems.Product.Fruit.Growing;

namespace Code.ECS.Features
{
	public sealed class GameplaySystems : Feature
	{
		public GameplaySystems(Contexts contexts)
			: base(nameof(GameplaySystems))
		{
			Add(new InitializationSystems(contexts));

			Add(new CollectingSystems(contexts));

			Add(new ViewSystems(contexts));

			Add(new WaitBeforeGrowingSystem(contexts));
			Add(new GrowingSystem(contexts));
			Add(new WaitAfterGrowingSystem(contexts));
			Add(new CheckGrowthUpSystem(contexts));

			Add(new MarkFallingSystem(contexts));
			Add(new FallingSystem(contexts));
			Add(new CheckFellUpSystem(contexts));
			Add(new DetachFromTreeSystem(contexts));
			Add(new MarkFellFruitAsPickableSystem(contexts));

			Add(new DurationSystem(contexts));
			Add(new CheckDurationUpSystem(contexts));

			Add(new RemoveTargetsOnTimeUpSystem(contexts));
		}
	}
}