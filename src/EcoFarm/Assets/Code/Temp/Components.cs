

using EcoFarmCustomGenerator.CodeGeneration.Attributes;

namespace Code
{
	[Dependencies(typeof(HealthComponent), typeof(PositionComponent), typeof(MovableComponent))]
	[Game] public sealed class EnemyComponent : FlagComponent { }

	// [DefaultValue(100)]
	[Game] public sealed class HealthComponent : ValueComponent<int> { }

	[Game] public sealed class MovableComponent : FlagComponent { }

	[Dependencies(typeof(NeededComponent))]
	[Player] public sealed class SomeComponent : ValueComponent<int> { }

	[Player] public sealed class NeededComponent : FlagComponent { }
}