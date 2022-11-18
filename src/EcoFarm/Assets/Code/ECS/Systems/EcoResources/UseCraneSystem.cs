using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class UseCraneSystem : ReactiveSystem<GameEntity>
	{
		public UseCraneSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.AllOf(GameMatcher.MouseDown, GameMatcher.Crane));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Consume);

		private void Consume(GameEntity crane) => crane.isUsed = true;
	}
}