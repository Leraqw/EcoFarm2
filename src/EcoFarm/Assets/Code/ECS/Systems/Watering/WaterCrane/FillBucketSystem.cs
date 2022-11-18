using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.WaterCrane
{
	public sealed class FillBucketSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _buckets;

		public FillBucketSystem(Contexts contexts) 
			: base(contexts.game)
			=> _buckets = contexts.game.GetGroup(GameMatcher.Bucket);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Used, Crane));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(FillBucket);

		private void FillBucket(GameEntity crane) => _buckets.ForEach((b) => b.isFilled = true);
	}
}