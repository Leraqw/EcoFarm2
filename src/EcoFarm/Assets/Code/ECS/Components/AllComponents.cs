using Code.Utils.ComponentsTemplates;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireResourceComponent : ValueComponent<string> { }

	[Game] public sealed class ResourceComponent : ValueComponent<GameObject> { }

	[Game] public sealed class TreeComponent : FlagComponent { }
}