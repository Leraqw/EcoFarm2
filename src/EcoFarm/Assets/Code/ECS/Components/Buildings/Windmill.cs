using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] public sealed class SpinnerComponent : IComponent { }

	[Game] public sealed class RotationSpeedComponent : IComponent { public float Value; }

	[Game] [Event(Self)] public sealed class RotationComponent : IComponent { public float Value; }
}