

using EcoFarmCustomGenerator.CodeGeneration.Attributes;

namespace Code
{
	[Dependencies(typeof(HealthComponent), typeof(PositionComponent), typeof(MovableComponent))]
[Game] public sealed class EnemyComponent : IComponent { }

	// [DefaultValue(100)]
[Game] public sealed class HealthComponent : IComponent { public int Value; }

[Game] public sealed class MovableComponent : IComponent { }

	[Dependencies(typeof(NeededComponent))]
[Player] public sealed class SomeComponent : IComponent { public int Value; }

[Player] public sealed class NeededComponent : IComponent { }
}