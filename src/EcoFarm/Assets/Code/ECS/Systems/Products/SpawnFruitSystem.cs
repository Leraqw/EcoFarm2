using System.Collections.Generic;
using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Products
{
	public sealed class SpawnFruitSystem : IExecuteSystem
	{
		private readonly GameContext _context;
		private readonly IGroup<GameEntity> _entities;
		private readonly Contexts _contexts;

		public SpawnFruitSystem(Contexts contexts)
		{
			_contexts = contexts;
			_context = contexts.game;
			_entities = _context.GetGroup(AllOf(Fruitful).AnyOf(SpawnPosition, Position));
		}

		private IFruitConfig FruitConfig => _contexts.GetConfiguration().Balance.Fruit;

		public void Execute() => _entities.ForEach(SpawnFruitFor, @if: IsHasNotFruits);

		private void SpawnFruitFor(GameEntity tree)
			=> _context.CreateEntity()
			           .Do((e) => e.AddDebugName("Fruit"))
			           .Do((e) => e.AddProduct(tree.tree.Value.Product))
			           .Do((e) => e.AddAttachedTo(tree.attachableIndex))
			           .Do((e) => e.AddPosition(tree.GetActualPosition() + FruitConfig.SpawnHeight))
			           .Do((e) => e.AddProportionalScale(FruitConfig.InitialScale))
			           .Do((e) => e.isFruitRequire = true)
			           .Do((e) => e.AddDuration(FruitConfig.BeforeGrowingTime));

		private bool IsHasNotFruits(GameEntity entity) => GetAttachedFruits(entity).Any() == false;

		private IEnumerable<GameEntity> GetAttachedFruits(GameEntity entity)
			=> _context.GetEntitiesWithAttachedTo(entity.attachableIndex);
	}
}