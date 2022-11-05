using System.Collections.Generic;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class OnTreeWateredSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public OnTreeWateredSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private ITreeConfig Configuration => _contexts.services.configurationService.Value.Balance.Tree;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watered);

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseWatering);

		private void IncreaseWatering(GameEntity entity) => entity.IncreaseWatering(Configuration.WateringStep);
	}
}