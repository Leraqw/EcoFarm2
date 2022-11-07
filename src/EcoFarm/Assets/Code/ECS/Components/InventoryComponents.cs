using Code.ECS.Components.ComplexComponentTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class InventoryComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class InventoryItemComponent : ValueComponent<Item> { }

	[Game] public sealed class CoinsCountComponent : ValueComponent<int> { }
}