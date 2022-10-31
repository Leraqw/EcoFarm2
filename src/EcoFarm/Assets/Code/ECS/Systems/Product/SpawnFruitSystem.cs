using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Balance.Fruit;
using static GameMatcher;

namespace Code.ECS.Systems.Product
{
	public sealed class SpawnFruitSystem : IExecuteSystem
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _entities;

		public SpawnFruitSystem(Contexts contexts)
		{
			_contexts = contexts;
			_entities = contexts.game.GetGroup(AllOf(Fruitful).AnyOf(SpawnPosition, Position).NoneOf(HasFruit));
		}

		public void Execute() => _entities.ForEach(SpawnFruitFor, @if: Filter);

		private bool Filter(GameEntity entity) => true;

		private void SpawnFruitFor(GameEntity tree)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Fruit"))
			            .Do((e) => e.AddAttachedTo(tree))
			            .Do((e) => e.attachedTo.Value.isHasFruit = true)
			            .Do((e) => e.AddPosition(tree.GetActualPosition() + SpawnHeight))
			            .Do((e) => e.AddProportionalScale(InitialScale))
			            .Do((e) => e.isFruitRequire = true)
			            .Do((e) => e.AddDuration(BeforeGrowingTime));
	}
}