using System.Collections.Generic;
using Code.Unity.ViewListeners;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class BindViewsSystem : ReactiveSystem<GameEntity>
	{
		public BindViewsSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.View);

		protected override bool Filter(GameEntity entity)
			=> true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(AddListener);

		private static void AddListener(GameEntity entity)
		{
			var listeners = entity.view.Value.GetComponents<BaseViewListener>();

			listeners.ForEach((l) => l.Register(entity));
		}
	}
}