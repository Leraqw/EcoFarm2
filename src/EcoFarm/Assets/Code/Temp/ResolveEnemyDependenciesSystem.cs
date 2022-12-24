using System.Collections.Generic;
using Code.ECS.Components;
using Code.Utils.ComponentsTemplates;
using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas;

namespace Code.Temp
{
	[Dependencies(typeof(HealthComponent), typeof(PositionComponent), typeof(MovableComponent))]
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
				// add components
				if (!e.HasComponent(GameComponentsLookup.Health)) e.AddComponent(GameComponentsLookup.Health, new HealthComponent());
				if (!e.HasComponent(GameComponentsLookup.Movable)) e.AddComponent(GameComponentsLookup.Movable, new MovableComponent());
				if (!e.HasComponent(GameComponentsLookup.Position)) e.AddComponent(GameComponentsLookup.Position, new PositionComponent());
			}
		}
	}
}