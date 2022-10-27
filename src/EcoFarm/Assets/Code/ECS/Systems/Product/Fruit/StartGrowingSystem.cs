using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class StartGrowingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public StartGrowingSystem(Contexts contexts)
			: base(contexts.game)
		{
			_contexts = contexts;
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Growing);

		protected override bool Filter(GameEntity entity)
			=> entity.hasView;
		
		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var entity in _contexts.game.GetEntities(GameMatcher.Growing))
			{
				entity.view.Value.transform.localScale = entity.growing.Value.StartValue;
			}
		}
	}
}