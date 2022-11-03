using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Crane
{
	public sealed class ClickOnCraneSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _buckets;

		public ClickOnCraneSystem(Contexts contexts)
			: base(contexts.game)
			=> _buckets = contexts.game.GetGroup(GameMatcher.Bucket);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseUp, GameMatcher.Crane));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(FillBucket);

		private void FillBucket(GameEntity crane) => _buckets.ForEach((b) => b.isFilled = true);
	}
}