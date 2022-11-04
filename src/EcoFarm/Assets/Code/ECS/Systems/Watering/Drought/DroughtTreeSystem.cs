using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Balance.Tree;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Drought
{
	public sealed class DroughtTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _trees;

		public DroughtTreeSystem(Contexts contexts)
			: base(contexts.game)
			=> _trees = contexts.game.GetGroup(AllOf(GameMatcher.Tree, GameMatcher.Watering));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DroughtTimer, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => _trees.ForEach(Drought);

		private static void Drought(GameEntity tree) => tree.UpdateWatering(with: (w) => w - WateringStep);
	}
}