using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.UI
{
	public sealed class EnablePreparedWindow : ReactiveSystem<GameEntity>
	{
		public EnablePreparedWindow(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Prepared);

		protected override bool Filter(GameEntity entity) => entity.hasEnabled == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Enable);

		private void Enable(GameEntity entity) => entity.ReplaceEnabled(true);
	}
}