using Code.Utils.ComponentsTemplates;
using EcoFarmDataModule;

namespace Code.ECS.Components
{
	[Game] public sealed class StorageComponent : ValueComponent<Storage> { }

	[Game] public sealed class ProductComponent : ValueComponent<Product> { }

	[Game] public sealed class TreeComponent : ValueComponent<Tree> { }
}