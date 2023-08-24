using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ReplaceSpriteWhileWorkingSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public ReplaceSpriteWhileWorkingSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
			=> _configurationService = configurationService;

		private IWaterCleanerConfig Sprite => _configurationService.Resource.Sprite.WaterCleaner;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(CleanerGenerator, Working).AddedOrRemoved());

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Replace);

		private void Replace(GameEntity entity)
		{
			entity.ReplaceSprite
			(
				entity.isWorking
					? Sprite.Dirty
					: Sprite.Clean
			);
		}
	}
}