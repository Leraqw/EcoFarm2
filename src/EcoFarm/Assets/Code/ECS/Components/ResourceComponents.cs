using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace EcoFarm
{
	[Game] [Unique] public sealed class WaterResourceComponent : IComponent { }

	[Game] [Unique] public sealed class EnergyResourceComponent : IComponent { }

	[Game] public sealed class RenewPriceComponent : IComponent { public int Value; }

	[Game] public sealed class ConsumableComponent : IComponent { [PrimaryEntityIndex] public int Value; }

	[Game] public sealed class ConsumerComponent : IComponent { [EntityIndex] public int Value; }

	[Game] public sealed class ProduceResourceComponent : IComponent { [EntityIndex] public int Value; }

	[Game] public sealed class ConsumptionCoefficientComponent : IComponent { public int Value; }

	[Game] public sealed class EfficiencyCoefficientComponent : IComponent { public int Value; }

	[Game] [Cleanup(RemoveComponent)] public sealed class UsedComponent : IComponent { }

	[Game] [Cleanup(RemoveComponent)] public sealed class RenewComponent : IComponent { }
}