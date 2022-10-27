using Code.Utils.Common;
using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components
{
	[Game] public sealed class FruitRequireComponent : FlagComponent { }

	[Game] public sealed class GrowingComponent : ValueComponent<Vector3Interval> { }

	[Game] public sealed class GrowthComponent : FlagComponent { }

	[Game] public sealed class WillFallComponent : FlagComponent { }

	[Game] public sealed class FallingComponent : ValueComponent<Vector3Interval> { }

	[Game] public sealed class FellComponent : FlagComponent { }
}