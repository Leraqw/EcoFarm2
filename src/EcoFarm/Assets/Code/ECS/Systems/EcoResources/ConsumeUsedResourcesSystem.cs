using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class ConsumeUsedResourcesSystem : ReactiveSystem<GameEntity>
	{
		public ConsumeUsedResourcesSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Used);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Consume);

		private void Consume(GameEntity entity) => entity.Consume();
	}
}