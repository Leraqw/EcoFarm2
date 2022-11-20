using System.Collections.Generic;
using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
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

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, Ready));

		protected override bool Filter(GameEntity entity) => entity.isReady;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Produce);

		private void Produce(GameEntity entity)
			=> entity
			   .Do(SpawnProduct)
			   .Do((e) => e.isUsed = true)
		/**/;

		private void SpawnProduct(GameEntity entity)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Product"))
			            .Do((e) => e.AddProduct(entity.factory.Value.OutputProducts.First()))
			            .AttachTo(entity)
			            .Do((e) => e.AddPosition(entity.GetActualPosition() + ProductSpawnOffset))
			            .Do((e) => e.AddViewPrefab(_contexts.GetConfiguration().Resource.Prefab.AppleJuice))
		/**/;
	}
}