using System.Collections.Generic;
using System.Linq;
using Entitas;
using static EcoFarm.Constants;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ProduceProductSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public ProduceProductSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IPrefabConfig Prefab => _contexts.GetConfiguration().Resource.Prefab;

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
			e.AddPollution(_contexts.game.waterResourceEntity.resource.Value);
			e.AddPollutionCoefficient(FactoryPollution);
		}

		private void SpawnProduct(GameEntity factory)
			=> _contexts.game.CreateEntity()
			            .Do((p) => p.AddDebugName("Product"))
			            .Do((p) => p.AddProduct(factory.factory.Value.OutputProducts.First()))
			            .AttachTo(factory)
			            .Do((p) => p.AddPosition(factory.GetActualPosition() + ProductSpawnOffset))
			            .Do((p) => p.AddViewPrefab(Prefab.AppleJuice))
			            .Do((p) => p.isPickable = true)
			            .Do((p) => p.isInFactory = true)
		/**/;
	}
}