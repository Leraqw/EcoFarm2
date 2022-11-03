using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components
{
	[Game] public sealed class FilledComponent : FlagComponent { }

	[Game] public sealed class RadiusComponent : ValueComponent<float> { }

	[Game] public sealed class CraneComponent : FlagComponent { }
	
	[Game] public sealed class BucketComponent : FlagComponent { }
}