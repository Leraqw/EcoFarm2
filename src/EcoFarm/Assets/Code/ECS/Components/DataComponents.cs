using Code.Utils.ComponentsTemplates;
using EcoFarmDataModule;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class StorageComponent : ValueComponent<Storage> { }

	[Game] public sealed class ProductComponent : ValueComponent<Product> { }

	[Game] public sealed class TreeComponent : ValueComponent<Tree> { }
	
	[Game] [Event(Self)] public sealed class GoalComponent : ValueComponent<Goal> { }

	[Game] public sealed class DevelopmentObjectComponent : ValueComponent<DevelopmentObject> { }
}