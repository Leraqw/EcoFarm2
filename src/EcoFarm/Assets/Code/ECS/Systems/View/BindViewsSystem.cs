using System.Collections.Generic;


using Entitas;

namespace EcoFarm
{
	public sealed class BindViewsSystem : ReactiveSystem<GameEntity>
	{
		public BindViewsSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.View);

		protected override bool Filter(GameEntity entity) => entity.hasView;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(RegisterListeners);

		private static void RegisterListeners(GameEntity entity)
			=> GetListeners(entity).ForEach((l) => l.Register(entity));

		private static IEnumerable<BaseViewListener> GetListeners(GameEntity entity)
			=> entity.view.Value.GetComponents<BaseViewListener>();
	}
}