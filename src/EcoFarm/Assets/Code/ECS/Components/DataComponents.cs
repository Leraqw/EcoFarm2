using EcoFarmModel;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] [Unique] public sealed class StorageComponent : IComponent { public StorageSO Value; }

	[Game] public sealed class ProductComponent : IComponent { public ProductSO Value; }

	[Game] public sealed class TreeComponent : IComponent { public TreeSO Value; }

	[Game] [Event(Self)] public sealed class GoalComponent : IComponent { public GoalSO Value; }

	[Game] public sealed class DevelopmentObjectComponent : IComponent { public DevObjectSO Value; }

	[Game] [Event(Self)] public sealed class BuildingComponent : IComponent { public BuildingSO Value; }

	[Game] [Event(Self)] public sealed class FactoryComponent : IComponent { public FactorySO Value; }

	[Game] [Event(Self)] public sealed class GeneratorComponent : IComponent { public GeneratorSO Value; }

	[Game] public sealed class InputProductsComponent : IComponent { public ProductSO[] Value; }

	[Game] public sealed class ResourceComponent : IComponent { [PrimaryEntityIndex] public ResourceSO Value; }
}