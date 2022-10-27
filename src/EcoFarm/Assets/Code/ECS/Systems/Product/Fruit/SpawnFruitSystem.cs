using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class SpawnFruitSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SpawnFruitSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.HasFruit);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SpawnFruitFor);

		private void SpawnFruitFor(GameEntity tree) => Spawn(tree.spawnPosition);

		private void Spawn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddSpawnPosition(position + Vector2.up)) // TODO: spawn on top of the tree
			            .Do((e) => e.isFruitRequire = true)
			            .Do((e) => e.AddDuration(Constants.Balance.Fruit.BeforeGrowingTime))
			            .Do((e) => e.AddDebugName("Fruit"));
	}
}