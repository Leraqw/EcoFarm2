using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using Packages.Code.Ecs.Components.Workflow;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireViewComponent : ValueComponent<string> { }

	[Game] public sealed class ViewPrefabComponent : ValueComponent<GameObject> { }
	
	[Game] public sealed class ViewComponent : ValueComponent<GameObject> { }

	[Game] public sealed class SpawnPositionComponent : ValueComponent<Vector2> { }

	[Game] [Event(Self)] public sealed class PositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class DurationComponent : ValueComponent<float> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class DurationUpComponent : FlagComponent { }

	[Game] public sealed class DebugNameComponent : ValueComponent<string> { }

	[Game] [Event(Self)] public sealed class ProportionalScaleComponent : ValueComponent<float> { }

	[Game] public sealed class TargetScaleComponent : ValueComponent<float> { }

	[Game] public sealed class TargetPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class AttachableIndexComponent : PrimaryComponent<int> { }

	[Game] public sealed class AttachedToComponent : IndexComponent<int> { }

	[Game] public sealed class DroughtTimerComponent : FlagComponent { }

	[Game] public sealed class RequireSpriteComponent : ValueComponent<string> { }
	
	[Game] [Event(Self)] public sealed class SpriteComponent : ValueComponent<Sprite> { }
}