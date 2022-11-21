using System.Collections.Generic;
using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class ProduceProductSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public ProduceProductSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IPrefabConfig Prefab => _contexts.GetConfiguration().Resource.Prefab;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, Working, DurationUp).NoneOf(Duration));

		protected override bool Filter(GameEntity factory) => factory.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Produce);

		private void Produce(GameEntity factory)
			=> factory
			   .Do((e) => e.isWorking = false)
			   .Do((e) => e.isUsed = true)
			   .Do(SpawnProduct)
		/**/;

		private void SpawnProduct(GameEntity factory)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Product"))
			            .Do((e) => e.AddProduct(factory.factory.Value.OutputProducts.First()))
			            .AttachTo(factory)
			            .Do((e) => e.AddPosition(factory.GetActualPosition() + ProductSpawnOffset))
			            .Do((e) => e.AddViewPrefab(Prefab.AppleJuice))
			            .Do((e) => e.isPickable = true)
			            .Do((e) => e.isInFactory = true)
		/**/;
	}
}