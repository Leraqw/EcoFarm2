using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.View
{
	public sealed class LoadViewForEntitySystem : ReactiveSystem<GameEntity>
	{
		public LoadViewForEntitySystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireGameObject);

		protected override bool Filter(GameEntity entity)
			=> entity.hasGameObject == false;

		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var e in entites)
			{
				
			}
		}
	}
}