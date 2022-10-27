using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public sealed class StartGrowingSystem : ReactiveSystem<GameEntity>
	{
		public StartGrowingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.Growing, GameMatcher.View);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SetScaleToStartValue);

		private static void SetScaleToStartValue(GameEntity entity)
			=> entity.view.Value.transform.localScale = entity.growing.Value.StartValue;
	}
}