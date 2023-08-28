using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using UnityEngine.UI;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] public sealed class WindowComponent : IComponent { }
	[Unique] [Game] public sealed class PlayerChoiceWindowComponent : IComponent { }
	[Unique] [Game] public sealed class PlayerWindowContentComponent : IComponent { public RectTransform Value; }
	[Game] public sealed class ToggledComponent : IComponent { }
	[Player] public sealed class ForPlayerButtonComponent : IComponent { }
	[Player] [Event(Self)]  public sealed class PlayerModeButtonsEnabledComponent : IComponent { public bool Value; }
	[Unique] [Player] public sealed class PlayerChoiceButtonComponent : IComponent { }
	[Unique] [Player] public sealed class ToDeleteComponent : IComponent { }
	[Unique] [Player] [Event(Self)] public sealed class EditModeComponent : IComponent { public bool Value; }
	[Unique][Player] [Event(Self)] public sealed class PlayerToEditComponent : IComponent { public PlayerView Value; }
	[Player] [Event(Self)] public sealed class InteractableComponent : IComponent { public bool Value; }
	[Game] [Event(Self)] public sealed class PlayerToChooseComponent : IComponent { public Player Value; }
	[Player] public sealed class EditedPlayerDataComponent : IComponent { public Player Value; }
	[Unique] [Game] [Event(Self)] public sealed class GreetingNicknameComponent : IComponent { public string Value;}
	[Unique] [Player] public sealed class PlayerListLengthComponent : IComponent { public int Value; }
}