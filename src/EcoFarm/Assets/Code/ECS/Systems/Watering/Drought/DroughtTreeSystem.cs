using System.Collections.Generic;
using Entitas;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class DroughtTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _trees;
		private readonly IConfigurationService _configurationService;

		[Inject]
		public DroughtTreeSystem(GameContext context, IConfigurationService configurationService)
			: base(context)
		{
			_trees = context.GetGroup(AllOf(GameMatcher.Tree, Watering));
			_configurationService = configurationService;
		}

		private IWateringConfig Configuration => _configurationService.Balance.Watering;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DroughtTimer, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => _trees.ForEach(Drought);

		private void Drought(GameEntity tree) => tree.DecreaseWatering(Configuration.DroughtStep);
	}
}