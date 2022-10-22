using Code.Utils.ComponentsTemplates;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class TreeSpriteComponent : ValueComponent<Sprite> { }

	[Game] public sealed class TreeComponent : FlagComponent { }
}