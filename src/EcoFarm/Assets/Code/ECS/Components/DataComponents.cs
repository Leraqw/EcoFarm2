using Code.Utils.ComponentsTemplates;
using EcoFarmDataModule;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class StorageComponent : ValueComponent<Storage> { }

	[Game] public sealed class ProductComponent : ValueComponent<Product> { }

	[Game] public sealed class TreeComponent : ValueComponent<Tree> { }
}