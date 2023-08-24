using System.Collections.Generic;
using Entitas;

namespace EcoFarm
{
	public sealed class OnTreeWateredSystem : ReactiveSystem<GameEntity>
	{
		private readonly IConfigurationService _configurationService;

		public OnTreeWateredSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
			=> _configurationService = configurationService;

		private IWateringConfig Configuration => _configurationService.Balance.Watering;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watered);

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseWatering);

		private void IncreaseWatering(GameEntity entity) => entity.IncreaseWatering(Configuration.WateringStep);
	}
}