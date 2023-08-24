using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using UnityEngine.UI;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] public sealed class WindowComponent : IComponent { }
	[Game] public sealed class PlayerChoiceWindowComponent : IComponent { }
	[Game] public sealed class PlayerWindowContentComponent : IComponent { public RectTransform Value; }
	[Game] public sealed class ToggledComponent : IComponent { }
	[Game] public sealed class ChosenComponent : IComponent { }
	[Player] public sealed class ForPlayerButtonComponent : IComponent { }
	[Player] public sealed class PlayerChoiceButtonComponent : IComponent { }
	[Player] public sealed class ToDeleteComponent : IComponent { }
	[Player] public sealed class ToEditPlayerDataComponent : IComponent { }
	//[Player] public sealed class ButtonPlayerToEditComponent : IComponent { public BaseButtonClickReceiver Value;}
	[Player] [Event(Self)] public sealed class EditModeComponent : IComponent { public bool Value; }
	[Player] public sealed class PlayerToEditComponent : IComponent { public PlayerView Value; }
	[Game] [Event(Self)]  public sealed class ModeButtonsComponent : IComponent { 
		public EnabledReceivers Enabled;
		public ColorBlock Color;
	}
	[Player] [Event(Self)] public sealed class InteractableComponent : IComponent { public bool Value; }
	[Game] [Event(Self)] public sealed class PlayerToChooseComponent : IComponent { public Player Value; }
	[Game] [Event(Self)] public sealed class GreetingNicknameComponent : IComponent { public string Value;}
	//[Player] [Event(Self)] public sealed class ToggleEditModeButtonsComponent : IComponent { public bool Value;}
}