using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class LoadRequiredSpriteSystem : ReactiveSystem<GameEntity>
	{
		public LoadRequiredSpriteSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(SpriteToLoad);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Load);

		private void Load(GameEntity entity)
			=> entity.Do((e) => e.ReplaceSprite(entity.spriteToLoad.Value))
			         .Do((e) => e.RemoveSpriteToLoad());
	}
}