using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] [Unique] public sealed class InventoryComponent : IComponent { }
	[Game] [Unique] public sealed class SellDealComponent : IComponent { }
	[Game] [Event(Self)] public sealed class InventoryItemComponent : IComponent { public Item Value; }
	[Game] [Event(Self)] public sealed class CoinsCountComponent : IComponent { public int Value; }
	[Game] public sealed class CountComponent : IComponent { public int Value; }
	[Game] [Unique] public sealed class CoinComponent : IComponent { }
	[Game] public sealed class SellCoefficientComponent : IComponent { public float Value; }
}