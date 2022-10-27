using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireViewComponent : ValueComponent<string> { }

	[Game] public sealed class ViewComponent : ValueComponent<GameObject> { }

	[Game] public sealed class SpawnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class RequireTreeOnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class HasFruitComponent : FlagComponent { }

	[Game] public sealed class DurationComponent : ValueComponent<float> { }

	[Cleanup(RemoveComponent)] [Game] public sealed class DurationUpComponent : FlagComponent { }

	[Game] public sealed class DebugNameComponent : ValueComponent<string> { }
}