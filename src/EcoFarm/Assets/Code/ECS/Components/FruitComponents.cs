
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code
{

	[Game] public sealed class FruitRequireComponent : FlagComponent { }

	[Game] public sealed class GrowthComponent : FlagComponent { }

	[Game] public sealed class WillFallComponent : FlagComponent { }

	[Game] public sealed class FellComponent : FlagComponent { }

	[Game] public sealed class PickableComponent : FlagComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class PickedComponent : FlagComponent { }

	[Game] public sealed class CollectedComponent : FlagComponent { }
}