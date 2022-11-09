using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI
{
	public sealed class EnablePreparedWindow : ReactiveSystem<GameEntity>
	{
		public EnablePreparedWindow(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Prepared.Added());

		protected override bool Filter(GameEntity entity) => entity.isPreparationInProcess == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Enable);

		private static void Enable(GameEntity entity) => entity
		                                                 .Do((e) => e.ReplaceEnabled(true))
		                                                 .Do((e) => e.isPrepared = false);
	}
}