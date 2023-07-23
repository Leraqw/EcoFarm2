
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] public sealed class SpinnerComponent : FlagComponent { }

	[Game] public sealed class RotationSpeedComponent : ValueComponent<float> { }

	[Game] [Event(Self)] public sealed class RotationComponent : ValueComponent<float> { }

}