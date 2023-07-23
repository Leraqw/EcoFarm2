using System.Collections.Generic;

using Entitas;

namespace Code
{
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
				// add components
				if (!e.HasComponent(GameComponentsLookup.Health))
					e.AddComponent(GameComponentsLookup.Health, new HealthComponent());
				if (!e.HasComponent(GameComponentsLookup.Movable))
					e.AddComponent(GameComponentsLookup.Movable, new MovableComponent());
				if (!e.HasComponent(GameComponentsLookup.Position))
					e.AddComponent(GameComponentsLookup.Position, new PositionComponent());
			}
		}
	}

	public sealed class ResolveDependenciesFeature : Feature
	{
		public ResolveDependenciesFeature(Contexts contexts)
			: base(nameof(ResolveDependenciesFeature))
		{
			Add(new ResolveEnemyDependenciesSystem(contexts));
			Add(new ResolveSomeDependenciesSystem(contexts));
		}
	}
}