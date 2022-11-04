using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] public sealed class RequireTreeOnPositionComponent : ValueComponent<Vector2> { }

	[Game] public sealed class FruitfulComponent : FlagComponent { }

	[Game] public sealed class TreeComponent : FlagComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class WateredComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class WateringComponent : ValueComponent<int> { }
}