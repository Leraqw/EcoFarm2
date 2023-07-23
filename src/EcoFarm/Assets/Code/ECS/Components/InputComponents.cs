using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code
{
	[Game] [Cleanup(DestroyEntity)] public sealed class MouseClickComponent : IComponent { public GameEntity Value; }

	[Game] [Cleanup(RemoveComponent)] public sealed class MouseDownComponent : IComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class MouseUpComponent : IComponent { }

	// Move to another file
	[Game] public sealed class DraggableComponent : IComponent { }

	[Game] public sealed class DraggingComponent : IComponent { }

	// Delete
	[Game] public sealed class DraggingStartComponent : IComponent { public Vector2 Value; }

	[Game] public sealed class DraggingEndComponent : IComponent { public Vector2 Value; }
}