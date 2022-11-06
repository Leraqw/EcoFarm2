using System.Collections.Generic;
using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Temp;
using static GameMatcher;

namespace Code.ECS.Systems.Product
{
	public sealed class SpawnFruitSystem : IExecuteSystem
	{
		private readonly GameContext _context;
		private readonly IGroup<GameEntity> _entities;
		private readonly IFruitConfig _fruitConfig;

		public SpawnFruitSystem(Contexts contexts)
		{
			_fruitConfig = contexts.GetConfiguration().Balance.Fruit;
			_context = contexts.game;
			_entities = _context.GetGroup(AllOf(Fruitful).AnyOf(SpawnPosition, Position));
		}

		public void Execute() => _entities.ForEach(SpawnFruitFor, @if: IsHasNotFruits);

		private void SpawnFruitFor(GameEntity tree)
			=> _context.CreateEntity()
			           .Do((e) => e.AddDebugName("Fruit"))
			           .Do((e) => e.AddFruitTypeId(AppleID))
			           .Do((e) => e.AddAttachedTo(tree.attachableIndex))
			           .Do((e) => e.AddPosition(tree.GetActualPosition() + _fruitConfig.SpawnHeight))
			           .Do((e) => e.AddProportionalScale(_fruitConfig.InitialScale))
			           .Do((e) => e.isFruitRequire = true)
			           .Do((e) => e.AddDuration(_fruitConfig.BeforeGrowingTime));

		private bool IsHasNotFruits(GameEntity entity) => GetAttachedFruits(entity).Any() == false;

		private IEnumerable<GameEntity> GetAttachedFruits(GameEntity entity)
			=> _context.GetEntitiesWithAttachedTo(entity.attachableIndex);
	}
}