using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] public sealed class WindowComponent : IComponent { }
	[Game] public sealed class CreateNewPlayerWindowComponent : IComponent { }
	[Game] public sealed class PlayerChoiceWindowComponent : IComponent { }
	[Game] public sealed class PlayerWindowContentComponent : IComponent { public RectTransform Value; }
	[Game] public sealed class ToggledComponent : IComponent { }
	[Game] public sealed class ChosenComponent : IComponent { }
	[Player] public sealed class ForPlayerButtonComponent : IComponent { }
	[Player] public sealed class PlayerChoiceButtonComponent : IComponent { }
	[Player] [Event(Self)] public sealed class InteractableComponent : IComponent { public bool Value; }
	[Game] [Event(Self)] public sealed class PlayerToChooseComponent : IComponent { public Player Value; }
}