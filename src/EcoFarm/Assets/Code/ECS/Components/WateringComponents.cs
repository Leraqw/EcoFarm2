using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas;

namespace Code
{
	[Game] public sealed class FilledComponent : IComponent { }
	[Game] public sealed class RadiusComponent : IComponent { public float Value; }
	[Game] [Cool] public sealed class CraneComponent : IComponent { }
	[Game] public sealed class BucketComponent : IComponent { }
}