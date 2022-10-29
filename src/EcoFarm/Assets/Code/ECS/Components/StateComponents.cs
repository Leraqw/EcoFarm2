using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components
{
	[Game] public sealed class FruitRequireComponent : FlagComponent { }

	[Game] public sealed class GrowthComponent : FlagComponent { }

	[Game] public sealed class WillFallComponent : FlagComponent { }

	[Game] public sealed class FellComponent : FlagComponent { }

	[Game] public sealed class PickableComponent : FlagComponent { }

	[Game] public sealed class PickedComponent : FlagComponent { }
}