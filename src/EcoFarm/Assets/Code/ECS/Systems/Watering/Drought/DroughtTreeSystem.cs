using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Drought
{
	public sealed class DroughtTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _trees;

		public DroughtTreeSystem(Contexts contexts)
			: base(contexts.game)
		{
			_contexts = contexts;
			_trees = contexts.game.GetGroup(AllOf(GameMatcher.Tree, GameMatcher.Watering));
		}

		private IWateringConfig Configuration => _contexts.GetConfiguration().Balance.Watering;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DroughtTimer, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => _trees.ForEach(Drought);

		private void Drought(GameEntity tree) => tree.DecreaseWatering(Configuration.WateringStep);
	}
}