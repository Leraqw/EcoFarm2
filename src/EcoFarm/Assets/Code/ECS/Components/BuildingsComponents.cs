using Code.Utils.ComponentsTemplates;
using Packages.Code.Ecs.Components.Workflow;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class SignComponent : FlagComponent { }

	[Game] public sealed class OccupiedComponent : FlagComponent { }

	[Game] public sealed class BuildPositionComponent : PrimaryComponent<Vector2> { }
}