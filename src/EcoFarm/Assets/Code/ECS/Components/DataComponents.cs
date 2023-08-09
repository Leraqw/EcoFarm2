using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] [Unique] public sealed class StorageComponent : IComponent { public Storage Value; }

	[Game] public sealed class ProductComponent : IComponent { public Product Value; }

	[Game] public sealed class TreeComponent : IComponent { public Tree Value; }

	[Game] [Event(Self)] public sealed class GoalComponent : IComponent { public Goal Value; }

	[Game] public sealed class DevelopmentObjectComponent : IComponent { public DevObject Value; }

	[Game] [Event(Self)] public sealed class BuildingComponent : IComponent { public Building Value; }

	[Game] [Event(Self)] public sealed class FactoryComponent : IComponent { public Factory Value; }

	[Game] [Event(Self)] public sealed class GeneratorComponent : IComponent { public Generator Value; }

	[Game] public sealed class InputProductsComponent : IComponent { public Product[] Value; }

	[Game] public sealed class ResourceComponent : IComponent { [PrimaryEntityIndex] public Resource Value; }
}