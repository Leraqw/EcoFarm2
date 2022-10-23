using Code.Utils.ComponentsTemplates;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireGameObjectComponent : ValueComponent<string> { }

	[Game] public sealed class GameObjectComponent : ValueComponent<GameObject> { }

	[Game] public sealed class TreeComponent : FlagComponent { }
}