using Code.ECS.Components.ComplexComponentTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class InventoryComponent : FlagComponent { }

	[Game] [Unique] public sealed class SellDealComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class InventoryItemComponent : ValueComponent<Item> { }

	[Game] [Event(Self)] public sealed class CoinsCountComponent : ValueComponent<int> { }

	[Game] public sealed class CountComponent : ValueComponent<int> { }

	[Game] [Unique] public sealed class CoinComponent : FlagComponent { }
}