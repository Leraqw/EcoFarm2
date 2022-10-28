using System.Collections.Generic;
using Code.Unity.ViewListeners;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class BindPositionViewSystem : ReactiveSystem<GameEntity>
	{
		public BindPositionViewSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.View, GameMatcher.RequireViewOfType, GameMatcher.Position);

		protected override bool Filter(GameEntity entity)
			=> entity.hasPosition
			   && entity.hasPositionListener == false
			   && entity.requireViewOfType.Value == typeof(PositionView);

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(AddListener);

		private static void AddListener(GameEntity entity)
			=> entity.Do((e) => e.GetViewComponent<PositionView>().Register(e))
			         .Do((e) => e.RemoveRequireViewOfType());
	}
}