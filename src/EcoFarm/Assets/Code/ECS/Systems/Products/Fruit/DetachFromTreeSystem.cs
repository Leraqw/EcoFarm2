using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Products.Fruit
{
	public sealed class DetachFromTreeSystem : ReactiveSystem<GameEntity>
	{
		public DetachFromTreeSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Collected, AttachedTo));

		protected override bool Filter(GameEntity entity) => entity.hasAttachedTo;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Detach);

		private static void Detach(GameEntity entity) => entity.Do((e) => e.RemoveAttachedTo());
	}
}