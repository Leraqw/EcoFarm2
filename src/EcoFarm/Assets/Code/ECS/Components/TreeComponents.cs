using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] public sealed class RequireTreeOnPositionComponent : IComponent { public Vector2 Value; }

	[Game] public sealed class FruitfulComponent : IComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class WateredComponent : IComponent { }

	[Game] [Event(Self)] public sealed class WateringComponent : IComponent { public int Value; }
}