using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Balance.Fruit;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class SpawnFruitSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SpawnFruitSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.HasFruit, GameMatcher.SpawnPosition);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SpawnFruitFor);

		private void SpawnFruitFor(GameEntity tree)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Fruit"))
			            .Do((e) => e.AddAttachedTo(tree))
			            .Do((e) => e.AddPosition(tree.spawnPosition + SpawnHeight))
			            .Do((e) => e.AddProportionalScale(0))
			            .Do((e) => e.isFruitRequire = true)
			            .Do((e) => e.AddDuration(BeforeGrowingTime));
	}
}