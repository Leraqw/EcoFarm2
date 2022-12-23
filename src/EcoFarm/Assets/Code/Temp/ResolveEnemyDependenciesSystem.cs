using System.Collections.Generic;
using Code.Utils.ComponentsTemplates;
using Entitas;

namespace Code.Temp
{
	// [Dependency(typeof(HealthComponent), typeof(PositionComponent), typeof(MovableComponent))]
	[Game] public sealed class EnemyComponent : FlagComponent { }

	// [DefaultValue(100)]
	[Game] public sealed class HealthComponent : ValueComponent<int> { }

	[Game] public sealed class MovableComponent : FlagComponent { }

	public sealed class ResolveEnemyDependenciesSystem : ReactiveSystem<GameEntity>
	{
		public ResolveEnemyDependenciesSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Enemy);

		protected override bool Filter(GameEntity entity) => entity.isEnemy;

		protected override void Execute(List<GameEntity> entites)
		{
			foreach (var e in entites)
			{
				if (e.hasHealth == false) e.AddHealth(default);
				if (e.hasPosition == false) e.AddPosition(default);
				e.isMovable = true;
			}
		}
	}
}