using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Balance.Tree;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class OnTreeWateredSystem : ReactiveSystem<GameEntity>
	{
		public OnTreeWateredSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watered);

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseWatering);

		private static void IncreaseWatering(GameEntity entity) => entity.UpdateWatering(with: (w) => w + WateringStep);
	}
}