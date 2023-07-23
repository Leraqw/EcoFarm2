using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code
{
	[Game] public sealed class FruitRequireComponent : IComponent { }

	[Game] public sealed class GrowthComponent : IComponent { }

	[Game] public sealed class WillFallComponent : IComponent { }

	[Game] public sealed class FellComponent : IComponent { }

	[Game] public sealed class PickableComponent : IComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class PickedComponent : IComponent { }

	[Game] public sealed class CollectedComponent : IComponent { }
}