using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components
{
	[Game] public sealed class FilledComponent : FlagComponent { }

	[Game] public sealed class RadiusComponent : ValueComponent<float> { }
}