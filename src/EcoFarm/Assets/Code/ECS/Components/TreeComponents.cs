using Code.Utils.ComponentsTemplates;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireTreeOnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class HasFruitComponent : FlagComponent { }

	[Game] public sealed class FruitfulComponent : FlagComponent { }

	[Game] public sealed class AttachedFruitComponent : ValueComponent<GameEntity> { }
}