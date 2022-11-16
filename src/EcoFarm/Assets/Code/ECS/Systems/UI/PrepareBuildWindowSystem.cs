using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI
{
	public sealed class PrepareBuildWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PrepareBuildWindowSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.AllOf(GameMatcher.PreparationInProcess, GameMatcher.SellWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private void Prepare(GameEntity window)
		{
			var buildView = _contexts.services.uiService.Value.BuildView;

			window
				.Do((e) => e.isPreparationInProcess = false)
				.Do((e) => e.isPrepared = true);
		}
	}
}