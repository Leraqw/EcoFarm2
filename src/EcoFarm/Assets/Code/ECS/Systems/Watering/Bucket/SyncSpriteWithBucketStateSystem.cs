using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class SyncSpriteWithBucketStateSystem : ReactiveSystem<GameEntity>
	{
		public SyncSpriteWithBucketStateSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Filled.AddedOrRemoved());

		protected override bool Filter(GameEntity entity) => entity.hasSprite && entity.hasRequireSprite == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Sync);

		private static void Sync(GameEntity entity) => entity.AddRequireSprite(entity.GetActualBucketSprite());
	}
}