using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class WaitBeforeGrowingSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public WaitBeforeGrowingSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(FruitRequire, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isFruitRequire;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.AddViewPrefab(_configurationService.Resource.Prefab.Apple))
			   .Do((e) => e.AddTargetScale(_configurationService.Balance.Fruit.FullScale))
			   .Do((e) => e.AddDuration(_configurationService.Balance.Fruit.GrowingTime))
			   .Do((e) => e.isFruitRequire = false);
	}
}