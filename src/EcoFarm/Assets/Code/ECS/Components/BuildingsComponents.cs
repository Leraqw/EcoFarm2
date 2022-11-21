using Code.Utils.ComponentsTemplates;
using EcoFarmDataModule;

namespace Code.ECS.Components
{
	[Game] public sealed class SignComponent : FlagComponent { }

	[Game] public sealed class OccupiedComponent : FlagComponent { }

	[Game] public sealed class BoughtComponent : FlagComponent { }

	[Game] public sealed class RequireProductComponent : ValueComponent<Product> { }

	[Game] public sealed class ReadyComponent : FlagComponent { }

	[Game] public sealed class InFactoryComponent : FlagComponent { }
}