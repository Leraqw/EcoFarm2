using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] public sealed class SignComponent : IComponent { }

	[Game] public sealed class OccupiedComponent : IComponent { }

	[Game] public sealed class BoughtComponent : IComponent { }

	[Game] public sealed class RequireProductComponent : IComponent { public ProductSO Value; }
	[Game] public sealed class ReadyComponent : IComponent { }

	[Game] public sealed class InFactoryComponent : IComponent { }

	[Game] public sealed class WorkingComponent : IComponent { }

	[Game] public sealed class BusyComponent : IComponent { }

	[Game] public sealed class PermanentGeneratorComponent : IComponent { }

	[Game] public sealed class CleanerGeneratorComponent : IComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class PollutionCoefficientComponent : IComponent { public int Value; }

	[Game] [Cleanup(RemoveComponent)] public sealed class PollutionComponent : IComponent { public ResourceSO Value; }

	[Game] [Event(Self)] public sealed class SpriteHighComponent : IComponent { public float Value; }
}