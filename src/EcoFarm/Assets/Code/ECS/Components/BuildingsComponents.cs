using Code.Utils.ComponentsTemplates;
using EcoFarmDataModule;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] public sealed class SignComponent : FlagComponent { }

	[Game] public sealed class OccupiedComponent : FlagComponent { }

	[Game] public sealed class BoughtComponent : FlagComponent { }

	[Game] public sealed class RequireProductComponent : ValueComponent<Product> { }

	[Game] public sealed class ReadyComponent : FlagComponent { }

	[Game] public sealed class InFactoryComponent : FlagComponent { }

	[Game] public sealed class WorkingComponent : FlagComponent { }

	[Game] public sealed class BusyComponent : FlagComponent { }

	[Game] public sealed class PermanentGeneratorComponent : FlagComponent { }

	[Game] public sealed class CleanerGeneratorComponent : FlagComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class PollutionCoefficientComponent : ValueComponent<int> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class PollutionComponent : ValueComponent<Resource> { }

	[Game] [Event(Self)] public sealed class SpriteHighComponent : ValueComponent<float> { }

	[Game] public sealed class DirectionComponent : ValueComponent<int> { }
}