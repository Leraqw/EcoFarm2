using Code.ECS.Components.ComplexComponentTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class InventoryComponent : FlagComponent { }

	[Game] public sealed class InventoryItemComponent : ValueComponent<Item> { }

	[Game] public sealed class CoinsCountComponent : ValueComponent<int> { }
}