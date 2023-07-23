using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class ReplaceSpriteWhileWorkingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public ReplaceSpriteWhileWorkingSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IWaterCleanerConfig Sprite => _contexts.GetConfiguration().Resource.Sprite.WaterCleaner;

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