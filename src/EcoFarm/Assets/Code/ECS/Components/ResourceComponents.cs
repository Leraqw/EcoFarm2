using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using Packages.Code.Ecs.Components.Workflow;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class WaterResourceComponent : FlagComponent { }

	[Game] [Unique] public sealed class EnergyResourceComponent : FlagComponent { }

	[Game] public sealed class RenewPriceComponent : ValueComponent<int> { }

	[Game] public sealed class ConsumableComponent : PrimaryComponent<int> { }

	[Game] public sealed class ConsumerComponent : IndexComponent<int> { }
	
	[Game] public sealed class ProduceResourceComponent : IndexComponent<int> { }

	[Game] public sealed class ConsumptionCoefficientComponent : ValueComponent<int> { }
	
	[Game] public sealed class EfficiencyCoefficientComponent : ValueComponent<int> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class UsedComponent : FlagComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class RenewComponent : FlagComponent { }
}