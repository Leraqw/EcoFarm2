
using EcoFarmCustomGenerator.CodeGeneration.Attributes;

namespace Code
{
	[Game] public sealed class FilledComponent : FlagComponent { }

	[Game] public sealed class RadiusComponent : ValueComponent<float> { }

	[Game] [Cool] public sealed class CraneComponent : FlagComponent { }
	
	[Game] public sealed class BucketComponent : FlagComponent { }
}