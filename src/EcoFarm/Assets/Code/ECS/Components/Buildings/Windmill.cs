using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components.Buildings
{
	[Game] public sealed class SpinnerComponent : FlagComponent { }

	[Game] public sealed class RotationSpeedComponent : ValueComponent<float> { }
}