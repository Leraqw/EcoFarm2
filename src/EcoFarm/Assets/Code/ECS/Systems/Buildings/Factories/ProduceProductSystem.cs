using System.Collections.Generic;
using System.Linq;
using Entitas;
using Zenject;
using static EcoFarm.Constants;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ProduceProductSystem : ReactiveSystem<GameEntity>
	{
		private readonly GameContext _context;
		private readonly IConfigurationService _configurationService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public ProduceProductSystem
		(
			GameContext context,
			IConfigurationService configurationService,
			GameEntity.Factory gameEntityFactory
		)
			: base(context)
		{
			_context = context;
			_configurationService = configurationService;
			_gameEntityFactory = gameEntityFactory;
		}

		private IPrefabConfig Prefab => _configurationService.Resource.Prefab;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(GameMatcher.Factory, Working, DurationUp).NoneOf(Duration));

		protected override bool Filter(GameEntity factory) => factory.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Produce);

		private void Produce(GameEntity e)
		{
			e.isWorking = false;
			e.isUsed = true;
			e.isBusy = false;

			SpawnProduct(e);
			e.AddPollution(_context.waterResourceEntity.resource.Value);
			e.AddPollutionCoefficient(FactoryPollution);
		}

		private void SpawnProduct(GameEntity factory)
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("Product");
			e.AddProduct(factory.factory.Value.OutputProducts.First());
			e.AttachTo(factory);
			e.AddViewPrefab(Prefab.AppleJuice);
			e.isPickable = true;
			e.isInFactory = true;

			var notPickedProductsNumber = factory.GetAttachedEntities().Count();
			var offset = ProductFabricOffset + ProductsOffset * notPickedProductsNumber;

			e.AddPosition(factory.GetActualPosition() + offset);
		}
	}
}