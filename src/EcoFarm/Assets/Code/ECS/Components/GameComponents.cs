using Code.Utils.Common;
using Code.Utils.ComponentsTemplates;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireViewComponent : ValueComponent<string> { }

	[Game] public sealed class ViewComponent : ValueComponent<GameObject> { }

	[Game] public sealed class SpawnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class RequireTreeOnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class TreeComponent : FlagComponent { }

	[Game] public sealed class HasFruitComponent : FlagComponent { }

	[Game] public sealed class GrowingComponent : ValueComponent<Vector3Interval> { }

	[Game] public sealed class DebugNameComponent : ValueComponent<string> { }
}