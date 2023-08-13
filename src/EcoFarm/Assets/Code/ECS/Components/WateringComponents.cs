using Entitas;

namespace EcoFarm
{
	[Game] public sealed class FilledComponent : IComponent { }
	[Game] public sealed class RadiusComponent : IComponent { public float Value; }
	[Game] public sealed class CraneComponent : IComponent { }
	[Game] public sealed class BucketComponent : IComponent { }
}