using System.Linq;




using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class SpawnFruitSystem : IExecuteSystem
	{
		private readonly GameContext _context;
		private readonly IGroup<GameEntity> _entities;
		private readonly Contexts _contexts;
		private IConfigurationService _configurationService;

		public SpawnFruitSystem(Contexts contexts, IConfigurationService configurationService)
		{
			_configurationService = configurationService;
			_contexts = contexts;
			_context = contexts.game;
			_entities = _context.GetGroup(AllOf(Fruitful).AnyOf(SpawnPosition, Position));
		}

		private IFruitConfig FruitConfig => _configurationService.Balance.Fruit;

		public void Execute() => _entities.ForEach(SpawnFruitFor, @if: IsHasNotFruits);

		private static bool IsHasNotFruits(GameEntity entity) => entity.GetAttachedEntities().Any() == false;

		private void SpawnFruitFor(GameEntity tree)
			=> _context.CreateEntity()
			           .Do((e) => e.AddDebugName("Fruit"))
			           .Do((e) => e.AddProduct(tree.tree.Value.Product))
			           .AttachTo(tree)
			           .Do((e) => e.AddPosition(tree.GetActualPosition() + FruitConfig.SpawnOffset))
			           .Do((e) => e.AddProportionalScale(FruitConfig.InitialScale))
			           .Do((e) => e.isFruitRequire = true)
			           .Do((e) => e.AddDuration(FruitConfig.BeforeGrowingTime))
		/**/;
	}
}