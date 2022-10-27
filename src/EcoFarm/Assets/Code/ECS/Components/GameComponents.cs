using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireViewComponent : ValueComponent<string> { }

	[Game] public sealed class ViewComponent : ValueComponent<GameObject> { }

	[Game] public sealed class SpawnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class RequireTreeOnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class TreeComponent : FlagComponent { }

	[FlagPrefix("has")] [Game] public sealed class FruitComponent : FlagComponent { }
}